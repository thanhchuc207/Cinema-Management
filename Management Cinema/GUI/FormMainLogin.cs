using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using GUI.MyUserControls;

namespace GUI
{
    public partial class FormMainLogin : Form
    {
        private List<string> list;
        private static int ck = 0;

        public FormMainLogin()
        {
            InitializeComponent();
            pnMain.Controls.Add(new UCLogin());
            BLL_TBMovie bll = new BLL_TBMovie();
            list = bll.GetListImgageMovie();

        }
        public void RemoveUserControl(UserControl uc)
        {
            pnMain.Controls.Remove(uc);
        }

        public void LoadUsercontrol(UserControl uc)
        {
            pnMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string temp = list[ck];
            if (temp != null)
            {
                pbMovie.Image = Image.FromFile(temp);
            }
            if (ck == list.Count - 1)
            {
                ck = 0;
            }
            else
                ck++;

        }

        public void ClosedForm(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }
    }
}
