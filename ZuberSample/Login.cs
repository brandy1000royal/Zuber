using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuberSample
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: verify credentials
            var thepassword = "Manager";
            var theusername = "Zuber";
            string username = textBoxusername.Text.Trim();
            var password = textBoxpassword.Text;

            if (username == null)
            {
                MessageBox.Show("Please Enter Username");
            }
            if (password== null)
            {
                MessageBox.Show("Please Enter Password");
            }


            if (username == theusername && thepassword == password)
            {

                if (true)
                {
                    // create new forms
                    var main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Username or Password is invalid");
                    textBoxpassword.Text = "";
                    textBoxusername.Text = "";
                }
            }
        }
    }
}
