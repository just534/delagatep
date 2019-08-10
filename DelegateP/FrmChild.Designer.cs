namespace DelegateP
{
    partial class FrmChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChildSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChildSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChildSend
            // 
            this.txtChildSend.Location = new System.Drawing.Point(27, 31);
            this.txtChildSend.Multiline = true;
            this.txtChildSend.Name = "txtChildSend";
            this.txtChildSend.Size = new System.Drawing.Size(396, 122);
            this.txtChildSend.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "发送的消息：";
            // 
            // txtReceived
            // 
            this.txtReceived.BackColor = System.Drawing.Color.Black;
            this.txtReceived.ForeColor = System.Drawing.Color.White;
            this.txtReceived.Location = new System.Drawing.Point(27, 222);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(396, 122);
            this.txtReceived.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "收到的消息：";
            // 
            // btnChildSend
            // 
            this.btnChildSend.Location = new System.Drawing.Point(348, 179);
            this.btnChildSend.Name = "btnChildSend";
            this.btnChildSend.Size = new System.Drawing.Size(75, 23);
            this.btnChildSend.TabIndex = 2;
            this.btnChildSend.Text = "发送消息";
            this.btnChildSend.UseVisualStyleBackColor = true;
            this.btnChildSend.Click += new System.EventHandler(this.btnChildSend_Click);
            // 
            // FrmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 355);
            this.Controls.Add(this.btnChildSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChildSend);
            this.Name = "FrmChild";
            this.Text = "委托练习：子窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChildSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChildSend;
    }
}