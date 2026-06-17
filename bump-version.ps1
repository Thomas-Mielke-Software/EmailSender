<#
.SYNOPSIS
    Raises the EmailSender version, builds the Release output, compiles the
    x64 and ARM64 Inno Setup installers, and creates a git commit + tag.

    The version lives in EmailSender\AssemblyInfo.cs (AssemblyVersion) and is
    mirrored into the two .iss files (#define MyAppVersion). After a successful
    build the version files are committed and an annotated tag "vX.Y.Z" is
    created (push is opt-in via -Push).

.PARAMETER Part
    Which version part to increase: major, minor or patch.

.PARAMETER DryRun
    Only show what would change; write nothing, build nothing, no git.

.PARAMETER NoBuild
    Skip the MSBuild Release build (e.g. when it was already built).

.PARAMETER NoInstaller
    Skip compiling the Inno Setup installers.

.PARAMETER NoGit
    Skip the git commit + tag step entirely.

.PARAMETER Push
    Also push the commit and the new tag (git push --follow-tags).

.EXAMPLE
    .\bump-version.ps1 -Part patch
    .\bump-version.ps1 -Part minor -Push
    .\bump-version.ps1 -Part major -DryRun
    .\bump-version.ps1 -Part patch -NoGit
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [ValidateSet('major','minor','patch')]
    [string]$Part,

    [switch]$DryRun,
    [switch]$NoBuild,
    [switch]$NoInstaller,

    # Skip the git commit + tag step entirely.
    [switch]$NoGit,

    # Also push the commit and the new tag (git push --follow-tags).
    [switch]$Push
)

$ErrorActionPreference = 'Stop'
$repoRoot      = $PSScriptRoot
$assemblyInfo  = Join-Path $repoRoot 'EmailSender\AssemblyInfo.cs'
# Single universal installer (x86 / x64 / ARM64); AnyCPU binaries.
$issFile       = Join-Path $repoRoot 'EmailSender.iss'

# Locate ISCC.exe (Inno Setup 6). Newer releases install per-user under
# %LOCALAPPDATA%; older ones under Program Files. Registry first, then known
# locations.
function Find-Iscc {
    foreach ($key in @(
        'HKLM:\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Inno Setup 6_is1',
        'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Inno Setup 6_is1',
        'HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Inno Setup 6_is1')) {
        if (Test-Path $key) {
            $loc = (Get-ItemProperty $key).InstallLocation
            if ($loc) {
                $exe = Join-Path $loc 'ISCC.exe'
                if (Test-Path $exe) { return $exe }
            }
        }
    }
    foreach ($exe in @(
        (Join-Path $env:LOCALAPPDATA 'Programs\Inno Setup 6\ISCC.exe'),
        (Join-Path ${env:ProgramFiles(x86)} 'Inno Setup 6\ISCC.exe'),
        (Join-Path $env:ProgramFiles 'Inno Setup 6\ISCC.exe'))) {
        if (Test-Path $exe) { return $exe }
    }
    return $null
}

# --- 1. Read current version from AssemblyInfo.cs -------------------------------
if (-not (Test-Path $assemblyInfo)) { throw "Not found: $assemblyInfo" }
$infoText = Get-Content $assemblyInfo -Raw -Encoding UTF8

if ($infoText -notmatch 'AssemblyVersion\("(\d+)\.(\d+)\.(\d+)(?:\.(\d+))?"\)') {
    throw "AssemblyVersion not found in $assemblyInfo"
}
$curMajor = [int]$Matches[1]
$curMinor = [int]$Matches[2]
$curPatch = [int]$Matches[3]

# --- 2. Compute the new version -------------------------------------------------
switch ($Part) {
    'major' { $newMajor = $curMajor + 1; $newMinor = 0;             $newPatch = 0 }
    'minor' { $newMajor = $curMajor;     $newMinor = $curMinor + 1; $newPatch = 0 }
    'patch' { $newMajor = $curMajor;     $newMinor = $curMinor;     $newPatch = $curPatch + 1 }
}
# AssemblyVersion stays a 4-part number; the 4th part (revision) is kept at 0.
$newVersion = "$newMajor.$newMinor.$newPatch.0"
$oldVersion = "$curMajor.$curMinor.$curPatch"

Write-Host ""
Write-Host "Version: $oldVersion  ->  $newMajor.$newMinor.$newPatch  (writing $newVersion)" -ForegroundColor Cyan
Write-Host ""

# --- 3. Update AssemblyInfo.cs (UTF-8, no BOM) ----------------------------------
Write-Host "AssemblyInfo.cs:"
$newInfoText = [regex]::Replace($infoText,
    'AssemblyVersion\("\d+\.\d+\.\d+(?:\.\d+)?"\)',
    "AssemblyVersion(""$newVersion"")")
Write-Host "  -> $assemblyInfo" -ForegroundColor Green
if (-not $DryRun) {
    [System.IO.File]::WriteAllText($assemblyInfo, $newInfoText,
        (New-Object System.Text.UTF8Encoding $false))
}

# --- 4. Update EmailSender.iss (#define MyAppVersion) ---------------------------
Write-Host "$(Split-Path $issFile -Leaf):"
if (-not (Test-Path $issFile)) { throw "Not found: $issFile" }
$issText = Get-Content $issFile -Raw -Encoding UTF8
if ($issText -notmatch '#define\s+MyAppVersion\s+"[^"]*"') {
    throw "MyAppVersion not found in $issFile"
}
$newIssText = [regex]::Replace($issText,
    '(#define\s+MyAppVersion\s+")[^"]*(")',
    "`${1}$newVersion`${2}")
Write-Host "  -> $issFile" -ForegroundColor Green
if (-not $DryRun) {
    [System.IO.File]::WriteAllText($issFile, $newIssText,
        (New-Object System.Text.UTF8Encoding $false))
}

if ($DryRun) {
    Write-Host ""
    Write-Host "DryRun: nothing written, no build, no ISCC." -ForegroundColor Yellow
    return
}

# --- 5. Build the Release output ------------------------------------------------
if (-not $NoBuild) {
    Write-Host ""
    Write-Host "Building EmailSender (Release)..." -ForegroundColor Cyan
    $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
    if (-not (Test-Path $vswhere)) { throw "vswhere.exe not found: $vswhere" }
    $msbuild = & $vswhere -latest -requires Microsoft.Component.MSBuild `
        -find 'MSBuild\**\Bin\MSBuild.exe' | Select-Object -First 1
    if (-not $msbuild -or -not (Test-Path $msbuild)) {
        throw "MSBuild.exe not found via vswhere."
    }
    & $msbuild (Join-Path $repoRoot 'EmailSender\EmailSender.csproj') `
        /t:Restore`;Build /p:Configuration=Release /m /nologo /v:minimal
    if ($LASTEXITCODE -ne 0) { throw "Build failed (exit code $LASTEXITCODE)." }
}

# --- 6. Compile the installer ---------------------------------------------------
if (-not $NoInstaller) {
    $iscc = Find-Iscc
    if (-not $iscc) { throw "ISCC.exe (Inno Setup 6) not found." }
    Write-Host ""
    Write-Host "Compiling $(Split-Path $issFile -Leaf) (using $iscc)..." -ForegroundColor Cyan
    & $iscc $issFile
    if ($LASTEXITCODE -ne 0) { throw "ISCC failed (exit code $LASTEXITCODE)." }
}

# --- 7. Git commit + annotated tag ----------------------------------------------
# Done last, so a failed build/installer never leaves a tag behind. Only the
# version files are committed, keeping the release commit clean. Push is opt-in.
if (-not $NoGit) {
    $gitTag = "v$newMajor.$newMinor.$newPatch"
    Write-Host ""
    Write-Host "Git: commit + tag $gitTag ..." -ForegroundColor Cyan

    # git reports progress on stderr; don't let that abort the script.
    $prevEAP = $ErrorActionPreference
    $ErrorActionPreference = 'Continue'
    try {
        # Stage first so this works whether the files are modified or still
        # untracked (e.g. EmailSender.iss on the very first release), then commit
        # exactly those paths so unrelated staged changes are left alone.
        & git -C $repoRoot add -- $assemblyInfo $issFile
        & git -C $repoRoot commit -m "$gitTag" -- $assemblyInfo $issFile
        if ($LASTEXITCODE -ne 0) {
            Write-Host "  WARN: git commit failed / nothing to commit (exit $LASTEXITCODE)." -ForegroundColor Yellow
        }

        # Annotated tag, idempotent: skip if it already exists.
        & git -C $repoRoot rev-parse -q --verify "refs/tags/$gitTag" 2>$null | Out-Null
        if ($LASTEXITCODE -eq 0) {
            Write-Host "  Tag $gitTag already exists -- not recreated." -ForegroundColor Yellow
        } else {
            & git -C $repoRoot tag -a "$gitTag" -m "$gitTag"
            if ($LASTEXITCODE -ne 0) {
                Write-Host "  WARN: git tag failed (exit $LASTEXITCODE)." -ForegroundColor Yellow
            }
        }

        if ($Push) {
            & git -C $repoRoot push --follow-tags
            if ($LASTEXITCODE -ne 0) {
                Write-Host "  WARN: git push failed (exit $LASTEXITCODE). Commit + tag are local." -ForegroundColor Yellow
            }
        } else {
            Write-Host "  Not pushed (use -Push, or run: git push --follow-tags)." -ForegroundColor Yellow
        }
    }
    finally {
        $ErrorActionPreference = $prevEAP
    }
}

Write-Host ""
Write-Host "Done. Installers are in: $(Join-Path $repoRoot 'Setup')" -ForegroundColor Green
Write-Host "Reminder: the produced executables and installers are NOT signed unless" -ForegroundColor Yellow
Write-Host "          a SignTool is enabled in the .iss files." -ForegroundColor Yellow
