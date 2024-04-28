namespace _03
{
    partial class Registr
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
            this.Save = new System.Windows.Forms.Button();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.Login2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openForm1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.ClearTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(338, 147);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(101, 60);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(160, 20);
            this.Surname.TabIndex = 13;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(101, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(160, 20);
            this.Name.TabIndex = 12;
            // 
            // Password2
            // 
            this.Password2.Location = new System.Drawing.Point(101, 121);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(160, 20);
            this.Password2.TabIndex = 11;
            // 
            // Login2
            // 
            this.Login2.Location = new System.Drawing.Point(101, 95);
            this.Login2.Name = "Login2";
            this.Login2.Size = new System.Drawing.Size(160, 20);
            this.Login2.TabIndex = 10;
            this.Login2.TextChanged += new System.EventHandler(this.Login2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ваш Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ваш Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ваше имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ваша фамилия";
            // 
            // openForm1
            // 
            this.openForm1.Location = new System.Drawing.Point(101, 415);
            this.openForm1.Name = "openForm1";
            this.openForm1.Size = new System.Drawing.Size(73, 23);
            this.openForm1.TabIndex = 19;
            this.openForm1.Text = "Вернуться";
            this.openForm1.UseVisualStyleBackColor = true;
            this.openForm1.Click += new System.EventHandler(this.openForm1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(15, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 20;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(257, 147);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 21;
            this.Test.Text = "Проверка";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // ClearTextBox
            // 
            this.ClearTextBox.Location = new System.Drawing.Point(340, 30);
            this.ClearTextBox.Name = "ClearTextBox";
            this.ClearTextBox.Size = new System.Drawing.Size(73, 23);
            this.ClearTextBox.TabIndex = 22;
            this.ClearTextBox.Text = "Очистить";
            this.ClearTextBox.UseVisualStyleBackColor = true;
            this.ClearTextBox.Click += new System.EventHandler(this.ClearTextBox_Click);
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearTextBox);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.openForm1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Login2);
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Surname;
        private new System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.TextBox Login2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openForm1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button ClearTextBox;
    }
}