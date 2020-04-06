using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZuberSample.Models;

namespace ZuberSample
{
    // https://stackoverflow.com/questions/15811254/how-to-set-datasource-to-a-datagridview-control-in-c-sharp
    public partial class ViewDrivers : Form
    {
        
        public ViewDrivers()
        {
            InitializeComponent();
            
            

            dataGridView1.DataSource = Data.drivers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = Data.drivers[e.RowIndex];
            //Console.WriteLine(e.RowIndex);
            MessageBox.Show("Item Clicked " + e.RowIndex);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
