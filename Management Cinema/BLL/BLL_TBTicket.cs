using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBTicket
    {
        public List<DTO_Ticket> GetListTickets(int receipt_id)
        {
            DAL_TBTicket dal = new DAL_TBTicket();
            return dal.GetListTickets(receipt_id);
        }
    }
}
