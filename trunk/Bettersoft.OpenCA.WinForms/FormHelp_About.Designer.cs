namespace Bettersoft.OpenCA.WinForms
{
    partial class FormHelp_About
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.labOpenSSLVersion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labSoftWriter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSoftDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labSoftVersion = new System.Windows.Forms.Label();
            this.labSoftName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.panelMain.SuspendLayout();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.picAbout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(484, 80);
            this.panelTop.TabIndex = 0;
            // 
            // picAbout
            // 
            this.picAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAbout.Location = new System.Drawing.Point(0, 0);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(484, 80);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnOK);
            this.panelMain.Controls.Add(this.layout);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(484, 282);
            this.panelMain.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(205, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.Controls.Add(this.labOpenSSLVersion, 1, 7);
            this.layout.Controls.Add(this.label6, 0, 7);
            this.layout.Controls.Add(this.labSoftWriter, 1, 4);
            this.layout.Controls.Add(this.label4, 0, 4);
            this.layout.Controls.Add(this.labSoftDate, 1, 3);
            this.layout.Controls.Add(this.label3, 0, 3);
            this.layout.Controls.Add(this.labSoftVersion, 1, 2);
            this.layout.Controls.Add(this.labSoftName, 1, 1);
            this.layout.Controls.Add(this.label2, 0, 2);
            this.layout.Controls.Add(this.label1, 0, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 9;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.Size = new System.Drawing.Size(484, 242);
            this.layout.TabIndex = 0;
            // 
            // labOpenSSLVersion
            // 
            this.labOpenSSLVersion.AutoSize = true;
            this.labOpenSSLVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labOpenSSLVersion.Location = new System.Drawing.Point(153, 195);
            this.labOpenSSLVersion.Name = "labOpenSSLVersion";
            this.labOpenSSLVersion.Size = new System.Drawing.Size(328, 30);
            this.labOpenSSLVersion.TabIndex = 12;
            this.labOpenSSLVersion.Text = "-";
            this.labOpenSSLVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(60, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "OpenSSL版本:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labSoftWriter
            // 
            this.labSoftWriter.AutoSize = true;
            this.labSoftWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labSoftWriter.Location = new System.Drawing.Point(153, 105);
            this.labSoftWriter.Name = "labSoftWriter";
            this.labSoftWriter.Size = new System.Drawing.Size(328, 30);
            this.labSoftWriter.TabIndex = 8;
            this.labSoftWriter.Text = "夏春涛  xchuntao@163.com";
            this.labSoftWriter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(81, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "作    者:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labSoftDate
            // 
            this.labSoftDate.AutoSize = true;
            this.labSoftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labSoftDate.Location = new System.Drawing.Point(153, 75);
            this.labSoftDate.Name = "labSoftDate";
            this.labSoftDate.Size = new System.Drawing.Size(328, 30);
            this.labSoftDate.TabIndex = 6;
            this.labSoftDate.Text = "2014-03-29";
            this.labSoftDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(83, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "更新日期:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labSoftVersion
            // 
            this.labSoftVersion.AutoSize = true;
            this.labSoftVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labSoftVersion.Location = new System.Drawing.Point(153, 45);
            this.labSoftVersion.Name = "labSoftVersion";
            this.labSoftVersion.Size = new System.Drawing.Size(328, 30);
            this.labSoftVersion.TabIndex = 4;
            this.labSoftVersion.Text = "0.5.5";
            this.labSoftVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSoftName
            // 
            this.labSoftName.AutoSize = true;
            this.labSoftName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labSoftName.Location = new System.Drawing.Point(153, 15);
            this.labSoftName.Name = "labSoftName";
            this.labSoftName.Size = new System.Drawing.Size(328, 30);
            this.labSoftName.TabIndex = 3;
            this.labSoftName.Text = "OpenCA.NET";
            this.labSoftName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(82, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "版 本 号:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "软件名称:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormHelp_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Name = "FormHelp_About";
            this.Text = "关于 OpenCA.NET";
            this.Load += new System.EventHandler(this.FormHelp_About_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label labOpenSSLVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labSoftWriter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSoftDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labSoftVersion;
        private System.Windows.Forms.Label labSoftName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}