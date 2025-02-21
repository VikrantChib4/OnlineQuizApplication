namespace OnlineQuiz.Teacher_ctrl
{
    partial class uc_studentresult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_studentresult));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsync = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxstud = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
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
            this.btnsync.Location = new System.Drawing.Point(800, 9);
            this.btnsync.Name = "btnsync";
            this.btnsync.Size = new System.Drawing.Size(76, 45);
            this.btnsync.TabIndex = 2;
            // 
            // comboBoxstud
            // 
            this.comboBoxstud.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxstud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxstud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxstud.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxstud.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxstud.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxstud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxstud.ItemHeight = 30;
            this.comboBoxstud.Location = new System.Drawing.Point(41, 93);
            this.comboBoxstud.Name = "comboBoxstud";
            this.comboBoxstud.Size = new System.Drawing.Size(246, 36);
            this.comboBoxstud.TabIndex = 3;
            this.comboBoxstud.SelectedIndexChanged += new System.EventHandler(this.comboBoxstud_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Location = new System.Drawing.Point(41, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 404);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_studentresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxstud);
            this.Controls.Add(this.btnsync);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_studentresult";
            this.Size = new System.Drawing.Size(1366, 582);
            this.Load += new System.EventHandler(this.uc_studentresult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnsync;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxstud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
