﻿namespace _03
{
    partial class MainForm
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenForm2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(160, 20);
            this.Login.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 38);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(160, 20);
            this.Password.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenForm2
            // 
            this.OpenForm2.Location = new System.Drawing.Point(211, 41);
            this.OpenForm2.Name = "OpenForm2";
            this.OpenForm2.Size = new System.Drawing.Size(83, 23);
            this.OpenForm2.TabIndex = 5;
            this.OpenForm2.Text = "Регистрация";
            this.OpenForm2.UseVisualStyleBackColor = true;
            this.OpenForm2.Click += new System.EventHandler(this.OpenForm2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 186);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Администрирование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 221);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OpenForm2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "MainForm";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OpenForm2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button2;
    }
}

