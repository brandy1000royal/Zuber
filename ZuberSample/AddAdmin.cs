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
    public partial class AddAdmin : Form
    {
        private readonly Zuber_dbEntities zuber_Db;
        ViewAdmins viewAdmins;
        public AddAdmin(ViewAdmins viewAdmins)
        {
            this.viewAdmins = viewAdmins;
            InitializeComponent();
            zuber_Db = new Zuber_dbEntities();
        }

        private void buttonaddnewadmin_Click(object sender, EventArgs e)
        {
            Data.admins.Add(new Models.Admins()
            {
                Name = textBoxaddadminname.Text,
                Username=textBoxaddadminusername.Text,
                Password=textBoxaddadminpassword.Text
            });

            var Admn = new Admin();
            Admn.Name = textBoxaddadminname.Text;
            Admn.Username = textBoxaddadminusername.Text;
            Admn.Password = textBoxaddadminpassword.Text;

            zuber_Db.Admin.Add(Admn);
            zuber_Db.SaveChanges();

            this.Close();

            MessageBox.Show("New Administrator Added");

            viewAdmins.RefreshData();
        }
    }
}
