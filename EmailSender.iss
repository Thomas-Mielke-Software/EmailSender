; ============================================================================
;  EmailSender - Inno Setup script (universal: x86 / x64 / ARM64)
;  Requires Inno Setup 6.3+.  Compile with:  ISCC.exe EmailSender.iss
;  The version is kept in sync by bump-version.ps1 (updates MyAppVersion).
;
;  EmailSender is an AnyCPU .NET Framework 4.8 application, so the binaries are
;  architecture-neutral managed IL. A single installer therefore serves every
;  Windows architecture; only the install location bitness differs per system.
; ============================================================================

#define MyAppName "EmailSender"
#define MyAppVersion "2.3.0.0"
#define MyAppPublisher "Thomas Mielke Softwareentwicklung"
#define MyAppURL "https://github.com/Thomas-Mielke-Software/EmailSender"
#define MyAppExeName "EmailSender.exe"
; Build output that gets packaged (AnyCPU Release build). Relative to this .iss.
#define SourceDir "EmailSender\bin\Release"

[Setup]
; (Reused from the old SetupEmailSender UpgradeCode.)
AppId={{B649D5E2-B371-4B94-BF45-51C6323FE090}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
LicenseFile=LICENSE
OutputDir=Setup
OutputBaseFilename=EmailSender-{#MyAppVersion}
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
; ArchitecturesAllowed is left unset on purpose -> the installer runs on x86,
; x64 and ARM64. On x64-compatible systems (x64 and ARM64) it installs into the
; native 64-bit Program Files / registry view; on x86 it installs 32-bit.
ArchitecturesInstallIn64BitMode=x64compatible
; .NET Framework 4.8 requires Windows 7 SP1 or newer.
MinVersion=6.1sp1
; Offer to close EmailSender automatically if it is running during install.
CloseApplications=yes
RestartApplications=no

; --- Code signing --------------------------------------------------------------------
; Configure your own sign tool in the Inno Setup IDE (Tools -> Configure Sign Tools...)
SignTool=winsdk10sha256
SignedUninstaller=yes

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "de"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#SourceDir}\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourceDir}\EmailSender.exe.config"; DestDir: "{app}"; Flags: ignoreversion
; All managed dependencies (MailKit, MimeKit, BouncyCastle, System.* shims).
Source: "{#SourceDir}\*.dll"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#MyAppName}}"; Flags: nowait postinstall skipifsilent

[Code]
function IsDotNet48Installed: Boolean;
var
  Release: Cardinal;
begin
  // 528040 is the registry "Release" value for .NET Framework 4.8.
  Result := RegQueryDWordValue(HKLM,
    'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', Release)
    and (Release >= 528040);
end;

function InitializeSetup: Boolean;
var
  ErrorCode: Integer;
begin
  Result := True;
  if not IsDotNet48Installed then
  begin
    if MsgBox('EmailSender requires the Microsoft .NET Framework 4.8, which '
      + 'does not appear to be installed.' + #13#10#13#10
      + 'Open the download page now?', mbConfirmation, MB_YESNO) = IDYES then
      ShellExec('open',
        'https://dotnet.microsoft.com/download/dotnet-framework/net48',
        '', '', SW_SHOW, ewNoWait, ErrorCode);
    Result := False;
  end;
end;
