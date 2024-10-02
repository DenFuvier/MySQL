using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using _03;




namespace _03
{
    public partial class MainForm : Form
    {
        ConnectSQL SQL = new ConnectSQL();

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
            string cs = SQL.GetConnect();
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
            /*this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();*/
            TestPasswordAdmin passwordForm = new TestPasswordAdmin();

            if (passwordForm.ShowDialog() == DialogResult.OK)
            {
                Admin admin = new Admin();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Доступ не разрешен. Неверный пароль.");
            }

        }




    }

}
