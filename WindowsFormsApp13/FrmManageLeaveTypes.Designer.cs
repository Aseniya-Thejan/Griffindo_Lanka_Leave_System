namespace WindowsFormsApp13
{
    partial class FrmManageLeaveTypes
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
            this.dgvLeaveTypes = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaveTypes
            // 
            this.dgvLeaveTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveTypes.Location = new System.Drawing.Point(30, 108);
            this.dgvLeaveTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLeaveTypes.Name = "dgvLeaveTypes";
            this.dgvLeaveTypes.RowHeadersWidth = 62;
            this.dgvLeaveTypes.Size = new System.Drawing.Size(990, 462);
            this.dgvLeaveTypes.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveChanges.Location = new System.Drawing.Point(395, 599);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(197, 54);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(345, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Leave Types";
            // 
            // FrmManageLeaveTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dgvLeaveTypes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManageLeaveTypes";
            this.Text = "Manage Leave Types - Griffindo Lanka Toys";
            this.Load += new System.EventHandler(this.FrmManageLeaveTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaveTypes;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label1;
    }
}
