using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OnlineQuiz.Teacher_ctrl
{

    public partial class Student : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Student()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void clearAll()
        {
            txtenroll.Clear();
            txtname.Clear();
            txtfname.Clear();
            txtmname.Clear();
            txtgender.Clear();
            txtcontact.Clear();
            txtaddress.Clear();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            String rollno = txtenroll.Text;
            String name = txtname.Text;
            String fname = txtfname.Text;
            String mname = txtmname.Text;
            String gender = txtgender.Text;
            String contactno = txtcontact.Text;
            String address = txtaddress.Text;


            query = "insert into details (rollno,name,fname,mname,gender,contactno,address) values('" + rollno + "','" + name + "','" + fname + "','" + mname + "','" + gender + "','" + contactno + "','" + address + "')";
            fn.setData(query, "Registration Successfull.");
            query = "insert into students (rollno,name,fname,gender,contactno) values('" + rollno + "','" + name + "','" + fname + "','" + gender + "','" + contactno + "')";
            fn.setData(query, "Done");
            clearAll();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
