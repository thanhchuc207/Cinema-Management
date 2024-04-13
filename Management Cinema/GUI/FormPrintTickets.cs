using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPrintTickets : Form
    {
        int id;
        public FormPrintTickets(int receipt_id)
        {
            InitializeComponent();
            this.id = receipt_id;
            SetCBBItems();

        }

        private void FormPrintTickets_Load(object sender, EventArgs e)
        {
            BLL_TBTicket bll = new BLL_TBTicket();
            List<DTO_Ticket> List = bll.GetListTickets(id);
            LoadTick(List[0]);

            this.rvTickets.RefreshReport();
        }
        public void SetCBBItems()
        {
            BLL_TBTicket bll = new BLL_TBTicket();
            List<DTO_Ticket> list = bll.GetListTickets(id);

            cbbItems.DataSource = list;
        }
        public void LoadTick(DTO_Ticket t)
        {
            string currentFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentFilePath).FullName).FullName).FullName;
            string reportFilePath = Path.Combine(projectDirectory, "ReportTicket.rdlc");
            rvTickets.LocalReport.ReportPath = reportFilePath;
            //rvTickets.LocalReport.ReportPath = @"D:\\ChucChuc\\Hoctap\\C#Code\\Guna3\\GUI\\ReportTicket.rdlc";
            //rvTickets.LocalReport.ReportPath = @"D:\CINEMA\Guna3\GUI\ReportTicket.rdlc";
            ReportParameterCollection para = new ReportParameterCollection();
            para.Add(new ReportParameter("Ticket_id", t.ticket_id.ToString()));
            para.Add(new ReportParameter("movie_name", t.movie_name.ToString()));
            para.Add(new ReportParameter("schedule_date", t.schedule_date.ToString()));
            para.Add(new ReportParameter("schedule_showtime", t.schedule_time.ToString()));
            para.Add(new ReportParameter("room_name", t.room_name.ToString()));
            para.Add(new ReportParameter("seat_name", t.seat_name.ToString()));
            para.Add(new ReportParameter("receipt_id", t.receipt_id.ToString()));
            para.Add(new ReportParameter("price", t.price.ToString()));
            rvTickets.LocalReport.SetParameters(para);
            this.rvTickets.RefreshReport();
        }

        

        private void cbbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentFilePath).FullName).FullName).FullName;
            string reportFilePath = Path.Combine(projectDirectory, "ReportTicket.rdlc");
            rvTickets.LocalReport.ReportPath = reportFilePath;
            //rvTickets.LocalReport.ReportPath = @"D:\\ChucChuc\\Hoctap\\C#Code\\Guna3\\GUI\\ReportTicket.rdlc";
            //rvTickets.LocalReport.ReportPath = @"D:\CINEMA\Guna3\GUI\ReportTicket.rdlc";
            DTO_Ticket t = cbbItems.SelectedItem as DTO_Ticket;
            if (t != null)
            {
                LoadTick(t);
            }
            this.rvTickets.RefreshReport();
        }
    }
}
