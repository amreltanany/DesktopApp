using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.econtactClasses
{
    internal class ContactClass
    {
        public int ContactID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String ContactNo { get; set; }
        public String Address { get; set; }
        public String Gender { get; set; }

        static string myConnString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public DataTable Select()
        {
            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myConnString);  // Connect to DB using connection string
            DataTable dt = new DataTable();  // Empty table to hold the data

            try
            {
                string sql = "SELECT * FROM tbl_contact";   // SQL query to select all rows from tbl_contact
                SqlCommand cmd = new SqlCommand(sql, conn); // Command object that holds the SQL and connection
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Adapter to fetch data
                conn.Open();   // Open the connection
                adapter.Fill(dt); // Execute the query and put results into dt
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Show error if something goes wrong
            }
            finally
            {
                conn.Close();  // Always close the connection
            }

            return dt; // Return the filled DataTable
        }

        public bool Insert(ContactClass c)
        {
            bool IsSuccess = false;

            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                string sql = "INSERT INTO tbl_contact (FirstName, LastName, ContactNo, Address,Gender) VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                    
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;
        }

        public bool Update(ContactClass c)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address,Gender=@Gender WHERE ContactID=@ContactID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;

        }

        public bool Delete(ContactClass c)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;
        }
    }
}
