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
        public AddDriver (ViewDrivers viewDriver)
        {
            this.viewDriver = viewDriver;
            InitializeComponent();
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

            this.Close();

            MessageBox.Show("New Driver Added");

            viewDriver.RefreshData();

        }
    }
}
