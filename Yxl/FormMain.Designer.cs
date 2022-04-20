
namespace Yxl
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tssFilter = new System.Windows.Forms.ToolStripSeparator();
            this.tsdCopy = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmiCopySymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCopyUnicode = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCopyHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.tssCopy = new System.Windows.Forms.ToolStripSeparator();
            this.tslCount = new System.Windows.Forms.ToolStripLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmfCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts
            // 
            this.ts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSearch,
            this.tstFilter,
            this.tssFilter,
            this.tsdCopy,
            this.tssCopy,
            this.tslCount});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(800, 27);
            this.ts.TabIndex = 0;
            this.ts.Text = "toolStrip1";
            // 
            // tslSearch
            // 
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(54, 24);
            this.tslSearch.Text = "搜索：";
            // 
            // tstFilter
            // 
            this.tstFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstFilter.Name = "tstFilter";
            this.tstFilter.Size = new System.Drawing.Size(100, 27);
            this.tstFilter.TextChanged += new System.EventHandler(this.tstFilter_TextChanged);
            // 
            // tssFilter
            // 
            this.tssFilter.Name = "tssFilter";
            this.tssFilter.Size = new System.Drawing.Size(6, 27);
            // 
            // tsdCopy
            // 
            this.tsdCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiCopySymbol,
            this.tmiCopyUnicode,
            this.tmiCopyHtml});
            this.tsdCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsdCopy.Image")));
            this.tsdCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdCopy.Name = "tsdCopy";
            this.tsdCopy.Size = new System.Drawing.Size(73, 24);
            this.tsdCopy.Text = "复制";
            // 
            // tmiCopySymbol
            // 
            this.tmiCopySymbol.Name = "tmiCopySymbol";
            this.tmiCopySymbol.Size = new System.Drawing.Size(224, 26);
            this.tmiCopySymbol.Text = "符号";
            this.tmiCopySymbol.Click += new System.EventHandler(this.tmiCopySymbol_Click);
            // 
            // tmiCopyUnicode
            // 
            this.tmiCopyUnicode.Name = "tmiCopyUnicode";
            this.tmiCopyUnicode.Size = new System.Drawing.Size(224, 26);
            this.tmiCopyUnicode.Text = "Unicode";
            this.tmiCopyUnicode.Click += new System.EventHandler(this.tmiCopyUnicode_Click);
            // 
            // tmiCopyHtml
            // 
            this.tmiCopyHtml.Name = "tmiCopyHtml";
            this.tmiCopyHtml.Size = new System.Drawing.Size(224, 26);
            this.tmiCopyHtml.Text = "HTML实体";
            this.tmiCopyHtml.Click += new System.EventHandler(this.tmiCopyHtml_Click);
            // 
            // tssCopy
            // 
            this.tssCopy.Name = "tssCopy";
            this.tssCopy.Size = new System.Drawing.Size(6, 27);
            // 
            // tslCount
            // 
            this.tslCount.Name = "tslCount";
            this.tslCount.Size = new System.Drawing.Size(18, 24);
            this.tslCount.Text = "0";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 27);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(800, 423);
            this.dgv.TabIndex = 1;
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmfCopy});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(109, 28);
            // 
            // cmfCopy
            // 
            this.cmfCopy.Name = "cmfCopy";
            this.cmfCopy.Size = new System.Drawing.Size(108, 24);
            this.cmfCopy.Text = "复制";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sSymbol";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "符号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sUnicode";
            this.Column2.HeaderText = "Unicode";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sHtml";
            this.Column3.HeaderText = "HTML实体";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sType";
            this.Column4.HeaderText = "类型";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sValue";
            this.Column6.HeaderText = "值";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "sDesc";
            this.Column5.HeaderText = "说明";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ts);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "特殊符号小程序";
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstFilter;
        private System.Windows.Forms.ToolStripSeparator tssFilter;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripDropDownButton tsdCopy;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmfCopy;
        private System.Windows.Forms.ToolStripMenuItem tmiCopySymbol;
        private System.Windows.Forms.ToolStripMenuItem tmiCopyUnicode;
        private System.Windows.Forms.ToolStripMenuItem tmiCopyHtml;
        private System.Windows.Forms.ToolStripSeparator tssCopy;
        private System.Windows.Forms.ToolStripLabel tslCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

