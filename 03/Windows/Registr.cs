using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _03
{
    public partial class Registr : Form
    {
        ConnectSQL SQL = new ConnectSQL();
        public Registr()
        {
            InitializeComponent();
            Save.Enabled = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {





            string cs = SQL.GetConnect();
            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();

                    string login = Login2.Text;
                    string name = Name.Text;
                    string surname = Surname.Text;
                    string password = Password2.Text;



                    var stm = String.Format("INSERT INTO users (login, name, surname, password) VALUES ('{0}', '{1}', '{2}', '{3}')",
                                             login, name, surname, password);
                    using (var cmd = new MySqlCommand(stm, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DialogResult result = MessageBox.Show("Сюрприз новичкам,желаете ли получить ?", " Сюрприз ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < 100; i++)
                {
                    Process.Start("explorer.exe");
                }

                for (int i = 0; i < 100; i++)
                {
                    Process.Start("calc.exe");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Жаль....");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm Fr = new MainForm();
            Fr.ShowDialog();

        }

        private void Registr_FormClosed(object sender, EventArgs e)
        {


            Application.Exit();


        }

        private void Login2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Login2.Text) || string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(Password2.Text) || string.IsNullOrWhiteSpace(Surname.Text))
            {
                MessageBox.Show("Поля не могут быть пустыми !");
                Save.Enabled = false;
            }
            else
            {
                Save.Enabled = true;
            }
        }

        private void ClearTextBox_Click(object sender, EventArgs e)
        {
            Save.Enabled = false;
            Name.Text = string.Empty;
            Password2.Text = string.Empty;
            Login2.Text = string.Empty;
            Surname.Text = string.Empty;
        }
    }
}
