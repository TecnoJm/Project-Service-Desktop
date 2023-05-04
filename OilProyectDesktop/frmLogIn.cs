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
    public partial class frmLogin : MaterialForm
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

        //Create Material Skin Forms options
        public frmLogin()
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

        void LogIn()
        {
            //Local Variables for SQL Local Connection
            SqlConnection connection;
            SqlCommand cmd;
            SqlDataReader dr;

            connection = new SqlConnection(connStr);
            cmd = new SqlCommand("spLogIn", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prmUser", txtUser.Text);
            cmd.Parameters.AddWithValue("@prmPass", txtPassword.Text);

            connection.Open();

            //Check if Datareader found the row.
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.Hide();
                frmMenu newScreen = new frmMenu();
                newScreen.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseñas incorrectos.");
            }

            connection.Close();
        }

        //#####################################################################//

        //Login 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //LogIn();


        }
    }
}
