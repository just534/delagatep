using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateP
{
    public partial class FrmChild : Form
    {
        public PassMsgDelegate sendMsg;
        public FrmChild()
        {
            InitializeComponent();
        }
        public FrmChild(string name):this()
        {
            this.Text = name;
        }

        private void btnChildSend_Click(object sender, EventArgs e)
        {
            sendMsg(this.txtChildSend.Text, this.Text);
        }

    }
}
