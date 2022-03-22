
namespace ZooloskiVrt.Klijent.Forme
{
    partial class FrmGlavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zivotinjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paketiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posetiociToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zivotinjeToolStripMenuItem,
            this.paketiToolStripMenuItem,
            this.posetiociToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1466, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zivotinjeToolStripMenuItem
            // 
            this.zivotinjeToolStripMenuItem.Name = "zivotinjeToolStripMenuItem";
            this.zivotinjeToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.zivotinjeToolStripMenuItem.Text = "Zivotinje";
            this.zivotinjeToolStripMenuItem.Click += new System.EventHandler(this.zivotinjeToolStripMenuItem_Click);
            // 
            // paketiToolStripMenuItem
            // 
            this.paketiToolStripMenuItem.Name = "paketiToolStripMenuItem";
            this.paketiToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.paketiToolStripMenuItem.Text = "Paketi";
            this.paketiToolStripMenuItem.Click += new System.EventHandler(this.paketiToolStripMenuItem_Click);
            // 
            // posetiociToolStripMenuItem
            // 
            this.posetiociToolStripMenuItem.Name = "posetiociToolStripMenuItem";
            this.posetiociToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.posetiociToolStripMenuItem.Text = "Posetioci";
            this.posetiociToolStripMenuItem.Click += new System.EventHandler(this.posetiociToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1466, 886);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 916);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGlavna";
            this.Text = "Zivotinje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGlavna_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zivotinjeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem paketiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posetiociToolStripMenuItem;
    }
}