using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bettersoft.OpenCA.WinForms
{
    public partial class FormMain
    {
        //菜单-【文件-证书颁发机构】
        private void menuFile_CA_Click(object sender, EventArgs e)
        {
            var selectedNode = treeNav.Nodes["Node_CA"];
            treeNav.SelectedNode = selectedNode;
        }

        //菜单-【文件-待审的申请】
        private void menuFile_RequestOfWait_Click(object sender, EventArgs e)
        {
            var selectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_RequestOfWait"];
            treeNav.SelectedNode = selectedNode;
        }

        //菜单-【文件-拒绝的申请】
        private void menuFile_RequestOfReject_Click(object sender, EventArgs e)
        {
            var selectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_RequestOfReject"];
            treeNav.SelectedNode = selectedNode;
        }

        //菜单-【文件-颁发的证书】
        private void menuFile_CertOfValid_Click(object sender, EventArgs e)
        {
            var selectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_CertOfValid"];
            treeNav.SelectedNode = selectedNode;
        }

        //菜单-【文件-吊销的证书】
        private void menuFile_CertOfRevoke_Click(object sender, EventArgs e)
        {
            var selectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_CertOfRevoke"];
            treeNav.SelectedNode = selectedNode;
        }

        //菜单-【文件-过期的证书】
        private void menuFile_CertOfExpire_Click(object sender, EventArgs e)
        {
            var selectedNode = treeNav.Nodes["Node_CA"].Nodes["Node_CertOfExpire"];
            treeNav.SelectedNode = selectedNode;
        }

        //菜单-【文件-退出】
        private void menuFile_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //菜单-【帮助-关于】
        private void menuHelp_About_Click(object sender, EventArgs e)
        {
            var form = new FormHelp_About();
            form.ShowDialog(this);
        }


        //菜单-【设置-修改登录口令】
        private void menuSet_EditLoginPassword_Click(object sender, EventArgs e)
        {
            var form = new FormEditPassword();
            form.ShowDialog(this);
        }
    }
}
