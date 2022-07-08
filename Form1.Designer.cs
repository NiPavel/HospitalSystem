
namespace HospitalSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.GroupBox();
            this.IncorrectUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DoctorUsername = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorrectUsername = new System.Windows.Forms.PictureBox();
            this.CorrectPassword = new System.Windows.Forms.PictureBox();
            this.IncorrectPassword = new System.Windows.Forms.Label();
            this.ShowPass = new System.Windows.Forms.Button();
            this.HidePass = new System.Windows.Forms.Button();
            this.Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 237);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to a Hospital System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.Transparent;
            this.Box.Controls.Add(this.HidePass);
            this.Box.Controls.Add(this.ShowPass);
            this.Box.Controls.Add(this.IncorrectPassword);
            this.Box.Controls.Add(this.CorrectPassword);
            this.Box.Controls.Add(this.CorrectUsername);
            this.Box.Controls.Add(this.IncorrectUser);
            this.Box.Controls.Add(this.button1);
            this.Box.Controls.Add(this.DoctorUsername);
            this.Box.Controls.Add(this.button2);
            this.Box.Controls.Add(this.label2);
            this.Box.Controls.Add(this.Password);
            this.Box.Controls.Add(this.label3);
            this.Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box.Location = new System.Drawing.Point(392, 231);
            this.Box.Name = "Box";
            this.Box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Box.Size = new System.Drawing.Size(419, 262);
            this.Box.TabIndex = 8;
            this.Box.TabStop = false;
            this.Box.Text = "LogIn";
            // 
            // IncorrectUser
            // 
            this.IncorrectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncorrectUser.Location = new System.Drawing.Point(53, 32);
            this.IncorrectUser.Name = "IncorrectUser";
            this.IncorrectUser.Size = new System.Drawing.Size(357, 24);
            this.IncorrectUser.TabIndex = 7;
            this.IncorrectUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(243, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 36);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoctorUsername
            // 
            this.DoctorUsername.Location = new System.Drawing.Point(158, 59);
            this.DoctorUsername.MaxLength = 8;
            this.DoctorUsername.Name = "DoctorUsername";
            this.DoctorUsername.Size = new System.Drawing.Size(174, 26);
            this.DoctorUsername.TabIndex = 3;
            this.DoctorUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DoctorUsername.TextChanged += new System.EventHandler(this.DoctorUsername_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(31, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 36);
            this.button2.TabIndex = 5;
            this.button2.TabStop = false;
            this.button2.Text = "SignIn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(158, 132);
            this.Password.MaxLength = 10;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(174, 26);
            this.Password.TabIndex = 4;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorrectUsername
            // 
            this.CorrectUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CorrectUsername.BackgroundImage")));
            this.CorrectUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CorrectUsername.Location = new System.Drawing.Point(338, 59);
            this.CorrectUsername.Name = "CorrectUsername";
            this.CorrectUsername.Size = new System.Drawing.Size(34, 26);
            this.CorrectUsername.TabIndex = 9;
            this.CorrectUsername.TabStop = false;
            // 
            // CorrectPassword
            // 
            this.CorrectPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CorrectPassword.BackgroundImage")));
            this.CorrectPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CorrectPassword.Location = new System.Drawing.Point(378, 129);
            this.CorrectPassword.Name = "CorrectPassword";
            this.CorrectPassword.Size = new System.Drawing.Size(29, 31);
            this.CorrectPassword.TabIndex = 10;
            this.CorrectPassword.TabStop = false;
            // 
            // IncorrectPassword
            // 
            this.IncorrectPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncorrectPassword.Location = new System.Drawing.Point(6, 91);
            this.IncorrectPassword.Name = "IncorrectPassword";
            this.IncorrectPassword.Size = new System.Drawing.Size(404, 38);
            this.IncorrectPassword.TabIndex = 11;
            this.IncorrectPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowPass
            // 
            this.ShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPass.BackgroundImage")));
            this.ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPass.Location = new System.Drawing.Point(338, 131);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(34, 29);
            this.ShowPass.TabIndex = 12;
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.Click += new System.EventHandler(this.button3_Click);
            // 
            // HidePass
            // 
            this.HidePass.BackColor = System.Drawing.Color.White;
            this.HidePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HidePass.BackgroundImage")));
            this.HidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HidePass.Location = new System.Drawing.Point(338, 129);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(34, 32);
            this.HidePass.TabIndex = 13;
            this.HidePass.UseVisualStyleBackColor = false;
            this.HidePass.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 464);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.TextBox DoctorUsername;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label IncorrectUser;
        private System.Windows.Forms.PictureBox CorrectUsername;
        private System.Windows.Forms.Label IncorrectPassword;
        private System.Windows.Forms.PictureBox CorrectPassword;
        private System.Windows.Forms.Button ShowPass;
        private System.Windows.Forms.Button HidePass;
    }
}

