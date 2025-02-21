namespace OnlineQuiz.Teacher_ctrl
{
    partial class uc_studd
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_studd));
            this.comboBoxstud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnsync = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxstud
            // 
            this.comboBoxstud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxstud.FormattingEnabled = true;
            this.comboBoxstud.Location = new System.Drawing.Point(9, 93);
            this.comboBoxstud.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxstud.Name = "comboBoxstud";
            this.comboBoxstud.Size = new System.Drawing.Size(479, 28);
            this.comboBoxstud.TabIndex = 43;
            this.comboBoxstud.SelectedIndexChanged += new System.EventHandler(this.comboBoxstud_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Student Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 49);
            this.label1.TabIndex = 41;
            this.label1.Text = "Student Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(25, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 446);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BorderRadius = 20;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.FillColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btndelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btndelete.Location = new System.Drawing.Point(1185, 77);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(151, 45);
            this.btndelete.TabIndex = 46;
            this.btndelete.Text = "Delete   ";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsync
            // 
            this.btnsync.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsync.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsync.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsync.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsync.FillColor = System.Drawing.Color.Transparent;
            this.btnsync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsync.ForeColor = System.Drawing.Color.White;
            this.btnsync.Image = ((System.Drawing.Image)(resources.GetObject("btnsync.Image")));
            this.btnsync.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsync.Location = new System.Drawing.Point(832, 16);
            this.btnsync.Name = "btnsync";
            this.btnsync.Size = new System.Drawing.Size(76, 45);
            this.btnsync.TabIndex = 47;
            this.btnsync.Click += new System.EventHandler(this.btnsync_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_studd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsync);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxstud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_studd";
            this.Size = new System.Drawing.Size(1366, 582);
            this.Load += new System.EventHandler(this.uc_studd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxstud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnsync;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
