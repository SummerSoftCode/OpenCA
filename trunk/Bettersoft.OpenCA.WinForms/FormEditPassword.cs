using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bettersoft.Common;

namespace Bettersoft.OpenCA.WinForms
{
    public partial class FormEditPassword : Form
    {
        public FormEditPassword()
        {
            InitializeComponent();
            //----
            FormHelper.InitModalDialog(this);
        }

        private void FormEditPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!VerifyUserInput()) return;

            MyUtil.SetLoginPassword(txtNewPassword.Text.Trim());
            MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //----
            this.Close();
        }

        #region 验证用户输入
        private bool VerifyUserInput()
        {
            if (txtOldPassword.Text.Trim() == "")
            {
                MessageBox.Show(this, "请输入旧密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Focus();
                return false;
            }
            //----
            if (txtNewPassword.Text.Trim() == "")
            {
                MessageBox.Show(this, "请输入新密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Focus();
                return false;
            }
            if (txtNewPassword2.Text.Trim() == "")
            {
                MessageBox.Show(this, "请确认新密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword2.Focus();
                return false;
            }

            if (txtNewPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show(this, "新密码不能少于6个字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Focus();
                return false;
            }

            if (txtNewPassword.Text != txtNewPassword2.Text)
            {
                MessageBox.Show(this, "两次输入的新密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Focus();
                return false;
            }
            //----
            var oldPassword = MyUtil.GetLoginPassword();
            if (txtOldPassword.Text.Trim() != oldPassword.Trim())
            {
                MessageBox.Show(this, "旧密码不正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Focus();
                return false;
            }
            //----
            return true;
        }
        #endregion
    }
}
