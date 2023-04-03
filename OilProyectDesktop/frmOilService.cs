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
    public partial class frmOilService : MaterialForm
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        //Create Material Skin Forms options
        public frmOilService()
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

        void InsertData()
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd;

                cmd = new SqlCommand("spRecordOilService", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Parameters (Data from Text Box)
                cmd.Parameters.AddWithValue("@prmCustomerPlate", txtCarPlate.Text);
                cmd.Parameters.AddWithValue("@prmCustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@prmCustomerPhone", txtCustomerPhone.Text);
                cmd.Parameters.AddWithValue("@prmGrade", cbxOilGrade.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@prmMiles", txtMiles.Text);
                cmd.Parameters.AddWithValue("@prmOilType", cbxOilType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@prmChangeMiles", txtChangeMiles.Text);
                cmd.Parameters.AddWithValue("@prmTodayDate", DateTime.Now);

                //Change date format for SQL to recognize the information.
                txtNextChangeDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@prmChangeDate", txtNextChangeDate.Text);
                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Oil Service Added!");
                    ClearTextBox();
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

                cmd = new SqlCommand("spSearchCustomerOilService", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmValue", txtCarPlate.Text);
                da.SelectCommand = cmd;
                da.Fill(dt);

                //if found, put the information in the Textboxs
                if (dt.Rows.Count > 0)
                {
                    txtCustomerName.Text = dt.Rows[0][0].ToString();
                    txtCustomerPhone.Text = dt.Rows[0][1].ToString();
                    cbxOilType.Text = dt.Rows[0][2].ToString();
                    cbxOilGrade.Text = dt.Rows[0][3].ToString();
                    txtMiles.Text = dt.Rows[0][4].ToString();
                    txtCustomerName.Enabled = false;
                    txtCustomerPhone.Enabled = false;
                }
                else if (dt.Rows.Count == 0)
                {
                    txtCustomerName.Text = null;
                    txtCustomerPhone.Text = null;
                    txtCustomerName.Enabled = true;
                    txtCustomerPhone.Enabled = true;
                    cbxOilType.Text = "";
                    cbxOilGrade.Text = "";
                    txtMiles.Text = "0";
                    txtChangeMiles.Text = "";
                    txtNextChangeDate.Text = "";
                }
            }
            catch (Exception)
            {
                //ClearTextBox();
            }
        }

        void CalculateDataForOilType()
        {
            try
            {
                DateTime nextMonth = DateTime.Now;
                cbxOilGrade.Enabled = true;

                //Create new Date for Oil Service
                if (cbxOilType.SelectedIndex == 0) //High Mileage
                {
                    DateTime newDate = nextMonth.AddMonths(3);
                    txtNextChangeDate.Text = newDate.ToString("ddd, dd MMM yyy");

                    //Calculate Next Change Miles
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 3000);

                    //Add Oil Grades for High Mileage
                    cbxOilGrade.Items.Clear();
                    cbxOilGrade.Items.Add("5W-20");
                    cbxOilGrade.Items.Add("5W-30");
                    cbxOilGrade.Items.Add("10W-30");
                    cbxOilGrade.Items.Add("10W-40");
                }

                if (cbxOilType.SelectedIndex == 1) //Sythethic Blend
                {
                    DateTime newDate = nextMonth.AddMonths(5);
                    txtNextChangeDate.Text = newDate.ToString("ddd, dd MMM yyy");

                    //Calculate Next Change Miles
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 5000);

                    //Add Oil Grades for Synthetic Blend
                    cbxOilGrade.Items.Clear();
                    cbxOilGrade.Items.Add("0W-40");
                    cbxOilGrade.Items.Add("10W-30");
                }

                if (cbxOilType.SelectedIndex == 2) //Flend Sythethic
                {
                    DateTime newDate = nextMonth.AddMonths(5);
                    txtNextChangeDate.Text = newDate.ToString("ddd, dd MMM yyy");

                    //Calculate Next Change Miles
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 5000);

                    //Add Oil Grades for Flend Synthetic
                    cbxOilGrade.Items.Clear();
                    cbxOilGrade.Items.Add("5W-30");
                    cbxOilGrade.Items.Add("10W-40");
                }
            }
            catch (Exception)
            {

            }
        }

        void CalculateDataForMiles()
        {
            DateTime nextMonth = DateTime.Now;
            try
            {
                //Create new Date for Oil Service
                if (cbxOilType.SelectedIndex == 0) //High Mileage
                {
                    DateTime newDate = nextMonth.AddMonths(3);
                    txtNextChangeDate.Text = newDate.ToString("ddd, dd MMM yyy");

                    //Calculate Next Change Miles
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 3000);
                }

                if (cbxOilType.SelectedIndex == 1) //Sythethic Blend
                {
                    DateTime newDate = nextMonth.AddMonths(5);
                    txtNextChangeDate.Text = newDate.ToString("ddd, dd MMM yyy");

                    //Calculate Next Change Miles
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 5000);
                }

                if (cbxOilType.SelectedIndex == 2) //Flend Sythethic
                {
                    DateTime newDate = nextMonth.AddMonths(5);
                    txtNextChangeDate.Text = newDate.ToString("ddd, dd MMM yyy");

                    //Calculate Next Change Miles
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 5000);
                }
            }
            catch (Exception)
            {

            }
        }

        void CalculateDataForOilGrade()
        {
            try
            {
                if (cbxOilType.SelectedIndex == 0) //High Mileage
                {
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 3000);
                }
                if (cbxOilType.SelectedIndex == 1) //Sythethic Blend
                {
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 5000);
                }
                if (cbxOilType.SelectedIndex == 2) //Flend Sythethic
                {
                    txtChangeMiles.Text = Convert.ToString(Convert.ToInt32(txtMiles.Text) + 5000);
                }
            }
            catch (Exception)
            {

            }
        }

        void ClearTextBox()
        {
            txtCarPlate.Clear();
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtMiles.Clear();
            txtChangeMiles.Clear();
            txtNextChangeDate.Clear();
        }

        //#####################################################################//

        private void frmOilService_Load(object sender, EventArgs e)
        {
            txtCustomerName.Enabled = false;
            txtCustomerPhone.Enabled = false;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            InsertData();
            ClearTextBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void txtCarPlate_TextChanged(object sender, EventArgs e)
        {
            SearchCustomerPlate();
        }

        private void cbxOilType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDataForOilType();
        }

        private void cbxOilGrade_TextChanged(object sender, EventArgs e)
        {
            CalculateDataForOilGrade();
        }

        private void txtMiles_TextChanged_1(object sender, EventArgs e)
        {
            CalculateDataForMiles();
        }
    }
 }
