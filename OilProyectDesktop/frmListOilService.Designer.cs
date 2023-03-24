
namespace OilProyectDesktop
{
    partial class frmListOilService
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
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblRowCounts = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(1004, 110);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(88, 36);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblRowCounts
            // 
            this.lblRowCounts.AutoSize = true;
            this.lblRowCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowCounts.Location = new System.Drawing.Point(12, 166);
            this.lblRowCounts.Name = "lblRowCounts";
            this.lblRowCounts.Size = new System.Drawing.Size(0, 29);
            this.lblRowCounts.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(551, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(395, 30);
            this.txtSearch.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search By:";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "Plate",
            "Name",
            "Phone",
            "Grade",
            "Miles",
            "Oil Type"});
            this.cbxSearchBy.Location = new System.Drawing.Point(206, 110);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(296, 33);
            this.cbxSearchBy.TabIndex = 10;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 198);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1147, 374);
            this.dgvCustomers.TabIndex = 9;
            // 
            // frmListOilService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 584);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblRowCounts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSearchBy);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "frmListOilService";
            this.Text = "Oil Service List";
            this.Load += new System.EventHandler(this.frmListOilService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private System.Windows.Forms.Label lblRowCounts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}