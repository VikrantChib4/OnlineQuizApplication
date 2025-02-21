namespace OnlineQuiz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.slctUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.exitbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewPass = new System.Windows.Forms.CheckBox();
            this.login = new Guna.UI2.WinForms.Guna2Button();
            this.userPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.userName = new Guna.UI2.WinForms.Guna2TextBox();
            this.error = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enrollment = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnstudentlogin = new Guna.UI2.WinForms.Guna2Button();
            this.sRegister = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Quiz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // slctUser
            // 
            this.slctUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slctUser.BackColor = System.Drawing.Color.Transparent;
            this.slctUser.BorderRadius = 15;
            this.slctUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.slctUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slctUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.slctUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.slctUser.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.slctUser.ForeColor = System.Drawing.Color.Black;
            this.slctUser.ItemHeight = 30;
            this.slctUser.Items.AddRange(new object[] {
            "TEACHER",
            "STUDENT"});
            this.slctUser.Location = new System.Drawing.Point(523, 138);
            this.slctUser.Name = "slctUser";
            this.slctUser.Size = new System.Drawing.Size(391, 36);
            this.slctUser.TabIndex = 2;
            this.slctUser.SelectedIndexChanged += new System.EventHandler(this.slctUser_SelectedIndexChanged);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitbtn.FillColor = System.Drawing.Color.Empty;
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.ImageSize = new System.Drawing.Size(50, 50);
            this.exitbtn.Location = new System.Drawing.Point(1279, 1);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.PressedColor = System.Drawing.Color.Gray;
            this.exitbtn.Size = new System.Drawing.Size(74, 60);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.viewPass);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.userPass);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(523, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 467);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // viewPass
            // 
            this.viewPass.AutoSize = true;
            this.viewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPass.Location = new System.Drawing.Point(116, 283);
            this.viewPass.Name = "viewPass";
            this.viewPass.Size = new System.Drawing.Size(152, 22);
            this.viewPass.TabIndex = 11;
            this.viewPass.Text = "Show Password";
            this.viewPass.UseVisualStyleBackColor = true;
            this.viewPass.CheckedChanged += new System.EventHandler(this.viewPass_CheckedChanged);
            // 
            // login
            // 
            this.login.BorderRadius = 18;
            this.login.BorderThickness = 1;
            this.login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login.FillColor = System.Drawing.Color.LimeGreen;
            this.login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.HoverState.FillColor = System.Drawing.Color.White;
            this.login.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.login.Location = new System.Drawing.Point(109, 326);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(180, 45);
            this.login.TabIndex = 10;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // userPass
            // 
            this.userPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPass.DefaultText = "";
            this.userPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPass.FillColor = System.Drawing.Color.LightGray;
            this.userPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPass.ForeColor = System.Drawing.Color.Black;
            this.userPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPass.Location = new System.Drawing.Point(17, 211);
            this.userPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userPass.Name = "userPass";
            this.userPass.PasswordChar = '*';
            this.userPass.PlaceholderText = "";
            this.userPass.SelectedText = "";
            this.userPass.Size = new System.Drawing.Size(356, 48);
            this.userPass.TabIndex = 9;
            this.userPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userName
            // 
            this.userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName.DefaultText = "";
            this.userName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName.FillColor = System.Drawing.Color.LightGray;
            this.userName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Black;
            this.userName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userName.Location = new System.Drawing.Point(17, 111);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.PlaceholderText = "";
            this.userName.SelectedText = "";
            this.userName.Size = new System.Drawing.Size(356, 48);
            this.userName.TabIndex = 8;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Red;
            this.error.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Transparent;
            this.error.Location = new System.Drawing.Point(3, 408);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(357, 26);
            this.error.TabIndex = 3;
            this.error.Text = "Incorrect USERNAME \"OR\" PASSWORD";
            this.error.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "PASSWORD";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Student Login";
            // 
            // enrollment
            // 
            this.enrollment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enrollment.DefaultText = "";
            this.enrollment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.enrollment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.enrollment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.enrollment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.enrollment.FillColor = System.Drawing.Color.LightGray;
            this.enrollment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enrollment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollment.ForeColor = System.Drawing.Color.Black;
            this.enrollment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enrollment.Location = new System.Drawing.Point(17, 131);
            this.enrollment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enrollment.Name = "enrollment";
            this.enrollment.PasswordChar = '\0';
            this.enrollment.PlaceholderText = "";
            this.enrollment.SelectedText = "";
            this.enrollment.Size = new System.Drawing.Size(356, 48);
            this.enrollment.TabIndex = 13;
            this.enrollment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnstudentlogin
            // 
            this.btnstudentlogin.BorderRadius = 18;
            this.btnstudentlogin.BorderThickness = 1;
            this.btnstudentlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstudentlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstudentlogin.FillColor = System.Drawing.Color.LimeGreen;
            this.btnstudentlogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentlogin.ForeColor = System.Drawing.Color.Black;
            this.btnstudentlogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnstudentlogin.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnstudentlogin.Location = new System.Drawing.Point(32, 309);
            this.btnstudentlogin.Name = "btnstudentlogin";
            this.btnstudentlogin.Size = new System.Drawing.Size(318, 45);
            this.btnstudentlogin.TabIndex = 13;
            this.btnstudentlogin.Text = "Login";
            this.btnstudentlogin.Click += new System.EventHandler(this.btnstudentlogin_Click);
            // 
            // sRegister
            // 
            this.sRegister.BorderRadius = 18;
            this.sRegister.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.sRegister.BorderThickness = 1;
            this.sRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sRegister.FillColor = System.Drawing.Color.LimeGreen;
            this.sRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sRegister.ForeColor = System.Drawing.Color.Black;
            this.sRegister.HoverState.FillColor = System.Drawing.Color.White;
            this.sRegister.HoverState.ForeColor = System.Drawing.Color.LimeGreen;
            this.sRegister.Location = new System.Drawing.Point(32, 232);
            this.sRegister.Name = "sRegister";
            this.sRegister.Size = new System.Drawing.Size(318, 45);
            this.sRegister.TabIndex = 15;
            this.sRegister.Text = "Register";
            this.sRegister.Click += new System.EventHandler(this.sRegister_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "ENROLLMENT NO.";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.sRegister);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnstudentlogin);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.enrollment);
            this.panel2.Location = new System.Drawing.Point(523, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 467);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 786);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.slctUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox slctUser;
        private Guna.UI2.WinForms.Guna2Button exitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label error;
        private Guna.UI2.WinForms.Guna2TextBox userName;
        private Guna.UI2.WinForms.Guna2Button login;
        private Guna.UI2.WinForms.Guna2TextBox userPass;
        private System.Windows.Forms.CheckBox viewPass;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox enrollment;
        private Guna.UI2.WinForms.Guna2Button btnstudentlogin;
        private Guna.UI2.WinForms.Guna2Button sRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}

