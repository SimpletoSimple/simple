namespace myMDI
{
    partial class myForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load,
            this.cascade,
            this.horizontal,
            this.vertical});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(81, 24);
            this.load.Text = "加载窗体";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // cascade
            // 
            this.cascade.Name = "cascade";
            this.cascade.Size = new System.Drawing.Size(81, 24);
            this.cascade.Text = "层叠平铺";
            this.cascade.Click += new System.EventHandler(this.cascade_Click);
            // 
            // horizontal
            // 
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(81, 24);
            this.horizontal.Text = "垂直平铺";
            this.horizontal.Click += new System.EventHandler(this.horizontal_Click);
            // 
            // vertical
            // 
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(81, 24);
            this.vertical.Text = "水平平铺";
            this.vertical.Click += new System.EventHandler(this.vertical_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "myForm";
            this.Text = "MDI";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.ToolStripMenuItem cascade;
        private System.Windows.Forms.ToolStripMenuItem horizontal;
        private System.Windows.Forms.ToolStripMenuItem vertical;
    }
}

