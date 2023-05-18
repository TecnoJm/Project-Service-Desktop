
namespace OilProyectDesktop
{
    partial class frmServices
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCarPlate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMasterID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvServicesDetail = new System.Windows.Forms.DataGridView();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Customer Phone:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Enabled = false;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(587, 101);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(235, 28);
            this.txtCustomerPhone.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Car Plate:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(312, 102);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(238, 28);
            this.txtCustomerName.TabIndex = 14;
            // 
            // txtCarPlate
            // 
            this.txtCarPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarPlate.Location = new System.Drawing.Point(67, 103);
            this.txtCarPlate.Name = "txtCarPlate";
            this.txtCarPlate.Size = new System.Drawing.Size(201, 28);
            this.txtCarPlate.TabIndex = 13;
            this.txtCarPlate.TextChanged += new System.EventHandler(this.txtCarPlate_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMasterID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCarPlate);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 175);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Data:";
            // 
            // lblMasterID
            // 
            this.lblMasterID.AutoSize = true;
            this.lblMasterID.Location = new System.Drawing.Point(16, 142);
            this.lblMasterID.Name = "lblMasterID";
            this.lblMasterID.Size = new System.Drawing.Size(19, 20);
            this.lblMasterID.TabIndex = 19;
            this.lblMasterID.Text = "L";
            this.lblMasterID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.dgvServicesDetail);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxProducts);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 545);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services Data";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(96, 488);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(117, 36);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Clear grid";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(471, 98);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(128, 28);
            this.txtQuantity.TabIndex = 25;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(676, 489);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 29);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total:";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(20, 488);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(65, 36);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvServicesDetail
            // 
            this.dgvServicesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicesDetail.Location = new System.Drawing.Point(20, 149);
            this.dgvServicesDetail.Name = "dgvServicesDetail";
            this.dgvServicesDetail.ReadOnly = true;
            this.dgvServicesDetail.RowHeadersWidth = 51;
            this.dgvServicesDetail.RowTemplate.Height = 24;
            this.dgvServicesDetail.Size = new System.Drawing.Size(843, 303);
            this.dgvServicesDetail.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(807, 92);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(56, 36);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(647, 98);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(128, 28);
            this.txtCost.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product Reference:";
            // 
            // cbxProducts
            // 
            this.cbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(20, 98);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(384, 30);
            this.cbxProducts.TabIndex = 0;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(923, 97);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(347, 647);
            this.rtbNotes.TabIndex = 21;
            this.rtbNotes.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(918, 758);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Notes:";
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 849);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmServices";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.frmServices_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCarPlate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProducts;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.DataGridView dgvServicesDetail;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblMasterID;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
    }
}