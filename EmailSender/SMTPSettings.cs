using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EmailSender
{
	/// <summary>
	/// Summary description for SMTPSettings.
	/// </summary>
	public class SMTPSettings : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		internal System.Windows.Forms.CheckBox CheckBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		internal System.Windows.Forms.GroupBox GroupBox8;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox TextBox12;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox TextBox13;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TextBox txtFromEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFromName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtReply;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.ComponentModel.IContainer components;

		public SMTPSettings()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SMTPSettings));
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFromName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtReply = new System.Windows.Forms.TextBox();
			this.txtFromEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.CheckBox3 = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.GroupBox8 = new System.Windows.Forms.GroupBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.TextBox12 = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.TextBox13 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.GroupBox8.SuspendLayout();
			this.SuspendLayout();
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
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// listView1
			// 
			this.listView1.AccessibleDescription = resources.GetString("listView1.AccessibleDescription");
			this.listView1.AccessibleName = resources.GetString("listView1.AccessibleName");
			this.listView1.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("listView1.Alignment")));
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listView1.Anchor")));
			this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader2,
																						this.columnHeader1});
			this.listView1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listView1.Dock")));
			this.listView1.Enabled = ((bool)(resources.GetObject("listView1.Enabled")));
			this.listView1.Font = ((System.Drawing.Font)(resources.GetObject("listView1.Font")));
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listView1.ImeMode")));
			this.listView1.LabelWrap = ((bool)(resources.GetObject("listView1.LabelWrap")));
			this.listView1.Location = ((System.Drawing.Point)(resources.GetObject("listView1.Location")));
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listView1.RightToLeft")));
			this.listView1.Size = ((System.Drawing.Size)(resources.GetObject("listView1.Size")));
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = ((int)(resources.GetObject("listView1.TabIndex")));
			this.listView1.Text = resources.GetString("listView1.Text");
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.Visible = ((bool)(resources.GetObject("listView1.Visible")));
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = resources.GetString("columnHeader2.Text");
			this.columnHeader2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader2.TextAlign")));
			this.columnHeader2.Width = ((int)(resources.GetObject("columnHeader2.Width")));
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = resources.GetString("columnHeader1.Text");
			this.columnHeader1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader1.TextAlign")));
			this.columnHeader1.Width = ((int)(resources.GetObject("columnHeader1.Width")));
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = ((System.Drawing.Size)(resources.GetObject("imageList1.ImageSize")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// splitter1
			// 
			this.splitter1.AccessibleDescription = resources.GetString("splitter1.AccessibleDescription");
			this.splitter1.AccessibleName = resources.GetString("splitter1.AccessibleName");
			this.splitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("splitter1.Anchor")));
			this.splitter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitter1.BackgroundImage")));
			this.splitter1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("splitter1.Dock")));
			this.splitter1.Enabled = ((bool)(resources.GetObject("splitter1.Enabled")));
			this.splitter1.Font = ((System.Drawing.Font)(resources.GetObject("splitter1.Font")));
			this.splitter1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("splitter1.ImeMode")));
			this.splitter1.Location = ((System.Drawing.Point)(resources.GetObject("splitter1.Location")));
			this.splitter1.MinExtra = ((int)(resources.GetObject("splitter1.MinExtra")));
			this.splitter1.MinSize = ((int)(resources.GetObject("splitter1.MinSize")));
			this.splitter1.Name = "splitter1";
			this.splitter1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("splitter1.RightToLeft")));
			this.splitter1.Size = ((System.Drawing.Size)(resources.GetObject("splitter1.Size")));
			this.splitter1.TabIndex = ((int)(resources.GetObject("splitter1.TabIndex")));
			this.splitter1.TabStop = false;
			this.splitter1.Visible = ((bool)(resources.GetObject("splitter1.Visible")));
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
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.btnDelete);
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
			// btnAdd
			// 
			this.btnAdd.AccessibleDescription = resources.GetString("btnAdd.AccessibleDescription");
			this.btnAdd.AccessibleName = resources.GetString("btnAdd.AccessibleName");
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnAdd.Anchor")));
			this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
			this.btnAdd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnAdd.Dock")));
			this.btnAdd.Enabled = ((bool)(resources.GetObject("btnAdd.Enabled")));
			this.btnAdd.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnAdd.FlatStyle")));
			this.btnAdd.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Font")));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnAdd.ImageAlign")));
			this.btnAdd.ImageIndex = ((int)(resources.GetObject("btnAdd.ImageIndex")));
			this.btnAdd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnAdd.ImeMode")));
			this.btnAdd.Location = ((System.Drawing.Point)(resources.GetObject("btnAdd.Location")));
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnAdd.RightToLeft")));
			this.btnAdd.Size = ((System.Drawing.Size)(resources.GetObject("btnAdd.Size")));
			this.btnAdd.TabIndex = ((int)(resources.GetObject("btnAdd.TabIndex")));
			this.btnAdd.Text = resources.GetString("btnAdd.Text");
			this.btnAdd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnAdd.TextAlign")));
			this.btnAdd.Visible = ((bool)(resources.GetObject("btnAdd.Visible")));
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.AccessibleDescription = resources.GetString("btnDelete.AccessibleDescription");
			this.btnDelete.AccessibleName = resources.GetString("btnDelete.AccessibleName");
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnDelete.Anchor")));
			this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
			this.btnDelete.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnDelete.Dock")));
			this.btnDelete.Enabled = ((bool)(resources.GetObject("btnDelete.Enabled")));
			this.btnDelete.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnDelete.FlatStyle")));
			this.btnDelete.Font = ((System.Drawing.Font)(resources.GetObject("btnDelete.Font")));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDelete.ImageAlign")));
			this.btnDelete.ImageIndex = ((int)(resources.GetObject("btnDelete.ImageIndex")));
			this.btnDelete.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnDelete.ImeMode")));
			this.btnDelete.Location = ((System.Drawing.Point)(resources.GetObject("btnDelete.Location")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnDelete.RightToLeft")));
			this.btnDelete.Size = ((System.Drawing.Size)(resources.GetObject("btnDelete.Size")));
			this.btnDelete.TabIndex = ((int)(resources.GetObject("btnDelete.TabIndex")));
			this.btnDelete.Text = resources.GetString("btnDelete.Text");
			this.btnDelete.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnDelete.TextAlign")));
			this.btnDelete.Visible = ((bool)(resources.GetObject("btnDelete.Visible")));
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.checkBox4);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.numericUpDown2);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Controls.Add(this.CheckBox3);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.numericUpDown1);
			this.panel2.Controls.Add(this.GroupBox8);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.textBox6);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// checkBox4
			// 
			this.checkBox4.AccessibleDescription = resources.GetString("checkBox4.AccessibleDescription");
			this.checkBox4.AccessibleName = resources.GetString("checkBox4.AccessibleName");
			this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("checkBox4.Anchor")));
			this.checkBox4.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("checkBox4.Appearance")));
			this.checkBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox4.BackgroundImage")));
			this.checkBox4.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox4.CheckAlign")));
			this.checkBox4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("checkBox4.Dock")));
			this.checkBox4.Enabled = ((bool)(resources.GetObject("checkBox4.Enabled")));
			this.checkBox4.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("checkBox4.FlatStyle")));
			this.checkBox4.Font = ((System.Drawing.Font)(resources.GetObject("checkBox4.Font")));
			this.checkBox4.Image = ((System.Drawing.Image)(resources.GetObject("checkBox4.Image")));
			this.checkBox4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox4.ImageAlign")));
			this.checkBox4.ImageIndex = ((int)(resources.GetObject("checkBox4.ImageIndex")));
			this.checkBox4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("checkBox4.ImeMode")));
			this.checkBox4.Location = ((System.Drawing.Point)(resources.GetObject("checkBox4.Location")));
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("checkBox4.RightToLeft")));
			this.checkBox4.Size = ((System.Drawing.Size)(resources.GetObject("checkBox4.Size")));
			this.checkBox4.TabIndex = ((int)(resources.GetObject("checkBox4.TabIndex")));
			this.checkBox4.Text = resources.GetString("checkBox4.Text");
			this.checkBox4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox4.TextAlign")));
			this.checkBox4.Visible = ((bool)(resources.GetObject("checkBox4.Visible")));
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtFromName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtReply);
			this.groupBox1.Controls.Add(this.txtFromEmail);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.checkBox2);
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
			// txtFromName
			// 
			this.txtFromName.AccessibleDescription = resources.GetString("txtFromName.AccessibleDescription");
			this.txtFromName.AccessibleName = resources.GetString("txtFromName.AccessibleName");
			this.txtFromName.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("txtFromName.Anchor")));
			this.txtFromName.AutoSize = ((bool)(resources.GetObject("txtFromName.AutoSize")));
			this.txtFromName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFromName.BackgroundImage")));
			this.txtFromName.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("txtFromName.Dock")));
			this.txtFromName.Enabled = ((bool)(resources.GetObject("txtFromName.Enabled")));
			this.txtFromName.Font = ((System.Drawing.Font)(resources.GetObject("txtFromName.Font")));
			this.txtFromName.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("txtFromName.ImeMode")));
			this.txtFromName.Location = ((System.Drawing.Point)(resources.GetObject("txtFromName.Location")));
			this.txtFromName.MaxLength = ((int)(resources.GetObject("txtFromName.MaxLength")));
			this.txtFromName.Multiline = ((bool)(resources.GetObject("txtFromName.Multiline")));
			this.txtFromName.Name = "txtFromName";
			this.txtFromName.PasswordChar = ((char)(resources.GetObject("txtFromName.PasswordChar")));
			this.txtFromName.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("txtFromName.RightToLeft")));
			this.txtFromName.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("txtFromName.ScrollBars")));
			this.txtFromName.Size = ((System.Drawing.Size)(resources.GetObject("txtFromName.Size")));
			this.txtFromName.TabIndex = ((int)(resources.GetObject("txtFromName.TabIndex")));
			this.txtFromName.Text = resources.GetString("txtFromName.Text");
			this.txtFromName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("txtFromName.TextAlign")));
			this.txtFromName.Visible = ((bool)(resources.GetObject("txtFromName.Visible")));
			this.txtFromName.WordWrap = ((bool)(resources.GetObject("txtFromName.WordWrap")));
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
			// txtReply
			// 
			this.txtReply.AccessibleDescription = resources.GetString("txtReply.AccessibleDescription");
			this.txtReply.AccessibleName = resources.GetString("txtReply.AccessibleName");
			this.txtReply.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("txtReply.Anchor")));
			this.txtReply.AutoSize = ((bool)(resources.GetObject("txtReply.AutoSize")));
			this.txtReply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtReply.BackgroundImage")));
			this.txtReply.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("txtReply.Dock")));
			this.txtReply.Enabled = ((bool)(resources.GetObject("txtReply.Enabled")));
			this.txtReply.Font = ((System.Drawing.Font)(resources.GetObject("txtReply.Font")));
			this.txtReply.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("txtReply.ImeMode")));
			this.txtReply.Location = ((System.Drawing.Point)(resources.GetObject("txtReply.Location")));
			this.txtReply.MaxLength = ((int)(resources.GetObject("txtReply.MaxLength")));
			this.txtReply.Multiline = ((bool)(resources.GetObject("txtReply.Multiline")));
			this.txtReply.Name = "txtReply";
			this.txtReply.PasswordChar = ((char)(resources.GetObject("txtReply.PasswordChar")));
			this.txtReply.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("txtReply.RightToLeft")));
			this.txtReply.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("txtReply.ScrollBars")));
			this.txtReply.Size = ((System.Drawing.Size)(resources.GetObject("txtReply.Size")));
			this.txtReply.TabIndex = ((int)(resources.GetObject("txtReply.TabIndex")));
			this.txtReply.Text = resources.GetString("txtReply.Text");
			this.txtReply.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("txtReply.TextAlign")));
			this.txtReply.Visible = ((bool)(resources.GetObject("txtReply.Visible")));
			this.txtReply.WordWrap = ((bool)(resources.GetObject("txtReply.WordWrap")));
			// 
			// txtFromEmail
			// 
			this.txtFromEmail.AccessibleDescription = resources.GetString("txtFromEmail.AccessibleDescription");
			this.txtFromEmail.AccessibleName = resources.GetString("txtFromEmail.AccessibleName");
			this.txtFromEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("txtFromEmail.Anchor")));
			this.txtFromEmail.AutoSize = ((bool)(resources.GetObject("txtFromEmail.AutoSize")));
			this.txtFromEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFromEmail.BackgroundImage")));
			this.txtFromEmail.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("txtFromEmail.Dock")));
			this.txtFromEmail.Enabled = ((bool)(resources.GetObject("txtFromEmail.Enabled")));
			this.txtFromEmail.Font = ((System.Drawing.Font)(resources.GetObject("txtFromEmail.Font")));
			this.txtFromEmail.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("txtFromEmail.ImeMode")));
			this.txtFromEmail.Location = ((System.Drawing.Point)(resources.GetObject("txtFromEmail.Location")));
			this.txtFromEmail.MaxLength = ((int)(resources.GetObject("txtFromEmail.MaxLength")));
			this.txtFromEmail.Multiline = ((bool)(resources.GetObject("txtFromEmail.Multiline")));
			this.txtFromEmail.Name = "txtFromEmail";
			this.txtFromEmail.PasswordChar = ((char)(resources.GetObject("txtFromEmail.PasswordChar")));
			this.txtFromEmail.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("txtFromEmail.RightToLeft")));
			this.txtFromEmail.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("txtFromEmail.ScrollBars")));
			this.txtFromEmail.Size = ((System.Drawing.Size)(resources.GetObject("txtFromEmail.Size")));
			this.txtFromEmail.TabIndex = ((int)(resources.GetObject("txtFromEmail.TabIndex")));
			this.txtFromEmail.Text = resources.GetString("txtFromEmail.Text");
			this.txtFromEmail.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("txtFromEmail.TextAlign")));
			this.txtFromEmail.Visible = ((bool)(resources.GetObject("txtFromEmail.Visible")));
			this.txtFromEmail.WordWrap = ((bool)(resources.GetObject("txtFromEmail.WordWrap")));
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
			// numericUpDown2
			// 
			this.numericUpDown2.AccessibleDescription = resources.GetString("numericUpDown2.AccessibleDescription");
			this.numericUpDown2.AccessibleName = resources.GetString("numericUpDown2.AccessibleName");
			this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("numericUpDown2.Anchor")));
			this.numericUpDown2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("numericUpDown2.Dock")));
			this.numericUpDown2.Enabled = ((bool)(resources.GetObject("numericUpDown2.Enabled")));
			this.numericUpDown2.Font = ((System.Drawing.Font)(resources.GetObject("numericUpDown2.Font")));
			this.numericUpDown2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("numericUpDown2.ImeMode")));
			this.numericUpDown2.Location = ((System.Drawing.Point)(resources.GetObject("numericUpDown2.Location")));
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("numericUpDown2.RightToLeft")));
			this.numericUpDown2.Size = ((System.Drawing.Size)(resources.GetObject("numericUpDown2.Size")));
			this.numericUpDown2.TabIndex = ((int)(resources.GetObject("numericUpDown2.TabIndex")));
			this.numericUpDown2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("numericUpDown2.TextAlign")));
			this.numericUpDown2.ThousandsSeparator = ((bool)(resources.GetObject("numericUpDown2.ThousandsSeparator")));
			this.numericUpDown2.UpDownAlign = ((System.Windows.Forms.LeftRightAlignment)(resources.GetObject("numericUpDown2.UpDownAlign")));
			this.numericUpDown2.Visible = ((bool)(resources.GetObject("numericUpDown2.Visible")));
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
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// CheckBox3
			// 
			this.CheckBox3.AccessibleDescription = resources.GetString("CheckBox3.AccessibleDescription");
			this.CheckBox3.AccessibleName = resources.GetString("CheckBox3.AccessibleName");
			this.CheckBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CheckBox3.Anchor")));
			this.CheckBox3.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("CheckBox3.Appearance")));
			this.CheckBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckBox3.BackgroundImage")));
			this.CheckBox3.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CheckBox3.CheckAlign")));
			this.CheckBox3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("CheckBox3.Dock")));
			this.CheckBox3.Enabled = ((bool)(resources.GetObject("CheckBox3.Enabled")));
			this.CheckBox3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("CheckBox3.FlatStyle")));
			this.CheckBox3.Font = ((System.Drawing.Font)(resources.GetObject("CheckBox3.Font")));
			this.CheckBox3.Image = ((System.Drawing.Image)(resources.GetObject("CheckBox3.Image")));
			this.CheckBox3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CheckBox3.ImageAlign")));
			this.CheckBox3.ImageIndex = ((int)(resources.GetObject("CheckBox3.ImageIndex")));
			this.CheckBox3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CheckBox3.ImeMode")));
			this.CheckBox3.Location = ((System.Drawing.Point)(resources.GetObject("CheckBox3.Location")));
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("CheckBox3.RightToLeft")));
			this.CheckBox3.Size = ((System.Drawing.Size)(resources.GetObject("CheckBox3.Size")));
			this.CheckBox3.TabIndex = ((int)(resources.GetObject("CheckBox3.TabIndex")));
			this.CheckBox3.Text = resources.GetString("CheckBox3.Text");
			this.CheckBox3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CheckBox3.TextAlign")));
			this.CheckBox3.Visible = ((bool)(resources.GetObject("CheckBox3.Visible")));
			this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
			// 
			// label9
			// 
			this.label9.AccessibleDescription = resources.GetString("label9.AccessibleDescription");
			this.label9.AccessibleName = resources.GetString("label9.AccessibleName");
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label9.Anchor")));
			this.label9.AutoSize = ((bool)(resources.GetObject("label9.AutoSize")));
			this.label9.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label9.Dock")));
			this.label9.Enabled = ((bool)(resources.GetObject("label9.Enabled")));
			this.label9.Font = ((System.Drawing.Font)(resources.GetObject("label9.Font")));
			this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
			this.label9.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.ImageAlign")));
			this.label9.ImageIndex = ((int)(resources.GetObject("label9.ImageIndex")));
			this.label9.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label9.ImeMode")));
			this.label9.Location = ((System.Drawing.Point)(resources.GetObject("label9.Location")));
			this.label9.Name = "label9";
			this.label9.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label9.RightToLeft")));
			this.label9.Size = ((System.Drawing.Size)(resources.GetObject("label9.Size")));
			this.label9.TabIndex = ((int)(resources.GetObject("label9.TabIndex")));
			this.label9.Text = resources.GetString("label9.Text");
			this.label9.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.TextAlign")));
			this.label9.Visible = ((bool)(resources.GetObject("label9.Visible")));
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
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("numericUpDown1.RightToLeft")));
			this.numericUpDown1.Size = ((System.Drawing.Size)(resources.GetObject("numericUpDown1.Size")));
			this.numericUpDown1.TabIndex = ((int)(resources.GetObject("numericUpDown1.TabIndex")));
			this.numericUpDown1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("numericUpDown1.TextAlign")));
			this.numericUpDown1.ThousandsSeparator = ((bool)(resources.GetObject("numericUpDown1.ThousandsSeparator")));
			this.numericUpDown1.UpDownAlign = ((System.Windows.Forms.LeftRightAlignment)(resources.GetObject("numericUpDown1.UpDownAlign")));
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 25,
																		 0,
																		 0,
																		 0});
			this.numericUpDown1.Visible = ((bool)(resources.GetObject("numericUpDown1.Visible")));
			// 
			// GroupBox8
			// 
			this.GroupBox8.AccessibleDescription = resources.GetString("GroupBox8.AccessibleDescription");
			this.GroupBox8.AccessibleName = resources.GetString("GroupBox8.AccessibleName");
			this.GroupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("GroupBox8.Anchor")));
			this.GroupBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GroupBox8.BackgroundImage")));
			this.GroupBox8.Controls.Add(this.Label14);
			this.GroupBox8.Controls.Add(this.TextBox12);
			this.GroupBox8.Controls.Add(this.Label15);
			this.GroupBox8.Controls.Add(this.TextBox13);
			this.GroupBox8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("GroupBox8.Dock")));
			this.GroupBox8.Enabled = ((bool)(resources.GetObject("GroupBox8.Enabled")));
			this.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GroupBox8.Font = ((System.Drawing.Font)(resources.GetObject("GroupBox8.Font")));
			this.GroupBox8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("GroupBox8.ImeMode")));
			this.GroupBox8.Location = ((System.Drawing.Point)(resources.GetObject("GroupBox8.Location")));
			this.GroupBox8.Name = "GroupBox8";
			this.GroupBox8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("GroupBox8.RightToLeft")));
			this.GroupBox8.Size = ((System.Drawing.Size)(resources.GetObject("GroupBox8.Size")));
			this.GroupBox8.TabIndex = ((int)(resources.GetObject("GroupBox8.TabIndex")));
			this.GroupBox8.TabStop = false;
			this.GroupBox8.Text = resources.GetString("GroupBox8.Text");
			this.GroupBox8.Visible = ((bool)(resources.GetObject("GroupBox8.Visible")));
			// 
			// Label14
			// 
			this.Label14.AccessibleDescription = resources.GetString("Label14.AccessibleDescription");
			this.Label14.AccessibleName = resources.GetString("Label14.AccessibleName");
			this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("Label14.Anchor")));
			this.Label14.AutoSize = ((bool)(resources.GetObject("Label14.AutoSize")));
			this.Label14.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("Label14.Dock")));
			this.Label14.Enabled = ((bool)(resources.GetObject("Label14.Enabled")));
			this.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Label14.Font = ((System.Drawing.Font)(resources.GetObject("Label14.Font")));
			this.Label14.Image = ((System.Drawing.Image)(resources.GetObject("Label14.Image")));
			this.Label14.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("Label14.ImageAlign")));
			this.Label14.ImageIndex = ((int)(resources.GetObject("Label14.ImageIndex")));
			this.Label14.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("Label14.ImeMode")));
			this.Label14.Location = ((System.Drawing.Point)(resources.GetObject("Label14.Location")));
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("Label14.RightToLeft")));
			this.Label14.Size = ((System.Drawing.Size)(resources.GetObject("Label14.Size")));
			this.Label14.TabIndex = ((int)(resources.GetObject("Label14.TabIndex")));
			this.Label14.Text = resources.GetString("Label14.Text");
			this.Label14.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("Label14.TextAlign")));
			this.Label14.Visible = ((bool)(resources.GetObject("Label14.Visible")));
			// 
			// TextBox12
			// 
			this.TextBox12.AccessibleDescription = resources.GetString("TextBox12.AccessibleDescription");
			this.TextBox12.AccessibleName = resources.GetString("TextBox12.AccessibleName");
			this.TextBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("TextBox12.Anchor")));
			this.TextBox12.AutoSize = ((bool)(resources.GetObject("TextBox12.AutoSize")));
			this.TextBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBox12.BackgroundImage")));
			this.TextBox12.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("TextBox12.Dock")));
			this.TextBox12.Enabled = ((bool)(resources.GetObject("TextBox12.Enabled")));
			this.TextBox12.Font = ((System.Drawing.Font)(resources.GetObject("TextBox12.Font")));
			this.TextBox12.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("TextBox12.ImeMode")));
			this.TextBox12.Location = ((System.Drawing.Point)(resources.GetObject("TextBox12.Location")));
			this.TextBox12.MaxLength = ((int)(resources.GetObject("TextBox12.MaxLength")));
			this.TextBox12.Multiline = ((bool)(resources.GetObject("TextBox12.Multiline")));
			this.TextBox12.Name = "TextBox12";
			this.TextBox12.PasswordChar = ((char)(resources.GetObject("TextBox12.PasswordChar")));
			this.TextBox12.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("TextBox12.RightToLeft")));
			this.TextBox12.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("TextBox12.ScrollBars")));
			this.TextBox12.Size = ((System.Drawing.Size)(resources.GetObject("TextBox12.Size")));
			this.TextBox12.TabIndex = ((int)(resources.GetObject("TextBox12.TabIndex")));
			this.TextBox12.Text = resources.GetString("TextBox12.Text");
			this.TextBox12.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("TextBox12.TextAlign")));
			this.TextBox12.Visible = ((bool)(resources.GetObject("TextBox12.Visible")));
			this.TextBox12.WordWrap = ((bool)(resources.GetObject("TextBox12.WordWrap")));
			// 
			// Label15
			// 
			this.Label15.AccessibleDescription = resources.GetString("Label15.AccessibleDescription");
			this.Label15.AccessibleName = resources.GetString("Label15.AccessibleName");
			this.Label15.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("Label15.Anchor")));
			this.Label15.AutoSize = ((bool)(resources.GetObject("Label15.AutoSize")));
			this.Label15.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("Label15.Dock")));
			this.Label15.Enabled = ((bool)(resources.GetObject("Label15.Enabled")));
			this.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Label15.Font = ((System.Drawing.Font)(resources.GetObject("Label15.Font")));
			this.Label15.Image = ((System.Drawing.Image)(resources.GetObject("Label15.Image")));
			this.Label15.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("Label15.ImageAlign")));
			this.Label15.ImageIndex = ((int)(resources.GetObject("Label15.ImageIndex")));
			this.Label15.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("Label15.ImeMode")));
			this.Label15.Location = ((System.Drawing.Point)(resources.GetObject("Label15.Location")));
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("Label15.RightToLeft")));
			this.Label15.Size = ((System.Drawing.Size)(resources.GetObject("Label15.Size")));
			this.Label15.TabIndex = ((int)(resources.GetObject("Label15.TabIndex")));
			this.Label15.Text = resources.GetString("Label15.Text");
			this.Label15.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("Label15.TextAlign")));
			this.Label15.Visible = ((bool)(resources.GetObject("Label15.Visible")));
			// 
			// TextBox13
			// 
			this.TextBox13.AccessibleDescription = resources.GetString("TextBox13.AccessibleDescription");
			this.TextBox13.AccessibleName = resources.GetString("TextBox13.AccessibleName");
			this.TextBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("TextBox13.Anchor")));
			this.TextBox13.AutoSize = ((bool)(resources.GetObject("TextBox13.AutoSize")));
			this.TextBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBox13.BackgroundImage")));
			this.TextBox13.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("TextBox13.Dock")));
			this.TextBox13.Enabled = ((bool)(resources.GetObject("TextBox13.Enabled")));
			this.TextBox13.Font = ((System.Drawing.Font)(resources.GetObject("TextBox13.Font")));
			this.TextBox13.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("TextBox13.ImeMode")));
			this.TextBox13.Location = ((System.Drawing.Point)(resources.GetObject("TextBox13.Location")));
			this.TextBox13.MaxLength = ((int)(resources.GetObject("TextBox13.MaxLength")));
			this.TextBox13.Multiline = ((bool)(resources.GetObject("TextBox13.Multiline")));
			this.TextBox13.Name = "TextBox13";
			this.TextBox13.PasswordChar = ((char)(resources.GetObject("TextBox13.PasswordChar")));
			this.TextBox13.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("TextBox13.RightToLeft")));
			this.TextBox13.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("TextBox13.ScrollBars")));
			this.TextBox13.Size = ((System.Drawing.Size)(resources.GetObject("TextBox13.Size")));
			this.TextBox13.TabIndex = ((int)(resources.GetObject("TextBox13.TabIndex")));
			this.TextBox13.Text = resources.GetString("TextBox13.Text");
			this.TextBox13.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("TextBox13.TextAlign")));
			this.TextBox13.Visible = ((bool)(resources.GetObject("TextBox13.Visible")));
			this.TextBox13.WordWrap = ((bool)(resources.GetObject("TextBox13.WordWrap")));
			// 
			// label8
			// 
			this.label8.AccessibleDescription = resources.GetString("label8.AccessibleDescription");
			this.label8.AccessibleName = resources.GetString("label8.AccessibleName");
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label8.Anchor")));
			this.label8.AutoSize = ((bool)(resources.GetObject("label8.AutoSize")));
			this.label8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label8.Dock")));
			this.label8.Enabled = ((bool)(resources.GetObject("label8.Enabled")));
			this.label8.Font = ((System.Drawing.Font)(resources.GetObject("label8.Font")));
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.ImageAlign")));
			this.label8.ImageIndex = ((int)(resources.GetObject("label8.ImageIndex")));
			this.label8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label8.ImeMode")));
			this.label8.Location = ((System.Drawing.Point)(resources.GetObject("label8.Location")));
			this.label8.Name = "label8";
			this.label8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label8.RightToLeft")));
			this.label8.Size = ((System.Drawing.Size)(resources.GetObject("label8.Size")));
			this.label8.TabIndex = ((int)(resources.GetObject("label8.TabIndex")));
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.TextAlign")));
			this.label8.Visible = ((bool)(resources.GetObject("label8.Visible")));
			// 
			// textBox6
			// 
			this.textBox6.AccessibleDescription = resources.GetString("textBox6.AccessibleDescription");
			this.textBox6.AccessibleName = resources.GetString("textBox6.AccessibleName");
			this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBox6.Anchor")));
			this.textBox6.AutoSize = ((bool)(resources.GetObject("textBox6.AutoSize")));
			this.textBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox6.BackgroundImage")));
			this.textBox6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBox6.Dock")));
			this.textBox6.Enabled = ((bool)(resources.GetObject("textBox6.Enabled")));
			this.textBox6.Font = ((System.Drawing.Font)(resources.GetObject("textBox6.Font")));
			this.textBox6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBox6.ImeMode")));
			this.textBox6.Location = ((System.Drawing.Point)(resources.GetObject("textBox6.Location")));
			this.textBox6.MaxLength = ((int)(resources.GetObject("textBox6.MaxLength")));
			this.textBox6.Multiline = ((bool)(resources.GetObject("textBox6.Multiline")));
			this.textBox6.Name = "textBox6";
			this.textBox6.PasswordChar = ((char)(resources.GetObject("textBox6.PasswordChar")));
			this.textBox6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBox6.RightToLeft")));
			this.textBox6.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBox6.ScrollBars")));
			this.textBox6.Size = ((System.Drawing.Size)(resources.GetObject("textBox6.Size")));
			this.textBox6.TabIndex = ((int)(resources.GetObject("textBox6.TabIndex")));
			this.textBox6.Text = resources.GetString("textBox6.Text");
			this.textBox6.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBox6.TextAlign")));
			this.textBox6.Visible = ((bool)(resources.GetObject("textBox6.Visible")));
			this.textBox6.WordWrap = ((bool)(resources.GetObject("textBox6.WordWrap")));
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// SMTPSettings
			// 
			this.AcceptButton = this.btnOK;
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.CancelButton = this.btnCancel;
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "SMTPSettings";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.SMTPSettings_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.GroupBox8.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private int _editing=-1;
		public ArrayList m_smtpServers = new ArrayList();

		private void RefresList()
		{
			listView1.Items.Clear();
			ListViewItem itm;
			int i = 0;
			foreach(SMTPServer svr in m_smtpServers)
			{
				i++;
				svr.HostID = i;
				itm = listView1.Items.Add(i.ToString());
				itm.SubItems.Add(svr.Host);
			}
			_editing = -1;
			ClearFields();
			panel2.Enabled = false;
		}

		private void SMTPSettings_Load(object sender, System.EventArgs e)
		{
			RefresList();
		}
		
		private void SaveEdit()
		{
			if(_editing!=-1)
			{
				SMTPServer svr = (SMTPServer) m_smtpServers[_editing];
				svr.Host = textBox6.Text.Trim();
				svr.Port = (int) numericUpDown1.Value;
				svr.IfAuth = CheckBox3.Checked;
				svr.UserID = TextBox13.Text.Trim();
				svr.Password = TextBox12.Text;
				svr.IfLimit = checkBox1.Checked;
				svr.NrPerSession = (int) numericUpDown2.Value;
				svr.IfSpecifySender = checkBox2.Checked;
				svr.SenderEmail = txtFromEmail.Text.Trim();
				svr.SenderName = txtFromName.Text.Trim();
				svr.ReplyEmail = txtReply.Text.Trim();
				svr.Enabled = checkBox4.Checked;
				m_smtpServers[_editing] = svr;
			}
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SaveEdit();
			if (listView1.SelectedItems.Count>0)
			{
				int index = listView1.SelectedItems[0].Index;
				SMTPServer svr = (SMTPServer) m_smtpServers[index];
				textBox6.Text = svr.Host;
				numericUpDown1.Value = svr.Port;
				CheckBox3.Checked = svr.IfAuth;
				TextBox13.Text = svr.UserID;
				TextBox12.Text = svr.Password;
				checkBox1.Checked = svr.IfLimit;
				numericUpDown2.Value = svr.NrPerSession;
				checkBox2.Checked = svr.IfSpecifySender;
				txtFromEmail.Text = svr.SenderEmail;
				txtFromName.Text = svr.SenderName;
				txtReply.Text = svr.ReplyEmail;
				checkBox4.Checked = svr.Enabled;
				panel2.Enabled = true;
				_editing = index;
			}
			else
			{
				_editing = -1;
				ClearFields();
				panel2.Enabled = false;
			}
		}

		private void ClearFields()
		{
			int old = _editing;
			_editing = -1;
			textBox6.Text = "";
			numericUpDown1.Value = 25;
			CheckBox3.Checked = false;
			TextBox13.Text = "";
			TextBox12.Text = "";
			checkBox1.Checked = false;
			numericUpDown2.Value = 1;
			checkBox2.Checked = false;
			txtFromEmail.Text = "";
			txtFromName.Text = "";
			txtReply.Text = "";
			checkBox4.Checked = true;
			_editing = old;
		}
		
		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			SaveEdit();
			SMTPServer svr = new SMTPServer();
			_editing = m_smtpServers.Add(svr);
			svr.HostID = _editing + 1;
			panel2.Enabled = true;
			ClearFields();
			ListViewItem itm = listView1.Items.Add((listView1.Items.Count + 1).ToString());
			itm.SubItems.Add("");
			itm.Selected = true;
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if(listView1.SelectedItems.Count>0)
			{
				m_smtpServers.RemoveAt(_editing);
				_editing = -1;
				listView1.SelectedItems.Clear();
				RefresList();
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			SaveEdit();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void textBox6_TextChanged(object sender, System.EventArgs e)
		{
			if(_editing!=-1)
				listView1.Items[_editing].SubItems[1].Text = textBox6.Text;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void CheckBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			GroupBox8.Enabled = CheckBox3.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			groupBox1.Enabled = checkBox2.Checked;
		}
	}
}
