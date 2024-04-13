using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3.UC
{
    public partial class UCStaff : UserControl
    {
        private static UCStaff _instance;
        public static UCStaff Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCStaff();
                return _instance;
            }
        }
        public UCStaff()
        {
            InitializeComponent();
        }
    }
}
