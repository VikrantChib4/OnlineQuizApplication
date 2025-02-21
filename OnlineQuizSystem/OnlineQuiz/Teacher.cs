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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = false;
            uC_UpdateQuestions1.Visible = false;
            uC_ViewDeleteQuestion1.Visible = false;
            uc_studentresult2.Visible = false;
            uc_studd1.Visible = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = true;
            uC_AddNewQuestion1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            uC_UpdateQuestions1.Visible = true;
            uC_UpdateQuestions1.BringToFront();
        }

        private void btnViewDeleteQuestions_Click(object sender, EventArgs e)
        {
            uC_ViewDeleteQuestion1.Visible = true;
            uC_ViewDeleteQuestion1.BringToFront();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            uc_studentresult2.Visible = true;
            uc_studentresult2.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            uc_studd1.Visible = true;
            uc_studd1.BringToFront();
        }
    }
    }

