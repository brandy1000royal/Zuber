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
    public partial class ViewCustomers : Form
    {
        
        public ViewCustomers()
        {
            InitializeComponent();
            RefreshData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = Data.customers[e.RowIndex];
            //Console.WriteLine(e.RowIndex);
            MessageBox.Show("Item Clicked " + e.RowIndex);

        }


        internal void RefreshData()
        {
            dataGridView1.DataSource = Data.admins;

            //https://stackoverflow.com/questions/7916919/adding-a-button-to-a-winforms-datagridview/7930582#7930582?newreg=5e0f4c7397e94074aeedf619beef2642
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn1);
            btn1.HeaderText = "";
            btn1.Text = "Update";
            btn1.Name = "btn";
            btn1.UseColumnTextForButtonValue = true;


            dataGridView1.Update();
        }

        private void ViewAdmins_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        // https://stackoverflow.com/questions/2021681/hide-form-instead-of-closing-when-close-button-clicked
        private void ViewAdmins_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
