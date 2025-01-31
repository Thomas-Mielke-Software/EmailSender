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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmOptions));
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
			this.tabControl1.AccessibleDescription = resources.GetString("tabControl1.AccessibleDescription");
			this.tabControl1.AccessibleName = resources.GetString("tabControl1.AccessibleName");
			this.tabControl1.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControl1.Alignment")));
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControl1.Anchor")));
			this.tabControl1.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControl1.Appearance")));
			this.tabControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControl1.BackgroundImage")));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControl1.Dock")));
			this.tabControl1.Enabled = ((bool)(resources.GetObject("tabControl1.Enabled")));
			this.tabControl1.Font = ((System.Drawing.Font)(resources.GetObject("tabControl1.Font")));
			this.tabControl1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControl1.ImeMode")));
			this.tabControl1.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControl1.ItemSize")));
			this.tabControl1.Location = ((System.Drawing.Point)(resources.GetObject("tabControl1.Location")));
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = ((System.Drawing.Point)(resources.GetObject("tabControl1.Padding")));
			this.tabControl1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControl1.RightToLeft")));
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = ((bool)(resources.GetObject("tabControl1.ShowToolTips")));
			this.tabControl1.Size = ((System.Drawing.Size)(resources.GetObject("tabControl1.Size")));
			this.tabControl1.TabIndex = ((int)(resources.GetObject("tabControl1.TabIndex")));
			this.tabControl1.Text = resources.GetString("tabControl1.Text");
			this.tabControl1.Visible = ((bool)(resources.GetObject("tabControl1.Visible")));
			// 
			// tabPage1
			// 
			this.tabPage1.AccessibleDescription = resources.GetString("tabPage1.AccessibleDescription");
			this.tabPage1.AccessibleName = resources.GetString("tabPage1.AccessibleName");
			this.tabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage1.Anchor")));
			this.tabPage1.AutoScroll = ((bool)(resources.GetObject("tabPage1.AutoScroll")));
			this.tabPage1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMargin")));
			this.tabPage1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMinSize")));
			this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
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
			this.tabPage1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage1.Dock")));
			this.tabPage1.Enabled = ((bool)(resources.GetObject("tabPage1.Enabled")));
			this.tabPage1.Font = ((System.Drawing.Font)(resources.GetObject("tabPage1.Font")));
			this.tabPage1.ImageIndex = ((int)(resources.GetObject("tabPage1.ImageIndex")));
			this.tabPage1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage1.ImeMode")));
			this.tabPage1.Location = ((System.Drawing.Point)(resources.GetObject("tabPage1.Location")));
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage1.RightToLeft")));
			this.tabPage1.Size = ((System.Drawing.Size)(resources.GetObject("tabPage1.Size")));
			this.tabPage1.TabIndex = ((int)(resources.GetObject("tabPage1.TabIndex")));
			this.tabPage1.Text = resources.GetString("tabPage1.Text");
			this.tabPage1.ToolTipText = resources.GetString("tabPage1.ToolTipText");
			this.tabPage1.Visible = ((bool)(resources.GetObject("tabPage1.Visible")));
			// 
			// label5
			// 
			this.label5.AccessibleDescription = resources.GetString("label5.AccessibleDescription");
			this.label5.AccessibleName = resources.GetString("label5.AccessibleName");
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
			this.label5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label5.Dock")));
			this.label5.Enabled = ((bool)(resources.GetObject("label5.Enabled")));
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Font = ((System.Drawing.Font)(resources.GetObject("label5.Font")));
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.ImageAlign")));
			this.label5.ImageIndex = ((int)(resources.GetObject("label5.ImageIndex")));
			this.label5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label5.ImeMode")));
			this.label5.Location = ((System.Drawing.Point)(resources.GetObject("label5.Location")));
			this.label5.Name = "label5";
			this.label5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label5.RightToLeft")));
			this.label5.Size = ((System.Drawing.Size)(resources.GetObject("label5.Size")));
			this.label5.TabIndex = ((int)(resources.GetObject("label5.TabIndex")));
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.TextAlign")));
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AccessibleDescription = resources.GetString("numericUpDown1.AccessibleDescription");
			this.numericUpDown1.AccessibleName = resources.GetString("numericUpDown1.AccessibleName");
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("numericUpDown1.Anchor")));
			this.numericUpDown1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("numericUpDown1.Dock")));
			this.numericUpDown1.Enabled = ((bool)(resources.GetObject("numericUpDown1.Enabled")));
			this.numericUpDown1.Font = ((System.Drawing.Font)(resources.GetObject("numericUpDown1.Font")));
			this.numericUpDown1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("numericUpDown1.ImeMode")));
			this.numericUpDown1.Location = ((System.Drawing.Point)(resources.GetObject("numericUpDown1.Location")));
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   999999,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("numericUpDown1.RightToLeft")));
			this.numericUpDown1.Size = ((System.Drawing.Size)(resources.GetObject("numericUpDown1.Size")));
			this.numericUpDown1.TabIndex = ((int)(resources.GetObject("numericUpDown1.TabIndex")));
			this.numericUpDown1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("numericUpDown1.TextAlign")));
			this.numericUpDown1.ThousandsSeparator = ((bool)(resources.GetObject("numericUpDown1.ThousandsSeparator")));
			this.numericUpDown1.UpDownAlign = ((System.Windows.Forms.LeftRightAlignment)(resources.GetObject("numericUpDown1.UpDownAlign")));
			this.numericUpDown1.Visible = ((bool)(resources.GetObject("numericUpDown1.Visible")));
			// 
			// checkBox3
			// 
			this.checkBox3.AccessibleDescription = resources.GetString("checkBox3.AccessibleDescription");
			this.checkBox3.AccessibleName = resources.GetString("checkBox3.AccessibleName");
			this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("checkBox3.Anchor")));
			this.checkBox3.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("checkBox3.Appearance")));
			this.checkBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox3.BackgroundImage")));
			this.checkBox3.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox3.CheckAlign")));
			this.checkBox3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("checkBox3.Dock")));
			this.checkBox3.Enabled = ((bool)(resources.GetObject("checkBox3.Enabled")));
			this.checkBox3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("checkBox3.FlatStyle")));
			this.checkBox3.Font = ((System.Drawing.Font)(resources.GetObject("checkBox3.Font")));
			this.checkBox3.Image = ((System.Drawing.Image)(resources.GetObject("checkBox3.Image")));
			this.checkBox3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox3.ImageAlign")));
			this.checkBox3.ImageIndex = ((int)(resources.GetObject("checkBox3.ImageIndex")));
			this.checkBox3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("checkBox3.ImeMode")));
			this.checkBox3.Location = ((System.Drawing.Point)(resources.GetObject("checkBox3.Location")));
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("checkBox3.RightToLeft")));
			this.checkBox3.Size = ((System.Drawing.Size)(resources.GetObject("checkBox3.Size")));
			this.checkBox3.TabIndex = ((int)(resources.GetObject("checkBox3.TabIndex")));
			this.checkBox3.Text = resources.GetString("checkBox3.Text");
			this.checkBox3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox3.TextAlign")));
			this.checkBox3.Visible = ((bool)(resources.GetObject("checkBox3.Visible")));
			// 
			// label10
			// 
			this.label10.AccessibleDescription = resources.GetString("label10.AccessibleDescription");
			this.label10.AccessibleName = resources.GetString("label10.AccessibleName");
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label10.Anchor")));
			this.label10.AutoSize = ((bool)(resources.GetObject("label10.AutoSize")));
			this.label10.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label10.Dock")));
			this.label10.Enabled = ((bool)(resources.GetObject("label10.Enabled")));
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label10.Font = ((System.Drawing.Font)(resources.GetObject("label10.Font")));
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label10.ImageAlign")));
			this.label10.ImageIndex = ((int)(resources.GetObject("label10.ImageIndex")));
			this.label10.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label10.ImeMode")));
			this.label10.Location = ((System.Drawing.Point)(resources.GetObject("label10.Location")));
			this.label10.Name = "label10";
			this.label10.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label10.RightToLeft")));
			this.label10.Size = ((System.Drawing.Size)(resources.GetObject("label10.Size")));
			this.label10.TabIndex = ((int)(resources.GetObject("label10.TabIndex")));
			this.label10.Text = resources.GetString("label10.Text");
			this.label10.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label10.TextAlign")));
			this.label10.Visible = ((bool)(resources.GetObject("label10.Visible")));
			// 
			// label7
			// 
			this.label7.AccessibleDescription = resources.GetString("label7.AccessibleDescription");
			this.label7.AccessibleName = resources.GetString("label7.AccessibleName");
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label7.Anchor")));
			this.label7.AutoSize = ((bool)(resources.GetObject("label7.AutoSize")));
			this.label7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label7.Dock")));
			this.label7.Enabled = ((bool)(resources.GetObject("label7.Enabled")));
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Font = ((System.Drawing.Font)(resources.GetObject("label7.Font")));
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.ImageAlign")));
			this.label7.ImageIndex = ((int)(resources.GetObject("label7.ImageIndex")));
			this.label7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label7.ImeMode")));
			this.label7.Location = ((System.Drawing.Point)(resources.GetObject("label7.Location")));
			this.label7.Name = "label7";
			this.label7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label7.RightToLeft")));
			this.label7.Size = ((System.Drawing.Size)(resources.GetObject("label7.Size")));
			this.label7.TabIndex = ((int)(resources.GetObject("label7.TabIndex")));
			this.label7.Text = resources.GetString("label7.Text");
			this.label7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.TextAlign")));
			this.label7.Visible = ((bool)(resources.GetObject("label7.Visible")));
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.AccessibleDescription = resources.GetString("numericUpDown5.AccessibleDescription");
			this.numericUpDown5.AccessibleName = resources.GetString("numericUpDown5.AccessibleName");
			this.numericUpDown5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("numericUpDown5.Anchor")));
			this.numericUpDown5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("numericUpDown5.Dock")));
			this.numericUpDown5.Enabled = ((bool)(resources.GetObject("numericUpDown5.Enabled")));
			this.numericUpDown5.Font = ((System.Drawing.Font)(resources.GetObject("numericUpDown5.Font")));
			this.numericUpDown5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("numericUpDown5.ImeMode")));
			this.numericUpDown5.Location = ((System.Drawing.Point)(resources.GetObject("numericUpDown5.Location")));
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("numericUpDown5.RightToLeft")));
			this.numericUpDown5.Size = ((System.Drawing.Size)(resources.GetObject("numericUpDown5.Size")));
			this.numericUpDown5.TabIndex = ((int)(resources.GetObject("numericUpDown5.TabIndex")));
			this.numericUpDown5.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("numericUpDown5.TextAlign")));
			this.numericUpDown5.ThousandsSeparator = ((bool)(resources.GetObject("numericUpDown5.ThousandsSeparator")));
			this.numericUpDown5.UpDownAlign = ((System.Windows.Forms.LeftRightAlignment)(resources.GetObject("numericUpDown5.UpDownAlign")));
			this.numericUpDown5.Visible = ((bool)(resources.GetObject("numericUpDown5.Visible")));
			// 
			// checkBox1
			// 
			this.checkBox1.AccessibleDescription = resources.GetString("checkBox1.AccessibleDescription");
			this.checkBox1.AccessibleName = resources.GetString("checkBox1.AccessibleName");
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("checkBox1.Anchor")));
			this.checkBox1.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("checkBox1.Appearance")));
			this.checkBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox1.BackgroundImage")));
			this.checkBox1.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox1.CheckAlign")));
			this.checkBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("checkBox1.Dock")));
			this.checkBox1.Enabled = ((bool)(resources.GetObject("checkBox1.Enabled")));
			this.checkBox1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("checkBox1.FlatStyle")));
			this.checkBox1.Font = ((System.Drawing.Font)(resources.GetObject("checkBox1.Font")));
			this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
			this.checkBox1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox1.ImageAlign")));
			this.checkBox1.ImageIndex = ((int)(resources.GetObject("checkBox1.ImageIndex")));
			this.checkBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("checkBox1.ImeMode")));
			this.checkBox1.Location = ((System.Drawing.Point)(resources.GetObject("checkBox1.Location")));
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("checkBox1.RightToLeft")));
			this.checkBox1.Size = ((System.Drawing.Size)(resources.GetObject("checkBox1.Size")));
			this.checkBox1.TabIndex = ((int)(resources.GetObject("checkBox1.TabIndex")));
			this.checkBox1.Text = resources.GetString("checkBox1.Text");
			this.checkBox1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox1.TextAlign")));
			this.checkBox1.Visible = ((bool)(resources.GetObject("checkBox1.Visible")));
			// 
			// CheckBox5
			// 
			this.CheckBox5.AccessibleDescription = resources.GetString("CheckBox5.AccessibleDescription");
			this.CheckBox5.AccessibleName = resources.GetString("CheckBox5.AccessibleName");
			this.CheckBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CheckBox5.Anchor")));
			this.CheckBox5.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("CheckBox5.Appearance")));
			this.CheckBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckBox5.BackgroundImage")));
			this.CheckBox5.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CheckBox5.CheckAlign")));
			this.CheckBox5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("CheckBox5.Dock")));
			this.CheckBox5.Enabled = ((bool)(resources.GetObject("CheckBox5.Enabled")));
			this.CheckBox5.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("CheckBox5.FlatStyle")));
			this.CheckBox5.Font = ((System.Drawing.Font)(resources.GetObject("CheckBox5.Font")));
			this.CheckBox5.Image = ((System.Drawing.Image)(resources.GetObject("CheckBox5.Image")));
			this.CheckBox5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CheckBox5.ImageAlign")));
			this.CheckBox5.ImageIndex = ((int)(resources.GetObject("CheckBox5.ImageIndex")));
			this.CheckBox5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CheckBox5.ImeMode")));
			this.CheckBox5.Location = ((System.Drawing.Point)(resources.GetObject("CheckBox5.Location")));
			this.CheckBox5.Name = "CheckBox5";
			this.CheckBox5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("CheckBox5.RightToLeft")));
			this.CheckBox5.Size = ((System.Drawing.Size)(resources.GetObject("CheckBox5.Size")));
			this.CheckBox5.TabIndex = ((int)(resources.GetObject("CheckBox5.TabIndex")));
			this.CheckBox5.Text = resources.GetString("CheckBox5.Text");
			this.CheckBox5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CheckBox5.TextAlign")));
			this.CheckBox5.Visible = ((bool)(resources.GetObject("CheckBox5.Visible")));
			this.CheckBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
			// 
			// NumericUpDown2
			// 
			this.NumericUpDown2.AccessibleDescription = resources.GetString("NumericUpDown2.AccessibleDescription");
			this.NumericUpDown2.AccessibleName = resources.GetString("NumericUpDown2.AccessibleName");
			this.NumericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("NumericUpDown2.Anchor")));
			this.NumericUpDown2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("NumericUpDown2.Dock")));
			this.NumericUpDown2.Enabled = ((bool)(resources.GetObject("NumericUpDown2.Enabled")));
			this.NumericUpDown2.Font = ((System.Drawing.Font)(resources.GetObject("NumericUpDown2.Font")));
			this.NumericUpDown2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("NumericUpDown2.ImeMode")));
			this.NumericUpDown2.Location = ((System.Drawing.Point)(resources.GetObject("NumericUpDown2.Location")));
			this.NumericUpDown2.Maximum = new System.Decimal(new int[] {
																		   999999,
																		   0,
																		   0,
																		   0});
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("NumericUpDown2.RightToLeft")));
			this.NumericUpDown2.Size = ((System.Drawing.Size)(resources.GetObject("NumericUpDown2.Size")));
			this.NumericUpDown2.TabIndex = ((int)(resources.GetObject("NumericUpDown2.TabIndex")));
			this.NumericUpDown2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("NumericUpDown2.TextAlign")));
			this.NumericUpDown2.ThousandsSeparator = ((bool)(resources.GetObject("NumericUpDown2.ThousandsSeparator")));
			this.NumericUpDown2.UpDownAlign = ((System.Windows.Forms.LeftRightAlignment)(resources.GetObject("NumericUpDown2.UpDownAlign")));
			this.NumericUpDown2.Visible = ((bool)(resources.GetObject("NumericUpDown2.Visible")));
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// NumericUpDown3
			// 
			this.NumericUpDown3.AccessibleDescription = resources.GetString("NumericUpDown3.AccessibleDescription");
			this.NumericUpDown3.AccessibleName = resources.GetString("NumericUpDown3.AccessibleName");
			this.NumericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("NumericUpDown3.Anchor")));
			this.NumericUpDown3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("NumericUpDown3.Dock")));
			this.NumericUpDown3.Enabled = ((bool)(resources.GetObject("NumericUpDown3.Enabled")));
			this.NumericUpDown3.Font = ((System.Drawing.Font)(resources.GetObject("NumericUpDown3.Font")));
			this.NumericUpDown3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("NumericUpDown3.ImeMode")));
			this.NumericUpDown3.Location = ((System.Drawing.Point)(resources.GetObject("NumericUpDown3.Location")));
			this.NumericUpDown3.Maximum = new System.Decimal(new int[] {
																		   512,
																		   0,
																		   0,
																		   0});
			this.NumericUpDown3.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("NumericUpDown3.RightToLeft")));
			this.NumericUpDown3.Size = ((System.Drawing.Size)(resources.GetObject("NumericUpDown3.Size")));
			this.NumericUpDown3.TabIndex = ((int)(resources.GetObject("NumericUpDown3.TabIndex")));
			this.NumericUpDown3.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("NumericUpDown3.TextAlign")));
			this.NumericUpDown3.ThousandsSeparator = ((bool)(resources.GetObject("NumericUpDown3.ThousandsSeparator")));
			this.NumericUpDown3.UpDownAlign = ((System.Windows.Forms.LeftRightAlignment)(resources.GetObject("NumericUpDown3.UpDownAlign")));
			this.NumericUpDown3.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			this.NumericUpDown3.Visible = ((bool)(resources.GetObject("NumericUpDown3.Visible")));
			// 
			// button5
			// 
			this.button5.AccessibleDescription = resources.GetString("button5.AccessibleDescription");
			this.button5.AccessibleName = resources.GetString("button5.AccessibleName");
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button5.Anchor")));
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button5.Dock")));
			this.button5.Enabled = ((bool)(resources.GetObject("button5.Enabled")));
			this.button5.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button5.FlatStyle")));
			this.button5.Font = ((System.Drawing.Font)(resources.GetObject("button5.Font")));
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button5.ImageAlign")));
			this.button5.ImageIndex = ((int)(resources.GetObject("button5.ImageIndex")));
			this.button5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button5.ImeMode")));
			this.button5.Location = ((System.Drawing.Point)(resources.GetObject("button5.Location")));
			this.button5.Name = "button5";
			this.button5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button5.RightToLeft")));
			this.button5.Size = ((System.Drawing.Size)(resources.GetObject("button5.Size")));
			this.button5.TabIndex = ((int)(resources.GetObject("button5.TabIndex")));
			this.button5.Text = resources.GetString("button5.Text");
			this.button5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button5.TextAlign")));
			this.button5.Visible = ((bool)(resources.GetObject("button5.Visible")));
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.AccessibleDescription = resources.GetString("button4.AccessibleDescription");
			this.button4.AccessibleName = resources.GetString("button4.AccessibleName");
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button4.Anchor")));
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button4.Dock")));
			this.button4.Enabled = ((bool)(resources.GetObject("button4.Enabled")));
			this.button4.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button4.FlatStyle")));
			this.button4.Font = ((System.Drawing.Font)(resources.GetObject("button4.Font")));
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button4.ImageAlign")));
			this.button4.ImageIndex = ((int)(resources.GetObject("button4.ImageIndex")));
			this.button4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button4.ImeMode")));
			this.button4.Location = ((System.Drawing.Point)(resources.GetObject("button4.Location")));
			this.button4.Name = "button4";
			this.button4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button4.RightToLeft")));
			this.button4.Size = ((System.Drawing.Size)(resources.GetObject("button4.Size")));
			this.button4.TabIndex = ((int)(resources.GetObject("button4.TabIndex")));
			this.button4.Text = resources.GetString("button4.Text");
			this.button4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button4.TextAlign")));
			this.button4.Visible = ((bool)(resources.GetObject("button4.Visible")));
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.AccessibleDescription = resources.GetString("button3.AccessibleDescription");
			this.button3.AccessibleName = resources.GetString("button3.AccessibleName");
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button3.Anchor")));
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button3.Dock")));
			this.button3.Enabled = ((bool)(resources.GetObject("button3.Enabled")));
			this.button3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button3.FlatStyle")));
			this.button3.Font = ((System.Drawing.Font)(resources.GetObject("button3.Font")));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.ImageAlign")));
			this.button3.ImageIndex = ((int)(resources.GetObject("button3.ImageIndex")));
			this.button3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button3.ImeMode")));
			this.button3.Location = ((System.Drawing.Point)(resources.GetObject("button3.Location")));
			this.button3.Name = "button3";
			this.button3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button3.RightToLeft")));
			this.button3.Size = ((System.Drawing.Size)(resources.GetObject("button3.Size")));
			this.button3.TabIndex = ((int)(resources.GetObject("button3.TabIndex")));
			this.button3.Text = resources.GetString("button3.Text");
			this.button3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.TextAlign")));
			this.button3.Visible = ((bool)(resources.GetObject("button3.Visible")));
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// GroupBox7
			// 
			this.GroupBox7.AccessibleDescription = resources.GetString("GroupBox7.AccessibleDescription");
			this.GroupBox7.AccessibleName = resources.GetString("GroupBox7.AccessibleName");
			this.GroupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("GroupBox7.Anchor")));
			this.GroupBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GroupBox7.BackgroundImage")));
			this.GroupBox7.Controls.Add(this.label3);
			this.GroupBox7.Controls.Add(this.numericUpDown4);
			this.GroupBox7.Controls.Add(this.label2);
			this.GroupBox7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("GroupBox7.Dock")));
			this.GroupBox7.Enabled = ((bool)(resources.GetObject("GroupBox7.Enabled")));
			this.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GroupBox7.Font = ((System.Drawing.Font)(resources.GetObject("GroupBox7.Font")));
			this.GroupBox7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("GroupBox7.ImeMode")));
			this.GroupBox7.Location = ((System.Drawing.Point)(resources.GetObject("GroupBox7.Location")));
			this.GroupBox7.Name = "GroupBox7";
			this.GroupBox7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("GroupBox7.RightToLeft")));
			this.GroupBox7.Size = ((System.Drawing.Size)(resources.GetObject("GroupBox7.Size")));
			this.GroupBox7.TabIndex = ((int)(resources.GetObject("GroupBox7.TabIndex")));
			this.GroupBox7.TabStop = false;
			this.GroupBox7.Text = resources.GetString("GroupBox7.Text");
			this.GroupBox7.Visible = ((bool)(resources.GetObject("GroupBox7.Visible")));
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Enabled = ((bool)(resources.GetObject("label3.Enabled")));
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Font = ((System.Drawing.Font)(resources.GetObject("label3.Font")));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.AccessibleDescription = resources.GetString("numericUpDown4.AccessibleDescription");
			this.numericUpDown4.AccessibleName = resources.GetString("numericUpDown4.AccessibleName");
			this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("numericUpDown4.Anchor")));
			this.numericUpDown4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("numericUpDown4.Dock")));
			this.numericUpDown4.Enabled = ((bool)(resources.GetObject("numericUpDown4.Enabled")));
			this.numericUpDown4.Font = ((System.Drawing.Font)(resources.GetObject("numericUpDown4.Font")));
			this.numericUpDown4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("numericUpDown4.ImeMode")));
			this.numericUpDown4.Location = ((System.Drawing.Point)(resources.GetObject("numericUpDown4.Location")));
			this.numericUpDown4.Maximum = new System.Decimal(new int[] {
																		   999999,
																		   0,
																		   0,
																		   0});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("numericUpDown4.RightToLeft")));
			this.numericUpDown4.Size = ((System.Drawing.Size)(resources.GetObject("numericUpDown4.Size")));
			this.numericUpDown4.TabIndex = ((int)(resources.GetObject("numericUpDown4.TabIndex")));
			this.numericUpDown4.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("numericUpDown4.TextAlign")));
			this.numericUpDown4.ThousandsSeparator = ((bool)(resources.GetObject("numericUpDown4.ThousandsSeparator")));
			this.numericUpDown4.UpDownAlign = ((System.Windows.Forms.LeftRightAlignment)(resources.GetObject("numericUpDown4.UpDownAlign")));
			this.numericUpDown4.Visible = ((bool)(resources.GetObject("numericUpDown4.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// checkBox2
			// 
			this.checkBox2.AccessibleDescription = resources.GetString("checkBox2.AccessibleDescription");
			this.checkBox2.AccessibleName = resources.GetString("checkBox2.AccessibleName");
			this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("checkBox2.Anchor")));
			this.checkBox2.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("checkBox2.Appearance")));
			this.checkBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox2.BackgroundImage")));
			this.checkBox2.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox2.CheckAlign")));
			this.checkBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("checkBox2.Dock")));
			this.checkBox2.Enabled = ((bool)(resources.GetObject("checkBox2.Enabled")));
			this.checkBox2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("checkBox2.FlatStyle")));
			this.checkBox2.Font = ((System.Drawing.Font)(resources.GetObject("checkBox2.Font")));
			this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
			this.checkBox2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox2.ImageAlign")));
			this.checkBox2.ImageIndex = ((int)(resources.GetObject("checkBox2.ImageIndex")));
			this.checkBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("checkBox2.ImeMode")));
			this.checkBox2.Location = ((System.Drawing.Point)(resources.GetObject("checkBox2.Location")));
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("checkBox2.RightToLeft")));
			this.checkBox2.Size = ((System.Drawing.Size)(resources.GetObject("checkBox2.Size")));
			this.checkBox2.TabIndex = ((int)(resources.GetObject("checkBox2.TabIndex")));
			this.checkBox2.Text = resources.GetString("checkBox2.Text");
			this.checkBox2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox2.TextAlign")));
			this.checkBox2.Visible = ((bool)(resources.GetObject("checkBox2.Visible")));
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// button1
			// 
			this.button1.AccessibleDescription = resources.GetString("button1.AccessibleDescription");
			this.button1.AccessibleName = resources.GetString("button1.AccessibleName");
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.Enabled = ((bool)(resources.GetObject("button1.Enabled")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = ((System.Drawing.Font)(resources.GetObject("button1.Font")));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.AccessibleDescription = resources.GetString("tabPage2.AccessibleDescription");
			this.tabPage2.AccessibleName = resources.GetString("tabPage2.AccessibleName");
			this.tabPage2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage2.Anchor")));
			this.tabPage2.AutoScroll = ((bool)(resources.GetObject("tabPage2.AutoScroll")));
			this.tabPage2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage2.AutoScrollMargin")));
			this.tabPage2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage2.AutoScrollMinSize")));
			this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
			this.tabPage2.Controls.Add(this.radioButton7);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.radioButton6);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Controls.Add(this.radioButton1);
			this.tabPage2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage2.Dock")));
			this.tabPage2.Enabled = ((bool)(resources.GetObject("tabPage2.Enabled")));
			this.tabPage2.Font = ((System.Drawing.Font)(resources.GetObject("tabPage2.Font")));
			this.tabPage2.ImageIndex = ((int)(resources.GetObject("tabPage2.ImageIndex")));
			this.tabPage2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage2.ImeMode")));
			this.tabPage2.Location = ((System.Drawing.Point)(resources.GetObject("tabPage2.Location")));
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage2.RightToLeft")));
			this.tabPage2.Size = ((System.Drawing.Size)(resources.GetObject("tabPage2.Size")));
			this.tabPage2.TabIndex = ((int)(resources.GetObject("tabPage2.TabIndex")));
			this.tabPage2.Text = resources.GetString("tabPage2.Text");
			this.tabPage2.ToolTipText = resources.GetString("tabPage2.ToolTipText");
			this.tabPage2.Visible = ((bool)(resources.GetObject("tabPage2.Visible")));
			// 
			// radioButton7
			// 
			this.radioButton7.AccessibleDescription = resources.GetString("radioButton7.AccessibleDescription");
			this.radioButton7.AccessibleName = resources.GetString("radioButton7.AccessibleName");
			this.radioButton7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButton7.Anchor")));
			this.radioButton7.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButton7.Appearance")));
			this.radioButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton7.BackgroundImage")));
			this.radioButton7.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton7.CheckAlign")));
			this.radioButton7.Checked = true;
			this.radioButton7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButton7.Dock")));
			this.radioButton7.Enabled = ((bool)(resources.GetObject("radioButton7.Enabled")));
			this.radioButton7.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButton7.FlatStyle")));
			this.radioButton7.Font = ((System.Drawing.Font)(resources.GetObject("radioButton7.Font")));
			this.radioButton7.Image = ((System.Drawing.Image)(resources.GetObject("radioButton7.Image")));
			this.radioButton7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton7.ImageAlign")));
			this.radioButton7.ImageIndex = ((int)(resources.GetObject("radioButton7.ImageIndex")));
			this.radioButton7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButton7.ImeMode")));
			this.radioButton7.Location = ((System.Drawing.Point)(resources.GetObject("radioButton7.Location")));
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButton7.RightToLeft")));
			this.radioButton7.Size = ((System.Drawing.Size)(resources.GetObject("radioButton7.Size")));
			this.radioButton7.TabIndex = ((int)(resources.GetObject("radioButton7.TabIndex")));
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = resources.GetString("radioButton7.Text");
			this.radioButton7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton7.TextAlign")));
			this.radioButton7.Visible = ((bool)(resources.GetObject("radioButton7.Visible")));
			this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleDescription = resources.GetString("groupBox2.AccessibleDescription");
			this.groupBox2.AccessibleName = resources.GetString("groupBox2.AccessibleName");
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox2.Anchor")));
			this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
			this.groupBox2.Controls.Add(this.btnDNS);
			this.groupBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox2.Dock")));
			this.groupBox2.Enabled = ((bool)(resources.GetObject("groupBox2.Enabled")));
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = ((System.Drawing.Font)(resources.GetObject("groupBox2.Font")));
			this.groupBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox2.ImeMode")));
			this.groupBox2.Location = ((System.Drawing.Point)(resources.GetObject("groupBox2.Location")));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox2.RightToLeft")));
			this.groupBox2.Size = ((System.Drawing.Size)(resources.GetObject("groupBox2.Size")));
			this.groupBox2.TabIndex = ((int)(resources.GetObject("groupBox2.TabIndex")));
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = resources.GetString("groupBox2.Text");
			this.groupBox2.Visible = ((bool)(resources.GetObject("groupBox2.Visible")));
			// 
			// btnDNS
			// 
			this.btnDNS.AccessibleDescription = resources.GetString("btnDNS.AccessibleDescription");
			this.btnDNS.AccessibleName = resources.GetString("btnDNS.AccessibleName");
			this.btnDNS.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnDNS.Anchor")));
			this.btnDNS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDNS.BackgroundImage")));
			this.btnDNS.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnDNS.Dock")));
			this.btnDNS.Enabled = ((bool)(resources.GetObject("btnDNS.Enabled")));
			this.btnDNS.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnDNS.FlatStyle")));
			this.btnDNS.Font = ((System.Drawing.Font)(resources.GetObject("btnDNS.Font")));
			this.btnDNS.Image = ((System.Drawing.Image)(resources.GetObject("btnDNS.Image")));
			this.btnDNS.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDNS.ImageAlign")));
			this.btnDNS.ImageIndex = ((int)(resources.GetObject("btnDNS.ImageIndex")));
			this.btnDNS.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnDNS.ImeMode")));
			this.btnDNS.Location = ((System.Drawing.Point)(resources.GetObject("btnDNS.Location")));
			this.btnDNS.Name = "btnDNS";
			this.btnDNS.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnDNS.RightToLeft")));
			this.btnDNS.Size = ((System.Drawing.Size)(resources.GetObject("btnDNS.Size")));
			this.btnDNS.TabIndex = ((int)(resources.GetObject("btnDNS.TabIndex")));
			this.btnDNS.Text = resources.GetString("btnDNS.Text");
			this.btnDNS.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDNS.TextAlign")));
			this.btnDNS.Visible = ((bool)(resources.GetObject("btnDNS.Visible")));
			this.btnDNS.Click += new System.EventHandler(this.btnDNS_Click);
			// 
			// radioButton6
			// 
			this.radioButton6.AccessibleDescription = resources.GetString("radioButton6.AccessibleDescription");
			this.radioButton6.AccessibleName = resources.GetString("radioButton6.AccessibleName");
			this.radioButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButton6.Anchor")));
			this.radioButton6.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButton6.Appearance")));
			this.radioButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton6.BackgroundImage")));
			this.radioButton6.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton6.CheckAlign")));
			this.radioButton6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButton6.Dock")));
			this.radioButton6.Enabled = ((bool)(resources.GetObject("radioButton6.Enabled")));
			this.radioButton6.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButton6.FlatStyle")));
			this.radioButton6.Font = ((System.Drawing.Font)(resources.GetObject("radioButton6.Font")));
			this.radioButton6.Image = ((System.Drawing.Image)(resources.GetObject("radioButton6.Image")));
			this.radioButton6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton6.ImageAlign")));
			this.radioButton6.ImageIndex = ((int)(resources.GetObject("radioButton6.ImageIndex")));
			this.radioButton6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButton6.ImeMode")));
			this.radioButton6.Location = ((System.Drawing.Point)(resources.GetObject("radioButton6.Location")));
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButton6.RightToLeft")));
			this.radioButton6.Size = ((System.Drawing.Size)(resources.GetObject("radioButton6.Size")));
			this.radioButton6.TabIndex = ((int)(resources.GetObject("radioButton6.TabIndex")));
			this.radioButton6.Text = resources.GetString("radioButton6.Text");
			this.radioButton6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton6.TextAlign")));
			this.radioButton6.Visible = ((bool)(resources.GetObject("radioButton6.Visible")));
			this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.btnSMTPSvrs);
			this.groupBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox1.Dock")));
			this.groupBox1.Enabled = ((bool)(resources.GetObject("groupBox1.Enabled")));
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = ((System.Drawing.Font)(resources.GetObject("groupBox1.Font")));
			this.groupBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox1.ImeMode")));
			this.groupBox1.Location = ((System.Drawing.Point)(resources.GetObject("groupBox1.Location")));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox1.RightToLeft")));
			this.groupBox1.Size = ((System.Drawing.Size)(resources.GetObject("groupBox1.Size")));
			this.groupBox1.TabIndex = ((int)(resources.GetObject("groupBox1.TabIndex")));
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = resources.GetString("groupBox1.Text");
			this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
			// 
			// btnSMTPSvrs
			// 
			this.btnSMTPSvrs.AccessibleDescription = resources.GetString("btnSMTPSvrs.AccessibleDescription");
			this.btnSMTPSvrs.AccessibleName = resources.GetString("btnSMTPSvrs.AccessibleName");
			this.btnSMTPSvrs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnSMTPSvrs.Anchor")));
			this.btnSMTPSvrs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSMTPSvrs.BackgroundImage")));
			this.btnSMTPSvrs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnSMTPSvrs.Dock")));
			this.btnSMTPSvrs.Enabled = ((bool)(resources.GetObject("btnSMTPSvrs.Enabled")));
			this.btnSMTPSvrs.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnSMTPSvrs.FlatStyle")));
			this.btnSMTPSvrs.Font = ((System.Drawing.Font)(resources.GetObject("btnSMTPSvrs.Font")));
			this.btnSMTPSvrs.Image = ((System.Drawing.Image)(resources.GetObject("btnSMTPSvrs.Image")));
			this.btnSMTPSvrs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnSMTPSvrs.ImageAlign")));
			this.btnSMTPSvrs.ImageIndex = ((int)(resources.GetObject("btnSMTPSvrs.ImageIndex")));
			this.btnSMTPSvrs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnSMTPSvrs.ImeMode")));
			this.btnSMTPSvrs.Location = ((System.Drawing.Point)(resources.GetObject("btnSMTPSvrs.Location")));
			this.btnSMTPSvrs.Name = "btnSMTPSvrs";
			this.btnSMTPSvrs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnSMTPSvrs.RightToLeft")));
			this.btnSMTPSvrs.Size = ((System.Drawing.Size)(resources.GetObject("btnSMTPSvrs.Size")));
			this.btnSMTPSvrs.TabIndex = ((int)(resources.GetObject("btnSMTPSvrs.TabIndex")));
			this.btnSMTPSvrs.Text = resources.GetString("btnSMTPSvrs.Text");
			this.btnSMTPSvrs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnSMTPSvrs.TextAlign")));
			this.btnSMTPSvrs.Visible = ((bool)(resources.GetObject("btnSMTPSvrs.Visible")));
			this.btnSMTPSvrs.Click += new System.EventHandler(this.btnSMTPSvrs_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AccessibleDescription = resources.GetString("radioButton1.AccessibleDescription");
			this.radioButton1.AccessibleName = resources.GetString("radioButton1.AccessibleName");
			this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButton1.Anchor")));
			this.radioButton1.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButton1.Appearance")));
			this.radioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton1.BackgroundImage")));
			this.radioButton1.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton1.CheckAlign")));
			this.radioButton1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButton1.Dock")));
			this.radioButton1.Enabled = ((bool)(resources.GetObject("radioButton1.Enabled")));
			this.radioButton1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButton1.FlatStyle")));
			this.radioButton1.Font = ((System.Drawing.Font)(resources.GetObject("radioButton1.Font")));
			this.radioButton1.Image = ((System.Drawing.Image)(resources.GetObject("radioButton1.Image")));
			this.radioButton1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton1.ImageAlign")));
			this.radioButton1.ImageIndex = ((int)(resources.GetObject("radioButton1.ImageIndex")));
			this.radioButton1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButton1.ImeMode")));
			this.radioButton1.Location = ((System.Drawing.Point)(resources.GetObject("radioButton1.Location")));
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButton1.RightToLeft")));
			this.radioButton1.Size = ((System.Drawing.Size)(resources.GetObject("radioButton1.Size")));
			this.radioButton1.TabIndex = ((int)(resources.GetObject("radioButton1.TabIndex")));
			this.radioButton1.Text = resources.GetString("radioButton1.Text");
			this.radioButton1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton1.TextAlign")));
			this.radioButton1.Visible = ((bool)(resources.GetObject("radioButton1.Visible")));
			// 
			// tabPage3
			// 
			this.tabPage3.AccessibleDescription = resources.GetString("tabPage3.AccessibleDescription");
			this.tabPage3.AccessibleName = resources.GetString("tabPage3.AccessibleName");
			this.tabPage3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage3.Anchor")));
			this.tabPage3.AutoScroll = ((bool)(resources.GetObject("tabPage3.AutoScroll")));
			this.tabPage3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMargin")));
			this.tabPage3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMinSize")));
			this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
			this.tabPage3.Controls.Add(this.radioButton3);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.radioButton4);
			this.tabPage3.Controls.Add(this.radioButton5);
			this.tabPage3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage3.Dock")));
			this.tabPage3.Enabled = ((bool)(resources.GetObject("tabPage3.Enabled")));
			this.tabPage3.Font = ((System.Drawing.Font)(resources.GetObject("tabPage3.Font")));
			this.tabPage3.ImageIndex = ((int)(resources.GetObject("tabPage3.ImageIndex")));
			this.tabPage3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage3.ImeMode")));
			this.tabPage3.Location = ((System.Drawing.Point)(resources.GetObject("tabPage3.Location")));
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage3.RightToLeft")));
			this.tabPage3.Size = ((System.Drawing.Size)(resources.GetObject("tabPage3.Size")));
			this.tabPage3.TabIndex = ((int)(resources.GetObject("tabPage3.TabIndex")));
			this.tabPage3.Text = resources.GetString("tabPage3.Text");
			this.tabPage3.ToolTipText = resources.GetString("tabPage3.ToolTipText");
			this.tabPage3.Visible = ((bool)(resources.GetObject("tabPage3.Visible")));
			this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
			// 
			// radioButton3
			// 
			this.radioButton3.AccessibleDescription = resources.GetString("radioButton3.AccessibleDescription");
			this.radioButton3.AccessibleName = resources.GetString("radioButton3.AccessibleName");
			this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButton3.Anchor")));
			this.radioButton3.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButton3.Appearance")));
			this.radioButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton3.BackgroundImage")));
			this.radioButton3.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton3.CheckAlign")));
			this.radioButton3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButton3.Dock")));
			this.radioButton3.Enabled = ((bool)(resources.GetObject("radioButton3.Enabled")));
			this.radioButton3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButton3.FlatStyle")));
			this.radioButton3.Font = ((System.Drawing.Font)(resources.GetObject("radioButton3.Font")));
			this.radioButton3.Image = ((System.Drawing.Image)(resources.GetObject("radioButton3.Image")));
			this.radioButton3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton3.ImageAlign")));
			this.radioButton3.ImageIndex = ((int)(resources.GetObject("radioButton3.ImageIndex")));
			this.radioButton3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButton3.ImeMode")));
			this.radioButton3.Location = ((System.Drawing.Point)(resources.GetObject("radioButton3.Location")));
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButton3.RightToLeft")));
			this.radioButton3.Size = ((System.Drawing.Size)(resources.GetObject("radioButton3.Size")));
			this.radioButton3.TabIndex = ((int)(resources.GetObject("radioButton3.TabIndex")));
			this.radioButton3.Text = resources.GetString("radioButton3.Text");
			this.radioButton3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton3.TextAlign")));
			this.radioButton3.Visible = ((bool)(resources.GetObject("radioButton3.Visible")));
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Enabled = ((bool)(resources.GetObject("label4.Enabled")));
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Font = ((System.Drawing.Font)(resources.GetObject("label4.Font")));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			// 
			// radioButton4
			// 
			this.radioButton4.AccessibleDescription = resources.GetString("radioButton4.AccessibleDescription");
			this.radioButton4.AccessibleName = resources.GetString("radioButton4.AccessibleName");
			this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButton4.Anchor")));
			this.radioButton4.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButton4.Appearance")));
			this.radioButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton4.BackgroundImage")));
			this.radioButton4.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton4.CheckAlign")));
			this.radioButton4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButton4.Dock")));
			this.radioButton4.Enabled = ((bool)(resources.GetObject("radioButton4.Enabled")));
			this.radioButton4.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButton4.FlatStyle")));
			this.radioButton4.Font = ((System.Drawing.Font)(resources.GetObject("radioButton4.Font")));
			this.radioButton4.Image = ((System.Drawing.Image)(resources.GetObject("radioButton4.Image")));
			this.radioButton4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton4.ImageAlign")));
			this.radioButton4.ImageIndex = ((int)(resources.GetObject("radioButton4.ImageIndex")));
			this.radioButton4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButton4.ImeMode")));
			this.radioButton4.Location = ((System.Drawing.Point)(resources.GetObject("radioButton4.Location")));
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButton4.RightToLeft")));
			this.radioButton4.Size = ((System.Drawing.Size)(resources.GetObject("radioButton4.Size")));
			this.radioButton4.TabIndex = ((int)(resources.GetObject("radioButton4.TabIndex")));
			this.radioButton4.Text = resources.GetString("radioButton4.Text");
			this.radioButton4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton4.TextAlign")));
			this.radioButton4.Visible = ((bool)(resources.GetObject("radioButton4.Visible")));
			// 
			// radioButton5
			// 
			this.radioButton5.AccessibleDescription = resources.GetString("radioButton5.AccessibleDescription");
			this.radioButton5.AccessibleName = resources.GetString("radioButton5.AccessibleName");
			this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButton5.Anchor")));
			this.radioButton5.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButton5.Appearance")));
			this.radioButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton5.BackgroundImage")));
			this.radioButton5.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton5.CheckAlign")));
			this.radioButton5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButton5.Dock")));
			this.radioButton5.Enabled = ((bool)(resources.GetObject("radioButton5.Enabled")));
			this.radioButton5.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButton5.FlatStyle")));
			this.radioButton5.Font = ((System.Drawing.Font)(resources.GetObject("radioButton5.Font")));
			this.radioButton5.Image = ((System.Drawing.Image)(resources.GetObject("radioButton5.Image")));
			this.radioButton5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton5.ImageAlign")));
			this.radioButton5.ImageIndex = ((int)(resources.GetObject("radioButton5.ImageIndex")));
			this.radioButton5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButton5.ImeMode")));
			this.radioButton5.Location = ((System.Drawing.Point)(resources.GetObject("radioButton5.Location")));
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButton5.RightToLeft")));
			this.radioButton5.Size = ((System.Drawing.Size)(resources.GetObject("radioButton5.Size")));
			this.radioButton5.TabIndex = ((int)(resources.GetObject("radioButton5.TabIndex")));
			this.radioButton5.Text = resources.GetString("radioButton5.Text");
			this.radioButton5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton5.TextAlign")));
			this.radioButton5.Visible = ((bool)(resources.GetObject("radioButton5.Visible")));
			// 
			// btnOK
			// 
			this.btnOK.AccessibleDescription = resources.GetString("btnOK.AccessibleDescription");
			this.btnOK.AccessibleName = resources.GetString("btnOK.AccessibleName");
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnOK.Anchor")));
			this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
			this.btnOK.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnOK.Dock")));
			this.btnOK.Enabled = ((bool)(resources.GetObject("btnOK.Enabled")));
			this.btnOK.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnOK.FlatStyle")));
			this.btnOK.Font = ((System.Drawing.Font)(resources.GetObject("btnOK.Font")));
			this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
			this.btnOK.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOK.ImageAlign")));
			this.btnOK.ImageIndex = ((int)(resources.GetObject("btnOK.ImageIndex")));
			this.btnOK.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnOK.ImeMode")));
			this.btnOK.Location = ((System.Drawing.Point)(resources.GetObject("btnOK.Location")));
			this.btnOK.Name = "btnOK";
			this.btnOK.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnOK.RightToLeft")));
			this.btnOK.Size = ((System.Drawing.Size)(resources.GetObject("btnOK.Size")));
			this.btnOK.TabIndex = ((int)(resources.GetObject("btnOK.TabIndex")));
			this.btnOK.Text = resources.GetString("btnOK.Text");
			this.btnOK.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOK.TextAlign")));
			this.btnOK.Visible = ((bool)(resources.GetObject("btnOK.Visible")));
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AccessibleDescription = resources.GetString("btnCancel.AccessibleDescription");
			this.btnCancel.AccessibleName = resources.GetString("btnCancel.AccessibleName");
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnCancel.Anchor")));
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnCancel.Dock")));
			this.btnCancel.Enabled = ((bool)(resources.GetObject("btnCancel.Enabled")));
			this.btnCancel.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnCancel.FlatStyle")));
			this.btnCancel.Font = ((System.Drawing.Font)(resources.GetObject("btnCancel.Font")));
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnCancel.ImageAlign")));
			this.btnCancel.ImageIndex = ((int)(resources.GetObject("btnCancel.ImageIndex")));
			this.btnCancel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnCancel.ImeMode")));
			this.btnCancel.Location = ((System.Drawing.Point)(resources.GetObject("btnCancel.Location")));
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnCancel.RightToLeft")));
			this.btnCancel.Size = ((System.Drawing.Size)(resources.GetObject("btnCancel.Size")));
			this.btnCancel.TabIndex = ((int)(resources.GetObject("btnCancel.TabIndex")));
			this.btnCancel.Text = resources.GetString("btnCancel.Text");
			this.btnCancel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnCancel.TextAlign")));
			this.btnCancel.Visible = ((bool)(resources.GetObject("btnCancel.Visible")));
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.btnDefault);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel1.Dock")));
			this.panel1.Enabled = ((bool)(resources.GetObject("panel1.Enabled")));
			this.panel1.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Font")));
			this.panel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel1.ImeMode")));
			this.panel1.Location = ((System.Drawing.Point)(resources.GetObject("panel1.Location")));
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel1.RightToLeft")));
			this.panel1.Size = ((System.Drawing.Size)(resources.GetObject("panel1.Size")));
			this.panel1.TabIndex = ((int)(resources.GetObject("panel1.TabIndex")));
			this.panel1.Text = resources.GetString("panel1.Text");
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			// 
			// btnDefault
			// 
			this.btnDefault.AccessibleDescription = resources.GetString("btnDefault.AccessibleDescription");
			this.btnDefault.AccessibleName = resources.GetString("btnDefault.AccessibleName");
			this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnDefault.Anchor")));
			this.btnDefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDefault.BackgroundImage")));
			this.btnDefault.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnDefault.Dock")));
			this.btnDefault.Enabled = ((bool)(resources.GetObject("btnDefault.Enabled")));
			this.btnDefault.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnDefault.FlatStyle")));
			this.btnDefault.Font = ((System.Drawing.Font)(resources.GetObject("btnDefault.Font")));
			this.btnDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnDefault.Image")));
			this.btnDefault.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDefault.ImageAlign")));
			this.btnDefault.ImageIndex = ((int)(resources.GetObject("btnDefault.ImageIndex")));
			this.btnDefault.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnDefault.ImeMode")));
			this.btnDefault.Location = ((System.Drawing.Point)(resources.GetObject("btnDefault.Location")));
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnDefault.RightToLeft")));
			this.btnDefault.Size = ((System.Drawing.Size)(resources.GetObject("btnDefault.Size")));
			this.btnDefault.TabIndex = ((int)(resources.GetObject("btnDefault.TabIndex")));
			this.btnDefault.Text = resources.GetString("btnDefault.Text");
			this.btnDefault.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDefault.TextAlign")));
			this.btnDefault.Visible = ((bool)(resources.GetObject("btnDefault.Visible")));
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// FrmOptions
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "FrmOptions";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.FrmOptions_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).EndInit();
			this.GroupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
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
