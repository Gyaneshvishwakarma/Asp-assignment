using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class validation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
     protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Perform the action when the form is valid
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string email = txtEmail.Text;

                lblResult.Text = "Username is : " +username+ " Password is : "+ password+  " Age is : " +age+ " Email is "+email;
            }
            else
            {
                // Display a message if the form is not valid
                lblResult.Text = "Please correct the validation errors.";
            }
        }
}