using OnlineQuiz.Teacher_ctrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineQuiz
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            error.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void slctUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (slctUser.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else if (slctUser.SelectedIndex == 1)
            {
                panel1.Visible = false;
                panel2.Visible = true;

            }
        }

        private void viewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (viewPass.Checked == true)
            {
                userPass.PasswordChar = '\0';
                viewPass.Text = "Hide Password";
            }
            else
            {
                userPass.PasswordChar = '*';
                viewPass.Text = "Show Password";
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (userName.Text == "vikrant" && userPass.Text == "22bcs50099")
            {
                error.Visible = false;
                Teacher te = new Teacher();
                te.Show();
                this.Hide();
            }
            else
            {
                error.Visible = true;
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
        private void sRegister_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
        }

        private void btnstudentlogin_Click(object sender, EventArgs e)
        {
            string rollno = enrollment.Text.Trim();

            if (enrollment.Text == "")
            {
                MessageBox.Show("Please fill all the detail", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                query = "SELECT * FROM details WHERE rollno = '" + enrollment.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    // Show success message and proceed to 'Exam' form (assuming it exists)                   
                    string rollNo = ds.Tables[0].Rows[0]["rollno"].ToString();

                    // Show success message and proceed to 'Exam' form with roll number
                    MessageBox.Show("Login successful!");
                    Exam examForm = new Exam(rollNo); // Pass the roll number to the Exam form
                    examForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("No data found for the entered enrollment number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


