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
    public partial class FormSeatTypeDetail : Form
    {
        public delegate void formSeatTypeAddEditDel();
        public formSeatTypeAddEditDel formSeatTypeAddEdit_del { get; set; }
        public int seattypeID { get; set; }
        public string colorname = "";
        public string colorHex = "";
        public FormSeatTypeDetail(int seattype_id)
        {
            InitializeComponent();
            seattypeID = seattype_id;
            if (seattypeID != 0)
            {
                GUI();
            }
        }
        private void GUI()
        {
            BLL_TBSeat bll = new BLL_TBSeat();
            DTO_Seat_Type i = bll.GetSeatType(seattypeID);
            tbSeatTypeName.Text = i.seat_type_name;
            tbSeatTypePrice.Text = i.seat_type_price_percent.ToString();
            tbColor.BackColor = ColorTranslator.FromHtml("#" + i.seat_type_color);
        }
        private string ConvertToHex(System.Drawing.Color color)
        {
            return string.Format("{0:X2}{1:X2}{2:X2}",
            color.R,
            color.G,
            color.B);
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            DTO_Seat_Type i = new DTO_Seat_Type
            {
                seat_type_id = seattypeID,
                seat_type_name = tbSeatTypeName.Text,
                seat_type_price_percent = Convert.ToInt32(tbSeatTypePrice.Text),
                seat_type_color = colorHex,
            };
            BLL_TBSeat bll = new BLL_TBSeat();
            string message = "";
            if (bll.AddOrUpdateSeatType(i, ref message))
            {
                MessageBox.Show(message);
                formSeatTypeAddEdit_del();
            }
            else
            {
                MessageBox.Show(message);
            }
            Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (seattypeID == 0) Close();
            else
            {
                BLL_TBSeat bll = new BLL_TBSeat();
                if (bll.DeleteSeatType(seattypeID))
                {
                    MessageBox.Show("Xóa thành công");
                    formSeatTypeAddEdit_del();

                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Tồn tại ghế có loại ghế này");
                }
                Close();
            }
        }

        private void btChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                colorHex = ConvertToHex(dlg.Color);
                colorname = dlg.Color.ToString();
                tbColor.BackColor = dlg.Color;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
