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
    public partial class frmMenu : Form
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        //Create Material Skin Forms options
        public frmMenu()
        {
            InitializeComponent();

            /*this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.BlueGrey900, Primary.Red900, Accent.Red700, TextShade.WHITE);*/
        }

        //Void methods
        //#####################################################################//

        void CalculateChangeDate()
        {

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd;
                DataSet ds = new DataSet();

                //Today's Date and 
                DateTime todayDate = DateTime.Now;
                TimeSpan tDifference;
                int timeDiffernce;

                con.Open();

                cmd = new SqlCommand("Select CustomerPlate, ChangeDate from dbo.OilService", con);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);

                //string s = "2001-05-01";

                //Read each CustomerPlate and ChangeDate rows from dbo.OilService
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if ((DateTime)dt.Rows[i][1] != todayDate)
                        {

                            tDifference = todayDate - (DateTime)dt.Rows[i][1];
                            timeDiffernce = tDifference.Days;

                            if(timeDiffernce <= 14)
                            {
                                ntiChangeDate.Icon = SystemIcons.Application;
                                ntiChangeDate.BalloonTipTitle = "Claudio AutoService Notification";
                                ntiChangeDate.BalloonTipText = "The Oil Change for the Plate: " + dt.Rows[i][0] + "\n to date: " + dt.Rows[i][1];
                                ntiChangeDate.ShowBalloonTip(1000);
                            }
                        }
                    }
                }

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //#####################################################################//

        private void frmMenu_Load(object sender, EventArgs e)
        {
            timerChangeDate.Start();
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

        private void timerChangeDate_Tick(object sender, EventArgs e)
        {
            CalculateChangeDate();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
