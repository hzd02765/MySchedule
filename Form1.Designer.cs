namespace MySchedule
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.readMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.writeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.shortMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.longMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.appinfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.displayMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMenu,
            this.writeMenu,
            this.deleteMenu,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(85, 22);
            this.fileMenu.Text = "ファイル(&F)";
            // 
            // readMenu
            // 
            this.readMenu.Name = "readMenu";
            this.readMenu.Size = new System.Drawing.Size(182, 22);
            this.readMenu.Text = "データ読み込み(&R)";
            // 
            // writeMenu
            // 
            this.writeMenu.Name = "writeMenu";
            this.writeMenu.Size = new System.Drawing.Size(182, 22);
            this.writeMenu.Text = "データ書き込み(&W)";
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(182, 22);
            this.deleteMenu.Text = "削除(&D)";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(182, 22);
            this.exitMenu.Text = "終了(&X)";
            // 
            // displayMenu
            // 
            this.displayMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortMenu,
            this.longMenu});
            this.displayMenu.Name = "displayMenu";
            this.displayMenu.Size = new System.Drawing.Size(62, 22);
            this.displayMenu.Text = "表示(&V)";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usingMenu,
            this.appinfoMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(75, 22);
            this.helpMenu.Text = "ヘルプ(&H)";
            // 
            // shortMenu
            // 
            this.shortMenu.Name = "shortMenu";
            this.shortMenu.Size = new System.Drawing.Size(166, 22);
            this.shortMenu.Text = "その日の予定(&S)";
            // 
            // longMenu
            // 
            this.longMenu.Name = "longMenu";
            this.longMenu.Size = new System.Drawing.Size(166, 22);
            this.longMenu.Text = "長期の予定(&L)";
            // 
            // usingMenu
            // 
            this.usingMenu.Name = "usingMenu";
            this.usingMenu.Size = new System.Drawing.Size(178, 22);
            this.usingMenu.Text = "使い方(&U)";
            // 
            // appinfoMenu
            // 
            this.appinfoMenu.Name = "appinfoMenu";
            this.appinfoMenu.Size = new System.Drawing.Size(178, 22);
            this.appinfoMenu.Text = "バージョン情報(&A)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 462);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySchedule";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem readMenu;
        private System.Windows.Forms.ToolStripMenuItem writeMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem displayMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem shortMenu;
        private System.Windows.Forms.ToolStripMenuItem longMenu;
        private System.Windows.Forms.ToolStripMenuItem usingMenu;
        private System.Windows.Forms.ToolStripMenuItem appinfoMenu;
    }
}

