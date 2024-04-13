using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3.UC
{
    public partial class UCStaffDetail : UserControl
    {
        public UCStaffDetail(int ID)
        {
            InitializeComponent();
            LoadCBBRole();
            if(ID!=0)
                GUI(ID);
        }

       private void LoadCBBRole()
        {
            DTO_CBBRole staff = new DTO_CBBRole
            {
                role_id = false,
                role_name= "Nhân viên"
                
            };
            DTO_CBBRole manager = new DTO_CBBRole
            {
                role_id = true,
                role_name = "Quản lý"
            };
        }
        private void GUI(int ID)
        {
            
            BLL_TBStaff db = new BLL_TBStaff();
            DTO_Staff i = db.GetStaff(ID);
            tbID.Text = i.staff_id.ToString();
            tbName.Text = i.staff_name.ToString();
            dtpkBirthday.Value = i.staff_birthday;
            tbPhone.Text=i.staff_phone.ToString();
            tbEmail.Text=i.email.ToString();
            if (i.role == false)
                cbbRole.Text="Nhân viên";
            else cbbRole.Text="Quản lý";
            if (i.staff_gender) rdobtFemale.Checked = true;
            else rdobtMale.Checked = true;

        }
         
    }
}
