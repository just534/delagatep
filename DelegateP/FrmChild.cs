﻿using System;
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
        //正常委托使用 public PassMsgDelegate sendMsg;
        public event PassMsgDelegate sendMsg;
        public FrmChild()
        {
            InitializeComponent();
        }
        public FrmChild(string name):this()
        {
            this.Text = name;
        }
        public void ReceivedMsg(string msg)//接收主窗体广播消息的方法
        {
            this.txtReceived.Text = msg;
        }

        private void btnChildSend_Click(object sender, EventArgs e)
        {
           sendMsg(this.txtChildSend.Text, this.Text);
        }

    }
}
