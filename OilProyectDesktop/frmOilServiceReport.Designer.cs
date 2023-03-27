
namespace OilProyectDesktop
{
    partial class frmOilServiceReport
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
            this.crvOilService = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvOilService
            // 
            this.crvOilService.ActiveViewIndex = -1;
            this.crvOilService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOilService.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOilService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvOilService.Location = new System.Drawing.Point(0, 0);
            this.crvOilService.Name = "crvOilService";
            this.crvOilService.Size = new System.Drawing.Size(1282, 707);
            this.crvOilService.TabIndex = 0;
            // 
            // frmOilServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 707);
            this.Controls.Add(this.crvOilService);
            this.Name = "frmOilServiceReport";
            this.Text = "frmOilServiceReport";
            this.Load += new System.EventHandler(this.frmOilServiceReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOilService;
    }
}