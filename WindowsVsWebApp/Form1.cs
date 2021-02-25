using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsVsWebApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string name;
        private void saveButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            nameTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = name;
        }
    }
}
