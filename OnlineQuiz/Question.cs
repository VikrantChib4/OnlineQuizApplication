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
    public partial class Question : Form
    {
        string RollNo;
        function fn = new function();
        String query;
        DataSet ds;
        Timer timer;
        DataTable shuffledQuestions;
        int currentQuestion = 1;
        int totalQuestions = 10;
        int currentShift = 1;
        int remainingTime = 600;
        int score = 0;


        public Question(string studentRollNo)
        {
            InitializeComponent();
            RollNo = studentRollNo;
            CheckUserLimit();
            PopulateComboBox();
            ShuffleQuestions();
            InitializeTimer();


        }
        private void CheckUserLimit()
        {
            query = "SELECT COUNT(*) FROM students WHERE examstatus = 1";
            ds = fn.GetData(query);
            int currentUsers = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            if (currentUsers >= 5)
            {
                MessageBox.Show("Maximum number of students are already taking the exam. Please wait.");
                this.Close();
                return;
            }
            else
            {
                query = $"UPDATE students SET examstatus = 1 WHERE rollno = '{RollNo}'";
                fn.setData(query, "You entered the exam");

            }
        }

        private void PopulateComboBox()
        {
            query = "SELECT DISTINCT qset FROM questions";
            ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    comboBoxChange.Items.Add(row["qset"].ToString());
                }
            }

            if (comboBoxChange.Items.Count > 0)
            {
                comboBoxChange.SelectedIndex = 0;

            }
        }

        private void UpdateTimeLabel()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
            txttimer.Text = $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
        }

        private void ShuffleQuestions()
        {
            query = $"SELECT * FROM questions WHERE qset = {currentShift}";
            ds = fn.GetData(query);

            shuffledQuestions = ds.Tables[0].Clone();
            Random rnd = new Random();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataRow newRow = shuffledQuestions.NewRow();
                newRow.ItemArray = row.ItemArray.Clone() as object[];
                int index = rnd.Next(shuffledQuestions.Rows.Count + 1);
                shuffledQuestions.Rows.InsertAt(newRow, index);
            }

            LoadQuestion(currentQuestion);

        }
        private void LoadQuestion(int questionNumber)
        {
            if (questionNumber <= shuffledQuestions.Rows.Count)
            {
                DataRow row = shuffledQuestions.Rows[questionNumber - 1];
                qnonlabel.Text = $"{questionNumber}";
                questionlabel.Text = row["question"].ToString();
                option1.Text = row["optionA"].ToString();
                option2.Text = row["optionB"].ToString();
                option3.Text = row["optionC"].ToString();
                option4.Text = row["optionD"].ToString();
            }
            else
            {
                MessageBox.Show("No more questions available.");
            }

        }

        private void CheckAnswer()
        {
            string selectedOptionText = null;
            if (option1.Checked) selectedOptionText = option1.Text;
            else if (option2.Checked) selectedOptionText = option2.Text;
            else if (option3.Checked) selectedOptionText = option3.Text;
            else if (option4.Checked) selectedOptionText = option4.Text;

            if (selectedOptionText != null)
            {
                DataRow row = shuffledQuestions.Rows[currentQuestion - 1];
                string correctAnswerText = row["ans"].ToString();

                if (selectedOptionText.Equals(correctAnswerText, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }

        }

        private void AutoSubmit()
        {
            MessageBox.Show("Time's up! Your quiz will be submitted automatically.");
            SubmitQuiz();

        }

        private void SubmitQuiz()
        {
            CheckAnswer(); // Ensure the last question's answer is checked before submission

            query = $"UPDATE students SET marksobtained = {score}, examstatus = 0 WHERE rollno = '{RollNo}'";
            fn.setData(query, "Updated Score");

            query = $"SELECT marksobtained FROM students WHERE rollno = '{RollNo}'";
            ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string retrievedScore = ds.Tables[0].Rows[0]["marksobtained"].ToString();
                Score scoreForm = new Score(retrievedScore);
                scoreForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error retrieving the score from the database.");
            }

        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += timer1_Tick;
            timer.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                UpdateTimeLabel();
            }
            else
            {
                timer.Stop();
                AutoSubmit();
            }

        }


        private void Question_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (IsOptionSelected())
            {
                CheckAnswer();
                if (currentQuestion < totalQuestions)
                {
                    currentQuestion++;
                    LoadQuestion(currentQuestion);
                }
                else
                {
                    MessageBox.Show("You have answered all questions.");
                    SubmitQuiz(); // Automatically submit the quiz after the last question
                }
            }
            else
            {
                MessageBox.Show("Please select an option before proceeding to the next question.");
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (IsOptionSelected())
            {
                SubmitQuiz();
            }
            else
            {
                MessageBox.Show("Please select an option before submitting.");
            }

        }
        private bool IsOptionSelected()
        {
            return option1.Checked || option2.Checked || option3.Checked || option4.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 1)
            {
                currentQuestion--;
                LoadQuestion(currentQuestion);
            }
            else if (currentShift > 1)
            {
                // If it's the first question in the current shift, go to the last question of the previous shift
                currentShift--;
                currentQuestion = totalQuestions; // Assuming there are 10 questions per shift
                LoadQuestion(currentQuestion);
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiz submitted because of interruption");
            SubmitQuiz();

        }

        private void comboBoxChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChange.SelectedItem != null)
                {
                    currentShift = int.Parse(comboBoxChange.SelectedItem.ToString());
                    currentQuestion = 1; // Reset question number for the new shift
                    ShuffleQuestions();
                }

            }
        }
}


