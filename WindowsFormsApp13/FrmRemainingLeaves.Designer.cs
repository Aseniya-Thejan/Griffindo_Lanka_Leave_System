namespace WindowsFormsApp13
{
    partial class FrmRemainingLeaves
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvBalances = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBalances
            // 
            this.dgvBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalances.Location = new System.Drawing.Point(20, 70);
            this.dgvBalances.Name = "dgvBalances";
            this.dgvBalances.Size = new System.Drawing.Size(660, 300);
            this.dgvBalances.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(200, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remaining Leave Balances";
            // 
            // FrmRemainingLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBalances);
            this.Name = "FrmRemainingLeaves";
            this.Text = "Remaining Leaves - Griffindo Lanka Toys";
            this.Load += new System.EventHandler(this.FrmRemainingLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBalances;
        private System.Windows.Forms.Label label1;
    }
}
