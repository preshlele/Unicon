using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxusername.Text == "le" && textBoxpass.Text == "123")
            {
                MessageBox.Show("login successful");
                this.Hide();
                var al = new add();
                al.ShowDialog();
            }
            else
            {
                MessageBox.Show("wrong credentials", "warning");
            }
        }
    }
}
