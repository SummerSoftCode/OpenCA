using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bettersoft.Common;
using Bettersoft.OpenCA.CAData;

namespace Bettersoft.OpenCA.WinForms
{
    /// <summary>
    /// 【关于】对话框
    /// </summary>
    public partial class FormHelp_About : Form
    {
        #region 构造函数
        public FormHelp_About()
        {
            InitializeComponent();
            //----
            FormHelper.InitModalDialog(this);
        }
        #endregion

        #region FormHelp_About_Load--初始化
        private void FormHelp_About_Load(object sender, EventArgs e)
        {
            var imageFile = AppDomain.CurrentDomain.BaseDirectory.Trim('\\') + @"\Images\about.jpg";
            picAbout.Image = new Bitmap(imageFile);
            //----
            var caDataHelper = new CADataHelper(Config.OPENSSL_FILE, Config.CADATA_DIR);

            labOpenSSLVersion.Text = caDataHelper.GetOpenSSLVersion();
        }
        #endregion

        #region 按钮-【确定】
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
