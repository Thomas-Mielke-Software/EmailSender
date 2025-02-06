//////////////////////////////////////////////////////////////////////
/////
/////  An open source project developped by someone
/////
/////  This program is free software; you can redistribute it and/or modify
/////  it under the terms of the GNU General Public License as published by
/////  the Free Software Foundation; either version 2 of the License, or
/////  (at your option) any later version.
/////
/////  This program is distributed in the hope that it will be useful,
/////  but WITHOUT ANY WARRANTY; without even the implied warranty of
/////  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/////  GNU General Public License for more details.
/////  You should have received a copy of the GNU General Public License
/////  along with this program; if not, write to the Free Software
/////  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
/////
/////  Change Log:
/////  2005-xx-xx VM Created
/////  2008-03-22 VM Cleanup the code
/////
/////////////////////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Net;
//using System.Net.Mail;
using LumiSoft.Net;
using LumiSoft.Net.SMTP.Client;
//using LumiSoft.Net.Dns;
using LumiSoft.Net.Mime;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using Win32Mapi;
using System.Collections.Generic;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit;

namespace EmailSender
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FrmMain : System.Windows.Forms.Form
	{
		#region Designer Created Codes
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.StatusBar statusBarMain;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.MenuItem menuItem34;
		private System.Windows.Forms.MenuItem menuItem39;
		private System.Windows.Forms.MenuItem menuItem40;
		private System.Windows.Forms.MenuItem menuItem42;
		private System.Windows.Forms.MenuItem menuItem44;
		private System.Windows.Forms.MenuItem menuItem45;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public ListView uxListViewAddress;
		private System.Windows.Forms.StatusBarPanel statusBarPanelMsg;
		private System.Windows.Forms.StatusBarPanel statusBarPanelStatus;
		private System.Windows.Forms.StatusBarPanel statusBarPanelSuccess;
		private System.Windows.Forms.StatusBarPanel statusBarPanelFail;
		private System.Windows.Forms.StatusBarPanel statusBarPanelTotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox uxFormat;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuItem menuItem48;
		private System.Windows.Forms.MenuItem menuItem49;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ContextMenu contextMenuAttach;
		private System.Windows.Forms.MenuItem menuItem51;
		private System.Windows.Forms.MenuItem menuItem52;
		private System.Windows.Forms.MenuItem menuItem53;
		private System.Windows.Forms.Button btnAttAdd;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.MenuItem menuItem59;
		private System.Windows.Forms.MenuItem menuItem60;
		private System.Windows.Forms.MenuItem menuItem61;
		private System.Windows.Forms.MenuItem menuItem62;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.MenuItem menuItem63;
		private System.Windows.Forms.MenuItem menuItem64;
		private System.Windows.Forms.TextBox txtFromEmail;
		private System.Windows.Forms.TextBox txtFromName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtBody;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox txtReply;
		private System.Windows.Forms.OpenFileDialog openFileDialog3;
		private System.Windows.Forms.MenuItem menuItem65;
		private System.Windows.Forms.MenuItem menuItem66;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.TabPage tabLog;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ListView lvLog;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.Timer tmrFailRetry;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.OpenFileDialog openFileDialog4;
		private System.Windows.Forms.SaveFileDialog saveFileDialog2;
		private System.Windows.Forms.MenuItem menuItem69;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.MenuItem menuItem70;
		private System.Windows.Forms.MenuItem menuItem41;
		private System.Windows.Forms.MenuItem menuItem71;
		private System.Windows.Forms.Timer tmrSaveFile;
		private System.Windows.Forms.MenuItem menuItem73;
		private System.Windows.Forms.MenuItem menuItem74;
		private System.Windows.Forms.MenuItem menuItem75;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButtonStart;
		private System.Windows.Forms.ToolBarButton toolBarButtonStop;
		private System.Windows.Forms.ToolBarButton toolBarButtonPause;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.MenuItem mnuFileNew;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.MenuItem mnuFileOpen;
		private System.Windows.Forms.ToolBarButton toolBarButtonNew;
		private System.Windows.Forms.ToolBarButton toolBarButtonSplit1;
		private System.Windows.Forms.ToolBarButton toolBarButtonOpen;
		private System.Windows.Forms.MenuItem mnuFileMerge;
		private System.Windows.Forms.MenuItem mnuFileSave;
		private System.Windows.Forms.ToolBarButton toolBarButtonSave;
        private System.Windows.Forms.MenuItem mnuLoadFileText;
		private System.Windows.Forms.MenuItem mnuSendStart;
		private System.Windows.Forms.MenuItem mnuSendPause;
		private System.Windows.Forms.MenuItem mnuSendStop;
		private System.Windows.Forms.ImageList imlToolbar;
		private System.Windows.Forms.ToolBarButton toolBarButtonSplit2;
		private System.Windows.Forms.ToolBarButton toolBarButtonAdd;
		private System.Windows.Forms.ToolBarButton toolBarButtonDelete;
		private System.Windows.Forms.ToolBarButton toolBarButtonEdit;
		private System.Windows.Forms.ToolBarButton toolBarButtonSplit3;
		private System.Windows.Forms.ToolBarButton toolBarButtonOption;
		private System.Windows.Forms.MenuItem mnuViewOptions;
        private ErrorProvider errorProvider1;
        private WebBrowser webBrowser1;
		private System.Windows.Forms.MenuItem menuItem67;

		
		#endregion
		
		public FrmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			uxListViewAddress.ListViewItemSorter = comparer;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuFileNew = new System.Windows.Forms.MenuItem();
            this.mnuFileOpen = new System.Windows.Forms.MenuItem();
            this.mnuFileMerge = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuFileSave = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem69 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem64 = new System.Windows.Forms.MenuItem();
            this.menuItem63 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem71 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem73 = new System.Windows.Forms.MenuItem();
            this.menuItem74 = new System.Windows.Forms.MenuItem();
            this.menuItem75 = new System.Windows.Forms.MenuItem();
            this.menuItem48 = new System.Windows.Forms.MenuItem();
            this.menuItem49 = new System.Windows.Forms.MenuItem();
            this.menuItem59 = new System.Windows.Forms.MenuItem();
            this.menuItem60 = new System.Windows.Forms.MenuItem();
            this.menuItem70 = new System.Windows.Forms.MenuItem();
            this.menuItem61 = new System.Windows.Forms.MenuItem();
            this.menuItem62 = new System.Windows.Forms.MenuItem();
            this.menuItem65 = new System.Windows.Forms.MenuItem();
            this.menuItem66 = new System.Windows.Forms.MenuItem();
            this.menuItem67 = new System.Windows.Forms.MenuItem();
            this.mnuLoadFileText = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem32 = new System.Windows.Forms.MenuItem();
            this.mnuViewOptions = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.mnuSendStart = new System.Windows.Forms.MenuItem();
            this.mnuSendPause = new System.Windows.Forms.MenuItem();
            this.mnuSendStop = new System.Windows.Forms.MenuItem();
            this.menuItem39 = new System.Windows.Forms.MenuItem();
            this.menuItem40 = new System.Windows.Forms.MenuItem();
            this.menuItem44 = new System.Windows.Forms.MenuItem();
            this.menuItem41 = new System.Windows.Forms.MenuItem();
            this.menuItem42 = new System.Windows.Forms.MenuItem();
            this.menuItem45 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.statusBarMain = new System.Windows.Forms.StatusBar();
            this.statusBarPanelMsg = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelStatus = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelSuccess = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelFail = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelTotal = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uxListViewAddress = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReply = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.uxFormat = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuAttach = new System.Windows.Forms.ContextMenu();
            this.menuItem53 = new System.Windows.Forms.MenuItem();
            this.menuItem51 = new System.Windows.Forms.MenuItem();
            this.menuItem52 = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAttAdd = new System.Windows.Forms.Button();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.lvLog = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.tmrFailRetry = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButtonNew = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonOpen = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonSave = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonSplit1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonAdd = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonEdit = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonDelete = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonSplit2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonStart = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonPause = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonStop = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonSplit3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonOption = new System.Windows.Forms.ToolBarButton();
            this.imlToolbar = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.tmrSaveFile = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelFail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem9,
            this.menuItem48,
            this.menuItem27,
            this.menuItem34,
            this.menuItem39});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileMerge,
            this.menuItem4,
            this.mnuFileSave,
            this.menuItem6,
            this.menuItem7,
            this.mnuFileExit});
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Index = 0;
            resources.ApplyResources(this.mnuFileNew, "mnuFileNew");
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Index = 1;
            resources.ApplyResources(this.mnuFileOpen, "mnuFileOpen");
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileMerge
            // 
            this.mnuFileMerge.Index = 2;
            resources.ApplyResources(this.mnuFileMerge, "mnuFileMerge");
            this.mnuFileMerge.Click += new System.EventHandler(this.mnuFileMerge_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            resources.ApplyResources(this.menuItem4, "menuItem4");
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Index = 4;
            resources.ApplyResources(this.mnuFileSave, "mnuFileSave");
            this.mnuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            resources.ApplyResources(this.menuItem6, "menuItem6");
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 6;
            resources.ApplyResources(this.menuItem7, "menuItem7");
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Index = 7;
            resources.ApplyResources(this.mnuFileExit, "mnuFileExit");
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem13,
            this.menuItem14,
            this.menuItem20,
            this.menuItem23,
            this.menuItem24,
            this.menuItem25,
            this.menuItem26,
            this.menuItem69,
            this.menuItem15,
            this.menuItem16,
            this.menuItem64,
            this.menuItem63,
            this.menuItem21,
            this.menuItem22,
            this.menuItem17,
            this.menuItem18,
            this.menuItem71,
            this.menuItem19,
            this.menuItem73,
            this.menuItem74,
            this.menuItem75});
            resources.ApplyResources(this.menuItem9, "menuItem9");
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            resources.ApplyResources(this.menuItem12, "menuItem12");
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            resources.ApplyResources(this.menuItem13, "menuItem13");
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            resources.ApplyResources(this.menuItem14, "menuItem14");
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 3;
            resources.ApplyResources(this.menuItem20, "menuItem20");
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 4;
            resources.ApplyResources(this.menuItem23, "menuItem23");
            this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 5;
            resources.ApplyResources(this.menuItem24, "menuItem24");
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 6;
            resources.ApplyResources(this.menuItem25, "menuItem25");
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 7;
            resources.ApplyResources(this.menuItem26, "menuItem26");
            this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // menuItem69
            // 
            this.menuItem69.Index = 8;
            resources.ApplyResources(this.menuItem69, "menuItem69");
            this.menuItem69.Click += new System.EventHandler(this.menuItem69_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 9;
            resources.ApplyResources(this.menuItem15, "menuItem15");
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 10;
            resources.ApplyResources(this.menuItem16, "menuItem16");
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // menuItem64
            // 
            this.menuItem64.Index = 11;
            resources.ApplyResources(this.menuItem64, "menuItem64");
            this.menuItem64.Click += new System.EventHandler(this.menuItem64_Click);
            // 
            // menuItem63
            // 
            this.menuItem63.Index = 12;
            resources.ApplyResources(this.menuItem63, "menuItem63");
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 13;
            resources.ApplyResources(this.menuItem21, "menuItem21");
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 14;
            resources.ApplyResources(this.menuItem22, "menuItem22");
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 15;
            resources.ApplyResources(this.menuItem17, "menuItem17");
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 16;
            resources.ApplyResources(this.menuItem18, "menuItem18");
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItem71
            // 
            this.menuItem71.Index = 17;
            resources.ApplyResources(this.menuItem71, "menuItem71");
            this.menuItem71.Click += new System.EventHandler(this.menuItem71_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 18;
            resources.ApplyResources(this.menuItem19, "menuItem19");
            this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // menuItem73
            // 
            this.menuItem73.Index = 19;
            resources.ApplyResources(this.menuItem73, "menuItem73");
            // 
            // menuItem74
            // 
            this.menuItem74.Index = 20;
            resources.ApplyResources(this.menuItem74, "menuItem74");
            this.menuItem74.Click += new System.EventHandler(this.menuItem74_Click);
            // 
            // menuItem75
            // 
            resources.ApplyResources(this.menuItem75, "menuItem75");
            this.menuItem75.Index = 21;
            this.menuItem75.Click += new System.EventHandler(this.menuItem75_Click);
            // 
            // menuItem48
            // 
            this.menuItem48.Index = 2;
            this.menuItem48.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem49,
            this.mnuLoadFileText});
            resources.ApplyResources(this.menuItem48, "menuItem48");
            // 
            // menuItem49
            // 
            this.menuItem49.Index = 0;
            this.menuItem49.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem59,
            this.menuItem60,
            this.menuItem70,
            this.menuItem61,
            this.menuItem62,
            this.menuItem65,
            this.menuItem66,
            this.menuItem67});
            resources.ApplyResources(this.menuItem49, "menuItem49");
            // 
            // menuItem59
            // 
            this.menuItem59.Index = 0;
            resources.ApplyResources(this.menuItem59, "menuItem59");
            this.menuItem59.Click += new System.EventHandler(this.menuItem59_Click);
            // 
            // menuItem60
            // 
            this.menuItem60.Index = 1;
            resources.ApplyResources(this.menuItem60, "menuItem60");
            this.menuItem60.Click += new System.EventHandler(this.menuItem60_Click);
            // 
            // menuItem70
            // 
            this.menuItem70.Index = 2;
            resources.ApplyResources(this.menuItem70, "menuItem70");
            this.menuItem70.Click += new System.EventHandler(this.menuItem70_Click);
            // 
            // menuItem61
            // 
            this.menuItem61.Index = 3;
            resources.ApplyResources(this.menuItem61, "menuItem61");
            this.menuItem61.Click += new System.EventHandler(this.menuItem61_Click);
            // 
            // menuItem62
            // 
            this.menuItem62.Index = 4;
            resources.ApplyResources(this.menuItem62, "menuItem62");
            this.menuItem62.Click += new System.EventHandler(this.menuItem62_Click);
            // 
            // menuItem65
            // 
            this.menuItem65.Index = 5;
            resources.ApplyResources(this.menuItem65, "menuItem65");
            this.menuItem65.Click += new System.EventHandler(this.menuItem65_Click);
            // 
            // menuItem66
            // 
            this.menuItem66.Index = 6;
            resources.ApplyResources(this.menuItem66, "menuItem66");
            this.menuItem66.Click += new System.EventHandler(this.menuItem66_Click);
            // 
            // menuItem67
            // 
            this.menuItem67.Index = 7;
            resources.ApplyResources(this.menuItem67, "menuItem67");
            this.menuItem67.Click += new System.EventHandler(this.menuItem67_Click);
            // 
            // mnuLoadFileText
            // 
            this.mnuLoadFileText.Index = 1;
            resources.ApplyResources(this.mnuLoadFileText, "mnuLoadFileText");
            this.mnuLoadFileText.Click += new System.EventHandler(this.menuLoadFileText_Click);
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 3;
            this.menuItem27.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem28,
            this.menuItem29,
            this.menuItem30,
            this.menuItem10,
            this.menuItem32,
            this.mnuViewOptions});
            resources.ApplyResources(this.menuItem27, "menuItem27");
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 0;
            resources.ApplyResources(this.menuItem28, "menuItem28");
            this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 1;
            resources.ApplyResources(this.menuItem29, "menuItem29");
            this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 2;
            resources.ApplyResources(this.menuItem30, "menuItem30");
            this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 3;
            resources.ApplyResources(this.menuItem10, "menuItem10");
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem32
            // 
            this.menuItem32.Index = 4;
            resources.ApplyResources(this.menuItem32, "menuItem32");
            // 
            // mnuViewOptions
            // 
            this.mnuViewOptions.Index = 5;
            resources.ApplyResources(this.mnuViewOptions, "mnuViewOptions");
            this.mnuViewOptions.Click += new System.EventHandler(this.mnuViewOptions_Click);
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 4;
            this.menuItem34.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSendStart,
            this.mnuSendPause,
            this.mnuSendStop});
            resources.ApplyResources(this.menuItem34, "menuItem34");
            // 
            // mnuSendStart
            // 
            this.mnuSendStart.Index = 0;
            resources.ApplyResources(this.mnuSendStart, "mnuSendStart");
            this.mnuSendStart.Click += new System.EventHandler(this.mnuSendStart_Click);
            // 
            // mnuSendPause
            // 
            resources.ApplyResources(this.mnuSendPause, "mnuSendPause");
            this.mnuSendPause.Index = 1;
            this.mnuSendPause.Click += new System.EventHandler(this.menuSendPause_Click);
            // 
            // mnuSendStop
            // 
            resources.ApplyResources(this.mnuSendStop, "mnuSendStop");
            this.mnuSendStop.Index = 2;
            this.mnuSendStop.Click += new System.EventHandler(this.menuSendStop_Click);
            // 
            // menuItem39
            // 
            this.menuItem39.Index = 5;
            this.menuItem39.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem40,
            this.menuItem44,
            this.menuItem41,
            this.menuItem42,
            this.menuItem45,
            this.mnuAbout});
            resources.ApplyResources(this.menuItem39, "menuItem39");
            // 
            // menuItem40
            // 
            this.menuItem40.Index = 0;
            resources.ApplyResources(this.menuItem40, "menuItem40");
            // 
            // menuItem44
            // 
            this.menuItem44.Index = 1;
            resources.ApplyResources(this.menuItem44, "menuItem44");
            // 
            // menuItem41
            // 
            this.menuItem41.Index = 2;
            resources.ApplyResources(this.menuItem41, "menuItem41");
            // 
            // menuItem42
            // 
            this.menuItem42.Index = 3;
            resources.ApplyResources(this.menuItem42, "menuItem42");
            this.menuItem42.Click += new System.EventHandler(this.menuItem42_Click);
            // 
            // menuItem45
            // 
            this.menuItem45.Index = 4;
            resources.ApplyResources(this.menuItem45, "menuItem45");
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 5;
            resources.ApplyResources(this.mnuAbout, "mnuAbout");
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // statusBarMain
            // 
            resources.ApplyResources(this.statusBarMain, "statusBarMain");
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanelMsg,
            this.statusBarPanelStatus,
            this.statusBarPanelSuccess,
            this.statusBarPanelFail,
            this.statusBarPanelTotal,
            this.statusBarPanel1});
            this.statusBarMain.ShowPanels = true;
            // 
            // statusBarPanelMsg
            // 
            this.statusBarPanelMsg.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanelMsg.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            resources.ApplyResources(this.statusBarPanelMsg, "statusBarPanelMsg");
            // 
            // statusBarPanelStatus
            // 
            this.statusBarPanelStatus.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            resources.ApplyResources(this.statusBarPanelStatus, "statusBarPanelStatus");
            // 
            // statusBarPanelSuccess
            // 
            this.statusBarPanelSuccess.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            resources.ApplyResources(this.statusBarPanelSuccess, "statusBarPanelSuccess");
            // 
            // statusBarPanelFail
            // 
            this.statusBarPanelFail.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            resources.ApplyResources(this.statusBarPanelFail, "statusBarPanelFail");
            // 
            // statusBarPanelTotal
            // 
            this.statusBarPanelTotal.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            resources.ApplyResources(this.statusBarPanelTotal, "statusBarPanelTotal");
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            resources.ApplyResources(this.statusBarPanel1, "statusBarPanel1");
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabLog);
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uxListViewAddress);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // uxListViewAddress
            // 
            this.uxListViewAddress.CheckBoxes = true;
            this.uxListViewAddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10});
            resources.ApplyResources(this.uxListViewAddress, "uxListViewAddress");
            this.uxListViewAddress.FullRowSelect = true;
            this.uxListViewAddress.HideSelection = false;
            this.uxListViewAddress.Name = "uxListViewAddress";
            this.uxListViewAddress.SmallImageList = this.imageList2;
            this.uxListViewAddress.UseCompatibleStateImageBehavior = false;
            this.uxListViewAddress.View = System.Windows.Forms.View.Details;
            this.uxListViewAddress.SelectedIndexChanged += new System.EventHandler(this.listViewAddress_SelectedIndexChanged);
            this.uxListViewAddress.DoubleClick += new System.EventHandler(this.listViewAddress_DoubleClick);
            this.uxListViewAddress.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewAddress_ItemCheck);
            this.uxListViewAddress.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewAddress_ColumnClick);
            this.uxListViewAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewAddress_KeyDown);
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList2, "imageList2");
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Controls.Add(this.panel1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtBody);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            // 
            // txtBody
            // 
            this.txtBody.AcceptsReturn = true;
            this.txtBody.AcceptsTab = true;
            resources.ApplyResources(this.txtBody, "txtBody");
            this.txtBody.Name = "txtBody";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.webBrowser1);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtFromEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFromName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtReply);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.uxFormat);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label6);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            this.comboBox1.Name = "comboBox1";
            // 
            // txtFromEmail
            // 
            resources.ApplyResources(this.txtFromEmail, "txtFromEmail");
            this.txtFromEmail.Name = "txtFromEmail";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Name = "label2";
            // 
            // txtFromName
            // 
            resources.ApplyResources(this.txtFromName, "txtFromName");
            this.txtFromName.Name = "txtFromName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Name = "label3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Name = "label7";
            // 
            // txtReply
            // 
            resources.ApplyResources(this.txtReply, "txtReply");
            this.txtReply.Name = "txtReply";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Name = "label5";
            // 
            // txtSubject
            // 
            resources.ApplyResources(this.txtSubject, "txtSubject");
            this.txtSubject.Name = "txtSubject";
            // 
            // uxFormat
            // 
            resources.ApplyResources(this.uxFormat, "uxFormat");
            this.uxFormat.Items.AddRange(new object[] {
            resources.GetString("uxFormat.Items"),
            resources.GetString("uxFormat.Items1")});
            this.uxFormat.Name = "uxFormat";
            // 
            // comboBox3
            // 
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2"),
            resources.GetString("comboBox3.Items3"),
            resources.GetString("comboBox3.Items4"),
            resources.GetString("comboBox3.Items5")});
            this.comboBox3.Name = "comboBox3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Name = "label6";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.panel2);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenu = this.contextMenuAttach;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Name = "listView1";
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // contextMenuAttach
            // 
            this.contextMenuAttach.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem53,
            this.menuItem51,
            this.menuItem52});
            // 
            // menuItem53
            // 
            this.menuItem53.Index = 0;
            resources.ApplyResources(this.menuItem53, "menuItem53");
            this.menuItem53.Click += new System.EventHandler(this.menuItem53_Click);
            // 
            // menuItem51
            // 
            this.menuItem51.DefaultItem = true;
            this.menuItem51.Index = 1;
            resources.ApplyResources(this.menuItem51, "menuItem51");
            this.menuItem51.Click += new System.EventHandler(this.menuItem51_Click);
            // 
            // menuItem52
            // 
            this.menuItem52.Index = 2;
            resources.ApplyResources(this.menuItem52, "menuItem52");
            this.menuItem52.Click += new System.EventHandler(this.menuItem52_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnAttAdd);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.toolTip1.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAttAdd
            // 
            resources.ApplyResources(this.btnAttAdd, "btnAttAdd");
            this.btnAttAdd.Name = "btnAttAdd";
            this.toolTip1.SetToolTip(this.btnAttAdd, resources.GetString("btnAttAdd.ToolTip"));
            this.btnAttAdd.Click += new System.EventHandler(this.btnAttAdd_Click);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.lvLog);
            resources.ApplyResources(this.tabLog, "tabLog");
            this.tabLog.Name = "tabLog";
            // 
            // lvLog
            // 
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            resources.ApplyResources(this.lvLog, "lvLog");
            this.lvLog.FullRowSelect = true;
            this.lvLog.MultiSelect = false;
            this.lvLog.Name = "lvLog";
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.Multiselect = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "*.txt";
            resources.ApplyResources(this.openFileDialog2, "openFileDialog2");
            this.openFileDialog2.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.xml";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.DefaultExt = "*.xml";
            resources.ApplyResources(this.openFileDialog3, "openFileDialog3");
            // 
            // tmrFailRetry
            // 
            this.tmrFailRetry.Tick += new System.EventHandler(this.tmrFailRetry_Tick);
            // 
            // toolBar1
            // 
            resources.ApplyResources(this.toolBar1, "toolBar1");
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButtonNew,
            this.toolBarButtonOpen,
            this.toolBarButtonSave,
            this.toolBarButtonSplit1,
            this.toolBarButtonAdd,
            this.toolBarButtonEdit,
            this.toolBarButtonDelete,
            this.toolBarButtonSplit2,
            this.toolBarButtonStart,
            this.toolBarButtonPause,
            this.toolBarButtonStop,
            this.toolBarButtonSplit3,
            this.toolBarButtonOption});
            this.toolBar1.ImageList = this.imlToolbar;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButtonNew
            // 
            resources.ApplyResources(this.toolBarButtonNew, "toolBarButtonNew");
            this.toolBarButtonNew.Name = "toolBarButtonNew";
            this.toolBarButtonNew.Tag = "New";
            // 
            // toolBarButtonOpen
            // 
            resources.ApplyResources(this.toolBarButtonOpen, "toolBarButtonOpen");
            this.toolBarButtonOpen.Name = "toolBarButtonOpen";
            this.toolBarButtonOpen.Tag = "Open";
            // 
            // toolBarButtonSave
            // 
            resources.ApplyResources(this.toolBarButtonSave, "toolBarButtonSave");
            this.toolBarButtonSave.Name = "toolBarButtonSave";
            this.toolBarButtonSave.Tag = "Save";
            // 
            // toolBarButtonSplit1
            // 
            this.toolBarButtonSplit1.Name = "toolBarButtonSplit1";
            this.toolBarButtonSplit1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButtonAdd
            // 
            resources.ApplyResources(this.toolBarButtonAdd, "toolBarButtonAdd");
            this.toolBarButtonAdd.Name = "toolBarButtonAdd";
            this.toolBarButtonAdd.Tag = "Add";
            // 
            // toolBarButtonEdit
            // 
            resources.ApplyResources(this.toolBarButtonEdit, "toolBarButtonEdit");
            this.toolBarButtonEdit.Name = "toolBarButtonEdit";
            this.toolBarButtonEdit.Tag = "Edit";
            // 
            // toolBarButtonDelete
            // 
            resources.ApplyResources(this.toolBarButtonDelete, "toolBarButtonDelete");
            this.toolBarButtonDelete.Name = "toolBarButtonDelete";
            this.toolBarButtonDelete.Tag = "Delete";
            // 
            // toolBarButtonSplit2
            // 
            this.toolBarButtonSplit2.Name = "toolBarButtonSplit2";
            this.toolBarButtonSplit2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButtonStart
            // 
            resources.ApplyResources(this.toolBarButtonStart, "toolBarButtonStart");
            this.toolBarButtonStart.Name = "toolBarButtonStart";
            this.toolBarButtonStart.Tag = "Start";
            // 
            // toolBarButtonPause
            // 
            resources.ApplyResources(this.toolBarButtonPause, "toolBarButtonPause");
            this.toolBarButtonPause.Name = "toolBarButtonPause";
            this.toolBarButtonPause.Tag = "Pause";
            // 
            // toolBarButtonStop
            // 
            resources.ApplyResources(this.toolBarButtonStop, "toolBarButtonStop");
            this.toolBarButtonStop.Name = "toolBarButtonStop";
            this.toolBarButtonStop.Tag = "Stop";
            // 
            // toolBarButtonSplit3
            // 
            this.toolBarButtonSplit3.Name = "toolBarButtonSplit3";
            this.toolBarButtonSplit3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButtonOption
            // 
            resources.ApplyResources(this.toolBarButtonOption, "toolBarButtonOption");
            this.toolBarButtonOption.Name = "toolBarButtonOption";
            this.toolBarButtonOption.Tag = "Option";
            // 
            // imlToolbar
            // 
            this.imlToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlToolbar.ImageStream")));
            this.imlToolbar.TransparentColor = System.Drawing.Color.Transparent;
            this.imlToolbar.Images.SetKeyName(0, "");
            this.imlToolbar.Images.SetKeyName(1, "");
            this.imlToolbar.Images.SetKeyName(2, "");
            this.imlToolbar.Images.SetKeyName(3, "");
            this.imlToolbar.Images.SetKeyName(4, "");
            this.imlToolbar.Images.SetKeyName(5, "");
            this.imlToolbar.Images.SetKeyName(6, "");
            this.imlToolbar.Images.SetKeyName(7, "");
            this.imlToolbar.Images.SetKeyName(8, "");
            this.imlToolbar.Images.SetKeyName(9, "");
            this.imlToolbar.Images.SetKeyName(10, "");
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.DefaultExt = "*.txt";
            resources.ApplyResources(this.openFileDialog4, "openFileDialog4");
            this.openFileDialog4.Multiselect = true;
            // 
            // saveFileDialog2
            // 
            resources.ApplyResources(this.saveFileDialog2, "saveFileDialog2");
            // 
            // tmrSaveFile
            // 
            this.tmrSaveFile.Tick += new System.EventHandler(this.tmrSaveFile_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusBarMain);
            this.Controls.Add(this.toolBar1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelFail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        internal class CustomExceptionHandler
        {

            // Handles the exception event.
            public void OnThreadException(object sender, ThreadExceptionEventArgs t)
            {
                FrmDebug frm = new FrmDebug(t.Exception);
                DialogResult result = DialogResult.Cancel;

                try
                {
                    result = frm.ShowDialog();
                }
                catch
                {
                    try
                    {
                        MessageBox.Show("Fatal Error", "Fatal Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                    }
                    finally
                    {
                        Application.Exit();
                    }
                }

                // Exits the program when the user clicks Abort.
                if (result == DialogResult.Abort)
                    Application.Exit();
            }
        }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();

            // Creates an instance of the methods that will handle the exception.
            CustomExceptionHandler eh = new CustomExceptionHandler();

            // Adds the event handler to to the event.
            Application.ThreadException += new ThreadExceptionEventHandler(eh.OnThreadException);

			//            If cul.Length > 0 Then Thread.CurrentThread.CurrentUICulture = New CultureInfo(cul)
			Application.Run(new FrmMain());
		}
		private int nIndex = 0;
		private bool _ifModified;
		private string _fileTitle = "";
		private string _oldFormTitle = "";
		private string _previewFileName = "";
		private ClassSettings _appOptions;
        private SMTP_Client _smtpClient;
		private int _cntActive = 0;
		private int _cntQueued = 0;
		int m_Total = 0;
		int m_cntFail = 0;
		int m_cntSuccess = 0;
		bool m_paused = false;
		bool m_stop;
		MailComparer comparer = new MailComparer();
		bool m_busy = false;

        //A list of email addresses in memory 
		private Dictionary<string,  int> _ht = new Dictionary<string,  int>();

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadSettings();
			_oldFormTitle = this.Text;
			mnuFileNew.PerformClick(); //menu New
            //2008-03-22 VM Set UI owner to "this".
            //client = new SMTP_Client(listViewAddress);
            _smtpClient = new SMTP_Client(this); 
            _smtpClient.CompletedAll += new System.EventHandler(this.SendMailCompletedAll);
			_smtpClient.SendJobCompleted += new SMTP_SendJob_EventHandler(SendMailSendJobCompleted);
			_smtpClient.PartOfMessageIsSent += new SMTP_PartOfMessage_EventHandler(SendMailPartOfMessageIsSent);
			_smtpClient.Error += new SMTP_Error_EventHandler(SendMailError);
			_smtpClient.NewSendJob += new SMTP_SendJob_EventHandler(SendMailNewSendJob);
			_smtpClient.SessionLog += new LogEventHandler(SendMailSessionLog);
			
			imageList2.ImageSize = new Size(12,12);
			imageList2.Images.Add (new Bitmap(typeof(FrmMain), "Image.perlblack12x12.gif"));
			imageList2.Images.Add (new Bitmap(typeof(FrmMain), "Image.perlgreen12x12.gif"));
			imageList2.Images.Add (new Bitmap(typeof(FrmMain), "Image.busy12.gif"));
			imageList2.Images.Add (new Bitmap(typeof(FrmMain), "Image.exclamation12.gif"));
			imageList2.Images.Add (new Bitmap(typeof(FrmMain), "Image.question12.gif"));
			imageList2.Images.Add (new Bitmap(typeof(FrmMain), "Image.information12.gif"));
			imageList2.Images.Add (new Bitmap(typeof(FrmMain), "Image.critical12.gif"));
			statusBarPanelMsg.Text = "";
		
			toolBarButtonPause.Enabled=false;
			toolBarButtonStop.Enabled = false;
		}

		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnAttAdd_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				foreach(string fn in openFileDialog1.FileNames)
				{
					AddAttachment(fn);
				}
			}
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			menuItem51.PerformClick();
		}

		private void menuItem53_Click(object sender, System.EventArgs e)
		{
			btnAttAdd.PerformClick();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			menuItem52.PerformClick();
		}

		private void menuItem52_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem itm in listView1.SelectedItems)
			{
				itm.Remove();
			}
		}

		private void menuItem51_Click(object sender, System.EventArgs e)
		{
			foreach( ListViewItem itm in listView1.SelectedItems)
			{
				System.Diagnostics.Process proc = new System.Diagnostics.Process(); 
				proc.EnableRaisingEvents=false; 
				proc.StartInfo.FileName=itm.Text; 
				proc.Start();
			}
		}

		private bool ImportAddr(string email, string contact, string company, string memo)
		{
			ListViewItem lvItm=null;
			bool ok;
			ok = false;
			bool add;
			add = false;
			if(!_ht.ContainsKey(email))
			{
				_ht.Add(email,uxListViewAddress.Items.Count);
				add = true;
			}
			else
			{
				if (_appOptions._ifReplaceDup)
				{
					int pos = (int) _ht[email];
					lvItm = uxListViewAddress.Items[pos];
					lvItm.SubItems[1].Text = contact;
					lvItm.SubItems[2].Text = company;
					lvItm.SubItems[3].Text = "Updated";
					lvItm.SubItems[4].Text = memo;
					lvItm.SubItems[5].Text = "";
					ok = true;
				}
				if (_appOptions._ifNoImportDup)
					ok = false;
				if (_appOptions._ifCreateDup)
					add = true;
			}
										
			if (add)
			{
				lvItm = uxListViewAddress.Items.Add(email);
				lvItm.SubItems.Add (contact);
				lvItm.SubItems.Add (company);
				lvItm.SubItems.Add ("New");
				lvItm.SubItems.Add(memo); 
				lvItm.SubItems.Add("");
				ok = true;
			}
			if (ok)
			{
				lvItm.Checked = true;
				lvItm.ImageIndex = 0;
				lvItm.EnsureVisible();
				listView1.Refresh();
				Application.DoEvents();
			}
			return ok;
		}

        /// <summary>
        /// Copy the email addresses from listViewAddress to _ht
        /// </summary>
		private void LoadHT()
		{
			_ht.Clear();
			foreach(ListViewItem itm in uxListViewAddress.Items)
			{
				if(!_ht.ContainsKey(itm.Text))
					_ht.Add(itm.Text, itm.Index);
			}
		}
		private void UnloadHT()
		{
			_ht.Clear();
		}

		#region DoVerticalImport()
        /// <summary>
        /// Import email recipients from a vertical layout text file into uxListViewAddress. See Sample_Vertical.txt
        /// </summary>
        /// <param name="importFileName"></param>
        /// <returns>Number of new recipients imported</returns>
		public int DoVerticalImport(string importFileName)
		{
			LoadHT();
			int cnt = 0;
            using (System.IO.FileStream fs = new FileStream(importFileName, FileMode.Open, FileAccess.Read))
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = sr.ReadLine().Trim();
                    while (line != null)
                    {
                        if (line != "")
                        {
                            string companyName = "";
                            string address = "";
                            string phone = "";
                            string fax = "";
                            string email = "";
                            string website = "";
                            string contact = "";
                            string title = "";
                            string memo = "";
                            Log("Importing " + line);
                            int pos = line.IndexOf(" ");
                            if (pos < 0) pos = 0;
                            companyName = line.Substring(pos).Trim();

                            while ((line = sr.ReadLine()) != "")
                            {
                                if (line == null) break;
                                line = line.Trim();
                                if (line.StartsWith("Address:"))
                                {
                                    address = line.Replace("Address:", "").Trim();
                                }
                                if (line.StartsWith("Phone:"))
                                {
                                    phone = line.Replace("Phone:", "").Trim();
                                }
                                if (line.StartsWith("Fax:"))
                                {
                                    fax = line.Replace("Fax:", "").Trim();
                                }
                                if (line.StartsWith("E-mail:"))
                                {
                                    email = line.Replace("E-mail:", "").Trim();
                                }
                                if (line.StartsWith("Website:"))
                                {
                                    website = line.Replace("Website:", "").Trim();
                                }
                                if (line.StartsWith("Memo:"))
                                {
                                    memo = line.Replace("Memo:", "").Trim();
                                }
                                if (line.StartsWith("Contact:"))
                                {
                                    contact = line.Replace("Contact:", "").Trim();
                                    if (contact.IndexOf(",") > 0)
                                    {
                                        title = contact.Substring(contact.IndexOf(",") + 1).Trim();
                                        contact = contact.Substring(0, contact.IndexOf(","));
                                    }
                                    else
                                        title = "";
                                }
                            }

                            if (ImportAddr(email, contact, companyName, memo))
                                cnt++;

                        }
                        else
                        {
                            line = sr.ReadLine();
                            if (line != null)
                                line = line.Trim();
                        }
                    }
                    sr.Close();
                }
                fs.Close();
            }
			UnloadHT();
			return cnt;
		}
		#endregion

		#region DoDelimitedImport()
        /// <summary>
        /// Import recipients from a common delimited file. 
        /// </summary>
        /// <param name="importFileName"></param>
        /// <param name="separator">list of delimiters</param>
        /// <returns></returns>
		public int DoDelimitedImport(string importFileName, char[] separator)
		{
			LoadHT();
			int cnt = 0;
			System.IO.FileStream fs = new FileStream(importFileName, FileMode.Open, FileAccess.Read);
			using (StreamReader sr = new StreamReader(fs)) 
			{
				string line; //= sr.ReadLine();
				while ((line = sr.ReadLine()) != null) 
				{
					if (line!="")
					{
						Log("Parsing: " + line);
						string[] fields = line.Split(separator,4); //0-email, 1-name, 2-company, 3-memo
						if (fields.Length==4)
						{
							string email = fields[0];
							string contact=fields[1];
							string company=fields[2];
							string memo=fields[3];
							if(ImportAddr(email, contact, company, memo))
								cnt++;
						}
						else
						{
							Log("Incorrect number of fields. Make sure the file is in correct format!"); 
						}
					}
				}
			}
			UnloadHT();
			return cnt;
		}
		#endregion

		#region DoXMLImport()
		private int DoXMLImport(string fn)
		{
			ExternalData extData;
			int cnt = 0;
			XmlSerializer s = new XmlSerializer( typeof( ExternalData ) );
			try
			{
				TextReader r = new StreamReader( fn );
				extData = (ExternalData)s.Deserialize( r );
				r.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening external data file. " + ex.Message, "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
			LoadHT();
									
			foreach (ExtAddress addr in extData.Addresses) 
			{ 
				if(ImportAddr(addr._email,addr._name, addr._company, addr._memo))
					cnt++;
			}
			UnloadHT();
			return cnt;

		}
		#endregion


	#region DoVerticalEmailImport()
	private int DoVerticalEmailImport(string fn)
	{
		LoadHT();
		int cnt = 0;
		System.IO.FileStream fs = new FileStream(fn, FileMode.Open, FileAccess.Read);
		using (StreamReader sr = new StreamReader(fs)) 
		{
			string line; //= sr.ReadLine();
			while ((line = sr.ReadLine()) != null) 
			{
				line = line.Trim();
				if (line!="")
				{
					Log("Parsing: " + line);
					if(ImportAddr(line, "", "", ""))
						cnt++;
				}
			}
		}
		UnloadHT();
		return cnt;
	}
		#endregion

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			LoadSettings();
			openFileDialog2.Filter = "Vertical text files(*.txt)|*.txt|Comma delimited text files(*.txt)|*.txt|Tab delimited text files(*.txt)|*.txt|XML files(*.xml)|*.xml|Email address only(*.txt)|*.txt";
			openFileDialog2.FilterIndex = 1; //The first item has an index of 1.
			if (openFileDialog2.ShowDialog()==DialogResult.OK)
			{
				int cnt = 0;
				statusBarPanelStatus.Text="Busy";
				try 
				{		

					foreach(string fn in openFileDialog2.FileNames)
					{
						switch(openFileDialog2.FilterIndex)
						{
							case 1:
								cnt += DoVerticalImport(fn);
								break;
							case 2:
								cnt += DoDelimitedImport(fn, new char[] {','});
								break;
							case 3:
								cnt += DoDelimitedImport(fn, new char[] {'\t'});
								break;
							case 4:
								cnt += DoXMLImport(fn);
								break;
							case 5:
								cnt += DoVerticalEmailImport(fn);
								break;
							default:
								break;
						}					
					}
					MessageBox.Show(cnt + " record(s) imported.", _oldFormTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show (ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				statusBarPanelMsg.Text = cnt + " record(s) imported.  "; 
				statusBarPanelStatus.Text = "Ready";
				statusBarPanelTotal.Text = "Total: " + uxListViewAddress.Items.Count.ToString();
			}
		}

		private void mnuFileMerge_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog3.ShowDialog()==DialogResult.OK)
			{
				MergeProfile(openFileDialog3.FileName);
			}

		}

		private void tmrSaveFile_Tick(object sender, System.EventArgs e)
		{
			if(_fileTitle!="")
			{
				SaveFile();
			}
		}

		private void menuItem71_Click(object sender, System.EventArgs e)
		{
			_blnExportAll = false;
			Export();
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			foreach (ListViewItem xitem in uxListViewAddress.Items) 
			{ 
				xitem.Selected = (xitem.ImageIndex == 6);
			} 


		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			foreach (ListViewItem xitem in uxListViewAddress.Items) 
			{ 
				xitem.Selected = !(xitem.SubItems[3].Text == "Send completed.");
			} 

		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			foreach (ListViewItem xitem in uxListViewAddress.Items) 
			{ 
				xitem.Selected = (xitem.SubItems[3].Text == "Send completed.");
			} 
        }


		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			AboutBox1 frm = new AboutBox1();
			frm.ShowDialog();
		}

		private void menuItem70_Click(object sender, System.EventArgs e)
		{
			if(!txtSubject.Focused && !txtBody.Focused)
			{
				MessageBox.Show("Field must be inserted inside Subject or Body.");
				return;
			}
			SendKeys.Send("<=Company>");

		}


		private void listViewAddress_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			if( e.Column == comparer.Column )
			{
				if( comparer.Order == SortOrder.Ascending )
					comparer.Order = SortOrder.Descending;
				else
					comparer.Order = SortOrder.Ascending;
			}
			else //if( (e.Column >= 0) & (e.Column <= 2) )
				comparer.Column = e.Column;
				
			uxListViewAddress.Sort();

		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			_ht.Clear();
			foreach (ListViewItem xitem in uxListViewAddress.Items) 
			{ 
				if(_ht.ContainsKey(xitem.Text))
					xitem.Selected = true;
				else
				{
					xitem.Selected = false;
					_ht.Add(xitem.Text, xitem.Index);
				}
			} 
			_ht.Clear();
		}
	
		public string NulltoString(string s)
		{
			if(s==null)
				s = "";
			return s;
		}
		public bool IsEmail(string inputEmail)
		{
			inputEmail  = NulltoString(inputEmail);
			string strRegex = @"^([a-zA-Z0-9_\-\.\+\&]+)@((\[[0-9]{1,3}" +
				@"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + 
				@".)+))([a-zA-Z]{2,14}|[0-9]{1,3})(\]?)$";
			System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(strRegex);
			if (re.IsMatch(inputEmail))
				return (true);
			else
				return (false);
		}

		private void menuItem69_Click(object sender, System.EventArgs e)
		{
			foreach (ListViewItem xitem in uxListViewAddress.Items) 
			{ 
				xitem.Selected = !IsEmail(xitem.Text);
			} 
		}
		#region DoVerticalExport()
		private int DoVerticalExport(string fn)
		{
			int cnt = 0;
			System.IO.FileStream fs = new FileStream(fn, FileMode.Create, FileAccess.ReadWrite);
			using (StreamWriter sw = new StreamWriter(fs)) 
			{
				sw.WriteLine();
				sw.WriteLine();
				foreach (ListViewItem xitem in uxListViewAddress.Items) 
				{ 
					if ((_blnExportAll) || (xitem.Selected))
					{
						cnt ++;
						sw.WriteLine(cnt.ToString() + ". " + xitem.SubItems[2].Text);
						sw.WriteLine("E-mail:\t" + xitem.Text);
						sw.WriteLine("Contact:\t" + xitem.SubItems[1].Text);
						sw.WriteLine("Memo:\t" + xitem.SubItems[4].Text); 
						sw.WriteLine();
					}
				} 
				//sw.Close();
			}
			//fs.Close();
			return cnt;
		}
		#endregion

		#region DoDelimitedExport()
		private int DoDelimitedExport(string fn, char[] separator)
		{
			int cnt = 0;
			System.IO.FileStream fs = new FileStream(fn, FileMode.Create, FileAccess.ReadWrite);
			using (StreamWriter sw = new StreamWriter(fs)) 
			{
				foreach (ListViewItem xitem in uxListViewAddress.Items) 
				{ 
					if ((_blnExportAll) || (xitem.Selected))
					{
						string s = xitem.Text + separator[0];
						s += xitem.SubItems[1].Text + separator[0];
						s += xitem.SubItems[2].Text + separator[0];
						s += xitem.SubItems[4].Text; 
						sw.WriteLine(s);
						cnt ++;
					}
				} 
				//sw.Close();
			}
			//fs.Close();
			return cnt;
		}
		#endregion

		#region DoXMLExport()
		private int DoXMLExport(string fn)
		{
			int cnt = 0;
			ExternalData myList = new ExternalData();
			foreach (ListViewItem xitem in uxListViewAddress.Items) 
			{ 
				if ((_blnExportAll) || (xitem.Selected))
				{
					myList.AddAddress(new ExtAddress(xitem.Text, xitem.SubItems[1].Text, xitem.SubItems[2].Text, xitem.SubItems[4].Text)); 
					cnt ++;
				}
			} 
	
			// Serialization
			XmlSerializer s = new XmlSerializer( typeof( ExternalData ) );
			TextWriter w = new StreamWriter( fn );
			s.Serialize( w, myList );
			w.Close();
			return cnt;
		}
		#endregion
		#region DoEmailOnlyExport()
		private int DoEmailOnlyExport(string fn)
		{
			int cnt = 0;
			System.IO.FileStream fs = new FileStream(fn, FileMode.Create, FileAccess.ReadWrite);
			using (StreamWriter sw = new StreamWriter(fs)) 
			{
				foreach (ListViewItem xitem in uxListViewAddress.Items) 
				{ 
					if ((_blnExportAll) || (xitem.Selected))
					{
						string s = xitem.Text + "\n\r";
						sw.WriteLine(s);
						cnt ++;
					}
				} 
				//sw.Close();
			}
			//fs.Close();
			return cnt;
		}
		#endregion
		private bool _blnExportAll;
		private void Export()
		{
			LoadSettings();
			saveFileDialog2.Filter = "Vertical text files(*.txt)|*.txt|Comma delimited text files(*.txt)|*.txt|Tab delimited text files(*.txt)|*.txt|XML files(*.xml)|*.xml|Email address only(*.txt)|*.txt";
			saveFileDialog2.FilterIndex = 1; //The first item has an index of 1.
			if (saveFileDialog2.ShowDialog()==DialogResult.OK)
			{
				int cnt = 0;
				statusBarPanelStatus.Text="Busy";
				try 
				{		

					string fn = saveFileDialog2.FileName;
					switch(saveFileDialog2.FilterIndex)
					{
						case 1:
							cnt += DoVerticalExport(fn);
							break;
						case 2:
							cnt += DoDelimitedExport(fn, new char[] {','});
							break;
						case 3:
							cnt += DoDelimitedExport(fn, new char[] {'\t'});
							break;
						case 4:
							cnt += DoXMLExport(fn);
							break;
						case 5:
							cnt += DoEmailOnlyExport(fn);
							break;
						default:
							break;
					}					
					MessageBox.Show(cnt + " record(s) exported.", _oldFormTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show (ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				statusBarPanelMsg.Text = cnt + " record(s) exported.  "; 
				statusBarPanelStatus.Text = "Ready";
				statusBarPanelTotal.Text = "Total: " + uxListViewAddress.Items.Count.ToString();
			}		
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			_blnExportAll = true;
			Export();

		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			tabControlMain.SelectedIndex = 3;
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			tabControlMain.SelectedIndex = 2;
		}

		private void menuItem29_Click(object sender, System.EventArgs e)
		{
			tabControlMain.SelectedIndex = 1;
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			tabControlMain.SelectedIndex = 0;
		}

		private void listViewAddress_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void listViewAddress_DoubleClick(object sender, System.EventArgs e)
		{
			menuItem13.PerformClick();
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem itm in uxListViewAddress.SelectedItems)
			{
				FrmProperties frm = new FrmProperties();
				frm.textBox1.Text= itm.Text;
				frm.textBox2.Text= itm.SubItems[1].Text;
				frm.textBox5.Text= itm.SubItems[2].Text;
				frm.textBox3.Text= itm.SubItems[3].Text;
				frm.textBox4.Text= itm.SubItems[4].Text;
				frm.checkBox1.Checked = itm.Checked;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					itm.Text = frm.textBox1.Text.Trim();
					itm.SubItems[1].Text = frm.textBox2.Text.Trim();
					itm.SubItems[2].Text = frm.textBox5.Text.Trim();
					itm.SubItems[3].Text = frm.textBox3.Text.Trim();
					itm.SubItems[4].Text = frm.textBox4.Text.Trim();
					itm.Checked = frm.checkBox1.Checked;
					IfDirty = true;
				}
				break;
			}
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{

			if (uxListViewAddress.SelectedItems.Count > 0 ) 
			{
				DialogResult result;
				result = MessageBox.Show ("This will remove selected " + uxListViewAddress.SelectedItems.Count.ToString() + " item(s). Do you want to continue?", _oldFormTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				if(result == DialogResult.Yes)
				{
					foreach (ListViewItem itm in uxListViewAddress.SelectedItems)
					{
						itm.Remove();
					}
					IfDirty = true;
				}
			}
		}


		private void listViewAddress_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				menuItem14.PerformClick();
				e.Handled = true;
			}
			if (e.KeyCode == Keys.Enter)
			{
				menuItem13.PerformClick();
				e.Handled = true;
			}
			if ((e.KeyCode == Keys.A) && e.Control)
			{
				menuItem16.PerformClick();
				e.Handled = true;
			}
		
		}

		private void listView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				menuItem52.PerformClick();
				e.Handled = true;
			}
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			FrmProperties frm = new FrmProperties();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				ListViewItem itm = uxListViewAddress.Items.Add(frm.textBox1.Text.Trim());
				itm.SubItems.Add(frm.textBox2.Text.Trim());
				itm.SubItems.Add(frm.textBox5.Text.Trim());
				itm.SubItems.Add(frm.textBox3.Text.Trim());
				itm.SubItems.Add(frm.textBox4.Text.Trim());
				itm.SubItems.Add("");
				itm.Checked = frm.checkBox1.Checked;
				itm.ImageIndex = 0;
				IfDirty = true;
			}
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem itm in uxListViewAddress.Items)
			{
				itm.Selected = true;
			}
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem itm in uxListViewAddress.SelectedItems)
			{
				itm.Checked = true;
			}
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem itm in uxListViewAddress.SelectedItems)
			{
				itm.Checked = false;
			}
		}

		private void menuItem64_Click(object sender, System.EventArgs e)
		{
			foreach(ListViewItem itm in uxListViewAddress.Items)
			{
				itm.Selected = !itm.Selected;
			}
		}

		/// <summary>
		/// Loads application level settings
		/// </summary>
		private void LoadSettings()
		{
			string fn = Application.UserAppDataPath + @"\..\settings.xml";
			if (File.Exists(fn))
			{
				// Deserialization
				XmlSerializer s = new XmlSerializer( typeof( ClassSettings ) );
				TextReader r = new StreamReader( fn );
				_appOptions = (ClassSettings)s.Deserialize( new System.Xml.XmlTextReader(r) );
				r.Close();
			}
			else
			{
				_appOptions = new ClassSettings();
			}
			tmrSaveFile.Interval = _appOptions._autoSaveInterval * 1000;
			tmrSaveFile.Enabled = _appOptions._ifAutoSave;
		}

		/// <summary>
		/// Enable or disable buttons while the program is busy
		/// </summary>
		/// <param name="isBusy">true=busy, false=idle</param>

		private void SetBusy(bool isBusy)
		{
			mnuSendStart.Enabled = !isBusy;
			toolBarButtonStart.Enabled = !isBusy;
			mnuSendPause.Enabled = isBusy;
			mnuSendStop.Enabled = isBusy;
			toolBarButtonPause.Enabled = isBusy;
			toolBarButtonStop.Enabled = isBusy;
			if(isBusy)
			{
				statusBarPanelStatus.Text = "Busy";
			}
			else
			{
				statusBarPanelStatus.Text = "Idle";
			}
			m_busy = isBusy;
		}

		private void DispStatus()
		{
			statusBarPanelSuccess.Text = "Success: " + m_cntSuccess.ToString();
			statusBarPanelFail.Text = "Fail: " + m_cntFail.ToString();
			statusBarPanelTotal.Text = "Total: " + m_Total.ToString();
		}

        private delegate void SendMailFailDelegate(int pIndex,string pErrorText);
		private void SendMailFail(int pIndex,string pErrorText)
		{
            if (this.InvokeRequired)
            {
                this.Invoke(new SendMailFailDelegate(SendMailFail), new object[]{pIndex, pErrorText});
            }
            else
            {
            ListViewItem itm = this.uxListViewAddress.Items[pIndex];
			itm.SubItems[3].Text = pErrorText;
			itm.ImageIndex = 6;
			if(!_appOptions._ifRetryFail) itm.Checked = false;
			m_cntFail++;
			DispStatus();
            }
		}

        private delegate void SendViaMapiDelegate(Address pAdr);
        private void SendViaMapi(Address pAdr)
		{
            if (this.InvokeRequired)
                this.Invoke(new SendViaMapiDelegate(SendViaMapi), new object[] { pAdr });
            else
            {
                ListViewItem itm = this.uxListViewAddress.Items[pAdr.Index];
                itm.SubItems[5].Text = "MAPI";
                Mapi ma = new Mapi();
                
                if (!ma.Logon(IntPtr.Zero))
                {
                    Log("MAPILogon failed! : " + ma.Error());
                    SendMailFail(pAdr.Index, ma.Error());
                    return;
                }
                foreach (ListViewItem it in listView1.Items)
                {
                    if (File.Exists(it.Text))
                        ma.Attach(it.Text);
                }
                ma.AddRecip(itm.SubItems[1].Text, itm.Text, false);
                if (!ma.Send(ParseMsg(txtSubject.Text, pAdr), ParseMsg(txtBody.Text, pAdr),uxFormat.Text))
                {
                    Log("MAPISendMail failed! : " + ma.Error());
                    SendMailFail(pAdr.Index, ma.Error());
                    return;
                }

                ma.Logoff();
                Log("SendMail completed: " + itm.Text);
                itm.SubItems[3].Text = "Send completed.";
                itm.Checked = false;
                itm.ImageIndex = 0;
                m_cntSuccess++;
                DispStatus();
                if (uxListViewAddress.SelectedItems.Count == 0)
                {  //all sent
                    Log("All Sent");
                }
            }
		}
		private void SendViaMapiComplete()
		{
            if (InvokeRequired)
                Invoke(new MethodInvoker(SendViaMapiComplete));
            else
            {
                Log("All done.");
                statusBarPanelMsg.Text = "Send mail completed";

                SetBusy(false);

                //retry failed addresses
                if (_appOptions._ifRetryFail)
                {
                    int cnt = 0;
                    foreach (ListViewItem itm in uxListViewAddress.Items)
                    {
                        if (itm.Checked) cnt++;
                    }
                    if (cnt > 0)
                    {
                        Log("Retry for failed address(es) in " + _appOptions._retryFail.ToString() + " second(s)...");
                        tmrFailRetry.Interval = _appOptions._retryFail * 1000;
                        tmrFailRetry.Start();
                        SetBusy(true);
                    }
                }
            }
		}
		
		private bool FindInAry(ArrayList pAry, string pFind)
		{
			foreach(string s in pAry)
			{
				if (s.ToUpper() == pFind.ToUpper())
					return true;
			}
			return false;
		}

		private bool FindDomainInAry(ArrayList pAry, string pFind)
		{
			foreach(string s in pAry)
			{
				if (pFind.ToUpper().EndsWith(s.ToUpper()))
					return true;
			}
			return false;
		}
		private bool CheckAddress(Address itm)
		{
			if (FindInAry(_appOptions.emailBlackList, itm.Email))
			{
				//found
				SendMailFail(itm.Index,"email is blocked");
				return false;
			}
			if (FindInAry(_appOptions.nameBlackList, NamePart(itm.Email)))
			{
				SendMailFail(itm.Index,"name is blocked");
				return false;
			}
			if (FindInAry(_appOptions.noSendList,itm.Email))
			{
				SendMailFail(itm.Index,"email is in No-Send list");
				return false;
			}
			if (FindDomainInAry(_appOptions.domainBlackList,DomainPart(itm.Email)))
			{
				SendMailFail(itm.Index,"Domain is blocked");
				return false;
			}
			if (!IsEmail(itm.Email))
			{
				SendMailFail(itm.Index,"Email address not valid");
				return false;
			}
			return true;
		}
		public string NamePart(string addr)
		{
			int pos = addr.IndexOf("@");
			if (pos>0)
				return addr.Substring(0, pos);
			else
				return addr;
		}

		public string DomainPart(string addr)
		{
			int pos = addr.IndexOf("@");
			if (addr.Length> pos + 1)
				return addr.Substring(pos + 1);
			else
				return addr;
		}

        private delegate void SendViaDirectDelegate(Address pAdr);
		private void SendViaDirect(Address pAdr)
		{
            if (this.InvokeRequired)
                this.Invoke(new SendViaDirectDelegate(SendViaDirect), new object[] { pAdr });
            else
            {
                string to = pAdr.Email;
                string name = pAdr.Name;
                string from = txtFromName.Text + "<" + txtFromEmail.Text + ">";
                //send directly or via smtp
                //--- Construct message ---------------------------------//
                MimeConstructor m = new MimeConstructor();
                m.To = new string[] { to };
                m.From = from;
                m.Subject = ParseMsg(txtSubject.Text, pAdr);
                m.Body = ParseMsg(txtBody.Text, pAdr);
                if (this.uxFormat.Text == "text/html")
                    m.BodyHtml = m.Body;
                foreach (ListViewItem it in listView1.Items)
                {
                    if (File.Exists(it.Text))
                        m.Attachments.Add(new LumiSoft.Net.Mime.Attachment(it.Text));
                }
                //-------------------------------------------------------//

                //--- Send message ------------------------------------------//
                _smtpClient.DnsServers = (string[])_appOptions.DNS.ToArray(typeof(string)); //new string[]{m_pDnsServer.Text};
                _smtpClient.UseSmartHost = false;
                _smtpClient.Username = "";
                _smtpClient.Password = "";
                _smtpClient.MaxSenderThreads = _appOptions._maxThreads;
                ShowItemCarrier(pAdr.Index,"Direct");
                _smtpClient.BeginSend(new string[] { to }, txtFromEmail.Text, m.ConstructBinaryMime(), pAdr.Index.ToString());
                //2008-03-22 VM Free UI thread. Cannot do this here. Move outside this thread.
                //while (_cntActive >= mySetting._maxThreads)
                //{
                //    Thread.Sleep(1000); //2008-03-22 VM Increased time interval from 100ms to 1s
                //}
            }
		}

        private delegate void SendViaSmtpDelegate(Address pAdr, SMTPServer svr);
		private void SendViaSmtp(Address pAdr, SMTPServer svr)
		{
            if (this.InvokeRequired)
                this.Invoke(new SendViaSmtpDelegate(SendViaSmtp), new object[] { pAdr, svr });
            else
            {
                string to = pAdr.Email;
                string name = pAdr.Name;
                string from, fromEmail, fromName;
                if (svr.IfSpecifySender)
                {
                    if (svr.ReplyEmail != "")
                        from = svr.ReplyEmail;
                    else
                        from = svr.SenderEmail;

                    if (svr.SenderName != "")
                    {
                        from = svr.SenderName + "<" + from + ">";
                        fromName = svr.SenderName;
                    }
                    else
                        fromName = null;
                    fromEmail = svr.SenderEmail;
                }
                else
                {
                    if (txtReply.Text.Trim() != "")
                        from = txtReply.Text.Trim();
                    else
                        from = txtFromEmail.Text.Trim();
                    if (txtFromName.Text.Trim() != "")
                        fromName = txtFromName.Text;
                    else
                        fromName = null;
                    fromEmail = txtFromEmail.Text.Trim();
                }
                //send directly or via smtp
                //--- Construct message ---------------------------------//
                MimeConstructor m = new MimeConstructor();
                m.To = new string[] { to };
                m.From = from;
                m.Subject = ParseMsg(txtSubject.Text, pAdr, svr);
                m.Body = ParseMsg(txtBody.Text, pAdr, svr);
                if (this.uxFormat.Text == "text/html")
                    m.BodyHtml = m.Body;
                foreach (ListViewItem it in listView1.Items)
                {
                    if (File.Exists(it.Text))
                        m.Attachments.Add(new LumiSoft.Net.Mime.Attachment(it.Text));
                }
                //-------------------------------------------------------//

                //--- Send message ------------------------------------------//
                

                // added new MailKit code

                ListViewItem itm = this.uxListViewAddress.Items[pAdr.Index];
                itm.SubItems[5].Text = "MailKit";

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(fromName, fromEmail));
                foreach (var toAddr in m.To)
                {
                    message.To.Add(new MailboxAddress(null, toAddr));
                }
                message.Subject = m.Subject;

                message.Body = new TextPart("plain")
                {
                    Text = m.Body
                };

                using (var client = new SmtpClient())
                {
                    ShowItemCarrier(pAdr.Index, "MailKit SMTP: " + svr.HostID.ToString());

                    try
                    {
                        client.Connect(svr.Host, svr.Port, useSsl: !svr.StartTls);

                        // Note: only needed if the SMTP server requires authentication
                        client.Authenticate(svr.UserID, svr.Password);

                        client.Send(message);
                        client.Disconnect(true);

                        _cntActive--;
                        itm.SubItems[3].Text = "Send completed.";
                        itm.Checked = false;
                        itm.ImageIndex = 0;
                        m_cntSuccess++;
                        DispStatus();
                    }
                    catch (Exception e)
                    {
                        _cntActive--;
                        itm.SubItems[3].Text = e.Message;
                        itm.ImageIndex = 6;
                        DispStatus();
                    }
                }

                /* removed old Smtp_Client code
                _smtpClient.SmartHost = svr.Host;
                _smtpClient.UseSmartHost = true;
                _smtpClient.Port = svr.Port;
                if (svr.IfAuth)
                {
                    _smtpClient.Username = svr.UserID;
                    _smtpClient.Password = svr.Password;
                }
                else
                {
                    _smtpClient.Username = "";
                    _smtpClient.Password = "";
                }
                ShowItemCarrier(pAdr.Index, "SMTP:" + svr.HostID.ToString());
                _smtpClient.MaxSenderThreads = _appOptions._maxThreads;
                _smtpClient.BeginSend(new string[] { to }, fromEmail, m.ConstructBinaryMime(), pAdr.Index.ToString());
                */

                //2008-03-22 VM Free up UI thread
                //while (_cntActive >= mySetting._maxThreads)
                //{
                //    Thread.Sleep(100);
                //}
            }
        }

        private delegate void ShowItemCarrierDelegate(int pIndex, string pText);
        private void ShowItemCarrier(int pIndex, string pText)
        {
            if (this.InvokeRequired)
                this.Invoke(new ShowItemCarrierDelegate(ShowItemCarrier), new object[] { pIndex, pText });
            else
            {
                ListViewItem itm = this.uxListViewAddress.Items[pIndex]; //2008-03-22 VM Change listView1 to listViewAddress
                itm.SubItems[5].Text = pText;
            }
        }

		private void Stopped()
		{
			Log("Stopped");
			SetBusy(false);
			statusBarPanelMsg.Text = "Stopped";
		}
		
		private void CheckDuplicate()
		{
			if (_appOptions._chkDuplicate)
			{
                Dictionary<string, string> ht = new Dictionary<string, string>();// Hashtable(new CaseInsensitiveHashCodeProvider(), new CaseInsensitiveComparer());
			
				foreach(ListViewItem itm in uxListViewAddress.CheckedItems)
				{
					if(ht.ContainsKey(itm.Text))
					{
						itm.Checked = false;
						itm.SubItems[3].Text = "Duplicate";
					}
					else
						ht.Add(itm.Text,itm.SubItems[1].Text);
				}
				ht = null;
			}
		}

		private void mnuSendStart_Click(object sender, System.EventArgs e)
		{
			if (m_paused) 
			{
				Log("Continue");
				m_paused = false;
				SetBusy(true);
				statusBarPanelMsg.Text = "Continue";
				foreach(ListViewItem itm in uxListViewAddress.CheckedItems)
				{
					if (itm.SubItems[3].Text == "Paused")
					{
						itm.SubItems[3].Text = "Queued";
					}
				}
			}
			else
			{
				//if (!validator1.ValidateAll()) return;
				if (_smtpClient.IsSending)
				{
					Log("Please wait for last send job finishes before starting a new one!");
					return;
				}
				if (!SaveFile()) 
					return;
				LoadSettings();
			

				CheckDuplicate();
				foreach(ListViewItem itm in uxListViewAddress.CheckedItems)
				{
					itm.SubItems[3].Text = "Queued";
					itm.ImageIndex = 0;
				}
				_cntQueued = uxListViewAddress.CheckedItems.Count;
				if (_cntQueued==0)
				{
					Log("No checked address to send.");
					statusBarPanelMsg.Text = "Nothing to send!"; 
					return;
				}
				m_Total = _cntQueued;
				m_cntFail = 0;
				m_cntSuccess = 0;
				DispStatus();
				SetBusy(true);
				Log("Start sending...");
				statusBarPanelMsg.Text = "Sending..."; 
				m_stop = false;
				m_paused = false;
				Thread t = new Thread(new ThreadStart(SendStart));
				t.Start();
			}
		}

        private delegate void ShowItemStatusDelegate(int pIndex, int pImageIndex, string pText);
        private void ShowItemStatus(int pIndex, int pImageIndex, string pText)
        {
            if (this.InvokeRequired)
                this.Invoke(new ShowItemStatusDelegate(ShowItemStatus), new object[] { pIndex, pImageIndex, pText });
            else
            {
                //2008-03-22 VM It is listViewAddress, not listView1
                //ListViewItem itm = listView1.Items[pIndex];
                ListViewItem itm = uxListViewAddress.Items[pIndex];
                itm.ImageIndex = 1;
                itm.SubItems[3].Text = pText;
            }
        }

        private void SendStart()
        {
            int cnt = 0;
            int indxSvr = 0;
            int cntMsgPerSvr = 0;
            foreach (Address adr in _mainList.Addresses)
            {
                if (adr.Checked)
                {
                    _cntQueued--;
                    if (CheckAddress(adr))
                    {
                        if (m_stop)
                        {
                            Stopped();
                            return;
                        }
                        if (_appOptions._ifLimitPerConn)
                        {
                            if (cnt >= _appOptions._limitPerConn)
                            {
                                Log("Max emails per connection reaches. Delaying " + _appOptions._perConnDelay + " second(s)...");
                                int delay = _appOptions._perConnDelay * 1000;
                                Thread.Sleep(delay);
                                cnt = 0;
                            }
                        }
                        if (m_stop)
                        {
                            Stopped();
                            return;
                        }

                        cnt++;
                        while (m_paused)
                        {
                            if (m_stop)
                            {
                                Stopped();
                                return;
                            }
                            Thread.Sleep(100);
                        };
                        ShowItemStatus(adr.Index, 1, "Start sending");
                        _cntActive++;
                        if (_appOptions._ifSendviaMAPI)
                        {
                            SendViaMapi(adr);
                        }
                        else if (_appOptions._ifSMTP)
                        {
                            SMTPServer svr = _appOptions.SMTPServers[indxSvr];
                            int limit = _appOptions._ifLimitPerConn ? _appOptions._limitPerConn : 65520;
                            limit = svr.IfLimit ? svr.NrPerSession : limit;
                            if ((!svr.Enabled) || (cntMsgPerSvr >= limit))
                            {
                                cntMsgPerSvr = 0;
                                bool found = false;
                                int i;
                                for (i = indxSvr + 1; i < _appOptions.SMTPServerCount(); i++)
                                {
                                    if (_appOptions.SMTPServers[i].Enabled)
                                    {
                                        if (_appOptions.SMTPServers[i].IfLimit)
                                        {
                                            if (_appOptions.SMTPServers[i].NrPerSession > 0)
                                            {
                                                found = true;
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            found = true;
                                            break;
                                        }
                                    }
                                }
                                if (found)
                                {
                                    indxSvr = i;
                                    svr = _appOptions.SMTPServers[i];
                                }
                                else
                                {
                                    for (i = 0; i <= indxSvr; i++)
                                    {
                                        if (_appOptions.SMTPServers[i].Enabled)
                                        {
                                            if (_appOptions.SMTPServers[i].IfLimit)
                                            {
                                                if (_appOptions.SMTPServers[i].NrPerSession > 0)
                                                {
                                                    found = true;
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                found = true;
                                                break;
                                            }
                                        }
                                    }
                                    if (found)
                                    {
                                        indxSvr = i;
                                        svr = _appOptions.SMTPServers[i];
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cannot find an available SMTP server. Please check your setting and try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }
                                }
                            }
                            SendViaSmtp(adr, svr);
                            cntMsgPerSvr++;
                        }
                        else
                        {
                            SendViaDirect(adr);
                        }

                        //2008-03-22 VM Wait for current active threads drop below _maxThreads setting.
                        if (_appOptions._ifSMTP || _appOptions._ifSendDirect)
                        {
                            while (_cntActive >= _appOptions._maxThreads)
                            {
                                Thread.Sleep(100);
                            }
                        }
                    }
                }
            }
            if (_appOptions._ifSendviaMAPI)
                SendViaMapiComplete();
        }

        private ClassFile _mainList;
        private void UpdateListView(bool pIsUpdate)
        {
            if (pIsUpdate)
            {
                listView1.Items.Clear();
                uxListViewAddress.Items.Clear();

                if (_mainList==null) return;

                txtFromEmail.Text = _mainList.FromEmail;
                txtFromName.Text = _mainList.FromName;
                txtReply.Text = _mainList.Reply;
                comboBox1.SelectedIndex = _mainList.Priority;
                uxFormat.Text = _mainList.Format;
                comboBox3.Text = _mainList.Encoding;
                txtSubject.Text = _mainList.Subject;
                txtBody.Text = _mainList.Body;
                ListViewItem xitem;
                foreach (Attachment att in _mainList.Attachments)
                {
                    AddAttachment(att._file);
                }

                foreach (Address addr in _mainList.Addresses)
                {
                    xitem = uxListViewAddress.Items.Add(addr.Email);
                    xitem.SubItems.Add(addr.Name);
                    xitem.SubItems.Add(addr.Company);
                    xitem.SubItems.Add(addr.Status);
                    xitem.SubItems.Add(addr.Memo);
                    xitem.SubItems.Add(addr.Carrier);
                    xitem.Checked = addr.Checked;
                    xitem.ImageIndex = addr.Image;
                }

                  }
            else
            {
                if (_mainList==null) _mainList = new ClassFile();

                _mainList.FromEmail = txtFromEmail.Text;
                _mainList.FromName = txtFromName.Text;
                _mainList.Reply = txtReply.Text;
                _mainList.Priority = comboBox1.SelectedIndex;
                _mainList.Format = uxFormat.Text;
                _mainList.Encoding = comboBox3.Text;
                _mainList.Subject = txtSubject.Text;
                _mainList.Body = txtBody.Text;

                _mainList.ClearAttach();
                foreach (ListViewItem xitem in listView1.Items)
                {
                    _mainList.AddAttach(new Attachment(xitem.Text));
                }

                _mainList.ClearAddress();
                int index = 0;
                foreach (ListViewItem xitem in uxListViewAddress.Items)
                {
                    _mainList.AddAddress(new Address(index,xitem.Text, xitem.SubItems[1].Text, xitem.SubItems[2].Text, xitem.SubItems[3].Text, xitem.SubItems[4].Text, xitem.SubItems[5].Text, xitem.Checked, xitem.ImageIndex));
                    index++;
                }
            }

        }

		private bool SaveFile()
		{
            UpdateListView(false);

			if(_fileTitle=="")
			{
				if (saveFileDialog1.ShowDialog()==DialogResult.OK)
				{
					_fileTitle = saveFileDialog1.FileName;
				}
				else 
					return false;
			}

			// Serialization
			XmlSerializer s = new XmlSerializer( typeof( ClassFile ) );
			TextWriter w = new StreamWriter( _fileTitle );
            s.Serialize(w, _mainList);
			w.Close();

			IfDirty = false;
			return true;
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if (saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				_fileTitle = saveFileDialog1.FileName;
				SaveFile();
			}
		}
		
		private void AddAttachment(string fn)
		{
			ListViewItem itm = listView1.Items.Add(fn);
			if (File.Exists(fn))
			{
				IntPtr hImgSmall;    //the handle to the system image list
				SHFILEINFO shinfo = new SHFILEINFO();
				hImgSmall = Win32.SHGetFileInfo(fn, 0, ref shinfo,
					(uint)Marshal.SizeOf(shinfo),
					Win32.SHGFI_ICON |
					Win32.SHGFI_SMALLICON);

				//The icon is returned in the hIcon member of the shinfo
				//struct
				System.Drawing.Icon myIcon =
					System.Drawing.Icon.FromHandle(shinfo.hIcon);

				imageList1.Images.Add(myIcon);
					
				itm.ImageIndex = nIndex++;

				long size;
				FileInfo fi = new FileInfo(fn);
				size = fi.Length / 1024;
				itm.SubItems.Add(size.ToString() + "KB");
				itm.Tag = fn;
			}
			else
			{
				itm.SubItems.Add("File not found!"); 
				itm.ForeColor = Color.Gray;
			}
		}

		/// <summary>
		/// Addes addresses and attachments to current from selected profile.
		/// </summary>
		/// <param name="importFileName"></param>
		private void MergeProfile(string fn)
		{
			ClassFile newFile;
			XmlSerializer s = new XmlSerializer( typeof( ClassFile ) );
			try
			{
				TextReader r = new StreamReader( fn );
				newFile = (ClassFile)s.Deserialize( new System.Xml.XmlTextReader(r) );
				r.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening profile. " + ex.Message, "Merge Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
				

			ListViewItem xitem;
			foreach (Attachment att in newFile.Attachments) 
			{ 
				AddAttachment(att._file);
			}
									
			foreach (Address addr in newFile.Addresses) 
			{ 
				xitem = uxListViewAddress.Items.Add(addr.Email); 
				xitem.SubItems.Add(addr.Name); 
				xitem.SubItems.Add(addr.Company); 
				xitem.SubItems.Add(addr.Status); 
				xitem.SubItems.Add(addr.Memo); 
				xitem.SubItems.Add(addr.Carrier);
				xitem.Checked = addr.Checked; 
				xitem.ImageIndex = addr.Image;
			}

			IfDirty = true;
			statusBarPanelMsg.Text = "Ready";		}

		private void LoadProfile(string fn)
		{
			//ClassFile newFile;
			XmlSerializer s = new XmlSerializer( typeof( ClassFile ) );
			try
			{
				TextReader r = new StreamReader( fn );
				_mainList = (ClassFile)s.Deserialize( new System.Xml.XmlTextReader(r) );
				r.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening profile. " + ex.Message, "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            UpdateListView(true);

			_fileTitle = openFileDialog3.FileName;
			IfDirty = false;
			statusBarPanelMsg.Text = "Ready";
		}

		/// <summary>
		/// Open profile from file. Will prompt for save modified if any.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuFileOpen_Click(object sender, System.EventArgs e)
		{
			if(IfDirty)
			{
				DialogResult ret = MessageBox.Show ("Do you want to save the changes to the profile?",this.Text,MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				switch(ret)
				{
					case DialogResult.Yes:
						if (!SaveFile())
							return;
						break;
					case DialogResult.Cancel:
						return;
						//break;
					default:
						break;
				}
			}

			if (openFileDialog3.ShowDialog()==DialogResult.OK)
			{
				LoadProfile(openFileDialog3.FileName);
			}
		}

		private void mnuFileNew_Click(object sender, System.EventArgs e)
		{
			if(IfDirty)
			{
				DialogResult ret = MessageBox.Show ("Do you want to save the changes to the profile?",this.Text,MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				switch(ret)
				{
					case DialogResult.Yes:
						if (!SaveFile())
							return;
						break;
					case DialogResult.Cancel:
						return;
					default:
						break;
				}
			}

			ClassFile newFile = new ClassFile();
			txtFromEmail.Text = newFile.FromEmail; 
			txtFromName.Text = newFile.FromName; 
			txtReply.Text = newFile.Reply; 
			comboBox1.SelectedIndex = newFile.Priority; 
			uxFormat.Text = newFile.Format; 
			comboBox3.Text = newFile.Encoding; 
			txtSubject.Text = newFile.Subject; 
			txtBody.Text = newFile.Body; 
			listView1.Items.Clear();
			uxListViewAddress.Items.Clear();
			
			_fileTitle = "";
			IfDirty = false;
		}

		private void menuItem59_Click(object sender, System.EventArgs e)
		{
			if(!txtSubject.Focused && !txtBody.Focused)
			{
				MessageBox.Show("Field must be inserted inside Subject or Body.");
				return;
			}
			SendKeys.Send("<=Email>");
		}

		private void menuFileSave_Click(object sender, System.EventArgs e)
		{
			SaveFile();
		}
		
		private string ParseMsg(string s, Address pAdr)
		{
            return ParseMsg(s, pAdr, null);
		}

		private string ParseMsg(string s, Address pAdr, SMTPServer svr)
		{
			if (svr!=null &&  svr.IfSpecifySender)
			{
				s = s.Replace("<=FromEmail>",svr.SenderEmail);
				s = s.Replace("<=FromName>",svr.SenderName);
				s = s.Replace("<=ReplyEmail>",svr.ReplyEmail);
			}
			else
			{
				s = s.Replace("<=FromEmail>",txtFromEmail.Text.Trim());
				s = s.Replace("<=FromName>",txtFromName.Text.Trim());
				s = s.Replace("<=ReplyEmail>",txtReply.Text.Trim());
			}
            
			s = s.Replace("<=Time>", DateTime.Now.ToString());
			if (pAdr!=null)
			{
				s = s.Replace("<=Email>",pAdr.Email);
				s = s.Replace("<=Name>",pAdr.Name);
				s = s.Replace("<=Company>",pAdr.Company);
				s = s.Replace("<=Status>",pAdr.Status);
				s = s.Replace("<=Memo>",pAdr.Memo);
			}
			return s;
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (tabControl1.SelectedIndex ==1)
			{
				string s;
				if (uxFormat.Text=="text/plain")
				{
					s =txtBody.Text.Replace("\r","<br>") ;

				}
				else
				{
					s = txtBody.Text;
				}
				s = ParseMsg(s, null);
				_previewFileName = Path.GetTempFileName() + ".htm";
				StreamWriter sw = new StreamWriter(_previewFileName);
				sw.Write(s);
				sw.Close();
				webBrowser1.Navigate(_previewFileName);
			}
		}

		private void mnuViewOptions_Click(object sender, System.EventArgs e)
		{
			FrmOptions frm = new FrmOptions();
			if (frm.ShowDialog()==DialogResult.OK)
				LoadSettings();
		}


		/// <summary>
		/// Sets or returns if the in memory settings are dirty.
		/// </summary>
		private bool IfDirty
		{
			get
			{
				return _ifModified;
			}
			set
			{
				string title="";
				if (_fileTitle=="") 
					title = "Untitled";
				else
					title = _fileTitle;
				if (value)
				{
					this.Text = _oldFormTitle + " - " + title + "*";
				}
				else
				{
					this.Text = _oldFormTitle + " - " + title;
				}
				_ifModified = value;
			}
		}

        private delegate void SendMailCompletedAllDelegate(object sender, System.EventArgs e);
        private void SendMailCompletedAll(object sender, System.EventArgs e)
        {
            if (InvokeRequired)
                Invoke(new SendMailCompletedAllDelegate(SendMailCompletedAll), new object[] { sender, e });
            else
            {
                Log("SendMail job remain: " + _cntQueued.ToString());
                if ((!_smtpClient.IsSending) && (_cntActive == 0) && (_cntQueued == 0))
                {
                    while (m_paused)
                    {
                        if (m_stop)
                        {
                            Stopped();
                            return;
                        }
                        Thread.Sleep(100);
                    };
                    Log("All done.");
                    statusBarPanelMsg.Text = "Send mail completed";

                    SetBusy(false);

                    //retry failed addresses
                    if (_appOptions._ifRetryFail)
                    {
                        int cnt = 0;
                        foreach (ListViewItem itm in uxListViewAddress.Items)
                        {
                            if (itm.Checked) cnt++;
                        }
                        if (cnt > 0)
                        {
                            Log("Retry for failed address in " + _appOptions._retryFail.ToString() + " second(s)...");
                            tmrFailRetry.Interval = _appOptions._retryFail * 1000;
                            tmrFailRetry.Start();
                            SetBusy(true);
                        }
                    }
                }
            }
        }

		private void SendMailSendJobCompleted(object sender, SendJob_EventArgs e)
		{
			_cntActive--;
			Log("SendMail completed: " + e.JobID);
			ListViewItem itm = FindItem(e.JobID);
			itm.SubItems[3].Text = "Send completed.";
			itm.Checked = false;
			itm.ImageIndex = 0;
			m_cntSuccess++;
			DispStatus();
		}

		private void SendMailPartOfMessageIsSent(object sender, PartOfMessage_EventArgs e)
		{
			ListViewItem itm = FindItem(e.JobID);
			itm.SubItems[3].Text = "Sending..." + e.TotalSent.ToString() + " of " + e.MessageSize + " bytes";
		}

		private void SendMailError(object sender, SMTP_Error e)
		{
			_cntActive--;
			string to="";
			foreach(string t in e.AffectedEmails)
			{
				to+= t + ";";
			}
			Log("Error sending to " + e.JobID + ": " + e.ErrorText );
			ListViewItem itm = FindItem(e.JobID);
			SendMailFail(itm.Index, e.ErrorText);
		}

        //2008-03-22 VM Use delegate to invoke UI
        private delegate void SendMailNewSendJobDelegate(object sender, SendJob_EventArgs e);

        private void SendMailNewSendJob(object sender, SendJob_EventArgs e)
		{
            if (this.InvokeRequired)
                this.Invoke(new SendMailNewSendJobDelegate(SendMailNewSendJob), new object[] {sender,e});
            else
            {
                string to = "";
                foreach (string t in e.To)
                {
                    to += t + ";";
                }
                Log("Sending...Job ID:" + e.JobID + " host:" + e.SmartHost);
                ListViewItem itm = FindItem(e.JobID);
                itm.SubItems[3].Text = "Sending...Job ID:" + e.JobID + " host:" + e.SmartHost;
                itm.ImageIndex = 1;
            }
		}
		
		private ListViewItem FindItem(string jobID)
		{
			return uxListViewAddress.Items[int.Parse(jobID)];
//			foreach(ListViewItem itm in listViewAddress.Items)
//			{
//				if(itm.Tag.ToString() == jobID)
//				{
//					return itm;
//				}
//			}
//			return null;
		}
		
		private void SendMailSessionLog(object sender,Log_EventArgs e)
		{
			Log(e.LogText);
		}

		private void Log(string pMsg)
		{
			lock(lvLog)
			{
				ListViewItem itm = lvLog.Items.Add(DateTime.Now.ToString());
				itm.SubItems.Add(pMsg);
				itm.EnsureVisible();
			}
		}

		private void tmrFailRetry_Tick(object sender, System.EventArgs e)
		{
			tmrFailRetry.Stop();
			if (m_stop)
			{
				Stopped();
				return;
			}
			mnuSendStart.PerformClick();
		}

		private void menuSendPause_Click(object sender, System.EventArgs e)
		{
			Log("Pausing");
			mnuSendPause.Enabled = false;
			mnuSendStart.Enabled = true;
			toolBarButtonStart.Enabled = true;
			toolBarButtonPause.Enabled = false;
			m_paused = true;
			statusBarPanelStatus.Text = "Pause";
			statusBarPanelMsg.Text = "Stopping";
			foreach(ListViewItem itm in uxListViewAddress.CheckedItems)
			{
				if (itm.SubItems[3].Text == "Queued")
				{
					itm.SubItems[3].Text = "Paused";
				}
			}
		}

		private void menuSendContinue_Click(object sender, System.EventArgs e)
		{
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (m_busy)
			{
				MessageBox.Show (Application.ProductName + " is busy. Please stop all jobs and try again.");
				e.Cancel = true;
			}
			else
			{
				m_paused = false;
				if(IfDirty)
				{
					DialogResult ret = MessageBox.Show ("Do you want to save the changes to the profile before closing?",this.Text,MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
					switch(ret)
					{
						case DialogResult.Yes:
							if (!SaveFile())
								e.Cancel = true;
							break;
						case DialogResult.Cancel:
							e.Cancel = true;
							break;
						default:
							break;
					}
				}
			}
		}

		private void menuSendStop_Click(object sender, System.EventArgs e)
		{
			m_stop = true;
			Log("Stopping");
			statusBarPanelMsg.Text = "Stopping";
			foreach(ListViewItem itm in uxListViewAddress.CheckedItems)
			{
				if (itm.SubItems[3].Text == "Queued")
				{
					itm.SubItems[3].Text = "Stopped";
				}
			}
		}


		private void menuItem62_Click(object sender, System.EventArgs e)
		{
			if(!txtSubject.Focused && !txtBody.Focused)
			{
				MessageBox.Show("Field must be inserted inside Subject or Body.");
				return;
			}
			SendKeys.Send("<=Time>");
		}

		private void menuItem60_Click(object sender, System.EventArgs e)
		{
			if(!txtSubject.Focused && !txtBody.Focused)
			{
				MessageBox.Show("Field must be inserted inside Subject or Body.");
				return;
			}
			SendKeys.Send("<=Name>");
		}

		private void menuItem61_Click(object sender, System.EventArgs e)
		{
			if(!txtSubject.Focused && !txtBody.Focused)
			{
				MessageBox.Show("Field must be inserted inside Subject or Body.");
				return;
			}
			SendKeys.Send("<=Memo>");
		}

		private void menuItem65_Click(object sender, System.EventArgs e)
		{
			if(!txtSubject.Focused && !txtBody.Focused)
			{
				MessageBox.Show("Field must be inserted inside Subject or Body.");
				return;
			}
			SendKeys.Send("<=FromEmail>");
		}

		private void menuItem66_Click(object sender, System.EventArgs e)
		{
			if(!txtSubject.Focused && !txtBody.Focused)
			{
				MessageBox.Show("Field must be inserted inside Subject or Body.");
				return;
			}
			SendKeys.Send("<=FromName>");
		}

		private void menuItem67_Click(object sender, System.EventArgs e)
		{
			if(!txtSubject.Focused && !txtBody.Focused)
			{
				MessageBox.Show("Field must be inserted inside Subject or Body.");
				return;
			}
			SendKeys.Send("<=ReplyEmail>");
		}

		private void menuLoadFileText_Click(object sender, System.EventArgs e)
		{
			if(txtBody.TextLength>0)
			{
				if (MessageBox.Show("This will replace the current email text body. Do you want to continue?","Load File As Email Body",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)!=DialogResult.OK)
				{
					return;
				}
			}

			if (openFileDialog4.ShowDialog() == DialogResult.OK)
			{
				try
				{
					StreamReader sr = new StreamReader(openFileDialog4.FileName);
					txtBody.SelectedText = sr.ReadToEnd();
					sr.Close();

				}
				catch (Exception ex)
				{
					MessageBox.Show (ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private void listViewAddress_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			IfDirty = true;
		}
		private string m_FindWhat="";
		private void menuItem74_Click(object sender, System.EventArgs e)
		{
			FrmFind frm = new FrmFind();
			if (frm.ShowDialog()==DialogResult.OK)
			{
				foreach(ListViewItem itm in uxListViewAddress.SelectedItems)
				{
					itm.Selected = false;
				}
				m_FindWhat=frm.textBox1.Text;
				menuItem75.Enabled = true;
				menuItem75.PerformClick();
			}
		}

		private void menuItem75_Click(object sender, System.EventArgs e)
		{
			if(m_FindWhat=="")
			{
				MessageBox.Show("Nothing to find");
			}
			else
			{
				int startIndex;
				if (uxListViewAddress.SelectedItems.Count==0)
					startIndex = 0;
				else
				{
					startIndex = uxListViewAddress.SelectedItems[0].Index + 1;
				}
				for (int i = startIndex;i<uxListViewAddress.Items.Count; i++)
				{
					foreach(ListViewItem.ListViewSubItem subItm in uxListViewAddress.Items[i].SubItems)
					{
						string s = subItm.Text.ToUpper();
						if (s.IndexOf(m_FindWhat.ToUpper())>=0)
						{
							foreach(ListViewItem itm in uxListViewAddress.SelectedItems)
								itm.Selected = false;
							uxListViewAddress.Items[i].Selected = true;
							uxListViewAddress.Items[i].EnsureVisible();
							return; //found
						}
					uxListViewAddress.Items[i].Selected = false;
					}
				}
				MessageBox.Show("No more can be found");
			}
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (e.Button.Tag.ToString())
			{
				case "New":
					mnuFileNew.PerformClick();
					break;
				case "Open":
					mnuFileOpen.PerformClick();
					break;
				case "Save":
					mnuFileSave.PerformClick();
					break;
				case "Start":
					mnuSendStart.PerformClick();
					break;
				case "Pause":
					mnuSendPause.PerformClick();
					break;
				case "Stop":
					mnuSendStop.PerformClick();
					break;
				case "Option":
					mnuViewOptions.PerformClick();
					break;
				case "Add":
					menuItem12.PerformClick();
					break;
				case "Edit":
					menuItem13.PerformClick();
					break;
				case "Delete":
					menuItem14.PerformClick();
					break;
				default:
					MessageBox.Show("Unhandled button:" + e.Button.Text); //Not supposed to see this.
					break;
			}
		}

		private void menuItem42_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Still not supported in this version.");
		}

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (File.Exists(_previewFileName))
            {
                File.Delete(_previewFileName);
            }
        }

	}

	/// <summary>
	/// Class providing IComparer to sort email items in Inbox.
	/// </summary>
	internal class MailComparer : IComparer
	{
		public int Compare( object object1 , object object2 )
		{
			if (sorting == SortOrder.None)
				return 0;
			ListViewItem lv1 = object1 as ListViewItem;
			ListViewItem lv2 = object2 as ListViewItem;
			if( (lv1 == null) || (lv2 == null) )
				return 0; 

			int r = 0;
//			if( sortcolumn == 0 )
//			{
//			    //Compare domain part first then email part.	
//				r = String.Compare( DomainPart(lv1.Text), DomainPart(lv2.Text) );
//				if (r==0)
//				{
//					r = String.Compare(NamePart(lv1.Text),NamePart(lv2.Text));
//				}
//			}
//			else 
				r = String.Compare( lv1.SubItems[sortcolumn].Text, lv2.SubItems[sortcolumn].Text );
			if( sorting == SortOrder.Descending )
				r = -r;
			return r;
		}

		public int Column
		{
			set { sortcolumn = value ; }
			get { return sortcolumn; }
		}

		public SortOrder Order
		{
			set { sorting = value; }
			get { return sorting; }
		}

		private int			sortcolumn = 0;
		private SortOrder	sorting = SortOrder.None;
		public string DomainPart(string addr)
		{
			int pos = addr.IndexOf("@");
			if (addr.Length> pos + 1)
				return addr.Substring(pos + 1);
			else
				return addr;
		}
		public string NamePart(string addr)
		{
			int pos = addr.IndexOf("@");
			if (pos>0)
				return addr.Substring(0, pos);
			else
				return addr;
		}

	}
}
