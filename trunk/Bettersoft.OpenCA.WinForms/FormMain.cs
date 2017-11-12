using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bettersoft.Common;
using System.IO;
using Bettersoft.OpenCA.CAData;

namespace Bettersoft.OpenCA.WinForms
{
    public partial class FormMain : Form
    {
        private CADataHelper caDataHelper;
        private string caPassword = "123456";
        private string xmlFilePath = "OpenCA.NET.xml";

        #region FormMain--构造函数
        public FormMain()
        {
            InitializeComponent();
            //----
            FormHelper.InitGridView(this.gridCertOfValid);
            FormHelper.InitGridView(this.gridCertOfRevoke);
            FormHelper.InitGridView(this.gridRequestOfWait);
            FormHelper.InitGridView(this.gridRequestOfReject);
            FormHelper.InitGridView(this.gridCertOfExpire);
            //----

            //----
            this.caDataHelper = new CADataHelper(Config.OPENSSL_FILE, Config.CADATA_DIR);
            this.caPassword = this.GetCAKeyPassword();
        }
        #endregion

        #region FormMain_Load--初始化控件
        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }
        #endregion        
        
        #region FormMain_Shown-第一次显示窗体时
        private void FormMain_Shown(object sender, EventArgs e)
        {
            //展开树形导航，并选中【待审的申请】节点
            treeNav.ExpandAll();
            var selectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_RequestOfWait"];
            treeNav.SelectedNode = selectedNode;
        }
        #endregion
        
        #region magic functions
        //绑定颁发的证书
        private void BindData_CertOfValid()
        {
            var certs = caDataHelper.GetCertList()
                                    .Where(p => p.State == "V")
                                    .ToList();
            gridCertOfValid.DataSource = certs;

            statusMain_FirstLabel.Text = "共 " + certs.Count.ToString() + " 条记录";
        }

        //绑定吊销的证书
        private void BindData_CertOfRevoke()
        {
            var certs = caDataHelper.GetCertList()
                                    .Where(p => p.State == "R")
                                    .ToList();
            gridCertOfRevoke.DataSource = certs;

            statusMain_FirstLabel.Text = "共 " + certs.Count.ToString() + " 条记录";
        }

        //绑定过期的证书
        private void BindData_CertOfExpire()
        {
            var certs = caDataHelper.GetCertList()
                                    .Where(p => p.State == "E")
                                    .ToList();
            gridCertOfExpire.DataSource = certs;

            statusMain_FirstLabel.Text = "共 " + certs.Count.ToString() + " 条记录";
        }

        //绑定待审批证书请求列表
        private void BindData_RequestOfWait()
        {
            var reqs = caDataHelper.GetRequestList(Config.CADATA_DIR.TrimEnd('\\') + @"\reqwait");
            gridRequestOfWait.DataSource = reqs;

            statusMain_FirstLabel.Text = "共 " + reqs.Count.ToString() + " 条记录";
        }

        //绑定拒绝的证书请求列表
        private void BindData_RequestOfReject()
        {
            var reqs = caDataHelper.GetRequestList(Config.CADATA_DIR.TrimEnd('\\') + @"\reqreject");
            gridRequestOfReject.DataSource = reqs;

            statusMain_FirstLabel.Text = "共 " + reqs.Count.ToString() + " 条记录";
        }

        //查看-证书内容
        private void ShowCert(string certFilePath)
        {
            if (!File.Exists(certFilePath))
            {
                MessageBox.Show(this, "证书文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var title = "查看-证书";
            var info = caDataHelper.GetCertText(certFilePath);
            var form = new FormShowText(title, info);
            form.ShowDialog(this);
        }
        #endregion

        #region FormMain_FormClosed-关闭窗体时退出主程序
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region tabMain_Selected-对应选中树节点
        private void tabMain_Selected(object sender, TabControlEventArgs e)
        {
            var selectedTabName = tabMain.SelectedTab.Name;
            switch (selectedTabName)
            {
                case "tabPage_CA":
                    treeNav.SelectedNode = treeNav.Nodes["Node_CA"];
                    break;
                case "tabPage_RequestOfWait":
                    treeNav.SelectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_RequestOfWait"];
                    break;
                case "tabPage_RequestOfReject":
                    treeNav.SelectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_RequestOfReject"];
                    break;
                case "tabPage_CertOfValid":
                    treeNav.SelectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_CertOfValid"];
                    break;
                case "tabPage_CertOfRevoke":
                    treeNav.SelectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_CertOfRevoke"];
                    break;
                case "tabPage_CertOfExpire":
                    treeNav.SelectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_CertOfExpire"];
                    break;
                default: break;
            }
        }
        #endregion

        
        
        

    }
}
