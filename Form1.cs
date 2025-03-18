using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessData_Click(object sender, EventArgs e)
        {
            // Simulate data processing
            MessageBox.Show("Processing data...");
        }
    }
}
