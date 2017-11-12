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
    /// 注册申请
    /// </summary>
    public partial class FormAddRequest : Form
    {
        private SubjectType subjectType;//证书类别
        private CADataHelper caDataHelper;

        #region FormAddRequest(SubjectType subjectType)--构造函数
        public FormAddRequest(SubjectType subjectType)
        {
            InitializeComponent();
            //----
            this.subjectType = subjectType;
            FormHelper.InitModalDialog(this);//初始化为模态对话框
            //----
            this.caDataHelper = new CADataHelper(Config.OPENSSL_FILE, Config.CADATA_DIR);
        }

        private FormAddRequest()
        {
            //...
        }
        #endregion

        #region FormAddRequest_Load--初始化控件内容
        private void FormAddRequest_Load(object sender, EventArgs e)
        {
            switch (this.subjectType)
            {
                case SubjectType.RootCA:
                    this.Text = "生成自签名根CA证书";
                    break;
                case SubjectType.SubCA:
                    this.Text = "下级CA证书申请";
                    break;
                case SubjectType.User:
                default:
                    this.Text = "用户证书申请";
                    break;
            }
            ctlBitLength.SelectedIndex = 0;
        }
        #endregion

        #region FormAddRequest_Shown--设置默认焦点
        private void FormAddRequest_Shown(object sender, EventArgs e)
        {
            ctlCommonName.Focus();
        }
        #endregion

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            //验证用户输入
            if (!VerifyUserInput()) return;

            //生成证书申请文件
            var requestObj = GetRequestObj();
            try
            {
                caDataHelper.GenRequestFile(requestObj);
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //退出对话框
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //获取证书申请对象
        private Request GetRequestObj()
        {
            var subjectObj = new Subject();
            subjectObj.CommonName = ctlCommonName.Text.Trim();
            subjectObj.CountryName = ctlCountryName.Text.Trim();
            subjectObj.EmailAddress = ctlEmailAddress.Text.Trim();
            subjectObj.LocalityName = ctlLocalityName.Text.Trim();
            subjectObj.OrganizationalUnitName = ctlOrganizationalUnitName.Text.Trim();
            subjectObj.OrganizationName = ctlOrganizationName.Text.Trim();
            subjectObj.StateOrProvinceName = ctlStateOrProvinceName.Text.Trim();

            var requestObj = new Request();
            requestObj.SubjectObj = subjectObj;
            requestObj.SubjectText = this.caDataHelper.GetSubjectText(subjectObj);
            requestObj.KeyBitLength = ctlBitLength.Text.Trim();
            requestObj.SubjectType = this.subjectType;

            return requestObj;
        }

        //验证用户输入内容 
        private bool VerifyUserInput()
        {
            if (this.ctlCommonName.Text.Trim() == "")
            {
                MessageBox.Show(this, "请输入名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ctlCommonName.Focus();
                return false;
            }

            if (this.ctlEmailAddress.Text.Trim() == "")
            {
                MessageBox.Show(this, "请输入Email！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ctlEmailAddress.Focus();
                return false;
            }

            if (this.ctlCountryName.Text.Trim() != "" && this.ctlCountryName.Text.Trim().Length != 2)
            {
                MessageBox.Show(this, "国家/地区必须是两个字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}
