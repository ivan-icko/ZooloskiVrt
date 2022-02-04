
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
            this.dodajZivotinjuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiZivotinjuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pretraziZivotinjuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zivotinjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(87, 565);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zivotinjeToolStripMenuItem
            // 
            this.zivotinjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajZivotinjuToolStripMenuItem,
            this.obrisiZivotinjuToolStripMenuItem,
            this.pretraziZivotinjuToolStripMenuItem});
            this.zivotinjeToolStripMenuItem.Name = "zivotinjeToolStripMenuItem";
            this.zivotinjeToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.zivotinjeToolStripMenuItem.Text = "Zivotinje";
            // 
            // dodajZivotinjuToolStripMenuItem
            // 
            this.dodajZivotinjuToolStripMenuItem.Name = "dodajZivotinjuToolStripMenuItem";
            this.dodajZivotinjuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajZivotinjuToolStripMenuItem.Text = "Dodaj zivotinju";
            this.dodajZivotinjuToolStripMenuItem.Click += new System.EventHandler(this.dodajZivotinjuToolStripMenuItem_Click);
            // 
            // obrisiZivotinjuToolStripMenuItem
            // 
            this.obrisiZivotinjuToolStripMenuItem.Name = "obrisiZivotinjuToolStripMenuItem";
            this.obrisiZivotinjuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.obrisiZivotinjuToolStripMenuItem.Text = "Obrisi zivotinju";
            this.obrisiZivotinjuToolStripMenuItem.Click += new System.EventHandler(this.obrisiZivotinjuToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(87, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(865, 565);
            this.pnlMain.TabIndex = 2;
            // 
            // pretraziZivotinjuToolStripMenuItem
            // 
            this.pretraziZivotinjuToolStripMenuItem.Name = "pretraziZivotinjuToolStripMenuItem";
            this.pretraziZivotinjuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pretraziZivotinjuToolStripMenuItem.Text = "Pretrazi zivotinju";
            this.pretraziZivotinjuToolStripMenuItem.Click += new System.EventHandler(this.pretraziZivotinjuToolStripMenuItem_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 565);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zivotinjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZivotinjuToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem obrisiZivotinjuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziZivotinjuToolStripMenuItem;
    }
}