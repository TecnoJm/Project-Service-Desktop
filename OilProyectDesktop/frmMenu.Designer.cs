
namespace OilProyectDesktop
{
    partial class frmMenu
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
            this.btnListOilServices = new System.Windows.Forms.Button();
            this.btnOilService = new System.Windows.Forms.Button();
            this.pnlMainFrame = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReportCustomer = new System.Windows.Forms.Button();
            this.btnReportOilService = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.pnlMainFrame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListOilServices
            // 
            this.btnListOilServices.Location = new System.Drawing.Point(48, 241);
            this.btnListOilServices.Name = "btnListOilServices";
            this.btnListOilServices.Size = new System.Drawing.Size(204, 89);
            this.btnListOilServices.TabIndex = 2;
            this.btnListOilServices.Text = "List Oil Services";
            this.btnListOilServices.UseVisualStyleBackColor = true;
            this.btnListOilServices.Click += new System.EventHandler(this.btnListOilServices_Click);
            // 
            // btnOilService
            // 
            this.btnOilService.Location = new System.Drawing.Point(48, 91);
            this.btnOilService.Name = "btnOilService";
            this.btnOilService.Size = new System.Drawing.Size(204, 89);
            this.btnOilService.TabIndex = 0;
            this.btnOilService.Text = "Oil Services";
            this.btnOilService.UseVisualStyleBackColor = true;
            this.btnOilService.Click += new System.EventHandler(this.btnOilService_Click);
            // 
            // pnlMainFrame
            // 
            this.pnlMainFrame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMainFrame.Controls.Add(this.panel2);
            this.pnlMainFrame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMainFrame.Location = new System.Drawing.Point(0, 80);
            this.pnlMainFrame.Name = "pnlMainFrame";
            this.pnlMainFrame.Size = new System.Drawing.Size(1942, 993);
            this.pnlMainFrame.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.btnReportCustomer);
            this.panel2.Controls.Add(this.btnReportOilService);
            this.panel2.Controls.Add(this.btnOilService);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnListOilServices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 993);
            this.panel2.TabIndex = 0;
            // 
            // btnReportCustomer
            // 
            this.btnReportCustomer.Location = new System.Drawing.Point(48, 808);
            this.btnReportCustomer.Name = "btnReportCustomer";
            this.btnReportCustomer.Size = new System.Drawing.Size(204, 89);
            this.btnReportCustomer.TabIndex = 4;
            this.btnReportCustomer.Text = "Report Customers";
            this.btnReportCustomer.UseVisualStyleBackColor = true;
            this.btnReportCustomer.Click += new System.EventHandler(this.btnReportCustomer_Click);
            // 
            // btnReportOilService
            // 
            this.btnReportOilService.Location = new System.Drawing.Point(48, 438);
            this.btnReportOilService.Name = "btnReportOilService";
            this.btnReportOilService.Size = new System.Drawing.Size(204, 89);
            this.btnReportOilService.TabIndex = 3;
            this.btnReportOilService.Text = "Report Oil Services";
            this.btnReportOilService.UseVisualStyleBackColor = true;
            this.btnReportOilService.Click += new System.EventHandler(this.btnReportOilService_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(48, 621);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(204, 89);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1942, 1073);
            this.Controls.Add(this.pnlMainFrame);
            this.Name = "frmMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMainFrame.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListOilServices;
        private System.Windows.Forms.Button btnOilService;
        private System.Windows.Forms.Panel pnlMainFrame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReportCustomer;
        private System.Windows.Forms.Button btnReportOilService;
        private System.Windows.Forms.Button btnCustomers;
    }
}