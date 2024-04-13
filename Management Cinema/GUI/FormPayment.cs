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

namespace GUI
{
   

    public partial class FormPayment : Form
    {
        DTO_TBSchedule schedule;
        DTO_Receipt receipt;
        List<DTO_TBSeatBooking> seats;
        public FormPayment(DTO_Receipt receipt, List<DTO_TBSeatBooking> ls)
        {
            BLL_TBSchedule bllSchedule = new BLL_TBSchedule();
            BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
            InitializeComponent();
            seats = ls;
            this.receipt = receipt;
            schedule = bllSchedule.GetScheduleDTO(receipt.schedule_id);
            string seat = bllSeatBooking.GetSeat(ls);
            lblViewSeat.Text = seat;
            LoadView();

        }
        public void LoadView()
        {
            BLL_TBMovie bllMovie=new BLL_TBMovie();
            BLL_TBRoom bllRoom = new BLL_TBRoom();
            BLL_TBSchedule bllSchedule = new BLL_TBSchedule();
            lblResult.Visible = false;
            string name_movie = bllMovie.GetNameMovie(schedule.movie_id);
            lblViewMovie.Text = name_movie;
            lblViewDate.Text = schedule.schedule_date.ToString("dd/MM/yyyy");
            lblViewSchedule.Text = schedule.schedule_start.ToString("hh\\:mm") + " ~ " + schedule.schedule_end.ToString("hh\\:mm");
            lblViewRoom.Text = bllRoom.GetNameRoom(schedule.room_id);
            lblViewSumOfSeat.Text = receipt.number_of_tickets.ToString();
            lblTotalPrice.Text = receipt.total_price.ToString();
            lblViewPrice.Text = bllSchedule.GetPrice(schedule.schedule_id).ToString();

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
        public void CloseForm()
        {
            FormBookChair frm = this.Owner as FormBookChair;
            frm.CloseForm();
            this.Close();
        }

        private void btnFindCustomer_Click_1(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                lblResult.Text = "Vui lòng nhập số điện thoại";
                if (lblResult.Visible == false)
                {
                    lblResult.Visible = true;
                }
            }
            else
            {
                BLL_TBCustomer bllCustomer = new BLL_TBCustomer();
                bool ck = bllCustomer.CheckPhone(txtPhone.Text);
                if (ck == false)
                {
                    lblResult.Text = "Không tìm thấy khách hàng!";
                    if (lblResult.Visible == false)
                    {
                        lblResult.Visible = true;
                    }
                }
                else
                {
                    DTO_Customer cus = bllCustomer.GetTBCustomerDTO(txtPhone.Text);
                    txtNameCustomer.Text = cus.customer_name.ToString();
                    txtBirthday.Value = cus.customer_birthday;
                    txtAddress.Text = cus.customer_address.ToString();
                    txtPoint.Text = cus.customer_points.ToString();
                }
            }
        }

        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            BLL_TBCustomer bllCustomer = new BLL_TBCustomer();
            BLL_TBReceipt bllReceipt = new BLL_TBReceipt();
            receipt.datetime_booking = DateTime.Now;
            DialogResult d;
            d = MessageBox.Show("Bạn có muốn sử dụng tài khoản người dùng không?", "Thanh toán", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if(bllCustomer.CheckFormatIsPhone(txtPhone.Text) && bllCustomer.CheckFormatName(txtNameCustomer.Text) && bllCustomer.CheckFormatAddress(txtAddress.Text) && bllCustomer.CheckFormatBirday(txtBirthday.Value))
                {
                    if (bllCustomer.CheckPhone(txtPhone.Text))//check sdt
                    {
                        DTO_Customer cus = bllCustomer.GetTBCustomerDTO(txtPhone.Text);
                        if (txtAddress.Text == cus.customer_address && txtNameCustomer.Text == cus.customer_name && cus.customer_birthday == txtBirthday.Value)
                        {
                            receipt.customer_id = bllCustomer.GetID(txtPhone.Text);
                            int id = bllReceipt.SaveReceipt(receipt);
                            foreach (DTO_TBSeatBooking i in seats)
                            {
                                i.receipt_id = id;
                            }
                            BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
                            bllSeatBooking.SaveBooking(seats);
                            cus.customer_points += int.Parse(lblViewSumOfSeat.Text) * 10;
                            bllCustomer.SaveOrUpdate(cus);
                            FormPrintReceipt frm = new FormPrintReceipt(id);
                            MessageBox.Show("Thanh toán thành công");
                            frm.ShowDialog(this);
                        }
                        else
                        {
                            DialogResult d1;
                            d1 = MessageBox.Show("Số điện thoại bị trùng bạn có muốn cập nhật lại thông tin cá nhân không?", "Cập nhật thông tin", MessageBoxButtons.YesNo);
                            if (d1 == DialogResult.Yes)
                            {

                                receipt.customer_id = bllCustomer.GetID(txtPhone.Text);
                                int id = bllReceipt.SaveReceipt(receipt);
                                foreach (DTO_TBSeatBooking i in seats)
                                {
                                    i.receipt_id = id;
                                }
                                BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
                                bllSeatBooking.SaveBooking(seats);
                                cus.customer_points += int.Parse(lblViewSumOfSeat.Text) * 10;
                                cus.customer_name = txtNameCustomer.Text;
                                cus.customer_address = txtAddress.Text;
                                cus.customer_birthday = txtBirthday.Value;
                                bllCustomer.SaveOrUpdate(cus);
                                FormPrintReceipt frm = new FormPrintReceipt(id);
                                MessageBox.Show("Thanh toán thành công");
                                frm.ShowDialog(this);
                            }
                            else
                            {

                                receipt.customer_id = bllCustomer.GetID(txtPhone.Text);
                                int id = bllReceipt.SaveReceipt(receipt);
                                foreach (DTO_TBSeatBooking i in seats)
                                {
                                    i.receipt_id = id;
                                }
                                BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
                                bllSeatBooking.SaveBooking(seats);
                                cus.customer_points += int.Parse(lblViewSumOfSeat.Text) * 10;
                                bllCustomer.SaveOrUpdate(cus);
                                FormPrintReceipt frm = new FormPrintReceipt(id);
                                MessageBox.Show("Thanh toán thành công");
                                frm.ShowDialog(this);
                            }
                        }
                    }
                    else
                    {
                        if (txtAddress.Text != "" && txtNameCustomer.Text != "" && txtPhone.Text != "" && txtBirthday.Text != "")
                        {
                            DTO_Customer cus = new DTO_Customer();
                            cus.customer_birthday = txtBirthday.Value;
                            cus.customer_address = txtAddress.Text;
                            cus.customer_name = txtNameCustomer.Text;
                            cus.customer_phone = txtPhone.Text;
                            cus.customer_points = 0;
                            receipt.customer_id = bllCustomer.SetCustomer(cus);
                            int id = bllReceipt.SaveReceipt(receipt);
                            foreach (DTO_TBSeatBooking i in seats)
                            {
                                i.receipt_id = id;
                            }
                            BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
                            bllSeatBooking.SaveBooking(seats);
                            cus.customer_points = int.Parse(lblViewSumOfSeat.Text) * 10;
                            bllCustomer.SaveOrUpdate(cus);
                            FormPrintReceipt frm = new FormPrintReceipt(id);
                            MessageBox.Show("Thanh toán thành công");
                            frm.ShowDialog(this);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        }
                    }
                }
                else
                {

                    MessageBox.Show("Lỗi cú pháp thông tin vui lòng nhập lại");
                }
            }
            else
            {
                int id = bllReceipt.SaveReceipt(receipt);
                foreach (DTO_TBSeatBooking i in seats)
                {
                    i.receipt_id = id;
                }
                BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
                bllSeatBooking.SaveBooking(seats);
                FormPrintReceipt frm = new FormPrintReceipt(id);
                MessageBox.Show("Thanh toán thành công");
                frm.ShowDialog(this);
            }
        }

    }
}
