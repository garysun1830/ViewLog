using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLog
{
    public partial class fmMessageCopy : Form
    {
        public string Message
        {
            set
            {
                txtMessage.Text = value;
            }
        }

        public fmMessageCopy()
        {
            InitializeComponent();
        }
    }
}
