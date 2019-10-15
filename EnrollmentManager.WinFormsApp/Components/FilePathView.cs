﻿using EnrollmentManager.InterfaceBusiness.Boundary.Views;
using System;
using System.Windows.Forms;

namespace EnrollmentManager.WinFormsApp.Components
{
    public partial class FilePathView : UserControl, IFilePathView
    {
        public IMainView ParentView { get; set; }
        public Action LoadFile { get; set; }

        public string FilePath
        {
            get => tbFilePath.Text;
            set => tbFilePath.Text = value;
        }

        public string Label
        {
            get => lbFilePath.Text;
            set => lbFilePath.Text = value;
        }

        public FilePathView()
        {
            InitializeComponent();

            btOpenFileDialog.Click += (obj, args) => OpenFileDialog();

            tbFilePath.KeyDown += (obj, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                    LoadFile?.Invoke();
            };
        }

        private void OpenFileDialog()
        {
            var dialog = new OpenFileDialog();

            try
            {
                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                tbFilePath.Text = dialog.FileName;
                LoadFile?.Invoke();
            }
            finally
            {
                dialog.Dispose();
            }
        }
    }
}
