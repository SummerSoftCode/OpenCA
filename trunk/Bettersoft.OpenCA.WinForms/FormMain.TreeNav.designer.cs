using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bettersoft.Common;
using System.IO;
using System.Drawing;

namespace Bettersoft.OpenCA.WinForms
{
    //树-导航
    public partial class FormMain
    {

        //根节点总是展开着
        private void treeNav_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == treeNav.Nodes[0] && !e.Node.IsExpanded)
            {
                e.Node.ExpandAll();
            }
        }

        //选中树节点时，展示相应的TAB页
        private void treeNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = e.Node;
            if (selectedNode.Tag == null)
            {
                MessageBox.Show(this, "树节点的Tag属性为null！", "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //----
            var selectedNodeTag = selectedNode.Tag.ToString().Trim();
            switch (selectedNodeTag)
            {
                case "CA":
                    tabMain.SelectTab("tabPage_CA");
                    break;
                case "RequestOfWait":
                    tabMain.SelectTab("tabPage_RequestOfWait");
                    break;
                case "RequestOfReject":
                    tabMain.SelectTab("tabPage_RequestOfReject");
                    break;
                case "CertOfValid":
                    tabMain.SelectTab("tabPage_CertOfValid");
                    break;
                case "CertOfRevoke":
                    tabMain.SelectTab("tabPage_CertOfRevoke");
                    break;
                case "CertOfExpire":
                    tabMain.SelectTab("tabPage_CertOfExpire");
                    break;
                default: break;
            }
        }
    }
}
