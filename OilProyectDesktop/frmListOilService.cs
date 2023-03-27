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
    public partial class frmListOilService : MaterialForm
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        //Create Material Skin Forms options
        public frmListOilService()
        {
            InitializeComponent();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.BlueGrey900, Primary.Red900, Accent.Red700, TextShade.WHITE);
        }

        //Void methods
        //#####################################################################//

        void GetData()
        {
            //Fill dgvCustomers Datatable with Customer Table
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            con.Open();

            cmd = new SqlCommand("spListOilService", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCustomers.DataSource = dt;

            //Row counts from Customer Table by SQL Transaction
            lblRowCounts.Text = (dgvCustomers.Rows.Count - 1).ToString() + " Records Found";

            con.Close();
        }

        void SearchData()
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            con.Open();

            //Create filter with cbxSearchBy combobox and data from Customer table
            cmd = new SqlCommand("spSearchOilService", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prmSearchBy", cbxSearchBy.Text);
            cmd.Parameters.AddWithValue("@prmValue", txtSearch.Text);
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCustomers.DataSource = dt;

            //Row counts from Customer Table by SQL Transaction
            lblRowCounts.Text = (dgvCustomers.Rows.Count - 1).ToString() + " Records Found";

            con.Close();
        }

        //#####################################################################//

        private void frmListOilService_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOilServiceReport frmOilServiceReport = new frmOilServiceReport();
            frmOilServiceReport.Show();
        }
    }
}
