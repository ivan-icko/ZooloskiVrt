
using System.Windows.Forms;

namespace ZooloskiVrt.Klijent.Forme.UserControls.Posetioci
{
    partial class UCPrikaziPrijave
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
            this.dgvPrijave = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrijave
            // 
            this.dgvPrijave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrijave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijave.Location = new System.Drawing.Point(48, 97);
            this.dgvPrijave.Name = "dgvPrijave";
            this.dgvPrijave.RowHeadersWidth = 51;
            this.dgvPrijave.RowTemplate.Height = 24;
            this.dgvPrijave.Size = new System.Drawing.Size(719, 385);
            this.dgvPrijave.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(62, 65);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(150, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Sve prijave:";
            // 
            // UCPrikaziPrijave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvPrijave);
            this.Name = "UCPrikaziPrijave";
            this.Size = new System.Drawing.Size(832, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrijave;
        private System.Windows.Forms.Label lbl1;

        public DataGridView DgvPrijave { get => dgvPrijave; set => dgvPrijave = value; }
        public Label Lbl1 { get => lbl1; set => lbl1 = value; }
    }
}
