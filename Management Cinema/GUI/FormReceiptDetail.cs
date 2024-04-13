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

namespace Guna3
{
    public partial class FormReceiptDetail : Form
    {
        public int receipt_id { get; set; }
        public int customer_id { get; set; }
        public FormReceiptDetail(int receiptID, int customerID)
        {
            InitializeComponent();
            receipt_id = receiptID;
            customer_id = customerID;
            GUI();
        }
        private void GUI()
        {
            BLL_TBReceipt bll = new BLL_TBReceipt();
            DTO_ReceiptDetail i = bll.GetReceiptDetail(receipt_id, customer_id);
            tbReceiptID.Text = receipt_id.ToString();
            if (i.customer_id != 0)
            {
                tbCustomerID.Text = i.customer_id.ToString();
                tbNameCustomer.Text = i.customer_name.ToString();
            }
            else
            {
                tbCustomerID.Text = "";
                tbNameCustomer.Text = "";
            }
            tbStaffID.Text = i.staff_id.ToString();
            tbNameStaff.Text = i.staff_name;
            tbDateTimeBooking.Text = i.datetimebooking.ToString();
            tbMovie.Text = i.movie_name;
            tbStarttime.Text = i.schedule_start.ToString();
            tbDate.Text = i.schedule_date.ToString();
            tbRoom.Text = i.room_name;
            tbNumSeatBooking.Text = i.number_of_tickets.ToString();

            tbPrice.Text = i.movie_price.ToString();
            try
            {
                double flPrice = double.Parse(i.movie_price.ToString().Replace(",", ""));
                tbPrice.Text = flPrice.ToString("0,00.##");
                tbPrice.Select(tbPrice.TextLength, 0);
            }
            catch (Exception e2)
            {
            }

            tbTotal.Text = i.total.ToString();
            try
            {
                double flPrice = double.Parse(i.total.ToString().Replace(",", ""));
                tbTotal.Text = flPrice.ToString("0,00.##");
                tbTotal.Select(tbTotal.TextLength, 0);
            }
            catch (Exception e2)
            {
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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
