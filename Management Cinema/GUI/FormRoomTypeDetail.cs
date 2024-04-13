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
    public partial class FormRoomTypeDetail : Form
    {
        public delegate void formRoomTypeAddEdit_Del();
        public formRoomTypeAddEdit_Del formRoomTyprAddEdit_del { get; set; }
        public int roomTypeID { get; set; }
        public string roomTypeName { get; set; }
        public FormRoomTypeDetail(int ID)
        {
            InitializeComponent();
            roomTypeID = ID;
            if (roomTypeID != 0)
            {
                GUI(roomTypeID);
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GUI(int roomType_id)
        {
            BLL_TBRoom bll = new BLL_TBRoom();
            DTO_CBBRoomType i = bll.GetRoomType(roomTypeID);
            tbRoomTypeName.Text = i.room_type_name;
            roomTypeName = i.room_type_name;
            tbRoomTypePrice.Text = i.room_type_price.ToString();
        }
        private bool CheckValidate()
        {
            if (tbRoomTypeName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng");
                return false;
            }
            if (tbRoomTypePrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập phụ thu loại phòng");
                return false;
            }
            if (tbRoomTypePrice.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng phụ thu loại phòng");
                return false;
            }
            return true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                BLL_TBRoom bll = new BLL_TBRoom();
                DTO_CBBRoomType i = new DTO_CBBRoomType
                {
                    room_type_id = roomTypeID,
                    room_type_name = tbRoomTypeName.Text,
                    room_type_price = Convert.ToInt32(tbRoomTypePrice.Text),
                };
                string message = "";
                if (bll.AddOrUpdateRoomType(i, roomTypeName, ref message))
                {
                    MessageBox.Show(message);
                    formRoomTyprAddEdit_del();
                    Close();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            BLL_TBRoom bll = new BLL_TBRoom();
            if (bll.DeleteRoomType(roomTypeID))
            {
                MessageBox.Show("Xóa thành công");
                formRoomTyprAddEdit_del();
            }
            else
            {
                MessageBox.Show("Xóa thất bại. Tồn tại phòng có loại phòng là loại này");
            }
            Close();
        }
    }
}
