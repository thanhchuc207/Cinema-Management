using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UCStatistical : UserControl
    {
        public UCStatistical()
        {
            InitializeComponent();
            cbbChoose.SelectedIndex = 0;
        }
        public void SetCBB()
        {
            if (cbbTimes.SelectedIndex == 0)
            {
                cbbItems.Items.Clear();
                for (int i = 1; i <= 12; i++)
                {
                    cbbItems.Items.Add(i.ToString());
                }
            }
            else if (cbbTimes.SelectedIndex == 1)
            {
                cbbItems.Items.Clear();
                for (int i = 2; i >= 0; i--)
                {
                    cbbItems.Items.Add(DateTime.Now.AddYears(-i).Year.ToString());
                }
            }
        }

        private void cbbTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCBB();
        }

        private void cbbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL_TBMovie bll=new BLL_TBMovie();
            BLL_TBCustomer bllCus= new BLL_TBCustomer();
            if (cbbItems.SelectedIndex >= 0)
            {
                if (cbbChoose.SelectedIndex == 0)
                {
                    
                    List<DTO_TBMovieStatitics> list =bll.GetStatitics(cbbTimes.SelectedItem.ToString(), cbbItems.SelectedItem.ToString());

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Tên phim", typeof(string));
                    dt.Columns.Add("Số vé đã mua", typeof(int));
                    dt.Columns.Add("Tổng tiền", typeof(int));
                    foreach (var i in list)
                    {
                        dt.Rows.Add(i.movie_name, i.number_of_ticket, i.total_price);
                    }
                    dtvView.DataSource = dt;
                }
                else if (cbbChoose.SelectedIndex == 1)
                {
                    List<DTO_TBCustomersStatitics> list = bllCus.GetListCusomerStatitic(cbbTimes.SelectedItem.ToString(), cbbItems.SelectedItem.ToString());
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Tên khách hàng", typeof(string));
                    dt.Columns.Add("Số vé đã mua", typeof(int));
                    dt.Columns.Add("Tổng tiền", typeof(int));

                    foreach (var item in list)
                    {
                        dt.Rows.Add(item.customer_name, item.number_of_ticket, item.total_price);
                    }

                    dtvView.DataSource = dt;
                }


            }
        }

        private void cbbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbItems.Items.Clear();
            dtvView.DataSource = null;
            dtvView.Rows.Clear();
            SetCBB();
        }
    }
}
