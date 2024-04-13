using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_TBReceipt
    {
        public DTO_Receipt GetReceiptDTO(int receipt_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                DTO_Receipt ret = new DTO_Receipt();
                TBReceipt get = db.TBReceipt.Where(p => p.receipt_id == receipt_id).FirstOrDefault();
                if (get != null)
                {
                    ret.receipt_id = get.receipt_id;
                    ret.total_price = get.total_price;
                    ret.staff_id = get.staff_id;
                    ret.customer_id = get.customer_id;
                    ret.datetime_booking = get.datetime_booking;
                    ret.number_of_tickets = get.number_of_tickets;
                    ret.schedule_id = get.schedule_id;
                }
                return ret;
            }
        }

        public int SaveReceipt(DTO_Receipt tBReceiptDTO)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBReceipt receipt = new TBReceipt();
                receipt.total_price = tBReceiptDTO.total_price;
                receipt.datetime_booking = tBReceiptDTO.datetime_booking;
                if (tBReceiptDTO.customer_id != null)
                {
                    receipt.customer_id = tBReceiptDTO.customer_id;
                }
                receipt.number_of_tickets = tBReceiptDTO.number_of_tickets;
                receipt.schedule_id = tBReceiptDTO.schedule_id;
                receipt.staff_id = tBReceiptDTO.staff_id;
                db.TBReceipt.Add(receipt);
                db.SaveChanges();
                int id_receip = GetId();
                return id_receip;
            }
        }
        public int GetId()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int id = db.TBReceipt.OrderByDescending(p => p.receipt_id).Select(p => p.receipt_id).FirstOrDefault();
                return id;
            }
        }

        public List<DTO_Receipt> GetListReceipt()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = from TBReceipt a in db.TBReceipt
                        join TBSchedule d in db.TBSchedule on a.schedule_id equals d.schedule_id
                        select new DTO_Receipt
                        {
                            receipt_id = a.receipt_id,
                            staff_id = a.staff_id,
                            customer_id = a.customer_id,
                            schedule_id = d.schedule_id,
                            datetime_booking = a.datetime_booking,
                            number_of_tickets = a.number_of_tickets,
                            total_price = a.total_price,
                        };
                return s.ToList();
            }
        }
        public List<DTO_Receipt> GetListReceiptByCustomerStaffReceiptDatetimebooking(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = from TBReceipt a in db.TBReceipt
                        join TBSchedule d in db.TBSchedule on a.schedule_id equals d.schedule_id
                        where (a.receipt_id.ToString().Contains(txt) || a.customer_id.ToString().Contains(txt))
                        select new DTO_Receipt
                        {
                            receipt_id = a.receipt_id,
                            staff_id = a.staff_id,
                            customer_id = a.customer_id,
                            schedule_id = d.schedule_id,
                            datetime_booking = a.datetime_booking,
                            number_of_tickets = a.number_of_tickets,
                            total_price = a.total_price,
                        };
                return s.ToList();
            }
        }
        public DTO_ReceiptDetail GetReceiptDetailHaveCustomer(int receiptID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = from TBReceipt a in db.TBReceipt
                        join TBStaff b in db.TBStaff on a.staff_id equals b.staff_id
                        join TBCustomer c in db.TBCustomer on a.customer_id equals c.customer_id
                        join TBSchedule d in db.TBSchedule on a.schedule_id equals d.schedule_id
                        join TBMovie e in db.TBMovie on d.movie_id equals e.movie_id
                        join TBRoom h in db.TBRoom on d.room_id equals h.room_id
                        where a.receipt_id == receiptID
                        select new DTO_ReceiptDetail
                        {
                            receipt_id = a.receipt_id,
                            customer_id = c.customer_id,
                            customer_name = c.customer_name,
                            staff_id = b.staff_id,
                            staff_name = b.staff_name,
                            datetimebooking = a.datetime_booking,
                            movie_name = e.movie_name,
                            schedule_start = d.schedule_start,
                            schedule_date = d.schedule_date,
                            room_name = h.room_name,
                            number_of_tickets = a.number_of_tickets,
                            movie_price = e.movie_price,
                            total = a.total_price
                        }
                        ; ;
                return s.FirstOrDefault();
            }
        }
        public DTO_ReceiptDetail GetReceiptDetailNonCustomer(int receiptID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = from TBReceipt a in db.TBReceipt
                        join TBStaff b in db.TBStaff on a.staff_id equals b.staff_id
                        join TBSchedule d in db.TBSchedule on a.schedule_id equals d.schedule_id
                        join TBMovie e in db.TBMovie on d.movie_id equals e.movie_id
                        join TBRoom h in db.TBRoom on d.room_id equals h.room_id
                        where a.receipt_id == receiptID
                        select new DTO_ReceiptDetail
                        {
                            receipt_id = a.receipt_id,
                            customer_id = 0,
                            customer_name = "",
                            staff_id = b.staff_id,
                            staff_name = b.staff_name,
                            datetimebooking = a.datetime_booking,
                            movie_name = e.movie_name,
                            schedule_start = d.schedule_start,
                            schedule_date = d.schedule_date,
                            room_name = h.room_name,
                            number_of_tickets = a.number_of_tickets,
                            movie_price = e.movie_price,
                            total = a.total_price
                        }
                        ;
                return s.FirstOrDefault();
            }
        }

    }
}
