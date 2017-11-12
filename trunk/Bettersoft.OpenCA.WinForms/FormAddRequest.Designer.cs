namespace Bettersoft.OpenCA.WinForms
{
    partial class FormAddRequest
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlCountryName = new System.Windows.Forms.TextBox();
            this.ctlStateOrProvinceName = new System.Windows.Forms.TextBox();
            this.ctlLocalityName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlOrganizationName = new System.Windows.Forms.TextBox();
            this.ctlOrganizationalUnitName = new System.Windows.Forms.TextBox();
            this.ctlEmailAddress = new System.Windows.Forms.TextBox();
            this.ctlCommonName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctlBitLength = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ctlCommonName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ctlStateOrProvinceName, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ctlLocalityName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ctlOrganizationName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ctlOrganizationalUnitName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ctlEmailAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ctlBitLength, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "国家/地区:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ctlCountryName);
            this.panel1.Location = new System.Drawing.Point(123, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 24);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "省份:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "城市:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "组织:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "部门:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "名称:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email:";
            // 
            // ctlCountryName
            // 
            this.ctlCountryName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctlCountryName.Location = new System.Drawing.Point(0, 1);
            this.ctlCountryName.Name = "ctlCountryName";
            this.ctlCountryName.Size = new System.Drawing.Size(150, 21);
            this.ctlCountryName.TabIndex = 0;
            // 
            // ctlStateOrProvinceName
            // 
            this.ctlStateOrProvinceName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctlStateOrProvinceName.Location = new System.Drawing.Point(123, 164);
            this.ctlStateOrProvinceName.Name = "ctlStateOrProvinceName";
            this.ctlStateOrProvinceName.Size = new System.Drawing.Size(150, 21);
            this.ctlStateOrProvinceName.TabIndex = 13;
            // 
            // ctlLocalityName
            // 
            this.ctlLocalityName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctlLocalityName.Location = new System.Drawing.Point(123, 134);
            this.ctlLocalityName.Name = "ctlLocalityName";
            this.ctlLocalityName.Size = new System.Drawing.Size(150, 21);
            this.ctlLocalityName.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "（2个英文字符，如:CN）";
            // 
            // ctlOrganizationName
            // 
            this.ctlOrganizationName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctlOrganizationName.Location = new System.Drawing.Point(123, 104);
            this.ctlOrganizationName.Name = "ctlOrganizationName";
            this.ctlOrganizationName.Size = new System.Drawing.Size(250, 21);
            this.ctlOrganizationName.TabIndex = 9;
            // 
            // ctlOrganizationalUnitName
            // 
            this.ctlOrganizationalUnitName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctlOrganizationalUnitName.Location = new System.Drawing.Point(123, 74);
            this.ctlOrganizationalUnitName.Name = "ctlOrganizationalUnitName";
            this.ctlOrganizationalUnitName.Size = new System.Drawing.Size(250, 21);
            this.ctlOrganizationalUnitName.TabIndex = 7;
            // 
            // ctlEmailAddress
            // 
            this.ctlEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctlEmailAddress.Location = new System.Drawing.Point(123, 44);
            this.ctlEmailAddress.Name = "ctlEmailAddress";
            this.ctlEmailAddress.Size = new System.Drawing.Size(250, 21);
            this.ctlEmailAddress.TabIndex = 5;
            // 
            // ctlCommonName
            // 
            this.ctlCommonName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctlCommonName.Location = new System.Drawing.Point(123, 14);
            this.ctlCommonName.Name = "ctlCommonName";
            this.ctlCommonName.Size = new System.Drawing.Size(250, 21);
            this.ctlCommonName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "密钥位长:";
            // 
            // ctlBitLength
            // 
            this.ctlBitLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctlBitLength.FormattingEnabled = true;
            this.ctlBitLength.Items.AddRange(new object[] {
            "1024",
            "2048"});
            this.ctlBitLength.Location = new System.Drawing.Point(123, 225);
            this.ctlBitLength.Name = "ctlBitLength";
            this.ctlBitLength.Size = new System.Drawing.Size(150, 20);
            this.ctlBitLength.TabIndex = 17;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(163, 262);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(244, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddRequest
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 296);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAddRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册申请";
            this.Load += new System.EventHandler(this.FormAddRequest_Load);
            this.Shown += new System.EventHandler(this.FormAddRequest_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctlCountryName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ctlStateOrProvinceName;
        private System.Windows.Forms.TextBox ctlLocalityName;
        private System.Windows.Forms.TextBox ctlOrganizationName;
        private System.Windows.Forms.TextBox ctlOrganizationalUnitName;
        private System.Windows.Forms.TextBox ctlEmailAddress;
        private System.Windows.Forms.TextBox ctlCommonName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ctlBitLength;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}