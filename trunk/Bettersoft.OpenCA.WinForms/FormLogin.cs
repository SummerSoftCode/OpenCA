using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
using Bettersoft.Common;

namespace Bettersoft.OpenCA.WinForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //----
            FormHelper.InitModalDialog(this);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            var password = txtLoginPassword.Text.Trim();
            if (String.IsNullOrWhiteSpace(password))
            {
                txtLoginPassword.Focus();
                return;
            }

            var loginPassword = MyUtil.GetLoginPassword();
            if (password != loginPassword)
            {
                MessageBox.Show(this, "登录口令不正确！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoginPassword.Focus();
                return;
            }
            //------------------------
            this.Hide();
            var form = new FormMain();
            form.ShowDialog(this);            
        }

        
    }
}
