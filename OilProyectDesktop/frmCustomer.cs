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
    public partial class frmCustomer : MaterialForm
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        //Create Material Skin Forms options
        public frmCustomer()
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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            lblRowCounts.Text = "";

            //Fill dgvCustomers Datatable with Customer Table
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            SqlDataReader dr;
            DataTable dt = new DataTable();

            cmd = new SqlCommand("spListCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCustomers.DataSource = dt;

            //Row counts from Customer Table by SQL Transaction
            lblRowCounts.Text = (dgvCustomers.Rows.Count).ToString() +  " Records Found";

            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            con.Open();
            cmd = new SqlCommand("spSearchCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@prmSearchBy", cbxSearchBy.Text);
            cmd.Parameters.AddWithValue("@prmValue", txtSearch.Text);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCustomers.DataSource = dt;
            con.Close();
        }
    }
}
