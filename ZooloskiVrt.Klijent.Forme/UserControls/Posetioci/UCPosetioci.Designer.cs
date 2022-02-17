
using System.Windows.Forms;

namespace ZooloskiVrt.Klijent.Forme.UserControls.Posetioci
{
    partial class UCPosetioci
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPaketi = new System.Windows.Forms.DataGridView();
            this.dgvPosetioci = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.txtBrojOsoba = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosetioci)).BeginInit();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPaketi
            // 
            this.dgvPaketi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPaketi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaketi.Location = new System.Drawing.Point(18, 21);
            this.dgvPaketi.Name = "dgvPaketi";
            this.dgvPaketi.RowHeadersWidth = 51;
            this.dgvPaketi.RowTemplate.Height = 24;
            this.dgvPaketi.Size = new System.Drawing.Size(723, 243);
            this.dgvPaketi.TabIndex = 0;
            // 
            // dgvPosetioci
            // 
            this.dgvPosetioci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPosetioci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosetioci.Location = new System.Drawing.Point(21, 21);
            this.dgvPosetioci.Name = "dgvPosetioci";
            this.dgvPosetioci.RowHeadersWidth = 51;
            this.dgvPosetioci.RowTemplate.Height = 24;
            this.dgvPosetioci.Size = new System.Drawing.Size(720, 225);
            this.dgvPosetioci.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(64, 287);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(192, 40);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Prijavi posetioca na paket";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(613, 287);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(192, 40);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikazi prijave";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // gb1
            // 
            this.gb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb1.Controls.Add(this.dgvPosetioci);
            this.gb1.Location = new System.Drawing.Point(64, 15);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(773, 266);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "Posetioci";
            // 
            // gb2
            // 
            this.gb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb2.Controls.Add(this.dgvPaketi);
            this.gb2.Location = new System.Drawing.Point(64, 333);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(773, 270);
            this.gb2.TabIndex = 5;
            this.gb2.TabStop = false;
            this.gb2.Text = "Paketi";
            // 
            // txtBrojOsoba
            // 
            this.txtBrojOsoba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojOsoba.Location = new System.Drawing.Point(392, 298);
            this.txtBrojOsoba.Name = "txtBrojOsoba";
            this.txtBrojOsoba.Size = new System.Drawing.Size(100, 22);
            this.txtBrojOsoba.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(401, 278);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 17);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Broj osoba";
            // 
            // UCPosetioci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBrojOsoba);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnDodaj);
            this.Name = "UCPosetioci";
            this.Size = new System.Drawing.Size(921, 639);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosetioci)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaketi;
        private System.Windows.Forms.DataGridView dgvPosetioci;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private TextBox txtBrojOsoba;
        private Label lbl1;

        public DataGridView DgvPaketi { get => dgvPaketi; set => dgvPaketi = value; }
        public DataGridView DgvPosetioci { get => dgvPosetioci; set => dgvPosetioci = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public Button BtnPrikazi { get => btnPrikazi; set => btnPrikazi = value; }
        public GroupBox Gb1 { get => gb1; set => gb1 = value; }
        public GroupBox Gb2 { get => gb2; set => gb2 = value; }
        public TextBox TxtBrojOsoba { get => txtBrojOsoba; set => txtBrojOsoba = value; }
        public Label Lbl1 { get => lbl1; set => lbl1 = value; }
    }
}
