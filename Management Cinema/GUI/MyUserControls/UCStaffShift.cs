﻿using BLL;
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

namespace GUI.MyUserControls
{
    public partial class UCStaffShift : UserControl
    {
        public UCStaffShift()
        {
            InitializeComponent();
        }
        public void SetData(DateTime dt)
        {
            BLL_TBShift bll=new BLL_TBShift();
            List<DTO_Shift> list = bll.GetListShift(dt);
            dtvShift.DataSource = list;


        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            SetData(dtpDate.Value);
        }
    }
}
