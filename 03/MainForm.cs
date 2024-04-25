using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace _03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          

        }

        private void MainForm1_FormClosed(object sender, EventArgs e)
        {
           
                Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=DenFuvier;password=N1PGKt1mT3UAlRRa;database=boyk";
            try
            {

                var con = new MySqlConnection(cs);

                con.Open();

                var stm = String.Format("SELECT Name, Surname FROM users WHERE Login = \"{0}\" AND password = \"{1}\"",
                    Login.Text,
                Password.Text);
                
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {

                    string name = Reader.GetString(0);
                    string Surname = Reader.GetString(1);
                    MessageBox.Show("Успешно вошли " + " " + name + " " + Surname);
                }
                else
                {

                    MessageBox.Show(".\r\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⣀⣀⣀⠄⡀⢀⣀⣀⣀⡀\r\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢠⣤⣤⣤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦\r\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⣠⣿⣿⣿⣿⣿⣿⡿⠛⠿⠟⠻⢿⣿⣿⡿⠋\r\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⢸⣿⣿⣿⣿⣿⣿⠇⠄⠄⠄⠄⠄⠄⠄⠘⢷⡀\r\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⣾⣿⣿⣿⣿⣿⠇⢀⣤⣤⣀⡀⠄⠄⢹⡆⠄⠙⢶⣄\r\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⢿⣿⢾⣿⣿⡇⠄⠄⣷⣜⣋⣙⣛⣶⣾⣟⣷⡦⣄⣸⡇\r\n⠄⠄⠄⠄⠄⠄⠄⠄⢀⣼⣿⠟⠿⠿⠃⠄⠄⠉⠛⠛⠛⠋⣯⡄⢉⣛⣦⠞⠉\r\n⠄⠄⠄⠄⠄⠄⢀⣴⡟⠹⣯⠄⠄⣠⡄⠄⠄⠄⠄⠄⠄⠄⠈⠁⠨⡿⣿\r\n⠄⠄⠄⠄⣀⣰⠟⣦⣷⠄⠹⣆⠄⠛⠛⠛⠻⠶⣄⡀⠄⠄⠄⠄⠄⠄⠈⢧⡀\r\n⠄⠄⢠⡞⠋⠻⣦⠸⣽⡆⠄⠉⢣⣄⡀⠄⠄⣀⣬⣽⣢⣤⣀⠄⠄⠄⠄⢸⡇\r\n⠄⢰⠇⠄⠄⠄⠄⢷⢧⢳⡄⠄⢸⣿⣿⣶⣾⣿⡆⠄⠄⠄⠈⠙⠛⠶⠶⠞⠃\r\n⠄⡞⠄⠄⠄⠄⠄⠘⣾⢸⡟⣤⣼⣿⣿⢻⣿⣿⣟\r\n⢠⡇⠄⠄⠄⠄⠄⠄⢻⠘⣷⠈⠁⠈⣿⣼⠋⠉⠹⣆\r\n⢸⡇⠄⠄⣀⣀⣀⣀⣿⠸⢿⣀⣀⣀⡿⣿⠄⠄⠄⠹⡇\r\n⠈⢷⣟⡿⣯⡍⣉⠉⠛⢢⣤⠄⠄⠄⠄⣿⡴⠖⠒⣶⣽\r\n⠄⢸⡿⣷⠏⣼⠋⣠⣤⠶⠾⠛⠉⠉⠉⠉⠳⢦⠄⠘⡇\r\n⠄⡟⠹⣜⠦⠷⠴⠋⠄⠄⠄⣀⣤⡴⠚⠛⠉⠉⠁⢀⡇\r\n⢀⡇⠄⠉⠓⠶⠶⠶⠒⠚⠉⠉⠙⠲⢦⣤⣤⣤⣴⠞⡇\r\n⢸⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣿⢸⢀⢸⡀⢸⡀\r\n⠘⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣿⡼⢸⠄⡇⢸⡇\r\n⠄⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠸⣷⣼⠄⡇⢸⡇\r\n⠄⢇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢹⣾⢠⠇⢸⡇\r\n⠄⢸⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⢿⢻⠄⣸⡇\r\n⠄⢸⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢸⡞⠛⠃\r\n⠄⠈⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣷\r\n⠄⠄⢧⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣿\r\n⠄⠄⢸⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢸\r\n⠄⠄⢸⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⣠⣤⣴⠚\r\n⠄⠄⠈⢹⣷⣶⣶⣶⣶⡖⠒⠒⢻⣿⣿⣿⣿⣿\r\n⠄⠄⠄⢸⣿⣿⣿⣿⣿⡇⠄⠄⢸⣿⣿⣿⣿⣿\r\n⠄⠄⠄⣿⣿⣿⣿⣿⣿⡇⠄⠄⢸⣿⣿⣿⣿⣿\r\n⠄⠄⠄⣿⣿⣿⣿⣿⣿⡇⠄⠄⢸⣿⣿⣿⣿⣿\r\n⠄⠄⢰⣿⣿⣿⣿⣿⣿⠃⠄⠄⢸⣿⣿⣿⣿⣿\r\n⠄⠄⢸⣿⣿⣿⣿⣿⡿⠄⠄⠄⣼⣿⣿⣿⣿⡏\r\n⠄⠄⣿⣿⣿⣿⣿⣿⠇⠄⠄⢀⣿⣿⣿⣿⣿⣧⣤⣀⣀⡀\r\n⠄⢸⣿⣿⣿⣿⣿⣿⣀⡀⠄⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⡀\r\n⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⣿⣿⣿⣿⣿⣿⠿⠇\r\n⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷\r\n⠄⠄⠄⠉⠉⠉⠉⠉⠛⠛⠛⠛⠉⠉");

                }

            }
            catch (Exception Exept)
            {


                MessageBox.Show(Exept.Message);

            }
        }

       

        private void OpenForm2_Click(object sender, EventArgs e)
        {
             this.Hide();
            Registr registr = new Registr();
            registr.ShowDialog();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
        }


    }
}
