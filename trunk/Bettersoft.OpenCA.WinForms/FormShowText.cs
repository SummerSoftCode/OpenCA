using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bettersoft.Common;

namespace Bettersoft.OpenCA.WinForms
{
    public partial class FormShowText : Form
    {
        private string title;
        private string info;

        private FormShowText()
        {
            InitializeComponent();
        }

        public FormShowText(string title, string info)
        {
            InitializeComponent();
            //----
            this.title = title;
            info = info.Replace("\n", Environment.NewLine);
            this.info = info;
        }

        private void FormShowText_Load(object sender, EventArgs e)
        {
            FormHelper.InitModalDialog(this);
            //----
            this.Text = this.title;
            this.txtInfo.Text = this.info;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
