namespace DelegateP
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateForm = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCloseChildForms = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReceived
            // 
            this.txtReceived.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtReceived.ForeColor = System.Drawing.Color.Transparent;
            this.txtReceived.Location = new System.Drawing.Point(25, 75);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(386, 149);
            this.txtReceived.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "收到的消息：";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(25, 264);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(386, 149);
            this.txtSend.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "广播的消息：";
            // 
            // btnCreateForm
            // 
            this.btnCreateForm.Location = new System.Drawing.Point(437, 75);
            this.btnCreateForm.Name = "btnCreateForm";
            this.btnCreateForm.Size = new System.Drawing.Size(107, 23);
            this.btnCreateForm.TabIndex = 2;
            this.btnCreateForm.Text = "创建子窗体";
            this.btnCreateForm.UseVisualStyleBackColor = true;
            this.btnCreateForm.Click += new System.EventHandler(this.btnCreateForm_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(437, 116);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(107, 23);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "清空消息";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnCloseChildForms
            // 
            this.btnCloseChildForms.Location = new System.Drawing.Point(437, 159);
            this.btnCloseChildForms.Name = "btnCloseChildForms";
            this.btnCloseChildForms.Size = new System.Drawing.Size(107, 23);
            this.btnCloseChildForms.TabIndex = 2;
            this.btnCloseChildForms.Text = "关闭子窗体";
            this.btnCloseChildForms.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(437, 390);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "广播消息";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 434);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCloseChildForms);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnCreateForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReceived);
            this.Name = "FrmMain";
            this.Text = "委托练习：主窗口";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateForm;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCloseChildForms;
        private System.Windows.Forms.Button btnSend;
    }
}

