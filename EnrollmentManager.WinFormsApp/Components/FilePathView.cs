using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentManager.WinFormsApp.Components
{
    public partial class FilePathView : UserControl
    {
        public string Label
        {
            get => lbFilePath.Text;
            set => lbFilePath.Text = value;
        }

        public FilePathView()
        {
            InitializeComponent();
        }
    }
}
