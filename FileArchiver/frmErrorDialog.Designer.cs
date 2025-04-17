namespace FileArchiver
{
    partial class frmErrorDialog
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmdIgnore = new System.Windows.Forms.Button();
            this.cmdIgnoreAll = new System.Windows.Forms.Button();
            this.cmdAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(13, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(588, 83);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdIgnore
            // 
            this.cmdIgnore.Location = new System.Drawing.Point(477, 95);
            this.cmdIgnore.Name = "cmdIgnore";
            this.cmdIgnore.Size = new System.Drawing.Size(123, 23);
            this.cmdIgnore.TabIndex = 1;
            this.cmdIgnore.Text = "Ignore and Continue";
            this.cmdIgnore.UseVisualStyleBackColor = true;
            this.cmdIgnore.Click += new System.EventHandler(this.cmdIgnore_Click);
            // 
            // cmdIgnoreAll
            // 
            this.cmdIgnoreAll.Location = new System.Drawing.Point(340, 95);
            this.cmdIgnoreAll.Name = "cmdIgnoreAll";
            this.cmdIgnoreAll.Size = new System.Drawing.Size(123, 23);
            this.cmdIgnoreAll.TabIndex = 2;
            this.cmdIgnoreAll.Text = "Ignore All Errors";
            this.cmdIgnoreAll.UseVisualStyleBackColor = true;
            this.cmdIgnoreAll.Click += new System.EventHandler(this.cmdIgnoreAll_Click);
            // 
            // cmdAbort
            // 
            this.cmdAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAbort.Location = new System.Drawing.Point(251, 95);
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(75, 23);
            this.cmdAbort.TabIndex = 3;
            this.cmdAbort.Text = "Abort Scan";
            this.cmdAbort.UseVisualStyleBackColor = true;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click);
            // 
            // frmErrorDialog
            // 
            this.AcceptButton = this.cmdIgnore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdAbort;
            this.ClientSize = new System.Drawing.Size(612, 129);
            this.Controls.Add(this.cmdAbort);
            this.Controls.Add(this.cmdIgnoreAll);
            this.Controls.Add(this.cmdIgnore);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmErrorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdIgnore;
        private System.Windows.Forms.Button cmdIgnoreAll;
        private System.Windows.Forms.Button cmdAbort;
        public System.Windows.Forms.Label lblMessage;
    }
}