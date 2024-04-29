using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _03
{
    public partial class Admin : Form
    {
        List<User> userS = new List<User>();
        public Admin()
        {


            InitializeComponent();

            UserView.SelectionChanged += UserView_SelectionChanged;

        }


        private void UserView_SelectionChanged(object sender, EventArgs e)
        {

            int number = UserView.CurrentRow.Index;
            User X = userS[number];
            Login_Admin.Text = X.Login;
            NameAdmin.Text = X.Name;
            Surname_admin.Text = X.Surname;
            Password_Admin.Text = X.Password;


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=DenFuvier;password=N1PGKt1mT3UAlRRa;database=boyk";
            try
            {
                var con = new MySqlConnection(cs);

                con.Open();



                var stm = String.Format("SELECT * FROM users ");




                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    string login = Reader.GetString(0);
                    string name = Reader.GetString(1);
                    string surname = Reader.GetString(2);
                    string password = Reader.GetString(3);

                    User user = new User(login, name, surname, password);
                    userS.Add(user);



                }
                con.Close();
            }
            catch (Exception Exept)
            {


                MessageBox.Show(Exept.Message);

            }

            UserView.DataSource = userS;

        }


        private void change_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=DenFuvier;password=N1PGKt1mT3UAlRRa;database=boyk";
            try
            {
                var con = new MySqlConnection(cs);

                con.Open();


                var stm = String.Format("UPDATE users SET Login = '{0}', name = '{1}', surname = '{2}', password = '{3}' WHERE Login = '{0}'",
                Login_Admin.Text,
                 NameAdmin.Text,
                  Surname_admin.Text,
                   Password_Admin.Text);





                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception Exept)
            {

                MessageBox.Show(Exept.Message);

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=DenFuvier;password=N1PGKt1mT3UAlRRa;database=boyk";
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();



                string stm = String.Format("DELETE FROM users WHERE login = '{0}' " , Login_Admin.Text );


                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();

                con.Close();
            }
            catch (Exception Exept)
            {

                MessageBox.Show(Exept.Message);

            }
        }

        private void openMySQl_Click(object sender, EventArgs e)
        {
            /*if (Process.GetProcessesByName("Vertrigo.exe").Any())
            {
                Process process = new Process();
                process.StartInfo.FileName = "Vertrigo.exe";
                process.StartInfo.Verb = "runas";
                process.Start();
                Process.Start($"http://127.0.0.1/phpmyadmin/sql.php?db=boyk&table=users&pos=0");
            }
            else
            {
                MessageBox.Show("Приложение уже запущено");
                Process.Start($"http://127.0.0.1/phpmyadmin/sql.php?db=boyk&table=users&pos=0");
            }
            */
            //Process.Start($"http://127.0.0.1/phpmyadmin/sql.php?db=boyk&table=users&pos=0");
            MessageBox.Show("Login : root || password : vertrigo");
            mySql MMM = new mySql();
            MMM.ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {
            userS.Clear(); 

            string cs = @"server=localhost;userid=DenFuvier;password=N1PGKt1mT3UAlRRa;database=boyk";

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var stm = "SELECT * FROM users";

                    using (var cmd = new MySqlCommand(stm, con))
                    {
                        using (MySqlDataReader Reader = cmd.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                string login = Reader.GetString(0);
                                string name = Reader.GetString(1);
                                string surname = Reader.GetString(2);
                                string password = Reader.GetString(3);
                                User user = new User(login, name, surname, password);
                                userS.Add(user);
                            }
                        }
                    }
                }

                UserView.DataSource = null; 
                UserView.DataSource = userS;
            }
            catch (Exception Exept)
            {
                MessageBox.Show(Exept.Message);
            }
        }

       

       

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"https://github.com/DenFuvier");

        }
    }
}

