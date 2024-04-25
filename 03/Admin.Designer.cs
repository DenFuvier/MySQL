namespace _03
{
    partial class Admin
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
            this.Exit = new System.Windows.Forms.Button();
            this.OpenForm1 = new System.Windows.Forms.Button();
            this.UserView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Surname_admin = new System.Windows.Forms.TextBox();
            this.NameAdmin = new System.Windows.Forms.TextBox();
            this.Password_Admin = new System.Windows.Forms.TextBox();
            this.Login_Admin = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.openMySQl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OpenForm1
            // 
            this.OpenForm1.Location = new System.Drawing.Point(93, 415);
            this.OpenForm1.Name = "OpenForm1";
            this.OpenForm1.Size = new System.Drawing.Size(75, 23);
            this.OpenForm1.TabIndex = 1;
            this.OpenForm1.Text = "Вернуться";
            this.OpenForm1.UseVisualStyleBackColor = true;
            this.OpenForm1.Click += new System.EventHandler(this.OpenForm1_Click);
            // 
            // UserView
            // 
            this.UserView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.UserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserView.Location = new System.Drawing.Point(12, 12);
            this.UserView.Name = "UserView";
            this.UserView.Size = new System.Drawing.Size(776, 202);
            this.UserView.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Login";
            // 
            // Surname_admin
            // 
            this.Surname_admin.Location = new System.Drawing.Point(93, 275);
            this.Surname_admin.Name = "Surname_admin";
            this.Surname_admin.Size = new System.Drawing.Size(160, 20);
            this.Surname_admin.TabIndex = 29;
            // 
            // NameAdmin
            // 
            this.NameAdmin.Location = new System.Drawing.Point(93, 253);
            this.NameAdmin.Name = "NameAdmin";
            this.NameAdmin.Size = new System.Drawing.Size(160, 20);
            this.NameAdmin.TabIndex = 28;
            // 
            // Password_Admin
            // 
            this.Password_Admin.Location = new System.Drawing.Point(93, 331);
            this.Password_Admin.Name = "Password_Admin";
            this.Password_Admin.Size = new System.Drawing.Size(160, 20);
            this.Password_Admin.TabIndex = 27;
            // 
            // Login_Admin
            // 
            this.Login_Admin.Location = new System.Drawing.Point(93, 305);
            this.Login_Admin.Name = "Login_Admin";
            this.Login_Admin.Size = new System.Drawing.Size(160, 20);
            this.Login_Admin.TabIndex = 26;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(320, 415);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 34;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(401, 415);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 35;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // openMySQl
            // 
            this.openMySQl.Location = new System.Drawing.Point(482, 415);
            this.openMySQl.Name = "openMySQl";
            this.openMySQl.Size = new System.Drawing.Size(94, 23);
            this.openMySQl.TabIndex = 36;
            this.openMySQl.Text = "Открыть SQL";
            this.openMySQl.UseVisualStyleBackColor = true;
            this.openMySQl.Click += new System.EventHandler(this.openMySQl_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openMySQl);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Surname_admin);
            this.Controls.Add(this.NameAdmin);
            this.Controls.Add(this.Password_Admin);
            this.Controls.Add(this.Login_Admin);
            this.Controls.Add(this.UserView);
            this.Controls.Add(this.OpenForm1);
            this.Controls.Add(this.Exit);
            this.Name = "Admin";
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button OpenForm1;
        private System.Windows.Forms.DataGridView UserView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Surname_admin;
        private System.Windows.Forms.TextBox NameAdmin;
        private System.Windows.Forms.TextBox Password_Admin;
        private System.Windows.Forms.TextBox Login_Admin;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button openMySQl;
    }
}