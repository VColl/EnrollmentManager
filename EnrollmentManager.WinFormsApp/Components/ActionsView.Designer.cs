namespace EnrollmentManager.WinFormsApp.Components
{
    partial class ActionsView
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
            this.btGenerate = new System.Windows.Forms.Button();
            this.tbVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGenerate
            // 
            this.btGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGenerate.Image = global::EnrollmentManager.WinFormsApp.Properties.Resources.icons8_play_16;
            this.btGenerate.Location = new System.Drawing.Point(512, 10);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(80, 25);
            this.btGenerate.TabIndex = 0;
            this.btGenerate.Text = "Gerar";
            this.btGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGenerate.UseVisualStyleBackColor = true;
            // 
            // tbVerify
            // 
            this.tbVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVerify.Image = global::EnrollmentManager.WinFormsApp.Properties.Resources.icons8_checkmark_16;
            this.tbVerify.Location = new System.Drawing.Point(598, 10);
            this.tbVerify.Name = "tbVerify";
            this.tbVerify.Size = new System.Drawing.Size(80, 25);
            this.tbVerify.TabIndex = 0;
            this.tbVerify.Text = "Verificar";
            this.tbVerify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbVerify.UseVisualStyleBackColor = true;
            // 
            // ActionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.tbVerify);
            this.MaximumSize = new System.Drawing.Size(10000, 45);
            this.MinimumSize = new System.Drawing.Size(193, 45);
            this.Name = "ActionsView";
            this.Size = new System.Drawing.Size(690, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbVerify;
        private System.Windows.Forms.Button btGenerate;
    }
}
