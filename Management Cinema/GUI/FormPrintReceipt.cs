using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.IO;

namespace GUI
{
    public partial class FormPrintReceipt : Form
    {
        int id;

        public FormPrintReceipt(int receipt_id)
        {
            BLL_TBTicket bll = new BLL_TBTicket();
            InitializeComponent();
            List<DTO_Ticket> booking = bll.GetListTickets(receipt_id);

            this.id = receipt_id;

        }

        private void FormPrintReceipt_Load(object sender, EventArgs e)
        {
            BLL_TBReceipt bllReceipt = new BLL_TBReceipt();

            BLL_TBTicket bllTicket = new BLL_TBTicket();
            List<DTO_Ticket> booking = bllTicket.GetListTickets(id);

            string currentFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentFilePath).FullName).FullName).FullName;
            string reportFilePath = Path.Combine(projectDirectory, "ReportReceipt.rdlc");
            rvData.LocalReport.ReportPath = @reportFilePath;
            
            //rvData.LocalReport.ReportPath = @"D:\ChucChuc\Hoctap\C#Code\Guna3\GUI\ReportReceipt.rdlc";
            //rvData.LocalReport.ReportPath = @"D:\CINEMA\Guna3\GUI\ReportReceipt.rdlc";
            var source = new ReportDataSource("dtsTickets", booking);
            DTO_Receipt receipt = bllReceipt.GetReceiptDTO(id);
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("rpparaIdReceipt", receipt.receipt_id.ToString()));
            parameters.Add(new ReportParameter("rpparaIdCustomer", receipt.customer_id.ToString()));
            parameters.Add(new ReportParameter("rpparaNumberOfTicket", receipt.number_of_tickets.ToString()));
            parameters.Add(new ReportParameter("rpparaIdStaff", receipt.staff_id.ToString()));
            parameters.Add(new ReportParameter("rpparaTotalPrice", receipt.total_price.ToString()));
            parameters.Add(new ReportParameter("rpparaDateTime", receipt.datetime_booking.ToString("dd/MM/yyyy")));
            rvData.LocalReport.DataSources.Clear();
            rvData.LocalReport.SetParameters(parameters);

            rvData.LocalReport.DataSources.Add(source);


            this.rvData.RefreshReport();

        }
    
        private void btnBooking_Click(object sender, EventArgs e)
        {
            FormPrintTickets tic = new FormPrintTickets(id);
            tic.ShowDialog();

        }

        private void FormPrintReceipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPayment frm = this.Owner as FormPayment;
            frm.CloseForm();
            this.Close();

        }
    }
}
