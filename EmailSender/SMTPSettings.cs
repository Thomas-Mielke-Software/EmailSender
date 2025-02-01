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
        private Label label4;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMTPSettings));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label4 = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFromName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtReply);
            this.groupBox1.Controls.Add(this.txtFromEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            // txtReply
            // 
            resources.ApplyResources(this.txtReply, "txtReply");
            this.txtReply.Name = "txtReply";
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
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.Name = "numericUpDown2";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckBox3
            // 
            resources.ApplyResources(this.CheckBox3, "CheckBox3");
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.Label14);
            this.GroupBox8.Controls.Add(this.TextBox12);
            this.GroupBox8.Controls.Add(this.Label15);
            this.GroupBox8.Controls.Add(this.TextBox13);
            this.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.GroupBox8, "GroupBox8");
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.TabStop = false;
            // 
            // Label14
            // 
            resources.ApplyResources(this.Label14, "Label14");
            this.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label14.Name = "Label14";
            // 
            // TextBox12
            // 
            resources.ApplyResources(this.TextBox12, "TextBox12");
            this.TextBox12.Name = "TextBox12";
            // 
            // Label15
            // 
            resources.ApplyResources(this.Label15, "Label15");
            this.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label15.Name = "Label15";
            // 
            // TextBox13
            // 
            resources.ApplyResources(this.TextBox13, "TextBox13");
            this.TextBox13.Name = "TextBox13";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SMTPSettings
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SMTPSettings";
            this.Load += new System.EventHandler(this.SMTPSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
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
                svr.StartTls = checkBox1.Checked;
                svr.UserID = TextBox13.Text.Trim();
				svr.Password = TextBox12.Text;
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
				checkBox1.Checked = svr.StartTls;
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
		    if (checkBox1.Checked)
                numericUpDown1.Value = 587;
            else
                numericUpDown1.Value = 465;
        }

		private void CheckBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			GroupBox8.Enabled = CheckBox3.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			groupBox1.Enabled = checkBox2.Checked;
		}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
