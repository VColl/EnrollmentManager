namespace EnrollmentManager.WinFormsApp.Components
{
    partial class FilePathView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.btRefreshFile = new System.Windows.Forms.Button();
            this.btOpenFileDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(72, 10);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(395, 20);
            this.tbFilePath.TabIndex = 0;
            // 
            // lbFilePath
            // 
            this.lbFilePath.Location = new System.Drawing.Point(-3, 6);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(69, 29);
            this.lbFilePath.TabIndex = 1;
            this.lbFilePath.Text = "File Path:";
            this.lbFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btRefreshFile
            // 
            this.btRefreshFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefreshFile.Image = global::EnrollmentManager.WinFormsApp.Properties.Resources.icons8_available_updates_16;
            this.btRefreshFile.Location = new System.Drawing.Point(503, 8);
            this.btRefreshFile.Name = "btRefreshFile";
            this.btRefreshFile.Size = new System.Drawing.Size(24, 24);
            this.btRefreshFile.TabIndex = 2;
            this.btRefreshFile.UseVisualStyleBackColor = true;
            // 
            // btOpenFileDialog
            // 
            this.btOpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenFileDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btOpenFileDialog.Image = global::EnrollmentManager.WinFormsApp.Properties.Resources.icons8_folder_16;
            this.btOpenFileDialog.Location = new System.Drawing.Point(473, 8);
            this.btOpenFileDialog.Name = "btOpenFileDialog";
            this.btOpenFileDialog.Size = new System.Drawing.Size(24, 24);
            this.btOpenFileDialog.TabIndex = 2;
            this.btOpenFileDialog.UseVisualStyleBackColor = false;
            // 
            // FilePathView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRefreshFile);
            this.Controls.Add(this.btOpenFileDialog);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.tbFilePath);
            this.MaximumSize = new System.Drawing.Size(10000, 40);
            this.MinimumSize = new System.Drawing.Size(0, 40);
            this.Name = "FilePathView";
            this.Size = new System.Drawing.Size(538, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.Button btOpenFileDialog;
        private System.Windows.Forms.Button btRefreshFile;
    }
}
