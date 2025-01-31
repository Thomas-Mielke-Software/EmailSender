namespace EmailSender
{
    partial class FrmDebug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDebug));
            this.uxCloseApp = new System.Windows.Forms.CheckBox();
            this.uxSendReport = new System.Windows.Forms.Button();
            this.uxReportText = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxCloseApp
            // 
            this.uxCloseApp.Checked = true;
            this.uxCloseApp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxCloseApp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxCloseApp.Location = new System.Drawing.Point(16, 67);
            this.uxCloseApp.Name = "uxCloseApp";
            this.uxCloseApp.Size = new System.Drawing.Size(120, 24);
            this.uxCloseApp.TabIndex = 7;
            this.uxCloseApp.Text = "Close application";
            // 
            // uxSendReport
            // 
            this.uxSendReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxSendReport.Image = ((System.Drawing.Image)(resources.GetObject("uxSendReport.Image")));
            this.uxSendReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxSendReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxSendReport.Location = new System.Drawing.Point(296, 67);
            this.uxSendReport.Name = "uxSendReport";
            this.uxSendReport.Size = new System.Drawing.Size(132, 23);
            this.uxSendReport.TabIndex = 4;
            this.uxSendReport.Text = "Report this problem";
            this.uxSendReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uxSendReport.Click += new System.EventHandler(this.uxSendReport_Click);
            // 
            // uxReportText
            // 
            this.uxReportText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxReportText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxReportText.Location = new System.Drawing.Point(16, 97);
            this.uxReportText.Multiline = true;
            this.uxReportText.Name = "uxReportText";
            this.uxReportText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxReportText.Size = new System.Drawing.Size(412, 82);
            this.uxReportText.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(16, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(412, 44);
            this.Label1.TabIndex = 5;
            this.Label1.Text = resources.GetString("Label1.Text");
            // 
            // uxCancel
            // 
            this.uxCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxCancel.Image = ((System.Drawing.Image)(resources.GetObject("uxCancel.Image")));
            this.uxCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxCancel.Location = new System.Drawing.Point(142, 68);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(128, 23);
            this.uxCancel.TabIndex = 8;
            this.uxCancel.Text = "Do not send report";
            this.uxCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 191);
            this.Controls.Add(this.uxCloseApp);
            this.Controls.Add(this.uxSendReport);
            this.Controls.Add(this.uxReportText);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.uxCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDebug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Error";
            this.Load += new System.EventHandler(this.FrmDebug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox uxCloseApp;
        internal System.Windows.Forms.Button uxSendReport;
        internal System.Windows.Forms.TextBox uxReportText;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button uxCancel;
    }
}