using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentDatabase
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            //Launches the login screen
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            //Establishes SQL connection with the StudentRegistry SQL database that contains the values for username and password.
            SqlConnection con2 = new SqlConnection(@"Data Source = NITEKARAMSE78AE\SQLEXPRESS; Initial Catalog = StudentRegistry; Integrated Security = True");
            //Selects data from database for "Username" and "Password" values using the two textboxes on the GUI
            string query = " select * from LoginDB where Username = '" + Usertxt.Text.Trim() + "' and Password = '" + Passwordtxt.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con2);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                //Allows login if user info is correct. Will close login window and open student database window. 
                StudentDatabase objStudentDatabase = new StudentDatabase();
                this.Hide();
                objStudentDatabase.Show();
            }

            else 
            {
                MessageBox.Show("Username/Password combination not recognized!", "Incorrect Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            //Closes the application and cancels login process. 
            Application.Exit();
        }
    }
}
