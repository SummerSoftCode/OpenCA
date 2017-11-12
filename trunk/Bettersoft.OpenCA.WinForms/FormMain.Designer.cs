namespace Bettersoft.OpenCA.WinForms
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("待审的申请", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("拒绝的申请", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("有效的证书", 3, 3);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("吊销的证书", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("过期的证书", 3, 3);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("证书颁发机构(CA)", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_CA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFile_RequestOfWait = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_RequestOfReject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFile_CertOfValid = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_CertOfRevoke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_CertOfExpire = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSet_EditLoginPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.toolMain_AddRequest = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolMain_AddRequest_ForUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMain_AddRequest_ForSubCA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMain_ImportRequest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMain_ExportCACert = new System.Windows.Forms.ToolStripButton();
            this.toolMain_ExportCRL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMain_About = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMain_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusMain_FirstLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.treeNav = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.splitter = new System.Windows.Forms.Splitter();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage_RequestOfWait = new System.Windows.Forms.TabPage();
            this.gridRequestOfWait = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestOfWait_FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuRequestOfWait = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRequestOfWait_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRequestOfWait_SignCert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRequestOfWait_Reject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRequestOfWait_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRequestOfWait_Add_ForUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRequestOfWait_Add_ForSubCA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRequestOfWait_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRequestOfWait_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_RequestOfReject = new System.Windows.Forms.TabPage();
            this.gridRequestOfReject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestOfReject_FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuRequestOfReject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRequestOfReject_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRequestOfReject_CancelReject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRequestOfReject_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_CertOfValid = new System.Windows.Forms.TabPage();
            this.gridCertOfValid = new System.Windows.Forms.DataGridView();
            this.CertOfValid_SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertOfValid_ExpiredTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertOfValid_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertOfValid_StoreDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertOfValid_DomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCertOfValid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCertOfValid_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCertOfValid_ExportX509 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCertOfValid_ExportP12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCertOfValid_ExportP7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCertOfValid_Revoke = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCertOfValid_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_CertOfRevoke = new System.Windows.Forms.TabPage();
            this.gridCertOfRevoke = new System.Windows.Forms.DataGridView();
            this.CertOfRevoke_SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCertOfRevoke = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCertOfRevoke_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCertOfRevoke_ShowCRL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCertOfRevoke_GenCRL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCertOfRevoke_ExportCRL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCertOfRevoke_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_CertOfExpire = new System.Windows.Forms.TabPage();
            this.gridCertOfExpire = new System.Windows.Forms.DataGridView();
            this.CertOfExpire_SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCertOfExpire = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCertOfExpire_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCertOfExpire_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_CA = new System.Windows.Forms.TabPage();
            this.btnExportCACert = new System.Windows.Forms.Button();
            this.btnGenRootCA = new System.Windows.Forms.Button();
            this.btnImportCAKey = new System.Windows.Forms.Button();
            this.btnImportCACert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCACert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCAKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveCAKeyPasswod = new System.Windows.Forms.Button();
            this.txtCAKeyPassword = new System.Windows.Forms.TextBox();
            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage_RequestOfWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRequestOfWait)).BeginInit();
            this.menuRequestOfWait.SuspendLayout();
            this.tabPage_RequestOfReject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRequestOfReject)).BeginInit();
            this.menuRequestOfReject.SuspendLayout();
            this.tabPage_CertOfValid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCertOfValid)).BeginInit();
            this.menuCertOfValid.SuspendLayout();
            this.tabPage_CertOfRevoke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCertOfRevoke)).BeginInit();
            this.menuCertOfRevoke.SuspendLayout();
            this.tabPage_CertOfExpire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCertOfExpire)).BeginInit();
            this.menuCertOfExpire.SuspendLayout();
            this.tabPage_CA.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuSet,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(784, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile_CA,
            this.toolStripSeparator12,
            this.menuFile_RequestOfWait,
            this.menuFile_RequestOfReject,
            this.toolStripSeparator13,
            this.menuFile_CertOfValid,
            this.menuFile_CertOfRevoke,
            this.menuFile_CertOfExpire,
            this.toolStripSeparator11,
            this.menuFile_Exit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(58, 21);
            this.menuFile.Text = "文件(&F)";
            // 
            // menuFile_CA
            // 
            this.menuFile_CA.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_home;
            this.menuFile_CA.Name = "menuFile_CA";
            this.menuFile_CA.Size = new System.Drawing.Size(188, 22);
            this.menuFile_CA.Text = "证书颁发机构(CA)(&A)";
            this.menuFile_CA.Click += new System.EventHandler(this.menuFile_CA_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(185, 6);
            // 
            // menuFile_RequestOfWait
            // 
            this.menuFile_RequestOfWait.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_reg;
            this.menuFile_RequestOfWait.Name = "menuFile_RequestOfWait";
            this.menuFile_RequestOfWait.Size = new System.Drawing.Size(188, 22);
            this.menuFile_RequestOfWait.Text = "待审的申请(&W)";
            this.menuFile_RequestOfWait.Click += new System.EventHandler(this.menuFile_RequestOfWait_Click);
            // 
            // menuFile_RequestOfReject
            // 
            this.menuFile_RequestOfReject.Name = "menuFile_RequestOfReject";
            this.menuFile_RequestOfReject.Size = new System.Drawing.Size(188, 22);
            this.menuFile_RequestOfReject.Text = "拒绝的申请(&R)";
            this.menuFile_RequestOfReject.Click += new System.EventHandler(this.menuFile_RequestOfReject_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(185, 6);
            // 
            // menuFile_CertOfValid
            // 
            this.menuFile_CertOfValid.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_cert;
            this.menuFile_CertOfValid.Name = "menuFile_CertOfValid";
            this.menuFile_CertOfValid.Size = new System.Drawing.Size(188, 22);
            this.menuFile_CertOfValid.Text = "颁发的证书(&S)";
            this.menuFile_CertOfValid.Click += new System.EventHandler(this.menuFile_CertOfValid_Click);
            // 
            // menuFile_CertOfRevoke
            // 
            this.menuFile_CertOfRevoke.Name = "menuFile_CertOfRevoke";
            this.menuFile_CertOfRevoke.Size = new System.Drawing.Size(188, 22);
            this.menuFile_CertOfRevoke.Text = "吊销的证书(&K)";
            this.menuFile_CertOfRevoke.Click += new System.EventHandler(this.menuFile_CertOfRevoke_Click);
            // 
            // menuFile_CertOfExpire
            // 
            this.menuFile_CertOfExpire.Name = "menuFile_CertOfExpire";
            this.menuFile_CertOfExpire.Size = new System.Drawing.Size(188, 22);
            this.menuFile_CertOfExpire.Text = "过期的证书(&E)";
            this.menuFile_CertOfExpire.Click += new System.EventHandler(this.menuFile_CertOfExpire_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(185, 6);
            // 
            // menuFile_Exit
            // 
            this.menuFile_Exit.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_exit;
            this.menuFile_Exit.Name = "menuFile_Exit";
            this.menuFile_Exit.Size = new System.Drawing.Size(188, 22);
            this.menuFile_Exit.Text = "退出(&Q)";
            this.menuFile_Exit.Click += new System.EventHandler(this.menuFile_Exit_Click);
            // 
            // menuSet
            // 
            this.menuSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSet_EditLoginPassword});
            this.menuSet.Name = "menuSet";
            this.menuSet.Size = new System.Drawing.Size(59, 21);
            this.menuSet.Text = "设置(&S)";
            // 
            // menuSet_EditLoginPassword
            // 
            this.menuSet_EditLoginPassword.Name = "menuSet_EditLoginPassword";
            this.menuSet_EditLoginPassword.Size = new System.Drawing.Size(163, 22);
            this.menuSet_EditLoginPassword.Text = "修改登录口令(&P)";
            this.menuSet_EditLoginPassword.Click += new System.EventHandler(this.menuSet_EditLoginPassword_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelp_About});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // menuHelp_About
            // 
            this.menuHelp_About.Image = ((System.Drawing.Image)(resources.GetObject("menuHelp_About.Image")));
            this.menuHelp_About.Name = "menuHelp_About";
            this.menuHelp_About.Size = new System.Drawing.Size(199, 22);
            this.menuHelp_About.Text = "关于 OpenCA.NET (&A)";
            this.menuHelp_About.Click += new System.EventHandler(this.menuHelp_About_Click);
            // 
            // toolMain
            // 
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMain_AddRequest,
            this.toolMain_ImportRequest,
            this.toolStripSeparator10,
            this.toolMain_ExportCACert,
            this.toolMain_ExportCRL,
            this.toolStripSeparator9,
            this.toolMain_About,
            this.toolStripSeparator8,
            this.toolMain_Exit});
            this.toolMain.Location = new System.Drawing.Point(0, 25);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(784, 25);
            this.toolMain.TabIndex = 1;
            this.toolMain.Text = "toolStrip1";
            // 
            // toolMain_AddRequest
            // 
            this.toolMain_AddRequest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMain_AddRequest_ForUser,
            this.toolMain_AddRequest_ForSubCA});
            this.toolMain_AddRequest.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_reg;
            this.toolMain_AddRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMain_AddRequest.Name = "toolMain_AddRequest";
            this.toolMain_AddRequest.Size = new System.Drawing.Size(85, 22);
            this.toolMain_AddRequest.Text = "注册申请";
            // 
            // toolMain_AddRequest_ForUser
            // 
            this.toolMain_AddRequest_ForUser.Name = "toolMain_AddRequest_ForUser";
            this.toolMain_AddRequest_ForUser.Size = new System.Drawing.Size(140, 22);
            this.toolMain_AddRequest_ForUser.Text = "用户证书";
            this.toolMain_AddRequest_ForUser.Click += new System.EventHandler(this.toolMain_AddRequest_ForUser_Click);
            // 
            // toolMain_AddRequest_ForSubCA
            // 
            this.toolMain_AddRequest_ForSubCA.Name = "toolMain_AddRequest_ForSubCA";
            this.toolMain_AddRequest_ForSubCA.Size = new System.Drawing.Size(140, 22);
            this.toolMain_AddRequest_ForSubCA.Text = "下级CA证书";
            this.toolMain_AddRequest_ForSubCA.Click += new System.EventHandler(this.toolMain_AddRequest_ForSubCA_Click);
            // 
            // toolMain_ImportRequest
            // 
            this.toolMain_ImportRequest.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_import;
            this.toolMain_ImportRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMain_ImportRequest.Name = "toolMain_ImportRequest";
            this.toolMain_ImportRequest.Size = new System.Drawing.Size(76, 22);
            this.toolMain_ImportRequest.Text = "导入申请";
            this.toolMain_ImportRequest.Click += new System.EventHandler(this.toolMain_ImportRequest_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolMain_ExportCACert
            // 
            this.toolMain_ExportCACert.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_cert;
            this.toolMain_ExportCACert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMain_ExportCACert.Name = "toolMain_ExportCACert";
            this.toolMain_ExportCACert.Size = new System.Drawing.Size(92, 22);
            this.toolMain_ExportCACert.Text = "导出CA证书";
            this.toolMain_ExportCACert.Click += new System.EventHandler(this.toolMain_ExportCACert_Click);
            // 
            // toolMain_ExportCRL
            // 
            this.toolMain_ExportCRL.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_crl;
            this.toolMain_ExportCRL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMain_ExportCRL.Name = "toolMain_ExportCRL";
            this.toolMain_ExportCRL.Size = new System.Drawing.Size(124, 22);
            this.toolMain_ExportCRL.Text = "导出证书吊销列表";
            this.toolMain_ExportCRL.Click += new System.EventHandler(this.toolMain_ExportCRL_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolMain_About
            // 
            this.toolMain_About.Image = ((System.Drawing.Image)(resources.GetObject("toolMain_About.Image")));
            this.toolMain_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMain_About.Name = "toolMain_About";
            this.toolMain_About.Size = new System.Drawing.Size(52, 22);
            this.toolMain_About.Text = "关于";
            this.toolMain_About.Click += new System.EventHandler(this.toolMain_About_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolMain_Exit
            // 
            this.toolMain_Exit.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_exit;
            this.toolMain_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMain_Exit.Name = "toolMain_Exit";
            this.toolMain_Exit.Size = new System.Drawing.Size(52, 22);
            this.toolMain_Exit.Text = "退出";
            this.toolMain_Exit.Click += new System.EventHandler(this.toolMain_Exit_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMain_FirstLabel});
            this.statusMain.Location = new System.Drawing.Point(0, 540);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(784, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip1";
            // 
            // statusMain_FirstLabel
            // 
            this.statusMain_FirstLabel.Name = "statusMain_FirstLabel";
            this.statusMain_FirstLabel.Size = new System.Drawing.Size(32, 17);
            this.statusMain_FirstLabel.Text = "就绪";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.treeNav);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 490);
            this.panelLeft.TabIndex = 3;
            // 
            // treeNav
            // 
            this.treeNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeNav.HideSelection = false;
            this.treeNav.HotTracking = true;
            this.treeNav.ImageIndex = 0;
            this.treeNav.ImageList = this.imgList;
            this.treeNav.ItemHeight = 25;
            this.treeNav.Location = new System.Drawing.Point(0, 0);
            this.treeNav.Name = "treeNav";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "Node_RequestOfWait";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Tag = "RequestOfWait";
            treeNode1.Text = "待审的申请";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Node_RequestOfReject";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Tag = "RequestOfReject";
            treeNode2.Text = "拒绝的申请";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "Node_CertOfValid";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Tag = "CertOfValid";
            treeNode3.Text = "有效的证书";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "Node_CertOfRevoke";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Tag = "CertOfRevoke";
            treeNode4.Text = "吊销的证书";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "Node_CertOfExpire";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Tag = "CertOfExpire";
            treeNode5.Text = "过期的证书";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Node_CA";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Tag = "CA";
            treeNode6.Text = "证书颁发机构(CA)";
            this.treeNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeNav.SelectedImageIndex = 0;
            this.treeNav.ShowRootLines = false;
            this.treeNav.Size = new System.Drawing.Size(200, 490);
            this.treeNav.TabIndex = 0;
            this.treeNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNav_AfterSelect);
            this.treeNav.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeNav_NodeMouseDoubleClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "icon_node.png");
            this.imgList.Images.SetKeyName(1, "icon_home.png");
            this.imgList.Images.SetKeyName(2, "icon_reg.png");
            this.imgList.Images.SetKeyName(3, "icon_cert.png");
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(200, 50);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 490);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.tabMain);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(203, 50);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(581, 490);
            this.panelRight.TabIndex = 5;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage_RequestOfWait);
            this.tabMain.Controls.Add(this.tabPage_RequestOfReject);
            this.tabMain.Controls.Add(this.tabPage_CertOfValid);
            this.tabMain.Controls.Add(this.tabPage_CertOfRevoke);
            this.tabMain.Controls.Add(this.tabPage_CertOfExpire);
            this.tabMain.Controls.Add(this.tabPage_CA);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(581, 490);
            this.tabMain.TabIndex = 0;
            this.tabMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMain_Selected);
            // 
            // tabPage_RequestOfWait
            // 
            this.tabPage_RequestOfWait.Controls.Add(this.gridRequestOfWait);
            this.tabPage_RequestOfWait.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RequestOfWait.Name = "tabPage_RequestOfWait";
            this.tabPage_RequestOfWait.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RequestOfWait.Size = new System.Drawing.Size(573, 464);
            this.tabPage_RequestOfWait.TabIndex = 1;
            this.tabPage_RequestOfWait.Text = "待审的申请";
            this.tabPage_RequestOfWait.UseVisualStyleBackColor = true;
            this.tabPage_RequestOfWait.Enter += new System.EventHandler(this.tabPage_RequestOfWait_Enter);
            // 
            // gridRequestOfWait
            // 
            this.gridRequestOfWait.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridRequestOfWait.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridRequestOfWait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRequestOfWait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.RequestOfWait_FilePath});
            this.gridRequestOfWait.ContextMenuStrip = this.menuRequestOfWait;
            this.gridRequestOfWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRequestOfWait.Location = new System.Drawing.Point(3, 3);
            this.gridRequestOfWait.Name = "gridRequestOfWait";
            this.gridRequestOfWait.RowTemplate.Height = 23;
            this.gridRequestOfWait.Size = new System.Drawing.Size(567, 458);
            this.gridRequestOfWait.TabIndex = 4;
            this.gridRequestOfWait.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRequestOfWait_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SubjectText";
            this.dataGridViewTextBoxColumn6.HeaderText = "主体";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PublicKeyAlgorithm";
            this.dataGridViewTextBoxColumn7.HeaderText = "公钥算法";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "KeyBitLength";
            this.dataGridViewTextBoxColumn8.HeaderText = "密钥位数";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SignatureAlgorithm";
            this.dataGridViewTextBoxColumn9.HeaderText = "签名算法";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 140;
            // 
            // RequestOfWait_FilePath
            // 
            this.RequestOfWait_FilePath.DataPropertyName = "FilePath";
            this.RequestOfWait_FilePath.HeaderText = "文件路径";
            this.RequestOfWait_FilePath.Name = "RequestOfWait_FilePath";
            this.RequestOfWait_FilePath.Visible = false;
            // 
            // menuRequestOfWait
            // 
            this.menuRequestOfWait.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRequestOfWait_Show,
            this.toolStripSeparator5,
            this.menuRequestOfWait_SignCert,
            this.menuRequestOfWait_Reject,
            this.toolStripMenuItem5,
            this.menuRequestOfWait_Add,
            this.menuRequestOfWait_Import,
            this.toolStripSeparator1,
            this.menuRequestOfWait_Refresh});
            this.menuRequestOfWait.Name = "menuCertOfValid";
            this.menuRequestOfWait.Size = new System.Drawing.Size(141, 154);
            // 
            // menuRequestOfWait_Show
            // 
            this.menuRequestOfWait_Show.Name = "menuRequestOfWait_Show";
            this.menuRequestOfWait_Show.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfWait_Show.Text = "查看(&S)";
            this.menuRequestOfWait_Show.Click += new System.EventHandler(this.menuRequestOfWait_Show_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(137, 6);
            // 
            // menuRequestOfWait_SignCert
            // 
            this.menuRequestOfWait_SignCert.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_cert;
            this.menuRequestOfWait_SignCert.Name = "menuRequestOfWait_SignCert";
            this.menuRequestOfWait_SignCert.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfWait_SignCert.Text = "颁发证书(&P)";
            this.menuRequestOfWait_SignCert.Click += new System.EventHandler(this.menuRequestOfWait_SignCert_Click);
            // 
            // menuRequestOfWait_Reject
            // 
            this.menuRequestOfWait_Reject.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_reject;
            this.menuRequestOfWait_Reject.Name = "menuRequestOfWait_Reject";
            this.menuRequestOfWait_Reject.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfWait_Reject.Text = "拒绝申请(&R)";
            this.menuRequestOfWait_Reject.Click += new System.EventHandler(this.menuRequestOfWait_Reject_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(137, 6);
            // 
            // menuRequestOfWait_Add
            // 
            this.menuRequestOfWait_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRequestOfWait_Add_ForUser,
            this.menuRequestOfWait_Add_ForSubCA});
            this.menuRequestOfWait_Add.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_reg;
            this.menuRequestOfWait_Add.Name = "menuRequestOfWait_Add";
            this.menuRequestOfWait_Add.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfWait_Add.Text = "注册申请(&A)";
            // 
            // menuRequestOfWait_Add_ForUser
            // 
            this.menuRequestOfWait_Add_ForUser.Name = "menuRequestOfWait_Add_ForUser";
            this.menuRequestOfWait_Add_ForUser.Size = new System.Drawing.Size(156, 22);
            this.menuRequestOfWait_Add_ForUser.Text = "用户证书(&U)";
            this.menuRequestOfWait_Add_ForUser.Click += new System.EventHandler(this.menuRequestOfWait_Add_ForUser_Click);
            // 
            // menuRequestOfWait_Add_ForSubCA
            // 
            this.menuRequestOfWait_Add_ForSubCA.Name = "menuRequestOfWait_Add_ForSubCA";
            this.menuRequestOfWait_Add_ForSubCA.Size = new System.Drawing.Size(156, 22);
            this.menuRequestOfWait_Add_ForSubCA.Text = "下级CA证书(&C)";
            this.menuRequestOfWait_Add_ForSubCA.Click += new System.EventHandler(this.menuRequestOfWait_Add_ForSubCA_Click);
            // 
            // menuRequestOfWait_Import
            // 
            this.menuRequestOfWait_Import.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_import;
            this.menuRequestOfWait_Import.Name = "menuRequestOfWait_Import";
            this.menuRequestOfWait_Import.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfWait_Import.Text = "导入申请(&I)";
            this.menuRequestOfWait_Import.Click += new System.EventHandler(this.menuRequestOfWait_Import_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // menuRequestOfWait_Refresh
            // 
            this.menuRequestOfWait_Refresh.Name = "menuRequestOfWait_Refresh";
            this.menuRequestOfWait_Refresh.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfWait_Refresh.Text = "刷新(&F)";
            this.menuRequestOfWait_Refresh.Click += new System.EventHandler(this.menuRequestOfWait_Refresh_Click);
            // 
            // tabPage_RequestOfReject
            // 
            this.tabPage_RequestOfReject.Controls.Add(this.gridRequestOfReject);
            this.tabPage_RequestOfReject.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RequestOfReject.Name = "tabPage_RequestOfReject";
            this.tabPage_RequestOfReject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RequestOfReject.Size = new System.Drawing.Size(573, 464);
            this.tabPage_RequestOfReject.TabIndex = 2;
            this.tabPage_RequestOfReject.Text = "拒绝的申请";
            this.tabPage_RequestOfReject.UseVisualStyleBackColor = true;
            this.tabPage_RequestOfReject.Enter += new System.EventHandler(this.tabPage_RequestOfReject_Enter);
            // 
            // gridRequestOfReject
            // 
            this.gridRequestOfReject.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridRequestOfReject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridRequestOfReject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRequestOfReject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.RequestOfReject_FilePath});
            this.gridRequestOfReject.ContextMenuStrip = this.menuRequestOfReject;
            this.gridRequestOfReject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRequestOfReject.Location = new System.Drawing.Point(3, 3);
            this.gridRequestOfReject.Name = "gridRequestOfReject";
            this.gridRequestOfReject.RowTemplate.Height = 23;
            this.gridRequestOfReject.Size = new System.Drawing.Size(567, 458);
            this.gridRequestOfReject.TabIndex = 5;
            this.gridRequestOfReject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRequestOfReject_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SubjectText";
            this.dataGridViewTextBoxColumn10.HeaderText = "主体";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PublicKeyAlgorithm";
            this.dataGridViewTextBoxColumn11.HeaderText = "公钥算法";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "KeyBitLength";
            this.dataGridViewTextBoxColumn12.HeaderText = "密钥位数";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "SignatureAlgorithm";
            this.dataGridViewTextBoxColumn13.HeaderText = "签名算法";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 140;
            // 
            // RequestOfReject_FilePath
            // 
            this.RequestOfReject_FilePath.DataPropertyName = "FilePath";
            this.RequestOfReject_FilePath.HeaderText = "文件路径";
            this.RequestOfReject_FilePath.Name = "RequestOfReject_FilePath";
            this.RequestOfReject_FilePath.Visible = false;
            // 
            // menuRequestOfReject
            // 
            this.menuRequestOfReject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRequestOfReject_Show,
            this.toolStripSeparator4,
            this.menuRequestOfReject_CancelReject,
            this.toolStripMenuItem2,
            this.menuRequestOfReject_Refresh});
            this.menuRequestOfReject.Name = "menuCertOfValid";
            this.menuRequestOfReject.Size = new System.Drawing.Size(141, 82);
            // 
            // menuRequestOfReject_Show
            // 
            this.menuRequestOfReject_Show.Name = "menuRequestOfReject_Show";
            this.menuRequestOfReject_Show.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfReject_Show.Text = "查看(&S)";
            this.menuRequestOfReject_Show.Click += new System.EventHandler(this.menuRequestOfReject_Show_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // menuRequestOfReject_CancelReject
            // 
            this.menuRequestOfReject_CancelReject.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_reject_cancel;
            this.menuRequestOfReject_CancelReject.Name = "menuRequestOfReject_CancelReject";
            this.menuRequestOfReject_CancelReject.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfReject_CancelReject.Text = "撤销拒绝(&C)";
            this.menuRequestOfReject_CancelReject.Click += new System.EventHandler(this.menuRequestOfReject_CancelReject_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(137, 6);
            // 
            // menuRequestOfReject_Refresh
            // 
            this.menuRequestOfReject_Refresh.Name = "menuRequestOfReject_Refresh";
            this.menuRequestOfReject_Refresh.Size = new System.Drawing.Size(140, 22);
            this.menuRequestOfReject_Refresh.Text = "刷新(&F)";
            this.menuRequestOfReject_Refresh.Click += new System.EventHandler(this.menuRequestOfReject_Refresh_Click);
            // 
            // tabPage_CertOfValid
            // 
            this.tabPage_CertOfValid.Controls.Add(this.gridCertOfValid);
            this.tabPage_CertOfValid.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CertOfValid.Name = "tabPage_CertOfValid";
            this.tabPage_CertOfValid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CertOfValid.Size = new System.Drawing.Size(573, 464);
            this.tabPage_CertOfValid.TabIndex = 3;
            this.tabPage_CertOfValid.Text = "颁发的证书";
            this.tabPage_CertOfValid.UseVisualStyleBackColor = true;
            this.tabPage_CertOfValid.Enter += new System.EventHandler(this.tabPage_CertOfValid_Enter);
            // 
            // gridCertOfValid
            // 
            this.gridCertOfValid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCertOfValid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCertOfValid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCertOfValid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CertOfValid_SerialNo,
            this.CertOfValid_ExpiredTime,
            this.CertOfValid_StartTime,
            this.CertOfValid_StoreDir,
            this.CertOfValid_DomainName});
            this.gridCertOfValid.ContextMenuStrip = this.menuCertOfValid;
            this.gridCertOfValid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCertOfValid.Location = new System.Drawing.Point(3, 3);
            this.gridCertOfValid.Name = "gridCertOfValid";
            this.gridCertOfValid.RowTemplate.Height = 23;
            this.gridCertOfValid.Size = new System.Drawing.Size(567, 458);
            this.gridCertOfValid.TabIndex = 1;
            this.gridCertOfValid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCertOfValid_CellDoubleClick);
            // 
            // CertOfValid_SerialNo
            // 
            this.CertOfValid_SerialNo.DataPropertyName = "SerialNo";
            this.CertOfValid_SerialNo.HeaderText = "序列号";
            this.CertOfValid_SerialNo.Name = "CertOfValid_SerialNo";
            this.CertOfValid_SerialNo.ReadOnly = true;
            // 
            // CertOfValid_ExpiredTime
            // 
            this.CertOfValid_ExpiredTime.DataPropertyName = "ExpiredTime";
            this.CertOfValid_ExpiredTime.HeaderText = "到期时间";
            this.CertOfValid_ExpiredTime.Name = "CertOfValid_ExpiredTime";
            this.CertOfValid_ExpiredTime.ReadOnly = true;
            // 
            // CertOfValid_StartTime
            // 
            this.CertOfValid_StartTime.DataPropertyName = "StartTime";
            this.CertOfValid_StartTime.HeaderText = "生效时间";
            this.CertOfValid_StartTime.Name = "CertOfValid_StartTime";
            this.CertOfValid_StartTime.ReadOnly = true;
            // 
            // CertOfValid_StoreDir
            // 
            this.CertOfValid_StoreDir.DataPropertyName = "StoreDir";
            this.CertOfValid_StoreDir.HeaderText = "存储路径";
            this.CertOfValid_StoreDir.Name = "CertOfValid_StoreDir";
            // 
            // CertOfValid_DomainName
            // 
            this.CertOfValid_DomainName.DataPropertyName = "DomainName";
            this.CertOfValid_DomainName.HeaderText = "特征名称";
            this.CertOfValid_DomainName.Name = "CertOfValid_DomainName";
            // 
            // menuCertOfValid
            // 
            this.menuCertOfValid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCertOfValid_Show,
            this.toolStripSeparator6,
            this.menuCertOfValid_ExportX509,
            this.menuCertOfValid_ExportP12,
            this.menuCertOfValid_ExportP7,
            this.toolStripMenuItem8,
            this.menuCertOfValid_Revoke,
            this.toolStripMenuItem1,
            this.menuCertOfValid_Refresh});
            this.menuCertOfValid.Name = "menuCertOfValid";
            this.menuCertOfValid.Size = new System.Drawing.Size(192, 154);
            // 
            // menuCertOfValid_Show
            // 
            this.menuCertOfValid_Show.Name = "menuCertOfValid_Show";
            this.menuCertOfValid_Show.Size = new System.Drawing.Size(191, 22);
            this.menuCertOfValid_Show.Text = "查看(&S)";
            this.menuCertOfValid_Show.Click += new System.EventHandler(this.menuCertOfValid_Show_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(188, 6);
            // 
            // menuCertOfValid_ExportX509
            // 
            this.menuCertOfValid_ExportX509.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_cert;
            this.menuCertOfValid_ExportX509.Name = "menuCertOfValid_ExportX509";
            this.menuCertOfValid_ExportX509.Size = new System.Drawing.Size(191, 22);
            this.menuCertOfValid_ExportX509.Text = "导出 X.509 证书(&X)";
            this.menuCertOfValid_ExportX509.Click += new System.EventHandler(this.menuCertOfValid_ExportX509_Click);
            // 
            // menuCertOfValid_ExportP12
            // 
            this.menuCertOfValid_ExportP12.Name = "menuCertOfValid_ExportP12";
            this.menuCertOfValid_ExportP12.Size = new System.Drawing.Size(191, 22);
            this.menuCertOfValid_ExportP12.Text = "导出 PKCS12 证书(&P)";
            this.menuCertOfValid_ExportP12.Click += new System.EventHandler(this.menuCertOfValid_ExportP12_Click);
            // 
            // menuCertOfValid_ExportP7
            // 
            this.menuCertOfValid_ExportP7.Name = "menuCertOfValid_ExportP7";
            this.menuCertOfValid_ExportP7.Size = new System.Drawing.Size(191, 22);
            this.menuCertOfValid_ExportP7.Text = "导出 PKCS7 证书(&E)";
            this.menuCertOfValid_ExportP7.Click += new System.EventHandler(this.menuCertOfValid_ExportP7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(188, 6);
            // 
            // menuCertOfValid_Revoke
            // 
            this.menuCertOfValid_Revoke.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_revoke;
            this.menuCertOfValid_Revoke.Name = "menuCertOfValid_Revoke";
            this.menuCertOfValid_Revoke.Size = new System.Drawing.Size(191, 22);
            this.menuCertOfValid_Revoke.Text = "吊销证书(&R)";
            this.menuCertOfValid_Revoke.Click += new System.EventHandler(this.menuCertOfValid_Revoke_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // menuCertOfValid_Refresh
            // 
            this.menuCertOfValid_Refresh.Name = "menuCertOfValid_Refresh";
            this.menuCertOfValid_Refresh.Size = new System.Drawing.Size(191, 22);
            this.menuCertOfValid_Refresh.Text = "刷新(&F)";
            this.menuCertOfValid_Refresh.Click += new System.EventHandler(this.menuCertOfValid_Refresh_Click);
            // 
            // tabPage_CertOfRevoke
            // 
            this.tabPage_CertOfRevoke.Controls.Add(this.gridCertOfRevoke);
            this.tabPage_CertOfRevoke.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CertOfRevoke.Name = "tabPage_CertOfRevoke";
            this.tabPage_CertOfRevoke.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CertOfRevoke.Size = new System.Drawing.Size(573, 464);
            this.tabPage_CertOfRevoke.TabIndex = 4;
            this.tabPage_CertOfRevoke.Text = "吊销的证书";
            this.tabPage_CertOfRevoke.UseVisualStyleBackColor = true;
            this.tabPage_CertOfRevoke.Enter += new System.EventHandler(this.tabPage_CertOfRevoke_Enter);
            // 
            // gridCertOfRevoke
            // 
            this.gridCertOfRevoke.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCertOfRevoke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCertOfRevoke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCertOfRevoke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CertOfRevoke_SerialNo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gridCertOfRevoke.ContextMenuStrip = this.menuCertOfRevoke;
            this.gridCertOfRevoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCertOfRevoke.Location = new System.Drawing.Point(3, 3);
            this.gridCertOfRevoke.Name = "gridCertOfRevoke";
            this.gridCertOfRevoke.RowTemplate.Height = 23;
            this.gridCertOfRevoke.Size = new System.Drawing.Size(567, 458);
            this.gridCertOfRevoke.TabIndex = 2;
            this.gridCertOfRevoke.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCertOfRevoke_CellDoubleClick);
            // 
            // CertOfRevoke_SerialNo
            // 
            this.CertOfRevoke_SerialNo.DataPropertyName = "SerialNo";
            this.CertOfRevoke_SerialNo.HeaderText = "序列号";
            this.CertOfRevoke_SerialNo.Name = "CertOfRevoke_SerialNo";
            this.CertOfRevoke_SerialNo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ExpiredTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "到期时间";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "生效时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StoreDir";
            this.dataGridViewTextBoxColumn4.HeaderText = "存储路径";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DomainName";
            this.dataGridViewTextBoxColumn5.HeaderText = "特征名称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // menuCertOfRevoke
            // 
            this.menuCertOfRevoke.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCertOfRevoke_Show,
            this.toolStripSeparator3,
            this.menuCertOfRevoke_ShowCRL,
            this.menuCertOfRevoke_GenCRL,
            this.menuCertOfRevoke_ExportCRL,
            this.toolStripMenuItem12,
            this.menuCertOfRevoke_Refresh});
            this.menuCertOfRevoke.Name = "menuCertOfValid";
            this.menuCertOfRevoke.Size = new System.Drawing.Size(190, 126);
            // 
            // menuCertOfRevoke_Show
            // 
            this.menuCertOfRevoke_Show.Name = "menuCertOfRevoke_Show";
            this.menuCertOfRevoke_Show.Size = new System.Drawing.Size(189, 22);
            this.menuCertOfRevoke_Show.Text = "查看(&S)";
            this.menuCertOfRevoke_Show.Click += new System.EventHandler(this.menuCertOfRevoke_Show_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // menuCertOfRevoke_ShowCRL
            // 
            this.menuCertOfRevoke_ShowCRL.Name = "menuCertOfRevoke_ShowCRL";
            this.menuCertOfRevoke_ShowCRL.Size = new System.Drawing.Size(189, 22);
            this.menuCertOfRevoke_ShowCRL.Text = "查看证书吊销列表(&C)";
            this.menuCertOfRevoke_ShowCRL.Click += new System.EventHandler(this.menuCertOfRevoke_ShowCRL_Click);
            // 
            // menuCertOfRevoke_GenCRL
            // 
            this.menuCertOfRevoke_GenCRL.Name = "menuCertOfRevoke_GenCRL";
            this.menuCertOfRevoke_GenCRL.Size = new System.Drawing.Size(189, 22);
            this.menuCertOfRevoke_GenCRL.Text = "生成证书吊销列表(&G)";
            this.menuCertOfRevoke_GenCRL.Click += new System.EventHandler(this.menuCertOfRevoke_GenCRL_Click);
            // 
            // menuCertOfRevoke_ExportCRL
            // 
            this.menuCertOfRevoke_ExportCRL.Image = global::Bettersoft.OpenCA.WinForms.Properties.Resources.icon_crl;
            this.menuCertOfRevoke_ExportCRL.Name = "menuCertOfRevoke_ExportCRL";
            this.menuCertOfRevoke_ExportCRL.Size = new System.Drawing.Size(189, 22);
            this.menuCertOfRevoke_ExportCRL.Text = "导出证书吊销列表(&E)";
            this.menuCertOfRevoke_ExportCRL.Click += new System.EventHandler(this.menuCertOfRevoke_ExportCRL_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(186, 6);
            // 
            // menuCertOfRevoke_Refresh
            // 
            this.menuCertOfRevoke_Refresh.Name = "menuCertOfRevoke_Refresh";
            this.menuCertOfRevoke_Refresh.Size = new System.Drawing.Size(189, 22);
            this.menuCertOfRevoke_Refresh.Text = "刷新(&F)";
            this.menuCertOfRevoke_Refresh.Click += new System.EventHandler(this.menuCertOfRevoke_Refresh_Click);
            // 
            // tabPage_CertOfExpire
            // 
            this.tabPage_CertOfExpire.Controls.Add(this.gridCertOfExpire);
            this.tabPage_CertOfExpire.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CertOfExpire.Name = "tabPage_CertOfExpire";
            this.tabPage_CertOfExpire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CertOfExpire.Size = new System.Drawing.Size(573, 464);
            this.tabPage_CertOfExpire.TabIndex = 5;
            this.tabPage_CertOfExpire.Text = "过期的证书";
            this.tabPage_CertOfExpire.UseVisualStyleBackColor = true;
            this.tabPage_CertOfExpire.Enter += new System.EventHandler(this.tabPage_CertOfExpire_Enter);
            // 
            // gridCertOfExpire
            // 
            this.gridCertOfExpire.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCertOfExpire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCertOfExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCertOfExpire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CertOfExpire_SerialNo,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.gridCertOfExpire.ContextMenuStrip = this.menuCertOfExpire;
            this.gridCertOfExpire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCertOfExpire.Location = new System.Drawing.Point(3, 3);
            this.gridCertOfExpire.Name = "gridCertOfExpire";
            this.gridCertOfExpire.RowTemplate.Height = 23;
            this.gridCertOfExpire.Size = new System.Drawing.Size(567, 458);
            this.gridCertOfExpire.TabIndex = 3;
            this.gridCertOfExpire.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCertOfExpire_CellDoubleClick);
            // 
            // CertOfExpire_SerialNo
            // 
            this.CertOfExpire_SerialNo.DataPropertyName = "SerialNo";
            this.CertOfExpire_SerialNo.HeaderText = "序列号";
            this.CertOfExpire_SerialNo.Name = "CertOfExpire_SerialNo";
            this.CertOfExpire_SerialNo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ExpiredTime";
            this.dataGridViewTextBoxColumn15.HeaderText = "到期时间";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn16.HeaderText = "生效时间";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "StoreDir";
            this.dataGridViewTextBoxColumn17.HeaderText = "存储路径";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "DomainName";
            this.dataGridViewTextBoxColumn18.HeaderText = "特征名称";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // menuCertOfExpire
            // 
            this.menuCertOfExpire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCertOfExpire_Show,
            this.toolStripSeparator2,
            this.menuCertOfExpire_Refresh});
            this.menuCertOfExpire.Name = "menuCertOfValid";
            this.menuCertOfExpire.Size = new System.Drawing.Size(116, 54);
            // 
            // menuCertOfExpire_Show
            // 
            this.menuCertOfExpire_Show.Name = "menuCertOfExpire_Show";
            this.menuCertOfExpire_Show.Size = new System.Drawing.Size(115, 22);
            this.menuCertOfExpire_Show.Text = "查看(&S)";
            this.menuCertOfExpire_Show.Click += new System.EventHandler(this.menuCertOfExpire_Show_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(112, 6);
            // 
            // menuCertOfExpire_Refresh
            // 
            this.menuCertOfExpire_Refresh.Name = "menuCertOfExpire_Refresh";
            this.menuCertOfExpire_Refresh.Size = new System.Drawing.Size(115, 22);
            this.menuCertOfExpire_Refresh.Text = "刷新(&F)";
            this.menuCertOfExpire_Refresh.Click += new System.EventHandler(this.menuCertOfExpire_Refresh_Click);
            // 
            // tabPage_CA
            // 
            this.tabPage_CA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage_CA.Controls.Add(this.btnExportCACert);
            this.tabPage_CA.Controls.Add(this.btnGenRootCA);
            this.tabPage_CA.Controls.Add(this.btnImportCAKey);
            this.tabPage_CA.Controls.Add(this.btnImportCACert);
            this.tabPage_CA.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_CA.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CA.Name = "tabPage_CA";
            this.tabPage_CA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CA.Size = new System.Drawing.Size(573, 464);
            this.tabPage_CA.TabIndex = 0;
            this.tabPage_CA.Text = "证书颁发机构(CA)";
            this.tabPage_CA.Enter += new System.EventHandler(this.tabPage_CA_Enter);
            // 
            // btnExportCACert
            // 
            this.btnExportCACert.Location = new System.Drawing.Point(20, 305);
            this.btnExportCACert.Name = "btnExportCACert";
            this.btnExportCACert.Size = new System.Drawing.Size(100, 23);
            this.btnExportCACert.TabIndex = 1;
            this.btnExportCACert.Text = "导出CA证书(&E)";
            this.btnExportCACert.UseVisualStyleBackColor = true;
            this.btnExportCACert.Click += new System.EventHandler(this.btnExportCACert_Click);
            // 
            // btnGenRootCA
            // 
            this.btnGenRootCA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenRootCA.Location = new System.Drawing.Point(346, 305);
            this.btnGenRootCA.Name = "btnGenRootCA";
            this.btnGenRootCA.Size = new System.Drawing.Size(180, 23);
            this.btnGenRootCA.TabIndex = 4;
            this.btnGenRootCA.Text = "生成自签名根证书和私钥(&G)";
            this.btnGenRootCA.UseVisualStyleBackColor = true;
            this.btnGenRootCA.Click += new System.EventHandler(this.btnGenRootCA_Click);
            // 
            // btnImportCAKey
            // 
            this.btnImportCAKey.Location = new System.Drawing.Point(232, 305);
            this.btnImportCAKey.Name = "btnImportCAKey";
            this.btnImportCAKey.Size = new System.Drawing.Size(100, 23);
            this.btnImportCAKey.TabIndex = 3;
            this.btnImportCAKey.Text = "导入CA私钥(&K)";
            this.btnImportCAKey.UseVisualStyleBackColor = true;
            this.btnImportCAKey.Click += new System.EventHandler(this.btnImportCAKey_Click);
            // 
            // btnImportCACert
            // 
            this.btnImportCACert.Location = new System.Drawing.Point(126, 305);
            this.btnImportCACert.Name = "btnImportCACert";
            this.btnImportCACert.Size = new System.Drawing.Size(100, 23);
            this.btnImportCACert.TabIndex = 2;
            this.btnImportCACert.Text = "导入CA证书(&I)";
            this.btnImportCACert.UseVisualStyleBackColor = true;
            this.btnImportCACert.Click += new System.EventHandler(this.btnImportCACert_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCACert, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCAKey, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "CA证书:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCACert
            // 
            this.txtCACert.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCACert.Location = new System.Drawing.Point(123, 23);
            this.txtCACert.Multiline = true;
            this.txtCACert.Name = "txtCACert";
            this.txtCACert.ReadOnly = true;
            this.txtCACert.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCACert.Size = new System.Drawing.Size(400, 194);
            this.txtCACert.TabIndex = 1;
            this.txtCACert.WordWrap = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "CA私钥:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCAKey
            // 
            this.txtCAKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCAKey.Location = new System.Drawing.Point(123, 224);
            this.txtCAKey.Name = "txtCAKey";
            this.txtCAKey.ReadOnly = true;
            this.txtCAKey.Size = new System.Drawing.Size(400, 21);
            this.txtCAKey.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "CA私钥保护口令:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSaveCAKeyPasswod);
            this.panel1.Controls.Add(this.txtCAKeyPassword);
            this.panel1.Location = new System.Drawing.Point(123, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 24);
            this.panel1.TabIndex = 13;
            // 
            // btnSaveCAKeyPasswod
            // 
            this.btnSaveCAKeyPasswod.Location = new System.Drawing.Point(207, 1);
            this.btnSaveCAKeyPasswod.Name = "btnSaveCAKeyPasswod";
            this.btnSaveCAKeyPasswod.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCAKeyPasswod.TabIndex = 1;
            this.btnSaveCAKeyPasswod.Text = "保存(&S)";
            this.btnSaveCAKeyPasswod.UseVisualStyleBackColor = true;
            this.btnSaveCAKeyPasswod.Click += new System.EventHandler(this.btnSaveCAKeyPasswod_Click);
            // 
            // txtCAKeyPassword
            // 
            this.txtCAKeyPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCAKeyPassword.Location = new System.Drawing.Point(1, 2);
            this.txtCAKeyPassword.Name = "txtCAKeyPassword";
            this.txtCAKeyPassword.PasswordChar = '*';
            this.txtCAKeyPassword.Size = new System.Drawing.Size(200, 21);
            this.txtCAKeyPassword.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "证书颁发机构(CA)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage_RequestOfWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRequestOfWait)).EndInit();
            this.menuRequestOfWait.ResumeLayout(false);
            this.tabPage_RequestOfReject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRequestOfReject)).EndInit();
            this.menuRequestOfReject.ResumeLayout(false);
            this.tabPage_CertOfValid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCertOfValid)).EndInit();
            this.menuCertOfValid.ResumeLayout(false);
            this.tabPage_CertOfRevoke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCertOfRevoke)).EndInit();
            this.menuCertOfRevoke.ResumeLayout(false);
            this.tabPage_CertOfExpire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCertOfExpire)).EndInit();
            this.menuCertOfExpire.ResumeLayout(false);
            this.tabPage_CA.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TreeView treeNav;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelp_About;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage_CA;
        private System.Windows.Forms.TabPage tabPage_RequestOfWait;
        private System.Windows.Forms.TabPage tabPage_RequestOfReject;
        private System.Windows.Forms.TabPage tabPage_CertOfValid;
        private System.Windows.Forms.DataGridView gridCertOfValid;
        private System.Windows.Forms.TabPage tabPage_CertOfRevoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertOfValid_SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertOfValid_ExpiredTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertOfValid_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertOfValid_StoreDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertOfValid_DomainName;
        private System.Windows.Forms.DataGridView gridCertOfRevoke;
        private System.Windows.Forms.ContextMenuStrip menuCertOfValid;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfValid_Revoke;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfValid_Refresh;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfValid_ExportX509;
        private System.Windows.Forms.ToolStripMenuItem menuSet;
        private System.Windows.Forms.DataGridView gridRequestOfWait;
        private System.Windows.Forms.ContextMenuStrip menuRequestOfWait;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfWait_SignCert;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfWait_Reject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfWait_Refresh;
        private System.Windows.Forms.DataGridView gridRequestOfReject;
        private System.Windows.Forms.ContextMenuStrip menuRequestOfReject;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfReject_Refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfWait_Add;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfWait_Import;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfValid_ExportP12;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfValid_ExportP7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ContextMenuStrip menuCertOfRevoke;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfRevoke_ExportCRL;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfRevoke_Refresh;
        private System.Windows.Forms.ToolStripStatusLabel statusMain_FirstLabel;
        private System.Windows.Forms.TabPage tabPage_CertOfExpire;
        private System.Windows.Forms.DataGridView gridCertOfExpire;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfReject_CancelReject;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip menuCertOfExpire;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfExpire_Refresh;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfExpire_Show;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfRevoke_Show;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfWait_Show;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfReject_Show;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfValid_Show;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertOfRevoke_SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertOfExpire_SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfRevoke_GenCRL;
        private System.Windows.Forms.ToolStripMenuItem menuCertOfRevoke_ShowCRL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolMain_About;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Exit;
        private System.Windows.Forms.ToolStripButton toolMain_Exit;
        private System.Windows.Forms.ToolStripButton toolMain_ExportCRL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolMain_ImportRequest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton toolMain_ExportCACert;
        private System.Windows.Forms.ToolStripMenuItem menuFile_CA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem menuFile_RequestOfWait;
        private System.Windows.Forms.ToolStripMenuItem menuFile_RequestOfReject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem menuFile_CertOfValid;
        private System.Windows.Forms.ToolStripMenuItem menuFile_CertOfRevoke;
        private System.Windows.Forms.ToolStripMenuItem menuFile_CertOfExpire;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCACert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCAKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImportCAKey;
        private System.Windows.Forms.Button btnImportCACert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveCAKeyPasswod;
        private System.Windows.Forms.TextBox txtCAKeyPassword;
        private System.Windows.Forms.Button btnGenRootCA;
        private System.Windows.Forms.Button btnExportCACert;
        private System.Windows.Forms.ToolStripMenuItem menuSet_EditLoginPassword;
        private System.Windows.Forms.ToolStripDropDownButton toolMain_AddRequest;
        private System.Windows.Forms.ToolStripMenuItem toolMain_AddRequest_ForUser;
        private System.Windows.Forms.ToolStripMenuItem toolMain_AddRequest_ForSubCA;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfWait_Add_ForUser;
        private System.Windows.Forms.ToolStripMenuItem menuRequestOfWait_Add_ForSubCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestOfWait_FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestOfReject_FilePath;
    }
}

