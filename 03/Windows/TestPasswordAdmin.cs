using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class TestPasswordAdmin : Form
    {
        private string Login_ = "Admin";
        private string password_ = "867783";
        public TestPasswordAdmin()
        {
            InitializeComponent();
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            string LOG = Login.Text;
            string PASSWORD = Password.Text;
             
            if (LOG == Login_ && PASSWORD == password_)
            {

                MessageBox.Show("Верно,вход...");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");


            }
        }
    }
}
