namespace 课设服务端
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelFreq = new System.Windows.Forms.Label();
            this.textFreq = new System.Windows.Forms.TextBox();
            this.labelLight = new System.Windows.Forms.Label();
            this.textLight = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(210, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(172, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "物联网智能控制台";
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelIp.Location = new System.Drawing.Point(60, 98);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(70, 27);
            this.labelIp.TabIndex = 0;
            this.labelIp.Text = "灯光IP";
            // 
            // textIP
            // 
            this.textIP.Font = new System.Drawing.Font("Consolas", 10F);
            this.textIP.Location = new System.Drawing.Point(135, 100);
            this.textIP.MaxLength = 15;
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(214, 27);
            this.textIP.TabIndex = 2;
            // 
            // textPort
            // 
            this.textPort.Font = new System.Drawing.Font("Consolas", 10F);
            this.textPort.Location = new System.Drawing.Point(430, 100);
            this.textPort.MaxLength = 5;
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 27);
            this.textPort.TabIndex = 3;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelPort.Location = new System.Drawing.Point(372, 98);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(52, 27);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "端口";
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelFreq.Location = new System.Drawing.Point(130, 49);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(134, 27);
            this.labelFreq.TabIndex = 0;
            this.labelFreq.Text = "通信频率(ms)";
            // 
            // textFreq
            // 
            this.textFreq.Font = new System.Drawing.Font("Consolas", 10F);
            this.textFreq.Location = new System.Drawing.Point(266, 51);
            this.textFreq.MaxLength = 5;
            this.textFreq.Name = "textFreq";
            this.textFreq.Size = new System.Drawing.Size(100, 27);
            this.textFreq.TabIndex = 1;
            // 
            // labelLight
            // 
            this.labelLight.AutoSize = true;
            this.labelLight.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelLight.Location = new System.Drawing.Point(182, 191);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(78, 23);
            this.labelLight.TabIndex = 0;
            this.labelLight.Text = "亮度指标";
            // 
            // textLight
            // 
            this.textLight.Font = new System.Drawing.Font("Consolas", 10F);
            this.textLight.Location = new System.Drawing.Point(266, 189);
            this.textLight.Name = "textLight";
            this.textLight.Size = new System.Drawing.Size(100, 27);
            this.textLight.TabIndex = 4;
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSet.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.buttonSet.Location = new System.Drawing.Point(0, 305);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(582, 48);
            this.buttonSet.TabIndex = 5;
            this.buttonSet.Text = "设定";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textLight);
            this.Controls.Add(this.labelLight);
            this.Controls.Add(this.textFreq);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物联网智能控制台";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.TextBox textFreq;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.TextBox textLight;
        private System.Windows.Forms.Button buttonSet;
    }
}

