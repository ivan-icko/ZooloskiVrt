
using System.Windows.Forms;

namespace ZooloskiVrt.Klijent.Forme.UserControls.Zivotinje
{
    partial class UCZivotinje
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
            this.dgvPretrazi = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStarost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaniste = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.cmbTipIshrane = new System.Windows.Forms.ComboBox();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.txtOznakaJedinke = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOcistiPretragu = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretrazi)).BeginInit();
            this.gbPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPretrazi
            // 
            this.dgvPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPretrazi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretrazi.Location = new System.Drawing.Point(480, 33);
            this.dgvPretrazi.Name = "dgvPretrazi";
            this.dgvPretrazi.RowHeadersWidth = 51;
            this.dgvPretrazi.Size = new System.Drawing.Size(830, 394);
            this.dgvPretrazi.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Location = new System.Drawing.Point(29, 371);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(103, 68);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVrsta.Location = new System.Drawing.Point(138, 43);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(121, 22);
            this.txtVrsta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vrsta:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pol:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Starost(dani):";
            // 
            // txtStarost
            // 
            this.txtStarost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStarost.Location = new System.Drawing.Point(138, 177);
            this.txtStarost.Name = "txtStarost";
            this.txtStarost.Size = new System.Drawing.Size(121, 22);
            this.txtStarost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Staniste:";
            // 
            // txtStaniste
            // 
            this.txtStaniste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaniste.Location = new System.Drawing.Point(138, 224);
            this.txtStaniste.Name = "txtStaniste";
            this.txtStaniste.Size = new System.Drawing.Size(121, 22);
            this.txtStaniste.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tip ishrane:";
            // 
            // cmbPol
            // 
            this.cmbPol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Location = new System.Drawing.Point(138, 126);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(121, 24);
            this.cmbPol.TabIndex = 11;
            // 
            // cmbTipIshrane
            // 
            this.cmbTipIshrane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipIshrane.FormattingEnabled = true;
            this.cmbTipIshrane.Location = new System.Drawing.Point(138, 266);
            this.cmbTipIshrane.Name = "cmbTipIshrane";
            this.cmbTipIshrane.Size = new System.Drawing.Size(121, 24);
            this.cmbTipIshrane.TabIndex = 12;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPretraga.Controls.Add(this.txtOznakaJedinke);
            this.gbPretraga.Controls.Add(this.label6);
            this.gbPretraga.Controls.Add(this.btnOcistiPretragu);
            this.gbPretraga.Controls.Add(this.txtId);
            this.gbPretraga.Controls.Add(this.btnAzuriraj);
            this.gbPretraga.Controls.Add(this.btnDodaj);
            this.gbPretraga.Controls.Add(this.btnPretrazi);
            this.gbPretraga.Controls.Add(this.cmbTipIshrane);
            this.gbPretraga.Controls.Add(this.txtVrsta);
            this.gbPretraga.Controls.Add(this.cmbPol);
            this.gbPretraga.Controls.Add(this.label1);
            this.gbPretraga.Controls.Add(this.label5);
            this.gbPretraga.Controls.Add(this.label2);
            this.gbPretraga.Controls.Add(this.label4);
            this.gbPretraga.Controls.Add(this.txtStarost);
            this.gbPretraga.Controls.Add(this.txtStaniste);
            this.gbPretraga.Controls.Add(this.label3);
            this.gbPretraga.Location = new System.Drawing.Point(82, 33);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(392, 478);
            this.gbPretraga.TabIndex = 13;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Zivotinja";
            // 
            // txtOznakaJedinke
            // 
            this.txtOznakaJedinke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOznakaJedinke.Location = new System.Drawing.Point(138, 83);
            this.txtOznakaJedinke.Name = "txtOznakaJedinke";
            this.txtOznakaJedinke.Size = new System.Drawing.Size(121, 22);
            this.txtOznakaJedinke.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Oznaka jedinke:";
            // 
            // btnOcistiPretragu
            // 
            this.btnOcistiPretragu.Location = new System.Drawing.Point(29, 315);
            this.btnOcistiPretragu.Name = "btnOcistiPretragu";
            this.btnOcistiPretragu.Size = new System.Drawing.Size(321, 28);
            this.btnOcistiPretragu.TabIndex = 17;
            this.btnOcistiPretragu.Text = "Ocisti pretragu";
            this.btnOcistiPretragu.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(292, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 22);
            this.txtId.TabIndex = 16;
            this.txtId.Visible = false;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAzuriraj.Location = new System.Drawing.Point(247, 368);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(103, 71);
            this.btnAzuriraj.TabIndex = 15;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(138, 369);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 70);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(480, 463);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(140, 48);
            this.btnPrikazi.TabIndex = 15;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziSve.Location = new System.Drawing.Point(840, 463);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(141, 48);
            this.btnPrikaziSve.TabIndex = 16;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(1181, 463);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(129, 48);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // UCZivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.dgvPretrazi);
            this.Name = "UCZivotinje";
            this.Size = new System.Drawing.Size(1313, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretrazi)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPretrazi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtVrsta;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStarost;
        private Label label4;
        private TextBox txtStaniste;
        private Label label5;
        private ComboBox cmbPol;
        private ComboBox cmbTipIshrane;
        private GroupBox gbPretraga;
        private Button btnPrikazi;
        private Button btnDodaj;
        private Button btnPrikaziSve;
        private Button btnAzuriraj;
        private Button btnObrisi;
        private TextBox txtId;
        private Button btnOcistiPretragu;
        private TextBox txtOznakaJedinke;
        private Label label6;

        public DataGridView DgvPretrazi { get => dgvPretrazi; set => dgvPretrazi = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public TextBox TxtVrsta { get => txtVrsta; set => txtVrsta = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtStarost { get => txtStarost; set => txtStarost = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public TextBox TxtStaniste { get => txtStaniste; set => txtStaniste = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public ComboBox CmbPol { get => cmbPol; set => cmbPol = value; }
        public ComboBox CmbTipIshrane { get => cmbTipIshrane; set => cmbTipIshrane = value; }
        public GroupBox GbPretraga { get => gbPretraga; set => gbPretraga = value; }
        public Button BtnPrikazi { get => btnPrikazi; set => btnPrikazi = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public Button BtnPrikaziSve { get => btnPrikaziSve; set => btnPrikaziSve = value; }
        public Button BtnAzuriraj { get => btnAzuriraj; set => btnAzuriraj = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public TextBox TxtId { get => txtId; set => txtId = value; }
        public Button BtnOcistiPretragu { get => btnOcistiPretragu; set => btnOcistiPretragu = value; }
        public TextBox TxtOznakaJedinke { get => txtOznakaJedinke; set => txtOznakaJedinke = value; }
    }
}
