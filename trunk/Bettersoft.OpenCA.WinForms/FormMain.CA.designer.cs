using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Bettersoft.OpenCA.WinForms
{
    //证书颁发机构
    public partial class FormMain
    {
        //激活TAB页时
        private void tabPage_CA_Enter(object sender, EventArgs e)
        {
            txtCACert.Text = "";
            txtCAKey.Text = "";
            txtCAKeyPassword.Text = "";
            //---------------------------
            //CA证书
            var caCertFile = Config.CADATA_DIR.TrimEnd('\\') + @"\cacert.pem";
            if (!File.Exists(caCertFile))
            {
                txtCACert.Text = "没有找到CA证书文件";
            }
            else
            {
                try
                {
                    txtCACert.Text = caDataHelper.GetCertText(caCertFile).Replace("\n", Environment.NewLine);
                }
                catch (Exception ex)
                {
                    txtCACert.Text = ex.Message;
                    MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //CA私钥
            var caKeyFile = Config.CADATA_DIR.TrimEnd('\\') + @"\private\cakey.pem";
            if (!File.Exists(caKeyFile))
            {
                txtCAKey.Text = "没有找到CA私钥文件";
            }
            else
            {
                txtCAKey.Text = @"\private\cakey.pem";
            }
            //CA私钥保护口令
            txtCAKeyPassword.Text = this.GetCAKeyPassword();
            //----
            statusMain_FirstLabel.Text = "就绪";
        }

        //导出CA证书
        private void btnExportCACert_Click(object sender, EventArgs e)
        {
            var caCertFilePath = Config.CADATA_DIR.TrimEnd('\\') + @"\cacert.pem";
            if (!File.Exists(caCertFilePath))
            {
                MessageBox.Show(this, "CA证书文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var destFileName = "cacert.pem";
            this.ExportX509Cert(caCertFilePath, destFileName);
        }

        //生成自签名根证书和私钥文件
        private void btnGenRootCA_Click(object sender, EventArgs e)
        {
            var cakeyFile = Config.CADATA_DIR.TrimEnd('\\') + @"\private\cakey.pem";
            var cacertFile = Config.CADATA_DIR.TrimEnd('\\') + @"\cacert.pem";
            if (File.Exists(cakeyFile) || File.Exists(cacertFile))
            {
                var text = "此操作将覆盖已存在的CA证书和私钥文件！\n\n确认要执行此操作吗？";
                var confirm = MessageBox.Show(this, text, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.No) return;
            }
            //-----------------------------------------
            var password = "123456";
            try
            {
                caDataHelper.GenCACert(password);
                MessageBox.Show(this, "操作成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabPage_CA_Enter(sender, e);
                //备份CA证书和私钥
                var now = DateTime.Now;
                this.BackupCACertFile(now);
                this.BackupCAKeyFile(now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //备份CA证书
        private void BackupCACertFile(DateTime now)
        {
            var backupDir = Config.CADATA_DIR.TrimEnd('\\') + @"\backup\cacert_" + now.ToString("yyyyMMddHHmmssfff");
            var srcCACertFile = Config.CADATA_DIR.TrimEnd('\\') + @"\cacert.pem";
            var dstCACertFile = backupDir + @"\cacert.pem";
            Directory.CreateDirectory(backupDir);
            File.Copy(srcCACertFile, dstCACertFile);
        }

        //备份CA私钥
        private void BackupCAKeyFile(DateTime now)
        {
            var backupDir = Config.CADATA_DIR.TrimEnd('\\') + @"\backup\cacert_" + now.ToString("yyyyMMddHHmmssfff") + @"\private";
            var srcCAKeyFile = Config.CADATA_DIR.TrimEnd('\\') + @"\private\cakey.pem";
            var dstCAKeyFile = backupDir + @"\cakey.pem";
            Directory.CreateDirectory(backupDir);
            File.Copy(srcCAKeyFile, dstCAKeyFile);
        }

        //导入CA证书
        private void btnImportCACert_Click(object sender, EventArgs e)
        {
            //1.让用户选择一个证书文件
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "X.509证书-PEM格式(*.pem)|*.pem";
            openFileDialog.Multiselect = false;
            var dlgResult = openFileDialog.ShowDialog(this);
            if (dlgResult == DialogResult.Cancel) return;
            var newCACertFile = openFileDialog.FileName;

            //2.判断是否是一个合法的证书文件
            try
            {
                var certText = caDataHelper.GetCertText(newCACertFile).Replace("\n", Environment.NewLine);
                //判断是否是一个CA证书
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "非法的证书！\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //3.拷贝用户选择的证书文件
            var oldCACertFile = Config.CADATA_DIR.TrimEnd('\\') + @"\cacert.pem";
            if (File.Exists(oldCACertFile))
            {
                var text = "此操作将覆盖已存在的CA证书文件！\n\n确认要执行此操作吗？";
                var confirm = MessageBox.Show(this, text, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.No) return;
            }
            this.BackupCACertFile(DateTime.Now);
            File.Copy(newCACertFile, oldCACertFile, true);
            MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Thread.Sleep(1000);
            tabPage_CA_Enter(sender, e);
        }

        //导入CA私钥
        private void btnImportCAKey_Click(object sender, EventArgs e)
        {
            //1.让用户选择一个证书文件
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CA私钥文件(*.pem)|*.pem";
            openFileDialog.Multiselect = false;
            var dlgResult = openFileDialog.ShowDialog(this);
            if (dlgResult == DialogResult.Cancel) return;

            //2.拷贝用户选择的证书文件
            var newCAKeyFile = openFileDialog.FileName;
            var oldCAKeyFile = Config.CADATA_DIR.TrimEnd('\\') + @"\private\cakey.pem";
            if (File.Exists(oldCAKeyFile))
            {
                var text = "此操作将覆盖已存在的CA私钥文件！\n\n确认要执行此操作吗？";
                var confirm = MessageBox.Show(this, text, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.No) return; 
            }
            this.BackupCAKeyFile(DateTime.Now);
            File.Copy(newCAKeyFile, oldCAKeyFile, true);
            MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabPage_CA_Enter(sender, e);
        }

        //保存CA私钥保护口令
        private void btnSaveCAKeyPasswod_Click(object sender, EventArgs e)
        {
            var password = txtCAKeyPassword.Text.Trim();
            if (String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(this, "CA私钥保护口令不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bytes = Encoding.UTF8.GetBytes(password);
            var password_Base64 = Convert.ToBase64String(bytes);

            XDocument xdoc = XDocument.Load(xmlFilePath);
            xdoc.Element("Config").Element("CAKeyPassword").Value = password_Base64;
            xdoc.Save(xmlFilePath);
            MessageBox.Show(this, "操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //获取CA私钥保护口令
        private string GetCAKeyPassword()
        {
            XDocument xdoc = XDocument.Load(xmlFilePath);
            var password_Base64 = xdoc.Element("Config").Element("CAKeyPassword").Value;
            var bytes = Convert.FromBase64String(password_Base64);
            var password = Encoding.UTF8.GetString(bytes);
            //MessageBox.Show(password);
            return password;
        }

        //导出CaP7证书(链)
        private void btnExportCAP7Cert_Click(object sender, EventArgs e)
        {

        }

    }
}
