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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Checked");
            }
            //string value = departmentComboBox.Text;
            //MessageBox.Show(value, "Department Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
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

            //departmentComboBox.DataSource = departmentList;

            //departmentComboBox.Items.Add("Physics");
            //departmentComboBox.Items.Add("Chemistry");
            //departmentComboBox.Items.Add("Biochemistry");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
