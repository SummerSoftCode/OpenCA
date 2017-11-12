using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Bettersoft.Common;

namespace Bettersoft.OpenCA.WinForms
{
    //吊销的证书
    public partial class FormMain
    {
        //载入证书列表
        private void tabPage_CertOfRevoke_Enter(object sender, EventArgs e)
        {
            BindData_CertOfRevoke();
        }

        //右键菜单-【刷新】
        private void menuCertOfRevoke_Refresh_Click(object sender, EventArgs e)
        {
            BindData_CertOfRevoke();
        }

        //右键菜单-【查看】
        private void menuCertOfRevoke_Show_Click(object sender, EventArgs e)
        {
            if (gridCertOfRevoke.SelectedRows.Count == 0) return;

            var serialNo = gridCertOfRevoke.SelectedRows[0].Cells["CertOfRevoke_SerialNo"].Value.ToString();
            var certFilePath = Config.CADATA_DIR.Trim('\\') + @"\certs\" + serialNo + ".pem";
            ShowCert(certFilePath);
        }

        //右键菜单-【生成证书吊销列表】
        private void menuCertOfRevoke_GenCRL_Click(object sender, EventArgs e)
        {
            try
            {
                var crlFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\crl\crl.pem";
                caDataHelper.GenCRL(crlFilePath, this.caPassword);
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //右键菜单-【导出证书吊销列表】
        private void menuCertOfRevoke_ExportCRL_Click(object sender, EventArgs e)
        {
            try
            {
                var crlFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\crl\crl.pem";
                if (!File.Exists(crlFilePath))
                {
                    var text = "当前库中没有证书吊销列表！\n\n您是否要立即生成证书吊销列表并导出？";
                    var confirm = MessageBox.Show(this, text, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.No) return;

                    caDataHelper.GenCRL(crlFilePath, this.caPassword);//生成证书吊销列表
                }
                //----
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "导出证书撤销列表-PEM格式";
                saveFileDialog.FileName = "crl.pem";
                saveFileDialog.Filter = "证书撤销列表-PEM格式(*.pem)|*.pem|证书撤销列表-DER格式(*.crl)|*.crl";
                saveFileDialog.OverwritePrompt = true;

                var dlgResult = saveFileDialog.ShowDialog(this);
                if (dlgResult != DialogResult.OK) return;

                var destFilePath = saveFileDialog.FileName;

                if (destFilePath.ToUpper().EndsWith(".PEM"))//PEM格式
                {
                    File.Copy(crlFilePath, destFilePath, true);
                }
                else//DER格式
                {
                    caDataHelper.PemCRLToDerCRL(crlFilePath, destFilePath);//格式转换
                }
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //【查看证书吊销列表】
        private void menuCertOfRevoke_ShowCRL_Click(object sender, EventArgs e)
        {
            try
            {
                var crlFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\crl\crl.pem";
                if (!File.Exists(crlFilePath))
                {
                    var text = "当前库中没有证书吊销列表！\n\n您是否要立即生成证书吊销列表并查看？";
                    var confirm = MessageBox.Show(this, text, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.No) return;

                    caDataHelper.GenCRL(crlFilePath, this.caPassword);//生成证书吊销列表
                }
                //----
                var title = "查看-证书吊销列表";
                var info = caDataHelper.GetCRLText(crlFilePath);
                var form = new FormShowText(title, info);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //查看
        private void gridCertOfRevoke_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            menuCertOfRevoke_Show_Click(sender, e);
        }

    }
}
