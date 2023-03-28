using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OilProyectDesktop
{
    public partial class frmMenu : MaterialForm
    {
        //Create Material Skin Forms options
        public frmMenu()
        {
            InitializeComponent();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.BlueGrey900, Primary.Red900, Accent.Red700, TextShade.WHITE);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        //Form Buttons
        //#####################################################################//

        private void btnOilService_Click(object sender, EventArgs e)
        {
            frmOilService frmOilService = new frmOilService() { TopLevel = false, TopMost = true };
            this.pnlMainFrame.Controls.Add(frmOilService);
            frmOilService.Show();
        }

        private void btnListOilServices_Click(object sender, EventArgs e)
        {
            frmListOilService frmListOilService = new frmListOilService() { TopLevel = false, TopMost = true };
            this.pnlMainFrame.Controls.Add(frmListOilService);
            frmListOilService.Show();
        }

        private void btnReportOilService_Click(object sender, EventArgs e)
        {
            frmOilServiceReport frmOilServiceReport = new frmOilServiceReport() { TopLevel = false, TopMost = true };
            this.pnlMainFrame.Controls.Add(frmOilServiceReport);
            frmOilServiceReport.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer() { TopLevel = false, TopMost = true };
            this.pnlMainFrame.Controls.Add(frmCustomer);
            frmCustomer.Show();
        }

        private void btnReportCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerReport frmCustomerReport = new frmCustomerReport() { TopLevel = false, TopMost = true };
            this.pnlMainFrame.Controls.Add(frmCustomerReport);
            frmCustomerReport.Show();
        }
    }
}
