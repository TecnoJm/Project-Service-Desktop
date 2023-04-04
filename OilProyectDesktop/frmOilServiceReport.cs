using System;
using MaterialSkin;
using MaterialSkin.Controls;
using OilProyectDesktop.Reports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilProyectDesktop
{
    public partial class frmOilServiceReport : MaterialForm
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        public frmOilServiceReport()
        {
            InitializeComponent();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.BlueGrey900, Primary.Red900, Accent.Red700, TextShade.WHITE);
        }

        //Void Events
        //#####################################################################//

        void Options()
        {
            btnApply.Visible = true;

            try
            {
                if (cbxOptions.SelectedIndex == 0) //Plate
                {
                    //Make visible only the neccesary objects
                    lblCarPlate.Visible = true;
                    txtCarPlate.Visible = true;

                    //Make invisible inneccesary objects
                    lblFrom.Visible = false;
                    lblTo.Visible = false;
                    dtpFrom.Visible = false;
                    dtpTo.Visible = false;
                }

                if (cbxOptions.SelectedIndex == 1) //Date
                {
                    //Make visible only the neccesary objects
                    lblFrom.Visible = true;
                    lblTo.Visible = true;
                    dtpFrom.Visible = true;
                    dtpTo.Visible = true;

                    //Make invisible inneccesary objects
                    lblCarPlate.Visible = false;
                    txtCarPlate.Visible = false;
                }

                if (cbxOptions.SelectedIndex == 2) //ASC/DSC
                {
                    //Make invisible inneccesary objects
                    lblFrom.Visible = false;
                    lblTo.Visible = false;
                    dtpFrom.Visible = false;
                    dtpTo.Visible = false;
                    lblCarPlate.Visible = false;
                    txtCarPlate.Visible = false;
                }

                if (cbxOptions.SelectedIndex == 3) //DSC/ASC
                {
                    //Make invisible inneccesary objects
                    lblFrom.Visible = false;
                    lblTo.Visible = false;
                    dtpFrom.Visible = false;
                    dtpTo.Visible = false;
                    lblCarPlate.Visible = false;
                    txtCarPlate.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }

        void ApplyFilter()
        {
            try
            {
                if (cbxOptions.SelectedIndex == 0) //Plate
                {
                    //Fitler OilService Table with data from txtCarPlate

                    //Search OilService from OilService table.
                    SqlConnection con = new SqlConnection(connStr);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd;
                    DataSet ds = new DataSet();

                    con.Open();

                    cmd = new SqlCommand("spSearchCustomerOilServiceReport", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prmValue", txtCarPlate.Text);
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    //Fill Customer Report with Dataset
                    rptOilService oilserviceReport = new rptOilService();
                    oilserviceReport.SetDataSource(ds.Tables[0]);
                    crvOilService.ReportSource = oilserviceReport;
                    con.Close();

                }

                if (cbxOptions.SelectedIndex == 1) //Date
                {
                    //Fitler OilService Table with data between Dates

                    //Search OilService from OilService table.
                    SqlConnection con = new SqlConnection(connStr);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd;
                    DataSet ds = new DataSet();

                    con.Open();

                    cmd = new SqlCommand("spSearchCustomerOilServiceReportByDate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@prmFrom", dtpFrom.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@prmTo", dtpTo.Value.ToString("yyyy-MM-dd"));
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    //Fill Customer Report with Dataset
                    rptOilService oilserviceReport = new rptOilService();
                    oilserviceReport.SetDataSource(ds.Tables[0]);
                    crvOilService.ReportSource = oilserviceReport;
                    con.Close();
                }

                if(cbxOptions.SelectedIndex == 2) //ASC/DSC
                {
                    //Fitler OilService Table ASC

                    //Search OilService from OilService table.
                    SqlConnection con = new SqlConnection(connStr);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd;
                    DataSet ds = new DataSet();

                    con.Open();

                    cmd = new SqlCommand("spSearchCustomerOilServiceReportASC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    //Fill Customer Report with Dataset
                    rptOilService oilserviceReport = new rptOilService();
                    oilserviceReport.SetDataSource(ds.Tables[0]);
                    crvOilService.ReportSource = oilserviceReport;
                    con.Close();
                }

                if (cbxOptions.SelectedIndex == 3) //DSC/ASC
                {
                    //Fitler OilService Table ASC

                    //Search OilService from OilService table.
                    SqlConnection con = new SqlConnection(connStr);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd;
                    DataSet ds = new DataSet();

                    con.Open();

                    cmd = new SqlCommand("spSearchCustomerOilServiceReportDESC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    //Fill Customer Report with Dataset
                    rptOilService oilserviceReport = new rptOilService();
                    oilserviceReport.SetDataSource(ds.Tables[0]);
                    crvOilService.ReportSource = oilserviceReport;
                    con.Close();
                }

            }
            catch (Exception)
            {

            }
        }

        //#####################################################################//

        private void frmOilServiceReport_Load(object sender, EventArgs e)
        {

        }

        private void cbxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Options();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
