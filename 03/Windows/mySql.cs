using System;
using System.Windows.Forms;

namespace _03
{
    public partial class mySql : Form
    {
        public mySql()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://127.0.0.1/phpmyadmin/sql.php?db=boyk&table=users&pos=0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
