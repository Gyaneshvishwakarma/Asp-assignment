using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Register : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Students (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)", connection))
            {
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
      

                connection.Open();
                cmd.ExecuteNonQuery();
            }

            BindGridView();
            ClearForm();
        }

        private void BindGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gvStudents.DataSource = dt;
                gvStudents.DataBind();
            }
        }

        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
        
        }
    }
