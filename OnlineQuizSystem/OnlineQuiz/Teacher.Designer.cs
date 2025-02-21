namespace OnlineQuiz
{
    partial class Teacher
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnResult = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewDeleteQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_studd1 = new OnlineQuiz.Teacher_ctrl.uc_studd();
            this.uc_studentresult2 = new OnlineQuiz.Teacher_ctrl.uc_studentresult();
            this.uC_ViewDeleteQuestion1 = new OnlineQuiz.Teacher_ctrl.UC_ViewDeleteQuestion();
            this.uC_UpdateQuestions1 = new OnlineQuiz.Teacher_ctrl.UC_UpdateQuestions();
            this.uC_AddNewQuestion1 = new OnlineQuiz.Teacher_ctrl.UC_AddNewQuestion();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btndetails);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Controls.Add(this.btnViewDeleteQuestions);
            this.panel1.Controls.Add(this.btnUpdateQuestion);
            this.panel1.Controls.Add(this.btnAddNewQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 185);
            this.panel1.TabIndex = 0;
            // 
            // btndetails
            // 
            this.btndetails.BackColor = System.Drawing.Color.Transparent;
            this.btndetails.BorderRadius = 20;
            this.btndetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btndetails.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btndetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btndetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btndetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndetails.FillColor = System.Drawing.Color.Transparent;
            this.btndetails.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetails.ForeColor = System.Drawing.Color.Black;
            this.btndetails.Image = ((System.Drawing.Image)(resources.GetObject("btndetails.Image")));
            this.btndetails.ImageSize = new System.Drawing.Size(25, 25);
            this.btndetails.Location = new System.Drawing.Point(932, 102);
            this.btndetails.Name = "btndetails";
            this.btndetails.Size = new System.Drawing.Size(200, 45);
            this.btndetails.TabIndex = 7;
            this.btndetails.Text = "Student Details";
            this.btndetails.Click += new System.EventHandler(this.btndetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.Location = new System.Drawing.Point(1287, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 68);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 20;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button5.Location = new System.Drawing.Point(1166, 102);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(200, 45);
            this.guna2Button5.TabIndex = 5;
            this.guna2Button5.Text = "LogOut";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.BorderRadius = 20;
            this.btnResult.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnResult.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnResult.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnResult.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnResult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResult.FillColor = System.Drawing.Color.Transparent;
            this.btnResult.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.Black;
            this.btnResult.Image = ((System.Drawing.Image)(resources.GetObject("btnResult.Image")));
            this.btnResult.ImageSize = new System.Drawing.Size(25, 25);
            this.btnResult.Location = new System.Drawing.Point(726, 102);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(200, 45);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Result";
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnViewDeleteQuestions
            // 
            this.btnViewDeleteQuestions.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDeleteQuestions.BorderRadius = 20;
            this.btnViewDeleteQuestions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewDeleteQuestions.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDeleteQuestions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDeleteQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDeleteQuestions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDeleteQuestions.FillColor = System.Drawing.Color.Transparent;
            this.btnViewDeleteQuestions.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeleteQuestions.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDeleteQuestions.Image")));
            this.btnViewDeleteQuestions.ImageSize = new System.Drawing.Size(60, 60);
            this.btnViewDeleteQuestions.Location = new System.Drawing.Point(479, 102);
            this.btnViewDeleteQuestions.Name = "btnViewDeleteQuestions";
            this.btnViewDeleteQuestions.Size = new System.Drawing.Size(222, 45);
            this.btnViewDeleteQuestions.TabIndex = 3;
            this.btnViewDeleteQuestions.Text = "Edit Question";
            this.btnViewDeleteQuestions.Click += new System.EventHandler(this.btnViewDeleteQuestions_Click);
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateQuestion.BackgroundImage")));
            this.btnUpdateQuestion.BorderRadius = 20;
            this.btnUpdateQuestion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateQuestion.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateQuestion.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateQuestion.Image")));
            this.btnUpdateQuestion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateQuestion.Location = new System.Drawing.Point(238, 102);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(214, 45);
            this.btnUpdateQuestion.TabIndex = 2;
            this.btnUpdateQuestion.Text = "Update Question";
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewQuestion.BorderRadius = 20;
            this.btnAddNewQuestion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewQuestion.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewQuestion.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewQuestion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewQuestion.Image")));
            this.btnAddNewQuestion.Location = new System.Drawing.Point(238, 41);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(200, 45);
            this.btnAddNewQuestion.TabIndex = 1;
            this.btnAddNewQuestion.Text = "Add Question";
            this.btnAddNewQuestion.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.uc_studd1);
            this.panel2.Controls.Add(this.uc_studentresult2);
            this.panel2.Controls.Add(this.uC_ViewDeleteQuestion1);
            this.panel2.Controls.Add(this.uC_UpdateQuestions1);
            this.panel2.Controls.Add(this.uC_AddNewQuestion1);
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 582);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uc_studd1
            // 
            this.uc_studd1.Location = new System.Drawing.Point(0, 0);
            this.uc_studd1.Name = "uc_studd1";
            this.uc_studd1.Size = new System.Drawing.Size(1366, 582);
            this.uc_studd1.TabIndex = 5;
            // 
            // uc_studentresult2
            // 
            this.uc_studentresult2.BackColor = System.Drawing.Color.White;
            this.uc_studentresult2.Location = new System.Drawing.Point(0, 0);
            this.uc_studentresult2.Name = "uc_studentresult2";
            this.uc_studentresult2.Size = new System.Drawing.Size(1366, 582);
            this.uc_studentresult2.TabIndex = 4;
            // 
            // uC_ViewDeleteQuestion1
            // 
            this.uC_ViewDeleteQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_ViewDeleteQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewDeleteQuestion1.Name = "uC_ViewDeleteQuestion1";
            this.uC_ViewDeleteQuestion1.Size = new System.Drawing.Size(1366, 582);
            this.uC_ViewDeleteQuestion1.TabIndex = 2;
            // 
            // uC_UpdateQuestions1
            // 
            this.uC_UpdateQuestions1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateQuestions1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateQuestions1.Name = "uC_UpdateQuestions1";
            this.uC_UpdateQuestions1.Size = new System.Drawing.Size(1366, 582);
            this.uC_UpdateQuestions1.TabIndex = 1;
            // 
            // uC_AddNewQuestion1
            // 
            this.uC_AddNewQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_AddNewQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddNewQuestion1.Name = "uC_AddNewQuestion1";
            this.uC_AddNewQuestion1.Size = new System.Drawing.Size(1366, 582);
            this.uC_AddNewQuestion1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewQuestion;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnResult;
        private Guna.UI2.WinForms.Guna2Button btnViewDeleteQuestions;
        private Guna.UI2.WinForms.Guna2Button btnUpdateQuestion;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Teacher_ctrl.UC_AddNewQuestion uC_AddNewQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Teacher_ctrl.UC_UpdateQuestions uC_UpdateQuestions1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Teacher_ctrl.UC_ViewDeleteQuestion uC_ViewDeleteQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Teacher_ctrl.uc_studentresult uc_studentresult2;
        private Guna.UI2.WinForms.Guna2Button btndetails;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Teacher_ctrl.uc_studd uc_studd1;
    }
}