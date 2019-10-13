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
            this.button2 = new System.Windows.Forms.Button();
            this.tbValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::EnrollmentManager.WinFormsApp.Properties.Resources.icons8_play_16;
            this.button2.Location = new System.Drawing.Point(512, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 0;
            this.button2.Text = "Gerar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbValidate
            // 
            this.tbValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValidate.Image = global::EnrollmentManager.WinFormsApp.Properties.Resources.icons8_checkmark_16;
            this.tbValidate.Location = new System.Drawing.Point(598, 10);
            this.tbValidate.Name = "tbValidate";
            this.tbValidate.Size = new System.Drawing.Size(80, 25);
            this.tbValidate.TabIndex = 0;
            this.tbValidate.Text = "Validar";
            this.tbValidate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbValidate.UseVisualStyleBackColor = true;
            // 
            // ActionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbValidate);
            this.MaximumSize = new System.Drawing.Size(10000, 45);
            this.MinimumSize = new System.Drawing.Size(193, 45);
            this.Name = "ActionsView";
            this.Size = new System.Drawing.Size(690, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbValidate;
        private System.Windows.Forms.Button button2;
    }
}
