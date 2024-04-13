using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBReceipt
    {
        public DTO_Receipt GetReceiptDTO(int receipt_id)
        {
            DAL_TBReceipt dal = new DAL_TBReceipt();
            return dal.GetReceiptDTO(receipt_id);
        }
        public int SaveReceipt(DTO_Receipt tBReceiptDTO)
        {
            DAL_TBReceipt dal = new DAL_TBReceipt();
            return dal.SaveReceipt(tBReceiptDTO);
        }
        public int GetId()
        {
            DAL_TBReceipt dal = new DAL_TBReceipt();
            return dal.GetId();
        }
        public List<DTO_Receipt> GetListReceipt()
        {
            DAL_TBReceipt dal = new DAL_TBReceipt();
            return dal.GetListReceipt().OrderByDescending(p => p.datetime_booking).ToList();
        }
        public List<DTO_Receipt> GetListReceiptByCustomerStaffReceiptDatetimebooking(string txt)
        {
            DAL_TBReceipt dal = new DAL_TBReceipt();
            return dal.GetListReceiptByCustomerStaffReceiptDatetimebooking(txt);
        }
        public DTO_ReceiptDetail GetReceiptDetail(int receiptID, int customerID)
        {
            DAL_TBReceipt dal = new DAL_TBReceipt();
            if (customerID != 0)
                return dal.GetReceiptDetailHaveCustomer(receiptID);
            else
                return dal.GetReceiptDetailNonCustomer(receiptID);
        }
    }
}
