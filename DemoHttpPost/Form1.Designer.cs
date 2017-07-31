namespace DemoHttpPost
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbPostType = new System.Windows.Forms.ComboBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDataBody = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLangType = new System.Windows.Forms.ComboBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelFile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btAddFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbQueryList = new System.Windows.Forms.ComboBox();
            this.btLoding = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPostType
            // 
            this.cbPostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostType.FormattingEnabled = true;
            this.cbPostType.Location = new System.Drawing.Point(12, 49);
            this.cbPostType.Name = "cbPostType";
            this.cbPostType.Size = new System.Drawing.Size(62, 20);
            this.cbPostType.TabIndex = 0;
            this.cbPostType.SelectedIndexChanged += new System.EventHandler(this.cbPostType_SelectedIndexChanged);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(81, 48);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(609, 21);
            this.tbUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "提交参数：";
            // 
            // tbDataBody
            // 
            this.tbDataBody.Location = new System.Drawing.Point(81, 80);
            this.tbDataBody.Multiline = true;
            this.tbDataBody.Name = "tbDataBody";
            this.tbDataBody.Size = new System.Drawing.Size(672, 108);
            this.tbDataBody.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "接交编码：";
            // 
            // cbLangType
            // 
            this.cbLangType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLangType.FormattingEnabled = true;
            this.cbLangType.Location = new System.Drawing.Point(81, 350);
            this.cbLangType.Name = "cbLangType";
            this.cbLangType.Size = new System.Drawing.Size(387, 20);
            this.cbLangType.TabIndex = 5;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 379);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(741, 183);
            this.tbResult.TabIndex = 6;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(696, 46);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(57, 23);
            this.btSubmit.TabIndex = 7;
            this.btSubmit.Text = "提 交";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(602, 16);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(86, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "保存(Ctrl+S)";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "上传的文件：";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePath,
            this.btDelFile});
            this.dgvFiles.Location = new System.Drawing.Point(81, 228);
            this.dgvFiles.Name = "dgvFiles";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFiles.RowTemplate.Height = 23;
            this.dgvFiles.Size = new System.Drawing.Size(672, 114);
            this.dgvFiles.TabIndex = 10;
            this.dgvFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellContentClick);
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "文件路径";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Width = 550;
            // 
            // btDelFile
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "删除";
            this.btDelFile.DefaultCellStyle = dataGridViewCellStyle1;
            this.btDelFile.HeaderText = "操作";
            this.btDelFile.Name = "btDelFile";
            this.btDelFile.ReadOnly = true;
            this.btDelFile.Text = "删除";
            this.btDelFile.Width = 70;
            // 
            // btAddFile
            // 
            this.btAddFile.Location = new System.Drawing.Point(81, 197);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(75, 23);
            this.btAddFile.TabIndex = 11;
            this.btAddFile.Text = "添加文件";
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "历史调试：";
            // 
            // cbQueryList
            // 
            this.cbQueryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueryList.FormattingEnabled = true;
            this.cbQueryList.Location = new System.Drawing.Point(81, 18);
            this.cbQueryList.Name = "cbQueryList";
            this.cbQueryList.Size = new System.Drawing.Size(434, 20);
            this.cbQueryList.TabIndex = 13;
            // 
            // btLoding
            // 
            this.btLoding.Location = new System.Drawing.Point(521, 16);
            this.btLoding.Name = "btLoding";
            this.btLoding.Size = new System.Drawing.Size(75, 23);
            this.btLoding.TabIndex = 15;
            this.btLoding.Text = "加载参数";
            this.btLoding.UseVisualStyleBackColor = true;
            this.btLoding.Click += new System.EventHandler(this.btLoding_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Tag = "123123";
            this.statusStrip1.Text = "statusStrip1123123";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 593);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btLoding);
            this.Controls.Add(this.cbQueryList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAddFile);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.cbLangType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDataBody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.cbPostType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "minPost 调试工具V1.0 - QQ:42309073";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPostType;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDataBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLangType;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbQueryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewButtonColumn btDelFile;
        private System.Windows.Forms.Button btLoding;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

