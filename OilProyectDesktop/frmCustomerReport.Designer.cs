﻿
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
            this.SuspendLayout();
            // 
            // crvCustomer
            // 
            this.crvCustomer.ActiveViewIndex = -1;
            this.crvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvCustomer.Location = new System.Drawing.Point(0, 67);
            this.crvCustomer.Name = "crvCustomer";
            this.crvCustomer.Size = new System.Drawing.Size(1282, 640);
            this.crvCustomer.TabIndex = 0;
            // 
            // frmCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 707);
            this.Controls.Add(this.crvCustomer);
            this.Location = new System.Drawing.Point(370, 80);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerReport";
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.frmCustomerReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCustomer;
    }
}