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
    public partial class UCReceipt : UserControl
    {
        private static UCReceipt _instance;
        public static UCReceipt Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCReceipt();
                return _instance;
            }
        }
        public UCReceipt()
        {
            InitializeComponent();
        }
    }
}
