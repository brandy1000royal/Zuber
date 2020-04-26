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
   
    public partial class AddDriver : Form
    { 
        ViewDrivers viewDriver;
        private readonly Zuber_dbEntities zuber_Db;
        public AddDriver (ViewDrivers viewDriver)
        {
            this.viewDriver = viewDriver;
            InitializeComponent();
            zuber_Db = new Zuber_dbEntities();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void buttonsubmitadd_Click(object sender, EventArgs e)
        {

            Data.drivers.Add(new Models.Driver()
            {
                Name = textBoxadddrivername.Text,
                Post = textBoxadddriverpost.Text,
                CarType = textBoxadddrivercartype.Text
            });

            var drive = new Drivers();
            drive.Name = textBoxadddrivername.Text;
            drive.Post = textBoxadddriverpost.Text;
            drive.CarType = textBoxadddrivercartype.Text;

            zuber_Db.Drivers.Add(drive);
            zuber_Db.SaveChanges();


            this.Close();

            MessageBox.Show("New Driver Added");

            viewDriver.RefreshData();

        }
    }
}
