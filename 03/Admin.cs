using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

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
            string cs = @"server=localhost;userid=root;password=vertrigo;database=boyk";
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
            string cs = @"server=localhost;userid=root;password=vertrigo;database=boyk";
            try
            {
                var con = new MySqlConnection(cs);

                con.Open();


                var stm = String.Format("Update login Name, Surname  FROM users WHERE Login = \"{0}\" AND password = \"{1}\"",
                   Login.Text,
               Password.Text);





                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                
            }
            catch (Exception Exept)
            {

                MessageBox.Show(Exept.Message);

            }
        }
    }
}
