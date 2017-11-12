using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Bettersoft.Common;
using Bettersoft.OpenCA.CAData;

namespace Bettersoft.OpenCA.WinForms
{
    public partial class FormMain
    {        
        //待审的申请列表
        private void tabPage_RequestOfWait_Enter(object sender, EventArgs e)
        {
            BindData_RequestOfWait();
        }

        //右键菜单-【查看】
        private void menuRequestOfWait_Show_Click(object sender, EventArgs e)
        {
            if (gridRequestOfWait.SelectedRows.Count == 0) return;

            var reqFilePath = gridRequestOfWait.SelectedRows[0].Cells["RequestOfWait_FilePath"].Value.ToString();
            var title = "查看-证书申请";
            var info = caDataHelper.GetRequestText(reqFilePath);
            var form = new FormShowText(title, info);
            form.ShowDialog();
        }

        //右键菜单-【颁发证书】
        private void menuRequestOfWait_SignCert_Click(object sender, EventArgs e)
        {
            if (gridRequestOfWait.SelectedRows.Count == 0) return;

            var reqFilePath = gridRequestOfWait.SelectedRows[0].Cells["RequestOfWait_FilePath"].Value.ToString();
            try
            {
                caDataHelper.SignCert(reqFilePath, this.caPassword);
                BindData_RequestOfWait();//刷新数据表格
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //右键菜单-【拒绝申请】
        private void menuRequestOfWait_Reject_Click(object sender, EventArgs e)
        {
            if (gridRequestOfWait.SelectedRows.Count == 0) return;

            var info = "您确实要拒绝选中的证书申请吗？";
            var confirm = MessageBox.Show(this, info, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            //----
            var reqFilePath = gridRequestOfWait.SelectedRows[0].Cells["RequestOfWait_FilePath"].Value.ToString();
            var reqFileName = reqFilePath.Substring(reqFilePath.LastIndexOf('\\') + 1);
            var destFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\reqreject\" + reqFileName;
            //destFilePath = FileHelper.GetUniqueFilePath(destFilePath);
            if (!File.Exists(destFilePath))
                File.Move(reqFilePath, destFilePath);
            else
                File.Delete(reqFilePath);
            BindData_RequestOfWait();//刷新数据
            MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //右键菜单-【导入申请】
        private void menuRequestOfWait_Import_Click(object sender, EventArgs e)
        {
            //1.让用户选择一个证书文件
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "证书申请文件(*.pem)|*.pem";
            openFileDialog.Multiselect = false;
            var dlgResult = openFileDialog.ShowDialog(this);
            if (dlgResult == DialogResult.Cancel) return;
            var srcRequestFile = openFileDialog.FileName;

            //2.判断是否是一个合法的证书申请文件
            try
            {
                var certText = caDataHelper.GetRequestText(srcRequestFile).Replace("\n", Environment.NewLine);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "非法的证书申请！\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //3.判断是否是已拒绝的申请
            var md5Text = caDataHelper.MD5File(srcRequestFile);
            var dstRequestFileName = "req" + md5Text + ".pem";
            var dstRequestFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\reqreject\" + dstRequestFileName;
            if (File.Exists(dstRequestFilePath))
            {
                MessageBox.Show(this, "该申请已被拒绝！\n\n您可以从“拒绝的申请”中撤销拒绝。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //4.拷贝用户选择的证书文件到reqwait目录
            try
            {
                dstRequestFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\reqwait\" + dstRequestFileName;
                if (!File.Exists(dstRequestFilePath))
                {
                    File.Copy(srcRequestFile, dstRequestFilePath, true);
                }
                else
                {
                    var text = "已存在一个相同的证书申请！\n\n确认要执行此操作吗？";
                    var confirm = MessageBox.Show(this, text, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.No) return;

                    File.Copy(srcRequestFile, dstRequestFilePath, true);
                }
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabPage_RequestOfWait_Enter(sender, e);//刷新当前TAB页
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }            
        }

        //右键菜单-【刷新】
        private void menuRequestOfWait_Refresh_Click(object sender, EventArgs e)
        {
            BindData_RequestOfWait();
        }

        //右键菜单-【注册申请-用户证书】
        private void menuRequestOfWait_Add_ForUser_Click(object sender, EventArgs e)
        {
            var form = new FormAddRequest(SubjectType.User);
            var dlgResult = form.ShowDialog(this);

            if (dlgResult == DialogResult.OK)
            {
                if (treeNav.SelectedNode != treeNav.Nodes[0].Nodes["Node_RequestOfWait"])
                    treeNav.SelectedNode = treeNav.Nodes[0].Nodes["Node_RequestOfWait"];
                else
                {
                    BindData_RequestOfWait();
                 }
            }
        }

        //右键菜单-【注册申请-下级CA证书】
        private void menuRequestOfWait_Add_ForSubCA_Click(object sender, EventArgs e)
        {
            var form = new FormAddRequest(SubjectType.SubCA);
            var dlgResult = form.ShowDialog(this);

            if (dlgResult == DialogResult.OK)
            {
                if (treeNav.SelectedNode != treeNav.Nodes[0].Nodes["Node_RequestOfWait"])
                    treeNav.SelectedNode = treeNav.Nodes[0].Nodes["Node_RequestOfWait"];
                else
                {
                    BindData_RequestOfWait();
                }
            }
        }

        //双击-查看
        private void gridRequestOfWait_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            menuRequestOfWait_Show_Click( sender,  e);
        }

    }
}
