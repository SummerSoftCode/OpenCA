using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bettersoft.OpenCA.WinForms
{        
    //过期的证书
    public partial class FormMain
    {
        private void tabPage_CertOfExpire_Enter(object sender, EventArgs e)
        {
            BindData_CertOfExpire();
        }

        //右键菜单-【刷新】
        private void menuCertOfExpire_Refresh_Click(object sender, EventArgs e)
        {
            BindData_CertOfExpire();
        }

        //右键菜单-【查看】
        private void menuCertOfExpire_Show_Click(object sender, EventArgs e)
        {
            if (gridCertOfExpire.SelectedRows.Count == 0) return;

            var serialNo = gridCertOfExpire.SelectedRows[0].Cells["CertOfExpire_SerialNo"].Value.ToString();
            var certFilePath = Config.CADATA_DIR.Trim('\\') + @"\certs\" + serialNo + ".pem";
            ShowCert(certFilePath);
        }

        //查看
        private void gridCertOfExpire_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            menuCertOfExpire_Show_Click(sender, e);
        }

        
    }
}
