using System;
using OilProyectDesktop.Reports;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class frmCustomerReport : MaterialForm
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        public frmCustomerReport()
        {
            InitializeComponent();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.BlueGrey900, Primary.Red900, Accent.Red700, TextShade.WHITE);
        }

        //#####################################################################//

        void GetCustomerData()
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            DataSet ds = new DataSet();

            con.Open();

            cmd = new SqlCommand("spListCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            //Fill Customer Report with Dataset
            rptCustomer customerReport = new rptCustomer();
            customerReport.SetDataSource(ds.Tables[0]);
            crvCustomer.ReportSource = customerReport;
            con.Close();
        }

        void ApplyFilter()
        {
            try
            {
                if (cbxOptions.SelectedIndex == 0) //ASC/DSC
                {
                    //Fitler Customer Table ASC

                    //Search Customer from OilService table.
                    SqlConnection con = new SqlConnection(connStr);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd;
                    DataSet ds = new DataSet();

                    con.Open();

                    cmd = new SqlCommand("spListCustomerASC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    //Fill Customer Report with Dataset
                    rptCustomer customerReport = new rptCustomer();
                    customerReport.SetDataSource(ds.Tables[0]);
                    crvCustomer.ReportSource = customerReport;
                    con.Close();
                }

                if (cbxOptions.SelectedIndex == 1) //DESC/ASC
                {
                    //Fitler Customer Table DESC

                    //Search Customer from OilService table.
                    SqlConnection con = new SqlConnection(connStr);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd;
                    DataSet ds = new DataSet();

                    con.Open();

                    cmd = new SqlCommand("spListCustomerDESC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    //Fill Customer Report with Dataset
                    rptCustomer customerReport = new rptCustomer();
                    customerReport.SetDataSource(ds.Tables[0]);
                    crvCustomer.ReportSource = customerReport;
                    con.Close();
                }

            }
            catch (Exception)
            {

            }
        }

        //#####################################################################//

        private void frmCustomerReport_Load(object sender, EventArgs e)
        {
            GetCustomerData();
        }

        private void cbxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
