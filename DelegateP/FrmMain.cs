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
    public partial class FrmMain : Form
    {
        public BcMsgDelegate bcMsg;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void ReceiveMsg(string Msg,string childname)
        {
            this.txtReceived.Text += $"收到消息:{Msg},来自窗体     {childname}\r\n";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                FrmChild child = new FrmChild("子窗体"+(i+1).ToString());
                child.sendMsg = this.ReceiveMsg;
                this.bcMsg += child.ReceivedMsg;
                child.Show();
                 
            }
          
            
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            bcMsg(this.txtSend.Text);
        }
    }
    public delegate void PassMsgDelegate(string msg, string childname);
    public delegate void BcMsgDelegate(string msg);
}
