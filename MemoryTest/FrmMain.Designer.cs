﻿namespace MemoryTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtMemoryAllowed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAllowVirtualMemorySize64 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBegin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemoryAllowed
            // 
            this.txtMemoryAllowed.Location = new System.Drawing.Point(167, 12);
            this.txtMemoryAllowed.Name = "txtMemoryAllowed";
            this.txtMemoryAllowed.Size = new System.Drawing.Size(100, 21);
            this.txtMemoryAllowed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "已分配内存";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "已分配虚拟内存";
            // 
            // txtAllowVirtualMemorySize64
            // 
            this.txtAllowVirtualMemorySize64.Location = new System.Drawing.Point(167, 39);
            this.txtAllowVirtualMemorySize64.Name = "txtAllowVirtualMemorySize64";
            this.txtAllowVirtualMemorySize64.Size = new System.Drawing.Size(100, 21);
            this.txtAllowVirtualMemorySize64.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MemoryTest.Properties.Resources.Memory;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnBegin
            // 
            this.btnBegin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBegin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBegin.Location = new System.Drawing.Point(273, 12);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(107, 48);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "开始测试";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 74);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAllowVirtualMemorySize64);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemoryAllowed);
            this.Controls.Add(this.btnBegin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Memory Allow Test for win32 application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox txtMemoryAllowed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAllowVirtualMemorySize64;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
