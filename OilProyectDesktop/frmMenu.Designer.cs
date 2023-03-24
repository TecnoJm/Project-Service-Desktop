
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListCustomers = new System.Windows.Forms.Button();
            this.btnListOilServices = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnOilService = new System.Windows.Forms.Button();
            this.pnlMainFrame = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnListCustomers);
            this.panel1.Controls.Add(this.btnListOilServices);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnOilService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 956);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1823, 122);
            this.panel1.TabIndex = 0;
            // 
            // btnListCustomers
            // 
            this.btnListCustomers.Location = new System.Drawing.Point(1498, 18);
            this.btnListCustomers.Name = "btnListCustomers";
            this.btnListCustomers.Size = new System.Drawing.Size(204, 89);
            this.btnListCustomers.TabIndex = 3;
            this.btnListCustomers.Text = "List Costumers";
            this.btnListCustomers.UseVisualStyleBackColor = true;
            // 
            // btnListOilServices
            // 
            this.btnListOilServices.Location = new System.Drawing.Point(562, 18);
            this.btnListOilServices.Name = "btnListOilServices";
            this.btnListOilServices.Size = new System.Drawing.Size(204, 89);
            this.btnListOilServices.TabIndex = 2;
            this.btnListOilServices.Text = "List Oil Services";
            this.btnListOilServices.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(1054, 18);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(204, 89);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnOilService
            // 
            this.btnOilService.Location = new System.Drawing.Point(101, 21);
            this.btnOilService.Name = "btnOilService";
            this.btnOilService.Size = new System.Drawing.Size(204, 89);
            this.btnOilService.TabIndex = 0;
            this.btnOilService.Text = "Oil Services";
            this.btnOilService.UseVisualStyleBackColor = true;
            this.btnOilService.Click += new System.EventHandler(this.btnOilService_Click);
            // 
            // pnlMainFrame
            // 
            this.pnlMainFrame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMainFrame.Location = new System.Drawing.Point(0, 64);
            this.pnlMainFrame.Name = "pnlMainFrame";
            this.pnlMainFrame.Size = new System.Drawing.Size(1823, 892);
            this.pnlMainFrame.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1823, 1078);
            this.Controls.Add(this.pnlMainFrame);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListCustomers;
        private System.Windows.Forms.Button btnListOilServices;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnOilService;
        private System.Windows.Forms.Panel pnlMainFrame;
    }
}