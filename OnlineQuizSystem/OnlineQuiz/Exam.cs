using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineQuiz.Teacher_ctrl
{
    public partial class Exam : Form
    {
        private string studentRollNo;

        // Constructor with rollNo parameter
        public Exam(string rollNo)
        {
            InitializeComponent();
            studentRollNo = rollNo; // Set the roll number
        }

            private void Exam_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            Question q = new Question(studentRollNo);
            q.Show();
            this.Hide();
        }
    }
}
