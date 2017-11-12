using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Bettersoft.Common;

namespace Bettersoft.OpenCA.WinForms
{
    public partial class FormMain
    {
        private void tabPage_RequestOfReject_Enter(object sender, EventArgs e)
        {
            BindData_RequestOfReject();
        }

        //右键菜单-【刷新】
        private void menuRequestOfReject_Refresh_Click(object sender, EventArgs e)
        {
            BindData_RequestOfReject();
        }

        //右键菜单-【查看】
        private void menuRequestOfReject_Show_Click(object sender, EventArgs e)
        {
            if (gridRequestOfReject.SelectedRows.Count == 0) return;

            var reqFilePath = gridRequestOfReject.SelectedRows[0].Cells["RequestOfReject_FilePath"].Value.ToString();
            var title = "查看-证书申请";
            var info = caDataHelper.GetRequestText(reqFilePath);
            var form = new FormShowText(title, info);
            form.ShowDialog();
        }

        //右键菜单-【撤销拒绝】
        private void menuRequestOfReject_CancelReject_Click(object sender, EventArgs e)
        {
            if (gridRequestOfReject.SelectedRows.Count == 0) return;
            var reqFilePath = gridRequestOfReject.SelectedRows[0].Cells["RequestOfReject_FilePath"].Value.ToString();

            var info = "您确实要撤销对选中证书申请的拒绝吗？";
            var confirm = MessageBox.Show(this, info, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            //----
            var reqFileName = reqFilePath.Substring(reqFilePath.LastIndexOf('\\') + 1);
            var destFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\reqwait\" + reqFileName;
            //destFilePath = FileHelper.GetUniqueFilePath(destFilePath);
            File.Move(reqFilePath, destFilePath);
            BindData_RequestOfReject();//刷新数据
            MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //查看
        private void gridRequestOfReject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            menuRequestOfReject_Show_Click(sender, e);
        }

        
    }
}
