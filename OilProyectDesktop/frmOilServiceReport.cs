using System;
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
    public partial class frmOilServiceReport : Form
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        public frmOilServiceReport()
        {
            InitializeComponent();
        }

        private void frmOilServiceReport_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            DataSet ds = new DataSet();

            con.Open();

            cmd = new SqlCommand("spListOilService", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            //Fill Customer Report with Dataset
            rptOilService oilserviceReport = new rptOilService();
            oilserviceReport.SetDataSource(ds.Tables[0]);
            crvOilService.ReportSource = oilserviceReport;
            con.Close();
        }
    }
}
