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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            var database = new UnicomEntities();
            var mem = new Member();
            mem.FirstName = textBoxfname.Text;
            mem.LastName = textBoxlname.Text;
            mem.OtherName = textBoxonames.Text;
            mem.DateOfBirth = Convert.ToDateTime(dateTimePicker1.Text);
            mem.PhoneNumber = textBoxpnum.Text;
            mem.LocationAddress = textBoxlocad.Text;
            mem.ResidentialAddress = textBoxresad.Text;
            mem.Email = textBoxemail.Text;
            mem.City = textBoxcity.Text;
            mem.Country = textBoxcountry.Text;
            mem.Sex = radioButton1.Text;
            mem.Groupid = Convert.ToInt32(textBoxgroupid.Text);
            mem.Priorityid = int.Parse(textBoxpriorityid.Text);
          //  database.Members.Add(mem);

            //database.SaveChanges();


            if (textBoxfname.Text != "" && textBoxlname.Text != "" && textBoxgroupid.Text != "" && textBoxpriorityid.Text != "")
            {
                MessageBox.Show("Added successfully");
                database.Members.Add(mem);
                database.SaveChanges();
               


            }
          if  (textBoxfname.Text == "" && textBoxlname.Text == "" && textBoxgroupid.Text == "" && textBoxpriorityid.Text == "")
           {
                MessageBox.Show("PLEASE FILL ALL REQUIRED FIELDS", "WARNING");


            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var v = new view();
            v.ShowDialog();
            var database = new UnicomEntities();
           

            ;
        }
    }
}
