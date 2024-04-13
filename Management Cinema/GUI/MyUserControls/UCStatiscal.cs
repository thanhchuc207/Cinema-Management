using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.MyUserControls
{
    public partial class UCStatiscal : UserControl
    {
        public UCStatiscal()
        {
            InitializeComponent();
            SetCBBYear();
            SetDGVAll(ref dgvMovieRevenue, 1);
            radiobtAll1.Checked = true;
            lbMonth1.Visible = false;
            cbbMonth1.Visible = false;
            lbYear1.Visible = false;
            cbbYear1.Visible = false;


        }
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2TabControl1.SelectedIndex==0)
            {
                SetDGVAll(ref dgvMovieRevenue, 1);
                radiobtAll1.Checked = true;
                lbMonth1.Visible = false;
                cbbMonth1.Visible = false;
                lbYear1.Visible = false;
                cbbYear1.Visible = false;
            }
            if (guna2TabControl1.SelectedIndex == 1)
            {
                SetDGVAll(ref dgvStaffRevenue, 2);
                radiobtAll2.Checked = true;
                lbMonth2.Visible = false;
                cbbMonth2.Visible = false;
                lbYear2.Visible = false;
                cbbYear2.Visible = false;
            }
            if (guna2TabControl1.SelectedIndex == 2)
            {
                SetDGVAll(ref dgvCustomerRevenue, 3);
                radiobtAll3.Checked = true;
                lbMonth3.Visible = false;
                cbbMonth3.Visible = false;
                lbYear3.Visible = false;
                cbbYear3.Visible = false;
            }
        }
        private void SetCBBYear()
        {
            BLL_Revenue bll = new BLL_Revenue();
            foreach (var i in bll.GetAllYearRevenue())
            {
                cbbYear1.Items.Add(i.ToString());
                cbbYear2.Items.Add(i.ToString());
                cbbYear3.Items.Add(i.ToString());
            }
        }
        private void ChangeFormatCurrency(ref TextBox tb1, string price)
        {
            tb1.Text = price;
            try
            {
                double flPrice = double.Parse(price.Replace(",", ""));
                tb1.Text = flPrice.ToString("0,00.##");
                tb1.Select(tb1.TextLength, 0);
            }
            catch (Exception e2)
            {
            }
        }
        private void SetTextBoxRevenue(DataGridView dgv, ref TextBox tb1,ref TextBox tb2)
        {
            if(dgv.Rows.Count > 0)
            {

                //top
                ChangeFormatCurrency(ref tb1, dgv.Rows[0].Cells[3].Value.ToString());
                int sum = 0;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    sum+=Convert.ToInt32(dgv.Rows[i].Cells[3].Value.ToString());
                }
                //total
                ChangeFormatCurrency(ref tb2, sum.ToString());
            }
            else
            {
                tb1.Text = "0";
                tb2.Text = "0";
            }      
        }
        private void SetDGVAll(ref DataGridView dgv,int tab)
        {
            BLL_Revenue bll = new BLL_Revenue();
            if(tab==1)
                dgv.DataSource = bll.GetMovieRevenue();
            if(tab==2)
                dgv.DataSource = bll.GetStaffRevenue();
            
            if(tab==3) 
                dgv.DataSource = bll.GetCustomerRevenue();
            
           // if (dgv.Rows.Count > 1) dgv.Sort(dgvMovieRevenue.Columns[3], ListSortDirection.Ascending);
        }
        private void SetDGVMonth(ref DataGridView dgv,int tab, int month,int year)
        {
            BLL_Revenue bll = new BLL_Revenue();
            if(tab==1)
              dgv.DataSource= bll.GetMovieRevenueByMonth(month, year);
           if (tab == 2)
              dgv.DataSource= bll.GetStaffRevenueByMonth(month, year);
            if (tab == 3)
                dgv.DataSource = bll.GetCustomerRevenueByMonth(month, year);

        }
        private void SetDGVYear(ref DataGridView dgv,int tab, int year)
        {
            BLL_Revenue bll = new BLL_Revenue();
            if(tab==1)
                dgv.DataSource= bll.GetMovieRevenueByYear(year);
            if (tab == 2)
                dgv.DataSource = bll.GetStaffRevenueByYear(year);
            if (tab == 3)
                dgv.DataSource = bll.GetCustomerRevenueByYear(year);
        }
        private void SetChart(DataGridView dgv, ref Chart chart)
        {
            int row = 10;
            if (dgv.Rows.Count < 10) row = dgv.Rows.Count;
            chart.Series["Doanh thu"].Points.Clear();
            for (int i = 0; i < row; i++)
            {
                chart.Series["Doanh thu"].Points.AddXY(dgv.Rows[i].Cells[1].Value.ToString(), dgv.Rows[i].Cells[3].Value);
            }
        }
        private void cbbYear1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((radiobtMonth1.Checked))//month
            {
                SetDGVMonth(ref dgvMovieRevenue,1, Convert.ToInt32(cbbMonth1.SelectedItem),Convert.ToInt32(cbbYear1.SelectedItem));
            }
            else//year
            {
                SetDGVYear(ref dgvMovieRevenue,1, Convert.ToInt32(cbbYear1.SelectedItem));
            }
            SetChart(dgvMovieRevenue, ref chartMovie);
            SetTextBoxRevenue(dgvMovieRevenue, ref tbTop, ref tbTotal);
        }

        private void cbbMonth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radiobtMonth1.Checked && (cbbYear1.SelectedItem.ToString()!=""))//year
            {
                chartMovie.Series["Doanh thu"].Points.Clear();
                dgvMovieRevenue.DataSource = null;

                SetDGVMonth(ref dgvMovieRevenue,1, Convert.ToInt32(cbbMonth1.SelectedItem), Convert.ToInt32(cbbYear1.SelectedItem));
                SetChart(dgvMovieRevenue, ref chartMovie);
                SetTextBoxRevenue(dgvMovieRevenue, ref tbTop, ref tbTotal);
            }
        }

        private void radiobtAll1_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtAll1.Checked)
            {
                lbMonth1.Visible = false;
                cbbMonth1.Visible = false;
                lbYear1.Visible = false;
                cbbYear1.Visible = false;
                dgvMovieRevenue.DataSource = null;
                chartMovie.Series["Doanh thu"].Points.Clear();
                SetDGVAll(ref dgvMovieRevenue,1);
                SetChart(dgvMovieRevenue,ref chartMovie);
                SetTextBoxRevenue(dgvMovieRevenue, ref tbTop, ref tbTotal);
            }
        }

        private void radiobtMonth1_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtMonth1.Checked)
            {
                lbMonth1.Visible = true;
                cbbMonth1.Visible = true;
                lbYear1.Visible = true;
                cbbYear1.Visible = true;
                dgvMovieRevenue.DataSource = null;
                chartMovie.Series["Doanh thu"].Points.Clear();
                tbTop.Text = "0";
                tbTotal.Text = "0";
                cbbYear1.Text = "";
                cbbMonth1.Text = "";
            }
        }

        private void radiobtYear1_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtYear1.Checked)
            {
                lbMonth1.Visible = false;
                cbbMonth1.Visible = false;
                lbYear1.Visible = true;
                cbbYear1.Visible = true;
                dgvMovieRevenue.DataSource = null;
                chartMovie.Series["Doanh thu"].Points.Clear();
                tbTop.Text = "0";
                tbTotal.Text = "0";
                cbbYear1.Text = "";
                cbbMonth1.Text = "";
            }
        }

        private void radiobtYear2_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtYear2.Checked)
            {
                lbMonth2.Visible = false;
                cbbMonth2.Visible = false;
                lbYear2.Visible = true;
                cbbYear2.Visible = true;
                dgvStaffRevenue.DataSource = null;
                chartStaff.Series["Doanh thu"].Points.Clear();
                tbTop2.Text = "0";
                tbTotal2.Text = "0";
                cbbYear2.Text = "";
                cbbMonth2.Text = "";
            }
        }

        private void radiobtMonth2_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtMonth2.Checked)
            {
                lbMonth2.Visible = true;
                cbbMonth2.Visible = true;
                lbYear2.Visible = true;
                cbbYear2.Visible = true;
                dgvStaffRevenue.DataSource = null;
                chartStaff.Series["Doanh thu"].Points.Clear();
                tbTop2.Text = "0";
                tbTotal2.Text = "0";
                cbbYear2.Text = "";
                cbbMonth2.Text = "";
            }

        }

        private void radiobtAll2_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtAll2.Checked)
            {
                lbMonth2.Visible = false;
                cbbMonth2.Visible = false;
                lbYear2.Visible = false;
                cbbYear2.Visible = false;
                dgvStaffRevenue.DataSource = null;
                chartStaff.Series["Doanh thu"].Points.Clear();
                SetDGVAll(ref dgvStaffRevenue, 2);
                SetChart(dgvStaffRevenue,ref chartStaff);
                SetTextBoxRevenue(dgvStaffRevenue, ref tbTop2, ref tbTotal2);
            }
        }

        private void cbbYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((radiobtMonth2.Checked))//month
            {
                SetDGVMonth(ref dgvStaffRevenue,2, Convert.ToInt32(cbbMonth2.SelectedItem), Convert.ToInt32(cbbYear2.SelectedItem));
            }
            else//year
            {
                SetDGVYear(ref dgvStaffRevenue,2, Convert.ToInt32(cbbYear2.SelectedItem));
            }
            SetChart(dgvStaffRevenue, ref chartStaff);
            SetTextBoxRevenue(dgvStaffRevenue, ref tbTop2, ref tbTotal2);
        }

        private void cbbMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radiobtMonth2.Checked && (cbbYear2.SelectedItem.ToString() != ""))//year
            {
                chartStaff.Series["Doanh thu"].Points.Clear();
                dgvStaffRevenue.DataSource = null;

                SetDGVMonth(ref dgvStaffRevenue, 2, Convert.ToInt32(cbbMonth2.SelectedItem), Convert.ToInt32(cbbYear2.SelectedItem));
                SetChart(dgvStaffRevenue, ref chartStaff);
                SetTextBoxRevenue(dgvStaffRevenue, ref tbTop2, ref tbTotal2);
            }
        }

        private void radiobtYear3_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtYear3.Checked)
            {
                lbMonth3.Visible = false;
                cbbMonth3.Visible = false;
                lbYear3.Visible = true;
                cbbYear3.Visible = true;
                dgvCustomerRevenue.DataSource = null;
                chartCustomer.Series["Doanh thu"].Points.Clear();
                tbTop3.Text = "0";
                tbTotal3.Text = "0";
                cbbYear3.Text = "";
                cbbMonth3.Text = "";
            }
        }

        private void radiobtMonth3_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtMonth3.Checked)
            {
                lbMonth3.Visible = true;
                cbbMonth3.Visible = true;
                lbYear3.Visible = true;
                cbbYear3.Visible = true;
                dgvCustomerRevenue.DataSource = null;
                chartCustomer.Series["Doanh thu"].Points.Clear();
                tbTop3.Text = "0";
                tbTotal3.Text = "0";
                cbbYear3.Text = "";
                cbbMonth3.Text = "";
            }

        }

        private void radiobtAll3_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtAll3.Checked)
            {
                lbMonth3.Visible = false;
                cbbMonth3.Visible = false;
                lbYear3.Visible = false;
                cbbYear3.Visible = false;
                dgvCustomerRevenue.DataSource = null;
                chartCustomer.Series["Doanh thu"].Points.Clear();
                SetDGVAll(ref dgvCustomerRevenue, 3);
                SetChart(dgvCustomerRevenue, ref chartCustomer);
                SetTextBoxRevenue(dgvCustomerRevenue, ref tbTop3, ref tbTotal3);
            }
        }

        private void cbbYear3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((radiobtMonth3.Checked))//month
            {
                SetDGVMonth(ref dgvCustomerRevenue, 3, Convert.ToInt32(cbbMonth3.SelectedItem), Convert.ToInt32(cbbYear3.SelectedItem));
            }
            else//year
            {
                SetDGVYear(ref dgvCustomerRevenue, 3, Convert.ToInt32(cbbYear3.SelectedItem));
            }
            SetChart(dgvCustomerRevenue, ref chartCustomer);
            SetTextBoxRevenue(dgvCustomerRevenue, ref tbTop3, ref tbTotal3);
        }

        private void cbbMonth3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radiobtMonth3.Checked && (cbbYear3.SelectedItem.ToString() != ""))//year
            {
                chartCustomer.Series["Doanh thu"].Points.Clear();
                dgvCustomerRevenue.DataSource = null;

                SetDGVMonth(ref dgvCustomerRevenue, 3, Convert.ToInt32(cbbMonth3.SelectedItem), Convert.ToInt32(cbbYear3.SelectedItem));
                SetChart(dgvCustomerRevenue, ref chartCustomer);
                SetTextBoxRevenue(dgvCustomerRevenue, ref tbTop3, ref tbTotal3);
            }
        }
    }
}
