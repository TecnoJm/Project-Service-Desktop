using System;
using OilProyectDesktop.Reports;
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
    public partial class frmReceipt : MaterialForm
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        public frmReceipt()
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

        void CreateReceipt()
        {
            try
            {
                //Example Invoice for Consumer Example
                SqlConnection con = new SqlConnection(connStr);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd;
                DataSet ds = new DataSet();

                con.Open();

                cmd = new SqlCommand("spCreateReceipt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);

                da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //Fill Bill with OilService data
                rptServicesReceipt servicesReceipt = new rptServicesReceipt();
                servicesReceipt.SetDataSource(ds.Tables[0]);
                crvReceipt.ReportSource = servicesReceipt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        //#####################################################################//

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            CreateReceipt();
        }
    }
}
