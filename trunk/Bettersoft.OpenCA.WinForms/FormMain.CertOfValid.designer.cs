using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Bettersoft.Common;

namespace Bettersoft.OpenCA.WinForms
{
    //颁发的证书
    public partial class FormMain
    {
        //载入证书列表
        private void tabPage_CertOfValid_Enter(object sender, EventArgs e)
        {
            BindData_CertOfValid();
        }

        //右键菜单-【刷新】
        private void menuCertOfValid_Refresh_Click(object sender, EventArgs e)
        {
            BindData_CertOfValid();
        }

        //右键菜单-【查看】
        private void menuCertOfValid_Show_Click(object sender, EventArgs e)
        {
            if (gridCertOfValid.SelectedRows.Count == 0) return;

            var serialNo = gridCertOfValid.SelectedRows[0].Cells["CertOfValid_SerialNo"].Value.ToString();
            var certFilePath = Config.CADATA_DIR.Trim('\\') + @"\certs\" + serialNo + ".pem";
            ShowCert(certFilePath);
        }

        //右键菜单-【导出X.509证书】
        private void menuCertOfValid_ExportX509_Click(object sender, EventArgs e)
        {
            if (gridCertOfValid.SelectedRows.Count == 0) return;

            var certSerialNo = gridCertOfValid.SelectedRows[0].Cells["CertOfValid_SerialNo"].Value.ToString();
            var certFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\certs\" + certSerialNo + ".pem";
            var destFileName = certSerialNo + ".pem";
            ExportX509Cert(certFilePath, destFileName);
        }

        //导出X509证书
        private void ExportX509Cert(string pemCertFilePath, string destFileName)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出 X.509 证书";
            saveFileDialog.FileName = destFileName;
            saveFileDialog.Filter = "X.509证书-PEM格式(*.pem)|*.pem|X.509证书-DER格式(*.der)|*.der";
            saveFileDialog.OverwritePrompt = true;

            var dlgResult = saveFileDialog.ShowDialog(this);
            if (dlgResult != DialogResult.OK) return;

            var destFilePath = saveFileDialog.FileName;
            try
            {
                if (destFilePath.ToUpper().EndsWith(".PEM"))//PEM格式
                {
                    File.Copy(pemCertFilePath, destFilePath, true);
                }
                else//DER格式
                {
                    caDataHelper.PemX509CertToDerX509Cert(pemCertFilePath, destFilePath);
                }
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //右键菜单-【吊销证书】
        private void menuCertOfValid_Revoke_Click(object sender, EventArgs e)
        {
            if (gridCertOfValid.SelectedRows.Count == 0) return;

            var confirm = MessageBox.Show(this, "您确认要吊销选中的证书吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            var certSerialNo = gridCertOfValid.SelectedRows[0].Cells["CertOfValid_SerialNo"].Value.ToString();
            var certFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\certs\" + certSerialNo + ".pem";

            try
            {
                caDataHelper.RevokeCert(certFilePath, this.caPassword);
                BindData_CertOfValid();//刷新数据表格
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //右键菜单-【导出p12证书】
        private void menuCertOfValid_ExportP12_Click(object sender, EventArgs e)
        {
            if (gridCertOfValid.SelectedRows.Count == 0) return;

            try
            {
                var certSerialNo = gridCertOfValid.SelectedRows[0].Cells["CertOfValid_SerialNo"].Value.ToString();
                var certFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\certs\" + certSerialNo + ".pem";

                var reqsignedDir = Config.CADATA_DIR.TrimEnd('\\') + @"\reqsigned";
                var files = Directory.GetFiles(reqsignedDir, "req*-cert" + certSerialNo + ".pem");
                var signed_reqFilePath = files[0];
                var signed_reqFileName = signed_reqFilePath.Substring(signed_reqFilePath.LastIndexOf(@"\req"));
                var md5String = signed_reqFileName.Substring(0, signed_reqFileName.LastIndexOf("-")).TrimStart(@"\req".ToCharArray());
                var keyFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\reqprivate\key" + md5String + ".pem";
                if (!File.Exists(keyFilePath))
                {
                    MessageBox.Show(this, "没有找到对应的私钥文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //显示保存对话框
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "导出PKCS12证书";
                saveFileDialog.FileName = certSerialNo + ".p12";
                saveFileDialog.Filter = "PKCS12证书文件(*.p12)|*.p12";
                saveFileDialog.OverwritePrompt = true;

                var dlgResult = saveFileDialog.ShowDialog(this);
                if (dlgResult != DialogResult.OK) return;

                var destFilePath = saveFileDialog.FileName;
                this.caDataHelper.GenP12Cert(keyFilePath, certFilePath, destFilePath);
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //右键菜单-【导出p7证书（证书链）】-封装“当前证书+CA证书+CA父证书链（p7）+CRL”
        private void menuCertOfValid_ExportP7_Click(object sender, EventArgs e)
        {
            if (gridCertOfValid.SelectedRows.Count == 0) return;

            var certSerialNo = gridCertOfValid.SelectedRows[0].Cells["CertOfValid_SerialNo"].Value.ToString();
            var certFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\certs\" + certSerialNo + ".pem";

            var caP7CertFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\ca_p7.pem";
            if (!File.Exists(caP7CertFilePath))
                caP7CertFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\cacert.pem";

            var crlFilePath = "";//为空则不导出CRL

            var destFileName = certSerialNo + "_p7.pem";
            ExportPKCS7Cert(destFileName, crlFilePath, certFilePath, caP7CertFilePath);
        }

        private void ExportPKCS7Cert(string destFileName, string crlFilePath, string certFilePath, string caP7CertFilePath)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出 PKCS7 证书";
            saveFileDialog.FileName = destFileName;
            saveFileDialog.Filter = "PKCS7证书-PEM格式(*.pem)|*.pem|PKCS7证书-DER格式(*.der)|*.der";
            saveFileDialog.OverwritePrompt = true;

            var dlgResult = saveFileDialog.ShowDialog(this);
            if (dlgResult != DialogResult.OK) return;

            var destFilePath = saveFileDialog.FileName;
            try
            {
                var tmpFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\temp\p7.pem";
                caDataHelper.GenP7Cert(tmpFilePath, crlFilePath, certFilePath, caP7CertFilePath);
                if (destFilePath.ToUpper().EndsWith(".PEM"))//PEM格式
                {
                    File.Copy(tmpFilePath, destFilePath, true);
                }
                else//DER格式
                {
                    caDataHelper.PemP7CertToDerP7Cert(tmpFilePath, destFilePath);       
                }
                MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //查看（证书内容文本）
        private void gridCertOfValid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            menuCertOfValid_Show_Click(sender, e);
        }


    }
}
