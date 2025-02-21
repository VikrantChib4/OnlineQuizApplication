using System;
using System.Collections;
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
    public partial class uc_studentresult : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public uc_studentresult()
        {
            InitializeComponent();
        }

       
        private void uc_studentresult_Load(object sender, EventArgs e)
        {
            comboBoxstud.Items.Add("All Students Name");

            // Query to fetch all student names
            query = "SELECT name FROM students";
            ds = fn.GetData(query);

            // Populate combobox with student names
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comboBoxstud.Items.Add(row["name"].ToString());
            }
        }

        private void comboBoxstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxstud.SelectedIndex > 0)
            {
                // Get selected student name
                string selectedName = comboBoxstud.SelectedItem.ToString();

                // Query to fetch student details based on selected name
                query = $"SELECT rollno, name, fname, gender, contactno, marksobtained,examstatus FROM students WHERE name = '{selectedName}'";
            }
            else
            {
                // Query to fetch all students' details
                query = "SELECT rollno, name, fname, gender, contactno, marksobtained,examstatus FROM students";
            }

            // Execute the query and bind results to DataGridView
            ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int rollno = Convert.ToInt32(selectedRow.Cells["rollno"].Value);
                string name = selectedRow.Cells["name"].Value.ToString();

                // Example: Use the values as needed
                MessageBox.Show($"Clicked on Roll No. {rollno}, Name: {name}");
            }
        }
    }
}
