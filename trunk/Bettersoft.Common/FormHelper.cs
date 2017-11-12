using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bettersoft.Common
{
    public class FormHelper
    {
        /// <summary>
        /// 初始化模式对话框
        /// </summary>
        public static void InitModalDialog(Form form)
        {
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// 初始化数据表格
        /// </summary>
        /// <param name="grid"></param>
        public static void InitGridView(DataGridView grid)
        {
            grid.RowHeadersWidth = 25;
            grid.AutoGenerateColumns = false;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
        }
    }
}
