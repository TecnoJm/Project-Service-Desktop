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
    public partial class frmServices : MaterialForm
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        public frmServices()
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

        void GetData()
        {
            //Fill dgvServicesDetail Datatable
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            con.Open();

            cmd = new SqlCommand("spCreateServicesDetailTemporal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvServicesDetail.DataSource = dt;

            con.Close();
        }

        void InsertDataServicesDetailTemporal()
        {
            try
            {
                //Insert data to Services table
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd;

                cmd = new SqlCommand("spRecordServicesDetailTemporal", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Parameters (Data from Text Box)
                //Change date format for SQL to recognize the information.
                cmd.Parameters.AddWithValue("@prmServicesDetailTemporal", 1);
                cmd.Parameters.AddWithValue("@prmDescription", cbxProducts.Text);
                cmd.Parameters.AddWithValue("@prmQuantity", Convert.ToInt32(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@prmCost", txtCost.Text);
                cmd.Parameters.AddWithValue("@prmSubtotal", 
                Convert.ToDecimal(txtCost.Text) * Convert.ToDecimal(txtQuantity.Text));

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Service Added!");
                    //ClearTextBox();
                }
                else
                { MessageBox.Show("Error!"); }

                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        void SearchCustomerPlate()
        {
            try
            {
                //Search Customer from Customers table.
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlConnection conn = new SqlConnection(connStr);

                cmd = new SqlCommand("spSearchCustomerService", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmValue", txtCarPlate.Text);
                da.SelectCommand = cmd;
                da.Fill(dt);

                //if found, put the information in the Textboxs
                if (dt.Rows.Count > 0)
                {
                    txtCustomerName.Text = dt.Rows[0][0].ToString();
                    txtCustomerPhone.Text = dt.Rows[0][1].ToString();
                    txtCustomerName.Enabled = false;
                    txtCustomerPhone.Enabled = false;
                }
                else if (dt.Rows.Count == 0)
                {
                    txtCustomerName.Text = null;
                    txtCustomerPhone.Text = null;
                    txtCustomerName.Enabled = true;
                    txtCustomerPhone.Enabled = true;
                }
            }
            catch (Exception)
            {
                //ClearTextBox();
            }
        }

        void SearchServicesMasterID()
        {
            try
            {
                //Search Customer from Customers table.
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlConnection conn = new SqlConnection(connStr);

                cmd = new SqlCommand("Select TOP from dbo.ServicesMaster where ID = ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmValue", txtCarPlate.Text);
                da.SelectCommand = cmd;
                da.Fill(dt);

                //if found, put the information in the Textboxs
                if (dt.Rows.Count > 0)
                {
                    txtCustomerName.Text = dt.Rows[0][0].ToString();
                    txtCustomerPhone.Text = dt.Rows[0][1].ToString();
                    txtCustomerName.Enabled = false;
                    txtCustomerPhone.Enabled = false;
                }
                else if (dt.Rows.Count == 0)
                {
                    txtCustomerName.Text = null;
                    txtCustomerPhone.Text = null;
                    txtCustomerName.Enabled = true;
                    txtCustomerPhone.Enabled = true;
                }
            }
            catch (Exception)
            {
                //ClearTextBox();
            }
        }

        void FillcbxProducts()
        {
            try
            {
                //Search Customer from Customers table.
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader sqr;

                conn.Open();
                cmd = new SqlCommand("Select * from dbo.Products", conn);
                sqr = cmd.ExecuteReader();

                while (sqr.Read())
                {
                    cbxProducts.Items.Add(sqr.GetString(2));
                }

                conn.Close();
            }
            catch (Exception)
            {
                //ClearTextBox();
            }
        }


        //#####################################################################//

        private void frmServices_Load(object sender, EventArgs e)
        {
            GetData();
            FillcbxProducts();
        }

        private void txtCarPlate_TextChanged(object sender, EventArgs e)
        {
            SearchCustomerPlate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
