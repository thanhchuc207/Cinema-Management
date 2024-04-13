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
    public partial class UCMovie : UserControl
    {
        private static UCMovie _instance;
        public static UCMovie Instance
        {
            get
            {
                if(_instance == null )
                    _instance = new UCMovie();
                return _instance;
            }
        }
        public UCMovie()
        {
            InitializeComponent();
        }
    }
}
