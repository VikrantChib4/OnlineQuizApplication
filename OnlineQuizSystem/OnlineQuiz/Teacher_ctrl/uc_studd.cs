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
    public partial class uc_studd : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        int rollno;
        string name;
        public uc_studd()
        {
            InitializeComponent();
        }

        private void uc_studd_Load(object sender, EventArgs e)
        {
            comboBoxstud.Items.Clear();
            comboBoxstud.Items.Add("All Student Names");
            query = "select distinct name from details";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBoxstud.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            uc_studd_Load(this, null);
        }

        private void comboBoxstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxstud.SelectedIndex != 0)
            {
                query = $"SELECT rollno, name, fname,mname, gender, contactno, address FROM details WHERE name = '{comboBoxstud.Text}'";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "SELECT rollno, name, fname, gender, contactno, address FROM details";
                DataSet ds = fn.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rollno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch
            {

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = $"DELETE FROM details WHERE rollno = '{rollno}'; DELETE FROM students WHERE rollno = '{rollno}'";
                fn.setData(query, "Record Information Deleted.");

                uc_studd_Load(this, null);
            }
        }
    }
}
