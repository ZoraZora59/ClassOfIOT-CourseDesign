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
            this.labelCurtainIP = new System.Windows.Forms.Label();
            this.textCurtainIP = new System.Windows.Forms.TextBox();
            this.textCurtainPort = new System.Windows.Forms.TextBox();
            this.labelCurtainPort = new System.Windows.Forms.Label();
            this.labelFreq = new System.Windows.Forms.Label();
            this.textFreq = new System.Windows.Forms.TextBox();
            this.labelLightCheck = new System.Windows.Forms.Label();
            this.textLight = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.textTranLightPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTranLightIP = new System.Windows.Forms.TextBox();
            this.labelTranLight = new System.Windows.Forms.Label();
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
            // labelCurtainIP
            // 
            this.labelCurtainIP.AutoSize = true;
            this.labelCurtainIP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelCurtainIP.Location = new System.Drawing.Point(60, 98);
            this.labelCurtainIP.Name = "labelCurtainIP";
            this.labelCurtainIP.Size = new System.Drawing.Size(70, 27);
            this.labelCurtainIP.TabIndex = 0;
            this.labelCurtainIP.Text = "窗帘IP";
            // 
            // textCurtainIP
            // 
            this.textCurtainIP.Font = new System.Drawing.Font("Consolas", 10F);
            this.textCurtainIP.Location = new System.Drawing.Point(135, 100);
            this.textCurtainIP.MaxLength = 15;
            this.textCurtainIP.Name = "textCurtainIP";
            this.textCurtainIP.Size = new System.Drawing.Size(214, 27);
            this.textCurtainIP.TabIndex = 2;
            // 
            // textCurtainPort
            // 
            this.textCurtainPort.Font = new System.Drawing.Font("Consolas", 10F);
            this.textCurtainPort.Location = new System.Drawing.Point(430, 100);
            this.textCurtainPort.MaxLength = 5;
            this.textCurtainPort.Name = "textCurtainPort";
            this.textCurtainPort.Size = new System.Drawing.Size(100, 27);
            this.textCurtainPort.TabIndex = 3;
            // 
            // labelCurtainPort
            // 
            this.labelCurtainPort.AutoSize = true;
            this.labelCurtainPort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelCurtainPort.Location = new System.Drawing.Point(372, 98);
            this.labelCurtainPort.Name = "labelCurtainPort";
            this.labelCurtainPort.Size = new System.Drawing.Size(52, 27);
            this.labelCurtainPort.TabIndex = 0;
            this.labelCurtainPort.Text = "端口";
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelFreq.Location = new System.Drawing.Point(130, 49);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(134, 27);
            this.labelFreq.TabIndex = 0;
            this.labelFreq.Text = "检测频率(ms)";
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
            // labelLightCheck
            // 
            this.labelLightCheck.AutoSize = true;
            this.labelLightCheck.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelLightCheck.Location = new System.Drawing.Point(174, 195);
            this.labelLightCheck.Name = "labelLightCheck";
            this.labelLightCheck.Size = new System.Drawing.Size(78, 23);
            this.labelLightCheck.TabIndex = 0;
            this.labelLightCheck.Text = "亮度指标";
            // 
            // textLight
            // 
            this.textLight.Font = new System.Drawing.Font("Consolas", 10F);
            this.textLight.Location = new System.Drawing.Point(258, 195);
            this.textLight.Name = "textLight";
            this.textLight.Size = new System.Drawing.Size(100, 27);
            this.textLight.TabIndex = 4;
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSet.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.buttonSet.Location = new System.Drawing.Point(0, 255);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(582, 48);
            this.buttonSet.TabIndex = 5;
            this.buttonSet.Text = "设定";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // textTranLightPort
            // 
            this.textTranLightPort.Font = new System.Drawing.Font("Consolas", 10F);
            this.textTranLightPort.Location = new System.Drawing.Point(430, 149);
            this.textTranLightPort.MaxLength = 5;
            this.textTranLightPort.Name = "textTranLightPort";
            this.textTranLightPort.Size = new System.Drawing.Size(100, 27);
            this.textTranLightPort.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(372, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "端口";
            // 
            // textTranLightIP
            // 
            this.textTranLightIP.Font = new System.Drawing.Font("Consolas", 10F);
            this.textTranLightIP.Location = new System.Drawing.Point(135, 147);
            this.textTranLightIP.MaxLength = 15;
            this.textTranLightIP.Name = "textTranLightIP";
            this.textTranLightIP.Size = new System.Drawing.Size(214, 27);
            this.textTranLightIP.TabIndex = 8;
            // 
            // labelTranLight
            // 
            this.labelTranLight.AutoSize = true;
            this.labelTranLight.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelTranLight.Location = new System.Drawing.Point(39, 147);
            this.labelTranLight.Name = "labelTranLight";
            this.labelTranLight.Size = new System.Drawing.Size(90, 27);
            this.labelTranLight.TabIndex = 7;
            this.labelTranLight.Text = "光传感IP";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.textTranLightPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTranLightIP);
            this.Controls.Add(this.labelTranLight);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textLight);
            this.Controls.Add(this.labelLightCheck);
            this.Controls.Add(this.textFreq);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.textCurtainPort);
            this.Controls.Add(this.labelCurtainPort);
            this.Controls.Add(this.textCurtainIP);
            this.Controls.Add(this.labelCurtainIP);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物联网智能控制台";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCurtainIP;
        private System.Windows.Forms.TextBox textCurtainIP;
        private System.Windows.Forms.TextBox textCurtainPort;
        private System.Windows.Forms.Label labelCurtainPort;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.TextBox textFreq;
        private System.Windows.Forms.Label labelLightCheck;
        private System.Windows.Forms.TextBox textLight;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.TextBox textTranLightPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTranLightIP;
        private System.Windows.Forms.Label labelTranLight;
    }
}

