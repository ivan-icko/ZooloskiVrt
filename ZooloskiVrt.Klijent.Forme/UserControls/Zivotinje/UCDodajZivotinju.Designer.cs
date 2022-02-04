
using System.Windows.Forms;

namespace ZooloskiVrt.Klijent.Forme.UserControls.Zivotinje
{
    partial class UCDodajZivotinju
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.txtStarost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaniste = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipIshrane = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.dgvZivotinje = new System.Windows.Forms.DataGridView();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta";
            // 
            // txtVrsta
            // 
            this.txtVrsta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVrsta.Location = new System.Drawing.Point(198, 35);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(121, 22);
            this.txtVrsta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pol";
            // 
            // cmbPol
            // 
            this.cmbPol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Location = new System.Drawing.Point(198, 77);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(121, 24);
            this.cmbPol.TabIndex = 3;
            // 
            // txtStarost
            // 
            this.txtStarost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStarost.Location = new System.Drawing.Point(198, 137);
            this.txtStarost.Name = "txtStarost";
            this.txtStarost.Size = new System.Drawing.Size(121, 22);
            this.txtStarost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Starost (u danima)";
            // 
            // txtStaniste
            // 
            this.txtStaniste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaniste.Location = new System.Drawing.Point(198, 186);
            this.txtStaniste.Name = "txtStaniste";
            this.txtStaniste.Size = new System.Drawing.Size(121, 22);
            this.txtStaniste.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Staniste";
            // 
            // cmbTipIshrane
            // 
            this.cmbTipIshrane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipIshrane.FormattingEnabled = true;
            this.cmbTipIshrane.Location = new System.Drawing.Point(198, 238);
            this.cmbTipIshrane.Name = "cmbTipIshrane";
            this.cmbTipIshrane.Size = new System.Drawing.Size(121, 24);
            this.cmbTipIshrane.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "TipIshrane";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(63, 295);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(256, 45);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnDodaj);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.cmbTipIshrane);
            this.gb1.Controls.Add(this.txtVrsta);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.txtStaniste);
            this.gb1.Controls.Add(this.cmbPol);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.txtStarost);
            this.gb1.Location = new System.Drawing.Point(154, 215);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(386, 379);
            this.gb1.TabIndex = 11;
            this.gb1.TabStop = false;
            this.gb1.Text = "Dodavanje zivotinje";
            // 
            // dgvZivotinje
            // 
            this.dgvZivotinje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZivotinje.Location = new System.Drawing.Point(28, 44);
            this.dgvZivotinje.Name = "dgvZivotinje";
            this.dgvZivotinje.RowHeadersWidth = 51;
            this.dgvZivotinje.RowTemplate.Height = 24;
            this.dgvZivotinje.Size = new System.Drawing.Size(780, 150);
            this.dgvZivotinje.TabIndex = 12;
            // 
            // UCDodajZivotinju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvZivotinje);
            this.Controls.Add(this.gb1);
            this.Name = "UCDodajZivotinju";
            this.Size = new System.Drawing.Size(905, 656);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.TextBox txtStarost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaniste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipIshrane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodaj;
        private GroupBox gb1;
        private DataGridView dgvZivotinje;

        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtVrsta { get => txtVrsta; set => txtVrsta = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox CmbPol { get => cmbPol; set => cmbPol = value; }
        public TextBox TxtStarost { get => txtStarost; set => txtStarost = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtStaniste { get => txtStaniste; set => txtStaniste = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public ComboBox CmbTipIshrane { get => cmbTipIshrane; set => cmbTipIshrane = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public GroupBox Gb1 { get => gb1; set => gb1 = value; }
        public DataGridView DgvZivotinje { get => dgvZivotinje; set => dgvZivotinje = value; }
    }
}
