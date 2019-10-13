namespace EnrollmentManager.WinFormsApp
{
    partial class MainView
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
            this.actionsView1 = new EnrollmentManager.WinFormsApp.Components.ActionsView();
            this.filePathView1 = new EnrollmentManager.WinFormsApp.Components.FilePathView();
            this.filePathView2 = new EnrollmentManager.WinFormsApp.Components.FilePathView();
            this.inputFileView = new EnrollmentManager.WinFormsApp.Components.FileView();
            this.outputFileView = new EnrollmentManager.WinFormsApp.Components.FileView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsView1
            // 
            this.actionsView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsView1.Location = new System.Drawing.Point(0, 405);
            this.actionsView1.MaximumSize = new System.Drawing.Size(10000, 45);
            this.actionsView1.MinimumSize = new System.Drawing.Size(193, 45);
            this.actionsView1.Name = "actionsView1";
            this.actionsView1.Size = new System.Drawing.Size(800, 45);
            this.actionsView1.TabIndex = 0;
            // 
            // filePathView1
            // 
            this.filePathView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePathView1.Location = new System.Drawing.Point(0, 0);
            this.filePathView1.MaximumSize = new System.Drawing.Size(10000, 40);
            this.filePathView1.MinimumSize = new System.Drawing.Size(0, 40);
            this.filePathView1.Name = "filePathView1";
            this.filePathView1.Size = new System.Drawing.Size(369, 40);
            this.filePathView1.TabIndex = 1;
            // 
            // filePathView2
            // 
            this.filePathView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePathView2.Location = new System.Drawing.Point(0, 0);
            this.filePathView2.MaximumSize = new System.Drawing.Size(10000, 40);
            this.filePathView2.MinimumSize = new System.Drawing.Size(0, 40);
            this.filePathView2.Name = "filePathView2";
            this.filePathView2.Size = new System.Drawing.Size(427, 40);
            this.filePathView2.TabIndex = 2;
            // 
            // inputFileView
            // 
            this.inputFileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFileView.Location = new System.Drawing.Point(0, 40);
            this.inputFileView.Name = "inputFileView";
            this.inputFileView.Size = new System.Drawing.Size(369, 365);
            this.inputFileView.TabIndex = 3;
            // 
            // outputFileView
            // 
            this.outputFileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputFileView.Location = new System.Drawing.Point(0, 40);
            this.outputFileView.Name = "outputFileView";
            this.outputFileView.Size = new System.Drawing.Size(427, 365);
            this.outputFileView.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.inputFileView);
            this.splitContainer.Panel1.Controls.Add(this.filePathView1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.outputFileView);
            this.splitContainer.Panel2.Controls.Add(this.filePathView2);
            this.splitContainer.Size = new System.Drawing.Size(800, 405);
            this.splitContainer.SplitterDistance = 369;
            this.splitContainer.TabIndex = 5;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.actionsView1);
            this.Name = "MainView";
            this.Text = "Enrollment Manager";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ActionsView actionsView1;
        private Components.FilePathView filePathView1;
        private Components.FilePathView filePathView2;
        private Components.FileView inputFileView;
        private Components.FileView outputFileView;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}

