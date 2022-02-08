
using System.Windows.Forms;

namespace ZooloskiVrt.Klijent.Forme.UserControls.Paketi
{
    partial class UCPaketi
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.txtDatumDo = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOcistiPretragu = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtNazivPaketa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPretrazi = new System.Windows.Forms.DataGridView();
            this.dgvZivotinjeUPaketu = new System.Windows.Forms.DataGridView();
            this.btnObrisiZivotinju = new System.Windows.Forms.Button();
            this.btnDodajZivotinju = new System.Windows.Forms.Button();
            this.gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretrazi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinjeUPaketu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(1106, 267);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(129, 48);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.Location = new System.Drawing.Point(405, 267);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(140, 48);
            this.btnPrikazi.TabIndex = 20;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziSve.Location = new System.Drawing.Point(753, 267);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(141, 48);
            this.btnPrikaziSve.TabIndex = 21;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPretraga.Controls.Add(this.txtDatumDo);
            this.gbPretraga.Controls.Add(this.txtCena);
            this.gbPretraga.Controls.Add(this.label6);
            this.gbPretraga.Controls.Add(this.btnOcistiPretragu);
            this.gbPretraga.Controls.Add(this.btnAzuriraj);
            this.gbPretraga.Controls.Add(this.btnDodaj);
            this.gbPretraga.Controls.Add(this.btnPretrazi);
            this.gbPretraga.Controls.Add(this.txtNazivPaketa);
            this.gbPretraga.Controls.Add(this.label1);
            this.gbPretraga.Controls.Add(this.label2);
            this.gbPretraga.Location = new System.Drawing.Point(7, 53);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(392, 364);
            this.gbPretraga.TabIndex = 19;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Paket";
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumDo.Location = new System.Drawing.Point(152, 125);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.Size = new System.Drawing.Size(121, 22);
            this.txtDatumDo.TabIndex = 20;
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.Location = new System.Drawing.Point(152, 82);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(121, 22);
            this.txtCena.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cena:";
            // 
            // btnOcistiPretragu
            // 
            this.btnOcistiPretragu.Location = new System.Drawing.Point(34, 196);
            this.btnOcistiPretragu.Name = "btnOcistiPretragu";
            this.btnOcistiPretragu.Size = new System.Drawing.Size(321, 28);
            this.btnOcistiPretragu.TabIndex = 17;
            this.btnOcistiPretragu.Text = "Ocisti pretragu";
            this.btnOcistiPretragu.UseVisualStyleBackColor = true;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAzuriraj.Location = new System.Drawing.Point(255, 258);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(103, 71);
            this.btnAzuriraj.TabIndex = 15;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(146, 259);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 70);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Location = new System.Drawing.Point(37, 261);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(103, 68);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // txtNazivPaketa
            // 
            this.txtNazivPaketa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNazivPaketa.Location = new System.Drawing.Point(152, 42);
            this.txtNazivPaketa.Name = "txtNazivPaketa";
            this.txtNazivPaketa.Size = new System.Drawing.Size(121, 22);
            this.txtNazivPaketa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv paketa:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum do:";
            // 
            // dgvPretrazi
            // 
            this.dgvPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPretrazi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretrazi.Location = new System.Drawing.Point(405, 39);
            this.dgvPretrazi.Name = "dgvPretrazi";
            this.dgvPretrazi.RowHeadersWidth = 51;
            this.dgvPretrazi.Size = new System.Drawing.Size(489, 208);
            this.dgvPretrazi.TabIndex = 18;
            // 
            // dgvZivotinjeUPaketu
            // 
            this.dgvZivotinjeUPaketu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvZivotinjeUPaketu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZivotinjeUPaketu.Location = new System.Drawing.Point(405, 376);
            this.dgvZivotinjeUPaketu.Name = "dgvZivotinjeUPaketu";
            this.dgvZivotinjeUPaketu.RowHeadersWidth = 51;
            this.dgvZivotinjeUPaketu.Size = new System.Drawing.Size(830, 204);
            this.dgvZivotinjeUPaketu.TabIndex = 23;
            // 
            // btnObrisiZivotinju
            // 
            this.btnObrisiZivotinju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiZivotinju.Location = new System.Drawing.Point(405, 596);
            this.btnObrisiZivotinju.Name = "btnObrisiZivotinju";
            this.btnObrisiZivotinju.Size = new System.Drawing.Size(140, 47);
            this.btnObrisiZivotinju.TabIndex = 21;
            this.btnObrisiZivotinju.Text = "Obrisi zivotinju";
            this.btnObrisiZivotinju.UseVisualStyleBackColor = true;
            // 
            // btnDodajZivotinju
            // 
            this.btnDodajZivotinju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajZivotinju.Location = new System.Drawing.Point(1106, 596);
            this.btnDodajZivotinju.Name = "btnDodajZivotinju";
            this.btnDodajZivotinju.Size = new System.Drawing.Size(129, 47);
            this.btnDodajZivotinju.TabIndex = 24;
            this.btnDodajZivotinju.Text = "Dodaj zivotinju";
            this.btnDodajZivotinju.UseVisualStyleBackColor = true;
            // 
            // UCPaketi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajZivotinju);
            this.Controls.Add(this.btnObrisiZivotinju);
            this.Controls.Add(this.dgvZivotinjeUPaketu);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.dgvPretrazi);
            this.Name = "UCPaketi";
            this.Size = new System.Drawing.Size(1243, 683);
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretrazi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinjeUPaketu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOcistiPretragu;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtNazivPaketa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPretrazi;
        private System.Windows.Forms.TextBox txtDatumDo;
        private System.Windows.Forms.DataGridView dgvZivotinjeUPaketu;
        private Button btnObrisiZivotinju;
        private Button btnDodajZivotinju;

        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Button BtnPrikazi { get => btnPrikazi; set => btnPrikazi = value; }
        public Button BtnPrikaziSve { get => btnPrikaziSve; set => btnPrikaziSve = value; }
        public GroupBox GbPretraga { get => gbPretraga; set => gbPretraga = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Button BtnOcistiPretragu { get => btnOcistiPretragu; set => btnOcistiPretragu = value; }
        public Button BtnAzuriraj { get => btnAzuriraj; set => btnAzuriraj = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public TextBox TxtNazivPaketa { get => txtNazivPaketa; set => txtNazivPaketa = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public DataGridView DgvPretrazi { get => dgvPretrazi; set => dgvPretrazi = value; }
        public TextBox TxtDatumDo { get => txtDatumDo; set => txtDatumDo = value; }
        public DataGridView DataGridView1 { get => dgvZivotinjeUPaketu; set => dgvZivotinjeUPaketu = value; }
        public DataGridView DgvZivotinjeUPaketu { get => dgvZivotinjeUPaketu; set => dgvZivotinjeUPaketu = value; }
        public Button BtnObrisiZivotinju { get => btnObrisiZivotinju; set => btnObrisiZivotinju = value; }
        public Button BtnDodajZivotinju { get => btnDodajZivotinju; set => btnDodajZivotinju = value; }
    }
}
