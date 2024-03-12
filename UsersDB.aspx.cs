using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class UsersDB : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // You can add any initialization code here
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Your connection string
        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        // Using statement ensures proper disposal of resources
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();

            // SQL query with parameterized values to prevent SQL injection
            string query = "INSERT INTO Users VALUES (@Username, @Password, @Age, @Email)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Add parameters
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                // Execute the query
                cmd.ExecuteNonQuery();

                // Display success message
                lblResult.Text = "Data inserted successfully!";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
