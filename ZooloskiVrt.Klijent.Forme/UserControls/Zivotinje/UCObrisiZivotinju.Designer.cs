
using System.Windows.Forms;

namespace ZooloskiVrt.Klijent.Forme.UserControls.Zivotinje
{
    partial class UCObrisiZivotinju
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
            this.dgvZivotinje = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZivotinje
            // 
            this.dgvZivotinje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZivotinje.Location = new System.Drawing.Point(17, 34);
            this.dgvZivotinje.Name = "dgvZivotinje";
            this.dgvZivotinje.RowHeadersWidth = 51;
            this.dgvZivotinje.RowTemplate.Height = 24;
            this.dgvZivotinje.Size = new System.Drawing.Size(584, 150);
            this.dgvZivotinje.TabIndex = 0;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(238, 266);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(144, 45);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // UCObrisiZivotinju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvZivotinje);
            this.Name = "UCObrisiZivotinju";
            this.Size = new System.Drawing.Size(634, 482);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZivotinje;
        private System.Windows.Forms.Button btnObrisi;

        public DataGridView DgvZivotinje { get => dgvZivotinje; set => dgvZivotinje = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
    }
}
