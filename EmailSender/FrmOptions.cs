using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;

namespace EmailSender
{
	/// <summary>
	/// Summary description for FrmOptions.
	/// </summary>
	public class FrmOptions : System.Windows.Forms.Form
	{
		#region Designer Made Code
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TabPage tabPage3;
		internal System.Windows.Forms.CheckBox CheckBox5;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		internal System.Windows.Forms.GroupBox GroupBox7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.Button btnDNS;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnDefault;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSMTPSvrs;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#endregion
		public FrmOptions()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptions));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDNS = new System.Windows.Forms.Button();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSMTPSvrs = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDefault = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).BeginInit();
            this.GroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.numericUpDown5);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.CheckBox5);
            this.tabPage1.Controls.Add(this.NumericUpDown2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NumericUpDown3);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.GroupBox7);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.button1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Name = "label5";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Name = "label10";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Name = "label7";
            // 
            // numericUpDown5
            // 
            resources.ApplyResources(this.numericUpDown5, "numericUpDown5");
            this.numericUpDown5.Name = "numericUpDown5";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            // 
            // CheckBox5
            // 
            resources.ApplyResources(this.CheckBox5, "CheckBox5");
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // NumericUpDown2
            // 
            resources.ApplyResources(this.NumericUpDown2, "NumericUpDown2");
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Name = "label1";
            // 
            // NumericUpDown3
            // 
            resources.ApplyResources(this.NumericUpDown3, "NumericUpDown3");
            this.NumericUpDown3.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.NumericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown3.Name = "NumericUpDown3";
            this.NumericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.label3);
            this.GroupBox7.Controls.Add(this.numericUpDown4);
            this.GroupBox7.Controls.Add(this.label2);
            this.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.GroupBox7, "GroupBox7");
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Name = "label3";
            // 
            // numericUpDown4
            // 
            resources.ApplyResources(this.numericUpDown4, "numericUpDown4");
            this.numericUpDown4.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Name = "label2";
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton7);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.radioButton6);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.radioButton1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // radioButton7
            // 
            resources.ApplyResources(this.radioButton7, "radioButton7");
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDNS);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnDNS
            // 
            resources.ApplyResources(this.btnDNS, "btnDNS");
            this.btnDNS.Name = "btnDNS";
            this.btnDNS.Click += new System.EventHandler(this.btnDNS_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.Checked = true;
            resources.ApplyResources(this.radioButton6, "radioButton6");
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.TabStop = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSMTPSvrs);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnSMTPSvrs
            // 
            resources.ApplyResources(this.btnSMTPSvrs, "btnSMTPSvrs");
            this.btnSMTPSvrs.Name = "btnSMTPSvrs";
            this.btnSMTPSvrs.Click += new System.EventHandler(this.btnSMTPSvrs_Click);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioButton3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.radioButton4);
            this.tabPage3.Controls.Add(this.radioButton5);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Name = "radioButton3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Name = "label4";
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Name = "radioButton4";
            // 
            // radioButton5
            // 
            resources.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Name = "radioButton5";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDefault);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnDefault
            // 
            resources.ApplyResources(this.btnDefault, "btnDefault");
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // FrmOptions
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOptions";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).EndInit();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		ClassSettings mySetting;

		private void tabPage3_Click(object sender, System.EventArgs e)
		{
		
		}
		private void LoadSetting()
		{
			checkBox1.Checked = mySetting._chkDuplicate;
			checkBox2.Checked = mySetting._ifRetryFail;
			numericUpDown5.Value = mySetting._retryFail;
			CheckBox5.Checked = mySetting._ifLimitPerConn;
			NumericUpDown2.Value = mySetting._limitPerConn;
			numericUpDown4.Value = mySetting._perConnDelay;
			NumericUpDown3.Value = (mySetting._maxThreads<=0?1:(mySetting._maxThreads>512?512:mySetting._maxThreads));
			radioButton7.Checked = mySetting._ifSendDirect;
			radioButton1.Checked = mySetting._ifSendviaMAPI;
			radioButton6.Checked = mySetting._ifSMTP;
			radioButton3.Checked = mySetting._ifReplaceDup;
			radioButton4.Checked = mySetting._ifNoImportDup;
			radioButton5.Checked = mySetting._ifCreateDup;
			checkBox3.Checked = mySetting._ifAutoSave;
			numericUpDown1.Value = mySetting._autoSaveInterval;
			groupBox1.Enabled = radioButton6.Checked;
			GroupBox7.Enabled = CheckBox5.Checked;
			NumericUpDown2.Enabled = CheckBox5.Checked;
			numericUpDown5.Enabled = checkBox2.Checked;		
		}
		
		private void FrmOptions_Load(object sender, System.EventArgs e)
		{
			string fn = Application.UserAppDataPath + @"\..\settings.xml";
			if (File.Exists(fn))
			{
				// Deserialization
				XmlSerializer s = new XmlSerializer( typeof( ClassSettings ) );
				TextReader r = new StreamReader( fn );
				mySetting = (ClassSettings)s.Deserialize( new System.Xml.XmlTextReader(r) );
				r.Close();
			}
			else
			{
				mySetting = new ClassSettings();
			}
			LoadSetting();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			mySetting._chkDuplicate = checkBox1.Checked;
			mySetting._ifRetryFail = checkBox2.Checked;
			mySetting._retryFail = (int) numericUpDown5.Value;
			mySetting._ifLimitPerConn = CheckBox5.Checked;
			mySetting._limitPerConn = (int) NumericUpDown2.Value;
			mySetting._perConnDelay = (int) numericUpDown4.Value;
			mySetting._maxThreads = (int) NumericUpDown3.Value;
			mySetting._ifSendDirect = radioButton7.Checked;
			mySetting._ifSendviaMAPI = radioButton1.Checked;
			mySetting._ifSMTP = radioButton6.Checked;
			mySetting._ifReplaceDup = radioButton3.Checked;
			mySetting._ifNoImportDup = radioButton4.Checked;
			mySetting._ifCreateDup = radioButton5.Checked;
			mySetting._ifAutoSave = checkBox3.Checked;
			mySetting._autoSaveInterval = (int) numericUpDown1.Value;
			string fn = Application.UserAppDataPath + @"\..\settings.xml";
			// Serialization
			XmlSerializer s = new XmlSerializer( typeof( ClassSettings ) );
			TextWriter w = new StreamWriter( fn );
			s.Serialize( w, mySetting );
			w.Close();
			this.Close();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			FrmList frm = new FrmList();
			frm.Text = "Email BlackList";
			frm.label1.Text = "When sending email, email addresses list here will be ignored.";
			foreach(string s in mySetting.emailBlackList)
			{
				frm.textBox1.Text += s + "\r\n";
			}
			if (frm.ShowDialog()==DialogResult.OK)
			{
				mySetting.emailBlackList.Clear();
				foreach(string s in frm.m_textArray)
				{
						mySetting.emailBlackList.Add(s);
				}
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			FrmList frm = new FrmList();
			frm.Text = "Name BlackList";
			frm.label1.Text = "When sending email, if the name part of the email address in the list, will be ignored.";
			foreach(string s in mySetting.nameBlackList)
			{
				frm.textBox1.Text += s + "\r\n";
			}
			if (frm.ShowDialog()==DialogResult.OK)
			{
				mySetting.nameBlackList.Clear();
				foreach(string s in frm.m_textArray)
				{
						mySetting.nameBlackList.Add(s);
				}
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			FrmList frm = new FrmList();
			frm.Text = "Domain BlackList";
			frm.label1.Text = "When sending email, if the domain part of the email address in the list, will be ignored.";
			foreach(string s in mySetting.domainBlackList)
			{
				frm.textBox1.Text += s + "\r\n";
			}
			if (frm.ShowDialog()==DialogResult.OK)
			{
				mySetting.domainBlackList.Clear();
				foreach(string s in frm.m_textArray)
				{
						mySetting.domainBlackList.Add(s);
				}
			}
		}

		private void btnDNS_Click(object sender, System.EventArgs e)
		{
			FrmList frm = new FrmList();
			frm.Text = "DNS servers";
			frm.label1.Text = "When sending email directly, will use these DNS servers. You may need to ask your ISP for these information. Please put the fastest ones on top.";
			foreach(string s in mySetting.DNS)
			{
				frm.textBox1.Text += s + "\r\n";
			}
			if (frm.ShowDialog()==DialogResult.OK)
			{
				mySetting.DNS.Clear();
				foreach(string s in frm.m_textArray)
				{
						mySetting.DNS.Add(s);
				}
			}

		}

		private void radioButton6_CheckedChanged(object sender, System.EventArgs e)
		{
			groupBox1.Enabled = radioButton6.Checked;
		}

		private void CheckBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			GroupBox7.Enabled = CheckBox5.Checked;
			NumericUpDown2.Enabled = CheckBox5.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			numericUpDown5.Enabled = checkBox2.Checked;
		}

		private void btnDefault_Click(object sender, System.EventArgs e)
		{
			mySetting = new ClassSettings();
			LoadSetting();
		}

		private void radioButton7_CheckedChanged(object sender, System.EventArgs e)
		{
			groupBox2.Enabled = radioButton7.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			FrmList frm = new FrmList();
			frm.Text = "Email No-Send List";
			frm.label1.Text = "When sending email, email addresses list here will be ignored.";
			foreach(string s in mySetting.noSendList)
			{
				frm.textBox1.Text += s + "\r\n";
			}
			if (frm.ShowDialog()==DialogResult.OK)
			{
				mySetting.noSendList.Clear();
				foreach(string s in frm.m_textArray)
				{
						mySetting.noSendList.Add(s);
				}
			}
		}

		private void btnSMTPSvrs_Click(object sender, System.EventArgs e)
		{
			SMTPSettings frm = new SMTPSettings();
			foreach(SMTPServer svr in mySetting.SMTPServers)
			{
				frm.m_smtpServers.Add(svr);
			}
			if(frm.ShowDialog()==DialogResult.OK)
			{
				mySetting.SMTPClearServers();
				foreach(SMTPServer svr in frm.m_smtpServers)
					mySetting.SMTPAddServer(svr);
			}
		}
	}
}
