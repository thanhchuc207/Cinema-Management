using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBSeat
    {
        public string GetSeatType(string seat_name, int room_id)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetSeatType(seat_name, room_id);
        }
        public string GetSeatName(int seat_id)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetSeatName(seat_id);
        }
        public string GetRoomName(int seat_id)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetRoomName(seat_id);
        }
        public int GetSeat_id(string seat_name, int room_id)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetSeat_id(seat_name, room_id);
        }
        public int GetPricePersent(int seat_id)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetPricePersent(seat_id);
        }
        public int GetPricePersent(bool isVip)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetPricePersent(isVip);
        }
        public void AddListSeat(List<DTO_Seat> list)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            dal.AddListSeat(list);
        }
        public List<DTO_Seat_Type> GetListSeatType()
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetListSeatType();
        }
        public int GetIdByName(string name, int room_id)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetIdByName(name, room_id);
        }
        public string GetColor(int id)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetColor(id);
        }
        public bool CheckSameSeatType(DTO_Seat_Type i, ref string message)
        {
            if (i.seat_type_id == 0)
            {
                foreach (var item in GetListSeatType())
                {
                    if (i.seat_type_name == item.seat_type_name)
                    {
                        message = "Tên loại ghế này đã tồn tại trong hệ thống";
                        return false;
                    }
                    if (i.seat_type_color == item.seat_type_color)
                    {
                        message = "Màu loại ghế này đã tồn tại trong hệ thống";
                        return false;
                    }
                }
                return true;
            }
            else
            {
                foreach (var item in GetListSeatType())
                {
                    if ((i.seat_type_id != item.seat_type_id) && (i.seat_type_name == item.seat_type_name))
                    {
                        message = "Tên loại ghế này đã tồn tại trong hệ thống";
                        return false;
                    }
                    if ((i.seat_type_id != item.seat_type_id) && (i.seat_type_color == item.seat_type_color))
                    {
                        message = "Màu loại ghế này đã tồn tại trong hệ thống";
                        return false;
                    }
                }
                return true;
            }
        }
        public bool AddOrUpdateSeatType(DTO_Seat_Type i, ref string message)
        {
            if (CheckSameSeatType(i, ref message))
            {
                if (i.seat_type_id == 0)
                {
                    AddSeatType(i);
                    message = "Thêm thành công";
                }
                else
                {
                    UpdateSeatType(i);
                    message = "Cập nhật thành công";
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddSeatType(DTO_Seat_Type i)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            dal.AddSeatType(i);
        }
        public void UpdateSeatType(DTO_Seat_Type i)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            dal.UpdateSeatType(i);
        }
        public DTO_Seat_Type GetSeatType(int ID)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetSeatType(ID);
        }
        public bool DeleteSeatType(int ID)
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.DeleteSeatType(ID);
        }
        public List<DTO_CBBSeatType> GetListCBBSeatType()
        {
            DAL_TBSeat dal = new DAL_TBSeat();
            return dal.GetListCBBSeatType();
        }
    }
}
