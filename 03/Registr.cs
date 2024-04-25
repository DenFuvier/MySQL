using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _03
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=DenFuvier;password=N1PGKt1mT3UAlRRa;database=boyk";
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
