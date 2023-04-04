
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOptions = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnApply = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.txtCarPlate = new System.Windows.Forms.TextBox();
            this.lblCarPlate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crvOilService
            // 
            this.crvOilService.ActiveViewIndex = -1;
            this.crvOilService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOilService.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOilService.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvOilService.Location = new System.Drawing.Point(0, 201);
            this.crvOilService.Name = "crvOilService";
            this.crvOilService.Size = new System.Drawing.Size(1387, 729);
            this.crvOilService.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter:";
            // 
            // cbxOptions
            // 
            this.cbxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOptions.FormattingEnabled = true;
            this.cbxOptions.Items.AddRange(new object[] {
            "Plate",
            "Date",
            "Order By: older",
            "Order By: newest"});
            this.cbxOptions.Location = new System.Drawing.Point(177, 100);
            this.cbxOptions.Name = "cbxOptions";
            this.cbxOptions.Size = new System.Drawing.Size(218, 33);
            this.cbxOptions.TabIndex = 25;
            this.cbxOptions.SelectedIndexChanged += new System.EventHandler(this.cbxOptions_SelectedIndexChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(435, 103);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(72, 29);
            this.lblFrom.TabIndex = 28;
            this.lblFrom.Text = "From";
            this.lblFrom.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(831, 103);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(42, 29);
            this.lblTo.TabIndex = 29;
            this.lblTo.Text = "To";
            this.lblTo.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Depth = 0;
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(1234, 99);
            this.btnApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApply.Name = "btnApply";
            this.btnApply.Primary = true;
            this.btnApply.Size = new System.Drawing.Size(75, 36);
            this.btnApply.TabIndex = 30;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(527, 103);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(277, 30);
            this.dtpFrom.TabIndex = 31;
            this.dtpFrom.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(896, 103);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(277, 30);
            this.dtpTo.TabIndex = 32;
            this.dtpTo.Visible = false;
            // 
            // txtCarPlate
            // 
            this.txtCarPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarPlate.Location = new System.Drawing.Point(665, 103);
            this.txtCarPlate.Name = "txtCarPlate";
            this.txtCarPlate.Size = new System.Drawing.Size(391, 30);
            this.txtCarPlate.TabIndex = 33;
            this.txtCarPlate.Visible = false;
            // 
            // lblCarPlate
            // 
            this.lblCarPlate.AutoSize = true;
            this.lblCarPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarPlate.Location = new System.Drawing.Point(499, 103);
            this.lblCarPlate.Name = "lblCarPlate";
            this.lblCarPlate.Size = new System.Drawing.Size(125, 29);
            this.lblCarPlate.TabIndex = 34;
            this.lblCarPlate.Text = "Car Plate:";
            this.lblCarPlate.Visible = false;
            // 
            // frmOilServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 930);
            this.Controls.Add(this.lblCarPlate);
            this.Controls.Add(this.txtCarPlate);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cbxOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crvOilService);
            this.Location = new System.Drawing.Point(370, 80);
            this.MaximizeBox = false;
            this.Name = "frmOilServiceReport";
            this.Text = "Oil Service Report";
            this.Load += new System.EventHandler(this.frmOilServiceReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOilService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOptions;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private MaterialSkin.Controls.MaterialRaisedButton btnApply;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.TextBox txtCarPlate;
        private System.Windows.Forms.Label lblCarPlate;
    }
}