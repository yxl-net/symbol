using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Yxl
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class FormMain : Form
    {
        #region 字段
        /// <summary>
        /// 表格绑定内存表
        /// </summary>
        DataTable dt = new DataTable();
        #endregion

        #region 构造方法
        /// <summary>
        /// 主窗体 构造方法
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            dgv.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dgv, true, null);//表格双缓冲
            foreach (DataGridViewColumn col in dgv.Columns)//遍历表格列集
            {
                dt.Columns.Add(col.DataPropertyName);//添加表格列字段
            }
            dt.DefaultView.ListChanged += (o, x) =>tslCount.Text=(o as DataView).Count.ToString();//内存表过滤行数改变
            dgv.DataSource = dt;//表格绑定内存表
            foreach(string line in File.ReadAllLines("yxl"))//遍历文件行集
            {
                dt.Rows.Add(line.Split(new char[] { ' ' }, 6));//添加行 6个值 最后一列可以包含空格
            }
            #region 生成数据
            string s = "♔♕♖♗♘♙♚♛♜♝♞♟";
            StringBuilder sb = new StringBuilder();
            foreach(char c in s)
            {
                sb.AppendLine($"{c} \\u{(int)c:X4} &#{(int)c};    ");
            }
            s = sb.ToString();
            #endregion
        }
        #endregion

        #region 工具栏句柄
        /// <summary>
        /// 过滤框文本改变
        /// </summary>
        /// <param name="sender">控件</param>
        /// <param name="e">事件参数</param>
        private void tstFilter_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = String.Format("sValue like '%{0}%' or sDesc like '%{0}%'", tstFilter.Text.Trim().Replace("'","''").Replace("%","[%]").Replace("*","[*]").Replace("[","[[]"));//值和描述 模糊搜索
        }

        /// <summary>
        /// 点击复制符号菜单项
        /// </summary>
        /// <param name="sender">控件</param>
        /// <param name="e">事件参数</param>
        private void tmiCopySymbol_Click(object sender, EventArgs e)
        {
            try//资源异常
            {
                Clipboard.SetText(dgv.CurrentRow.Cells[0].Value.ToString());//设置剪贴板文本
            }
            catch//不报错
            {
            }
        }

        /// <summary>
        /// 点击复制Unicode菜单项
        /// </summary>
        /// <param name="sender">控件</param>
        /// <param name="e">事件参数</param>
        private void tmiCopyUnicode_Click(object sender, EventArgs e)
        {
            try//资源异常
            {
                Clipboard.SetText(dgv.CurrentRow.Cells[1].Value.ToString());//设置剪贴板文本
            }
            catch//不报错
            {
            }
        }

        /// <summary>
        /// 点击复制HTML实体菜单项
        /// </summary>
        /// <param name="sender">控件</param>
        /// <param name="e">事件参数</param>
        private void tmiCopyHtml_Click(object sender, EventArgs e)
        {
            try//资源异常
            {
                Clipboard.SetText(dgv.CurrentRow.Cells[2].Value.ToString());//设置剪贴板文本
            }
            catch//不报错
            {
            }
        }
        #endregion
    }
}
