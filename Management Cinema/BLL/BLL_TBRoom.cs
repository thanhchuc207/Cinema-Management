using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBRoom
    {
        public DTO_TBRoom GetRoom(int room_id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetRoom(room_id);
        }
        public string GetNameRoom(int room_id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetNameRoom(room_id);
        }
        public int GetRoomTypePricePercent(int roomType_id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetRoomTypePricePercent(roomType_id);
        }
        public int GetRoomPricePercent(int room_id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetRoomPricePercent(room_id);
        }
        public string GetRoomTypeName(int room_type_id)
        {
            DAL_TBRoom room = new DAL_TBRoom();
            return room.GetRoomTypeName(room_type_id);
        }
        public List<int> GetListRoomType()
        {
            DAL_TBRoom room = new DAL_TBRoom();
            return room.GetListRoomType();
        }
        public List<DTO_CBBRoomType> GetAllRoomTypes()
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetAllRoomTypes();
        }
        public List<DTO_CBBRoom> GetAllRoomNameByType(int id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetAllRoomNameByType(id);
        }
        public List<DTO_CBBRoom> GetRoomNameByTypeAndName(int id, string txt)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetRoomNameByTypeAndName(id, txt);
        }
        public List<DTO_CBBRoom> GetAllRoomNames()
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetAllRoomNames();
        }
        public DTO_Room GetRoomByID(int id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetRoomByID(id);
        }
        public bool AddOrUpdateRoom(DTO_Room i, ref string txt, List<DTO_Seat> seats)
        {
            if (i.room_id == 0)
            {
                if (CheckSameRoomName(i.room_id, i.room_name))
                {
                    int room_id = AddRoom(i);
                    foreach (DTO_Seat seat in seats)
                    {
                        seat.room_id = room_id;
                    }
                    txt = "Thêm thành công";
                    BLL_TBSeat bllSeat = new BLL_TBSeat();
                    bllSeat.AddListSeat(seats);
                    return true;
                }
                else
                {
                    txt = "Trùng tên phòng. Vui lòng chọn tên khác";
                    return false;
                }

            }
            else
            {
                if (CheckSameRoomName(i.room_id, i.room_name))
                {
                    if (UpdateRoom(i))
                    {
                        txt = "Cập nhật thành công";
                        return true;
                    }
                    else
                    {
                        txt = "Không thể thay đổi thông tin. Tồn tại vé đã đặt ở phòng này";
                        return false;
                    }
                }
                else
                {
                    txt = "Trùng tên phòng. Vui lòng chọn tên khác";
                    return false;
                }
            }
        }
        public bool CheckSameRoomName(int roomID, string txt)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.CheckSameRoomName(roomID, txt);
        }
        public int AddRoom(DTO_Room i)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.AddRoom(i);
        }
        public bool UpdateRoom(DTO_Room i)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.UpdateRoom(i);
        }
        public bool DeleteRoom(int roomID)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.DeleteRoom(roomID);
        }
        public List<DTO_RoomType> GetAllRoomType()
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetAllRoomType();
        }
        public DTO_CBBRoomType GetRoomType(int id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.GetRoomType(id);
        }
        public bool CheckSameRoomTypeName(string txt)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.CheckSameRoomTypeName(txt);
        }
        public void AddRoomType(DTO_CBBRoomType i)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            dal.AddRoomType(i);
        }
        public void UpdateRoomType(DTO_CBBRoomType i)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            dal.UpdateRoomType(i);
        }
        public bool AddOrUpdateRoomType(DTO_CBBRoomType i, string roomTypeName, ref string txt)
        {
            if (i.room_type_id == 0)
            {
                if (CheckSameRoomTypeName(i.room_type_name))
                {
                    AddRoomType(i);
                    txt = "Thêm thành công";
                    return true;
                }
                else
                {
                    txt = "Đã tồn tại loại phòng này. Vui lòng nhập tên khác";
                    return false;
                }
            }
            else
            {
                if (i.room_type_name != roomTypeName)
                {
                    if (CheckSameRoomTypeName(i.room_type_name))
                    {
                        UpdateRoomType(i);
                        txt = "Cập nhật thành công";
                        return true;
                    }
                    else
                    {
                        txt = "Đã tồn tại loại phòng này. Vui lòng nhập tên khác";
                        return false;
                    }
                }
                else
                {
                    UpdateRoomType(i);
                    txt = "Cập nhật thành công";
                    return true;
                }
            }
        }
        public bool DeleteRoomType(int room_type_id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            return dal.DeleteRoomType(room_type_id);
        }

    }
}
