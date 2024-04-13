using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3.UC
{
    public partial class UCCustomer : UserControl
    {
        public UCCustomer()
        {
            InitializeComponent();
            //LoadDGV();
        }
        //private void LoadDGV()
        //{
        //    DB_BLL db = new DB_BLL();
        //    dataGridView1.DataSource = db.GetAllCustomer();
        //}
    }
}
