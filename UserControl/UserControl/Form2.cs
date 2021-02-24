using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> departmentList = new List<string>();
            departmentList.Add("CSE");
            departmentList.Add("EEE");
            departmentList.Add("CE");
            departmentList.Add("ME");
            departmentList.Add("ENG");
            departmentList.Sort();

            foreach (var data in departmentList)
            {
                departmentComboBox.Items.Add(data);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string value = departmentComboBox.Text;
            departmentListBox.Items.Add(value);
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = departmentComboBox.Text;
            MessageBox.Show(value);
        }
    }
}
