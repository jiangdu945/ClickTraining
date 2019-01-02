namespace ClickTraining
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status_currentLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_combo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_speed1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_speed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_speed3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_level1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_level2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_level4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1007, 569);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_level1,
            this.tsmi_level2,
            this.tsmi_level3,
            this.tsmi_level4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 92);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status_currentLevel,
            this.toolStripStatusLabel2,
            this.status_combo,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 23);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 18);
            this.toolStripStatusLabel1.Text = "当前等级：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // status_currentLevel
            // 
            this.status_currentLevel.Name = "status_currentLevel";
            this.status_currentLevel.Size = new System.Drawing.Size(131, 18);
            this.status_currentLevel.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 18);
            this.toolStripStatusLabel2.Text = "连击：";
            // 
            // status_combo
            // 
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(15, 18);
            this.status_combo.Text = "0";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_speed3,
            this.tsmi_speed2,
            this.tsmi_speed1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 21);
            this.toolStripDropDownButton1.Text = "速度切换";
            // 
            // tsmi_speed1
            // 
            this.tsmi_speed1.Name = "tsmi_speed1";
            this.tsmi_speed1.Size = new System.Drawing.Size(180, 22);
            this.tsmi_speed1.Text = "慢速";
            this.tsmi_speed1.Click += new System.EventHandler(this.tsmi_speed1_Click);
            // 
            // tsmi_speed2
            // 
            this.tsmi_speed2.Name = "tsmi_speed2";
            this.tsmi_speed2.Size = new System.Drawing.Size(180, 22);
            this.tsmi_speed2.Text = "普通";
            this.tsmi_speed2.Click += new System.EventHandler(this.tsmi_speed2_Click);
            // 
            // tsmi_speed3
            // 
            this.tsmi_speed3.Name = "tsmi_speed3";
            this.tsmi_speed3.Size = new System.Drawing.Size(180, 22);
            this.tsmi_speed3.Text = "快速";
            this.tsmi_speed3.Click += new System.EventHandler(this.tsmi_speed3_Click);
            // 
            // tsmi_level1
            // 
            this.tsmi_level1.Name = "tsmi_level1";
            this.tsmi_level1.Size = new System.Drawing.Size(180, 22);
            this.tsmi_level1.Text = "初级";
            this.tsmi_level1.Click += new System.EventHandler(this.tsmi_level1_Click);
            // 
            // tsmi_level2
            // 
            this.tsmi_level2.Name = "tsmi_level2";
            this.tsmi_level2.Size = new System.Drawing.Size(180, 22);
            this.tsmi_level2.Text = "中级";
            this.tsmi_level2.Click += new System.EventHandler(this.tsmi_level2_Click);
            // 
            // tsmi_level3
            // 
            this.tsmi_level3.Name = "tsmi_level3";
            this.tsmi_level3.Size = new System.Drawing.Size(180, 22);
            this.tsmi_level3.Text = "高级";
            this.tsmi_level3.Click += new System.EventHandler(this.tsmi_level3_Click);
            // 
            // tsmi_level4
            // 
            this.tsmi_level4.Name = "tsmi_level4";
            this.tsmi_level4.Size = new System.Drawing.Size(180, 22);
            this.tsmi_level4.Text = "专家";
            this.tsmi_level4.Click += new System.EventHandler(this.tsmi_level4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 569);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CF练习器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel status_currentLevel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel status_combo;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_speed3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_speed2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_speed1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_level1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_level2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_level3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_level4;
    }
}

