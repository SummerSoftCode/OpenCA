using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bettersoft.OpenCA.WinForms
{
    //工具条
    public partial class FormMain
    {
        //工具条-【注册申请-用户证书】
        private void toolMain_AddRequest_ForUser_Click(object sender, EventArgs e)
        {
            menuRequestOfWait_Add_ForUser_Click(sender, e);
        }

        //工具条-【注册申请-下级CA证书】
        private void toolMain_AddRequest_ForSubCA_Click(object sender, EventArgs e)
        {
            menuRequestOfWait_Add_ForSubCA_Click(sender, e);
        }        

        //工具条-【导入申请】
        private void toolMain_ImportRequest_Click(object sender, EventArgs e)
        {
            menuRequestOfWait_Import_Click(sender, e);
        }
        
        //工具条-【导出CA证书】
        private void toolMain_ExportCACert_Click(object sender, EventArgs e)
        {
            btnExportCACert_Click(sender, e);
        }

        //工具条-【导出证书吊销列表】
        private void toolMain_ExportCRL_Click(object sender, EventArgs e)
        {
            menuCertOfRevoke_ExportCRL_Click(sender, e);
        }

        //工具条-【关于】
        private void toolMain_About_Click(object sender, EventArgs e)
        {
            menuHelp_About_Click(sender, e);
        }

        //工具条-【退出】
        private void toolMain_Exit_Click(object sender, EventArgs e)
        {
            menuFile_Exit_Click(sender, e);
        }

    }
}
