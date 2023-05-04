
namespace OilProyectDesktop
{
    partial class frmCustomerReport
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
            this.crvCustomer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbxOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // crvCustomer
            // 
            this.crvCustomer.ActiveViewIndex = -1;
            this.crvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvCustomer.Location = new System.Drawing.Point(0, 203);
            this.crvCustomer.Name = "crvCustomer";
            this.crvCustomer.Size = new System.Drawing.Size(1387, 727);
            this.crvCustomer.TabIndex = 0;
            // 
            // cbxOptions
            // 
            this.cbxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOptions.FormattingEnabled = true;
            this.cbxOptions.Items.AddRange(new object[] {
            "Order By: A-Z",
            "Order By: Z-A"});
            this.cbxOptions.Location = new System.Drawing.Point(174, 107);
            this.cbxOptions.Name = "cbxOptions";
            this.cbxOptions.Size = new System.Drawing.Size(218, 33);
            this.cbxOptions.TabIndex = 27;
            this.cbxOptions.SelectedIndexChanged += new System.EventHandler(this.cbxOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Filter:";
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Depth = 0;
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(413, 105);
            this.btnApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApply.Name = "btnApply";
            this.btnApply.Primary = true;
            this.btnApply.Size = new System.Drawing.Size(75, 36);
            this.btnApply.TabIndex = 31;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 930);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbxOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crvCustomer);
            this.Location = new System.Drawing.Point(370, 80);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerReport";
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.frmCustomerReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCustomer;
        private System.Windows.Forms.ComboBox cbxOptions;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnApply;
    }
}