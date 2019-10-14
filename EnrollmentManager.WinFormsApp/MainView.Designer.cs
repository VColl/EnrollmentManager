﻿namespace EnrollmentManager.WinFormsApp
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
            this.actionsView = new EnrollmentManager.WinFormsApp.Components.ActionsView();
            this.inputFilePathView = new EnrollmentManager.WinFormsApp.Components.FilePathView();
            this.outputFilePathView = new EnrollmentManager.WinFormsApp.Components.FilePathView();
            this.inputFileView = new EnrollmentManager.WinFormsApp.Components.FileView();
            this.outputFileView = new EnrollmentManager.WinFormsApp.Components.FileView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsView
            // 
            this.actionsView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsView.Location = new System.Drawing.Point(0, 405);
            this.actionsView.MaximumSize = new System.Drawing.Size(10000, 45);
            this.actionsView.MinimumSize = new System.Drawing.Size(193, 45);
            this.actionsView.Name = "actionsView";
            this.actionsView.Size = new System.Drawing.Size(800, 45);
            this.actionsView.TabIndex = 0;
            // 
            // inputFilePathView
            // 
            this.inputFilePathView.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputFilePathView.Label = "Entrada:";
            this.inputFilePathView.Location = new System.Drawing.Point(5, 0);
            this.inputFilePathView.MaximumSize = new System.Drawing.Size(10000, 40);
            this.inputFilePathView.MinimumSize = new System.Drawing.Size(0, 40);
            this.inputFilePathView.Name = "inputFilePathView";
            this.inputFilePathView.Size = new System.Drawing.Size(364, 40);
            this.inputFilePathView.TabIndex = 0;
            // 
            // outputFilePathView
            // 
            this.outputFilePathView.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputFilePathView.Label = "Saída:";
            this.outputFilePathView.Location = new System.Drawing.Point(0, 0);
            this.outputFilePathView.MaximumSize = new System.Drawing.Size(10000, 40);
            this.outputFilePathView.MinimumSize = new System.Drawing.Size(0, 40);
            this.outputFilePathView.Name = "outputFilePathView";
            this.outputFilePathView.Size = new System.Drawing.Size(422, 40);
            this.outputFilePathView.TabIndex = 1;
            // 
            // inputFileView
            // 
            this.inputFileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFileView.Location = new System.Drawing.Point(5, 40);
            this.inputFileView.Name = "inputFileView";
            this.inputFileView.Size = new System.Drawing.Size(364, 365);
            this.inputFileView.TabIndex = 3;
            // 
            // outputFileView
            // 
            this.outputFileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputFileView.Location = new System.Drawing.Point(0, 40);
            this.outputFileView.Name = "outputFileView";
            this.outputFileView.Size = new System.Drawing.Size(422, 365);
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
            this.splitContainer.Panel1.Controls.Add(this.inputFilePathView);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.outputFileView);
            this.splitContainer.Panel2.Controls.Add(this.outputFilePathView);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
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
            this.Controls.Add(this.actionsView);
            this.Name = "MainView";
            this.Text = "Enrollment Manager";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ActionsView actionsView;
        private Components.FilePathView inputFilePathView;
        private Components.FilePathView outputFilePathView;
        private Components.FileView inputFileView;
        private Components.FileView outputFileView;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}

