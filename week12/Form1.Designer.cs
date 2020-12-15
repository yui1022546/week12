
namespace week12
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuTxb = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.showTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入目录";
            // 
            // menuTxb
            // 
            this.menuTxb.Location = new System.Drawing.Point(64, 102);
            this.menuTxb.Name = "menuTxb";
            this.menuTxb.Size = new System.Drawing.Size(100, 21);
            this.menuTxb.TabIndex = 1;
            this.menuTxb.TextChanged += new System.EventHandler(this.menuTxb_TextChanged);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(73, 147);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "button1";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // showTxb
            // 
            this.showTxb.Location = new System.Drawing.Point(244, 43);
            this.showTxb.Multiline = true;
            this.showTxb.Name = "showTxb";
            this.showTxb.Size = new System.Drawing.Size(224, 232);
            this.showTxb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 341);
            this.Controls.Add(this.showTxb);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.menuTxb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox menuTxb;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox showTxb;
    }
}

