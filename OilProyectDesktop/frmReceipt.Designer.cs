
namespace OilProyectDesktop
{
    partial class frmReceipt
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
            this.crvReceipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReceipt
            // 
            this.crvReceipt.ActiveViewIndex = -1;
            this.crvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReceipt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvReceipt.Location = new System.Drawing.Point(0, 63);
            this.crvReceipt.Name = "crvReceipt";
            this.crvReceipt.Size = new System.Drawing.Size(1321, 728);
            this.crvReceipt.TabIndex = 0;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 791);
            this.Controls.Add(this.crvReceipt);
            this.MaximizeBox = false;
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReceipt;
    }
}