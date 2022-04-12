using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentDatabase
{
    public partial class StudentDatabase : Form
    {
        //Establishes connection to SQL database
        SqlConnection con = new SqlConnection(@"Data Source = NITEKARAMSE78AE\SQLEXPRESS; Initial Catalog = StudentRegistry; Integrated Security = True");
        public int StudentIDNum;

        public StudentDatabase()
        {
            //Launches application page
            InitializeComponent();
        }

        private void StudentDatabase_Load(object sender, EventArgs e)
        {
            //Displays data in the DataGridView
            Disp_data();
        }

        public void Disp_data()
        {
            //Defines Disp_data values to display in Datagridview
            SqlCommand cmd = new SqlCommand("Select * from StudentInformation", con);
            DataTable dt = new DataTable();

            //Fixes open connection error
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            //Opens reader
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            StudentData.DataSource = dt;

            Countlbl.Text = dt.Rows.Count.ToString();


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                //Allows information to be filled into textboxes and saved in database.
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into StudentInformation values('" + StudentIDtxt.Text + "' , '" + Lastnametxt.Text + "' , '" + Firstnametxt.Text + "', '" + Agetxt.Text + "', '" + Emailtxt.Text + "' , '" + Phonetxt.Text + "')";
                cmd.ExecuteNonQuery();
                Disp_data();
                con.Close();
                ResetFormControls();

                MessageBox.Show("New Student record added.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private bool IsValid()
        {

            //Makes Student ID a requirement
            if (StudentIDtxt.Text == string.Empty)
            {
                MessageBox.Show("Student ID is required.", "Record Not Stored", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Makes last name a requirement
            if (Lastnametxt.Text == string.Empty)
            {
                MessageBox.Show("Last name is required.", "Record Not Stored", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Makes first name a requirement
            if (Firstnametxt.Text == string.Empty)
            {
                MessageBox.Show("First name is required.", "Record Not Stored", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

            //the above listed are reuirements because they are the minimums to tell one record from another.
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Fixes open connection error
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            //Deletion parameters
            if (StudentIDNum > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE from StudentInformation where StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.StudentIDNum);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student record removed.", "Delete Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disp_data();
                ResetFormControls();
            }

            //Promots user to select a record to delete
            else
            {
                MessageBox.Show("Please select a record to remove.", "Selet Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (StudentIDNum > 0)
            {
                //Parameters to update a record
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE StudentInformation SET LastName = @LastName , FirstName = @FirstName , Age = @Age , Email = @Email , Phone = @Phone WHERE StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LastName", Lastnametxt.Text);
                cmd.Parameters.AddWithValue("@FirstName", Firstnametxt.Text);
                cmd.Parameters.AddWithValue("@Age", Agetxt.Text);
                cmd.Parameters.AddWithValue("@Email", Emailtxt.Text);
                cmd.Parameters.AddWithValue("@Phone", Phonetxt.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentIDNum);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student Record successfully updated!", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Disp_data();
                ResetFormControls();
            }

            else
            {
                //prompts user to select a record to update
                MessageBox.Show("Please select a record to update", "Select A Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            //private void created to allow form controls to be reset upon clicking new entries.
            ResetFormControls();
            Disp_data();
        }

        private void ResetFormControls()
        {
            //Will refresh data in the event that a user uses the search function
            Disp_data();

            //Clears text boxes to allow for fresh entry.
            StudentIDtxt.Clear();
            Lastnametxt.Clear();
            Firstnametxt.Clear();
            Agetxt.Clear();
            Emailtxt.Clear();
            Phonetxt.Clear();
            Searchtxt.Clear();

            //Sets cursor to the StudentID text box, which is the first on the tab list. 
            StudentIDtxt.Focus();
        }

        private void StudentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Imports data from selected rows to text boxes to allow information to be updated.
            StudentIDNum = Convert.ToInt32(StudentData.SelectedRows[0].Cells[0].Value);
            Lastnametxt.Text = StudentData.SelectedRows[0].Cells[1].Value.ToString();
            Firstnametxt.Text = StudentData.SelectedRows[0].Cells[2].Value.ToString();
            Agetxt.Text = StudentData.SelectedRows[0].Cells[3].Value.ToString();
            Emailtxt.Text = StudentData.SelectedRows[0].Cells[4].Value.ToString();
            Phonetxt.Text = StudentData.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        using (DataTable dt = new DataTable("StudentInformation"))
                        {
                            using (SqlCommand cmd = new SqlCommand("select *from StudentInformation where LastName like @LastName or FirstName like @FirstName or Age like @Age", con))
                            {
                                cmd.Parameters.AddWithValue("LastName", string.Format("%{0}%", Searchtxt.Text));
                                cmd.Parameters.AddWithValue("FirstName", string.Format("%{0}%", Searchtxt.Text));
                                cmd.Parameters.AddWithValue("Age", string.Format("%{0}%", Searchtxt.Text));
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);
                                StudentData.DataSource = dt;
                                Countlbl.Text = $"{StudentData.RowCount}";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Define Search Items.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                Searchbtn.PerformClick();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This selects all data in the table to be exported to the Excel sheet
            StudentData.SelectAll();

            //copies data to the clipboard for export
            DataObject copydata = StudentData.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object misseddata = System.Reflection.Missing.Value;

            //defines values for the two varialbles used to export data
            xlWbook = xlapp.Workbooks.Add(misseddata);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            //exports all data including column names 
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }

    }
}

