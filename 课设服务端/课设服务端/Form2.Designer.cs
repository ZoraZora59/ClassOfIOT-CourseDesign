namespace 课设服务端
{
    partial class control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(control));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.labelViewState = new System.Windows.Forms.Label();
            this.labelLight = new System.Windows.Forms.Label();
            this.labelViewLight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(245, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(92, 27);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "控制面板";
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(90, 208);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(114, 49);
            this.buttonOff.TabIndex = 1;
            this.buttonOff.Text = "关灯";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(90, 108);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(114, 49);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "开灯";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelState.Location = new System.Drawing.Point(378, 196);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(141, 27);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "状态（亮/灭）";
            // 
            // labelViewState
            // 
            this.labelViewState.AutoSize = true;
            this.labelViewState.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelViewState.Location = new System.Drawing.Point(271, 196);
            this.labelViewState.Name = "labelViewState";
            this.labelViewState.Size = new System.Drawing.Size(112, 27);
            this.labelViewState.TabIndex = 2;
            this.labelViewState.Text = "当前状态：";
            // 
            // labelLight
            // 
            this.labelLight.AutoSize = true;
            this.labelLight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLight.Location = new System.Drawing.Point(378, 117);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(72, 27);
            this.labelLight.TabIndex = 1;
            this.labelLight.Text = "亮度值";
            // 
            // labelViewLight
            // 
            this.labelViewLight.AutoSize = true;
            this.labelViewLight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelViewLight.Location = new System.Drawing.Point(271, 117);
            this.labelViewLight.Name = "labelViewLight";
            this.labelViewLight.Size = new System.Drawing.Size(112, 27);
            this.labelViewLight.TabIndex = 0;
            this.labelViewLight.Text = "当前亮度：";
            // 
            // control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelViewState);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.labelLight);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelViewLight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物联网智能控制面板";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.control_FormClosed);
            this.Load += new System.EventHandler(this.control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelViewState;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.Label labelViewLight;
    }
}