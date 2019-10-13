namespace EnrollmentManager.WinFormsApp.Components
{
    partial class FileView
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
            this.gbFileContent = new System.Windows.Forms.GroupBox();
            this.tbFileContent = new System.Windows.Forms.TextBox();
            this.gbFileContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFileContent
            // 
            this.gbFileContent.Controls.Add(this.tbFileContent);
            this.gbFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFileContent.Location = new System.Drawing.Point(0, 0);
            this.gbFileContent.Name = "gbFileContent";
            this.gbFileContent.Size = new System.Drawing.Size(710, 551);
            this.gbFileContent.TabIndex = 0;
            this.gbFileContent.TabStop = false;
            // 
            // tbFileContent
            // 
            this.tbFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileContent.Location = new System.Drawing.Point(3, 16);
            this.tbFileContent.Multiline = true;
            this.tbFileContent.Name = "tbFileContent";
            this.tbFileContent.Size = new System.Drawing.Size(704, 532);
            this.tbFileContent.TabIndex = 0;
            // 
            // FileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFileContent);
            this.Name = "FileView";
            this.Size = new System.Drawing.Size(710, 551);
            this.gbFileContent.ResumeLayout(false);
            this.gbFileContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFileContent;
        private System.Windows.Forms.TextBox tbFileContent;
    }
}
