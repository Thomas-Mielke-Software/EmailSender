//////////////////////////////////////////////////////////////////////
/////
/////  An open source project developped by a man
/////  Copyright (C) 2005  Vincent Magiya
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
/////////////////////////////////////////////////////////////////////////
///using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EmailSender
{
	/// <summary>
	/// Summary description for FrmFind.
	/// </summary>
	public class FrmFind : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmFind()
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(268, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// btnFind
			// 
			this.btnFind.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnFind.Location = new System.Drawing.Point(312, 28);
			this.btnFind.Name = "btnFind";
			this.btnFind.TabIndex = 1;
			this.btnFind.Text = "Find";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancel.Location = new System.Drawing.Point(312, 60);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(24, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Find what?";
			// 
			// FrmFind
			// 
			this.AcceptButton = this.btnFind;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(400, 99);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmFind";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Find";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion
	}
}
