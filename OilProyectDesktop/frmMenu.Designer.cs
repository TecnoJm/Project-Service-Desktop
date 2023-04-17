
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
            this.components = new System.ComponentModel.Container();
            this.btnListOilServices = new System.Windows.Forms.Button();
            this.btnOilService = new System.Windows.Forms.Button();
            this.pnlMainFrame = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChangeDate = new System.Windows.Forms.Label();
            this.btnReportCustomer = new System.Windows.Forms.Button();
            this.btnReportOilService = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.ntiChangeDate = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerChangeDate = new System.Windows.Forms.Timer(this.components);
            this.pnlFormMove = new System.Windows.Forms.Panel();
            this.btnMinimizeForm = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pnlMainFrame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFormMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListOilServices
            // 
            this.btnListOilServices.Location = new System.Drawing.Point(38, 293);
            this.btnListOilServices.Name = "btnListOilServices";
            this.btnListOilServices.Size = new System.Drawing.Size(204, 89);
            this.btnListOilServices.TabIndex = 2;
            this.btnListOilServices.Text = "List Oil Services";
            this.btnListOilServices.UseVisualStyleBackColor = true;
            this.btnListOilServices.Click += new System.EventHandler(this.btnListOilServices_Click);
            // 
            // btnOilService
            // 
            this.btnOilService.Location = new System.Drawing.Point(38, 150);
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
            this.pnlMainFrame.Location = new System.Drawing.Point(0, 40);
            this.pnlMainFrame.Name = "pnlMainFrame";
            this.pnlMainFrame.Size = new System.Drawing.Size(1924, 1015);
            this.pnlMainFrame.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.lblChangeDate);
            this.panel2.Controls.Add(this.btnReportCustomer);
            this.panel2.Controls.Add(this.btnReportOilService);
            this.panel2.Controls.Add(this.btnOilService);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnListOilServices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 1015);
            this.panel2.TabIndex = 0;
            // 
            // lblChangeDate
            // 
            this.lblChangeDate.AutoSize = true;
            this.lblChangeDate.Location = new System.Drawing.Point(3, 11);
            this.lblChangeDate.Name = "lblChangeDate";
            this.lblChangeDate.Size = new System.Drawing.Size(46, 17);
            this.lblChangeDate.TabIndex = 5;
            this.lblChangeDate.Text = "label1";
            this.lblChangeDate.Visible = false;
            // 
            // btnReportCustomer
            // 
            this.btnReportCustomer.Location = new System.Drawing.Point(38, 705);
            this.btnReportCustomer.Name = "btnReportCustomer";
            this.btnReportCustomer.Size = new System.Drawing.Size(204, 89);
            this.btnReportCustomer.TabIndex = 4;
            this.btnReportCustomer.Text = "Report Customers";
            this.btnReportCustomer.UseVisualStyleBackColor = true;
            this.btnReportCustomer.Click += new System.EventHandler(this.btnReportCustomer_Click);
            // 
            // btnReportOilService
            // 
            this.btnReportOilService.Location = new System.Drawing.Point(38, 439);
            this.btnReportOilService.Name = "btnReportOilService";
            this.btnReportOilService.Size = new System.Drawing.Size(204, 89);
            this.btnReportOilService.TabIndex = 3;
            this.btnReportOilService.Text = "Report Oil Services";
            this.btnReportOilService.UseVisualStyleBackColor = true;
            this.btnReportOilService.Click += new System.EventHandler(this.btnReportOilService_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(38, 569);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(204, 89);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // ntiChangeDate
            // 
            this.ntiChangeDate.Text = "notifyIcon1";
            this.ntiChangeDate.Visible = true;
            // 
            // timerChangeDate
            // 
            this.timerChangeDate.Interval = 5000;
            this.timerChangeDate.Tick += new System.EventHandler(this.timerChangeDate_Tick);
            // 
            // pnlFormMove
            // 
            this.pnlFormMove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFormMove.Controls.Add(this.btnMinimizeForm);
            this.pnlFormMove.Controls.Add(this.btnCloseForm);
            this.pnlFormMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormMove.Location = new System.Drawing.Point(0, 0);
            this.pnlFormMove.Name = "pnlFormMove";
            this.pnlFormMove.Size = new System.Drawing.Size(1924, 53);
            this.pnlFormMove.TabIndex = 2;
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeForm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimizeForm.Location = new System.Drawing.Point(1774, 0);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.Size = new System.Drawing.Size(75, 53);
            this.btnMinimizeForm.TabIndex = 1;
            this.btnMinimizeForm.Text = "__";
            this.btnMinimizeForm.UseVisualStyleBackColor = true;
            this.btnMinimizeForm.Click += new System.EventHandler(this.btnMinimizeForm_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCloseForm.Location = new System.Drawing.Point(1849, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 53);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlFormMove);
            this.Controls.Add(this.pnlMainFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMainFrame.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlFormMove.ResumeLayout(false);
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
        private System.Windows.Forms.NotifyIcon ntiChangeDate;
        private System.Windows.Forms.Label lblChangeDate;
        private System.Windows.Forms.Timer timerChangeDate;
        private System.Windows.Forms.Panel pnlFormMove;
        private System.Windows.Forms.Button btnMinimizeForm;
        private System.Windows.Forms.Button btnCloseForm;
    }
}