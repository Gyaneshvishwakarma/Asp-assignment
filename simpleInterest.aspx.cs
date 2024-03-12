using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class simpleInterest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calculate_Click(object sender, EventArgs e)
    {
            // Parse input values
            double principal = Convert.ToDouble(txtPrincipal.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            double time = Convert.ToDouble(txtTime.Text);

            // Calculate Simple Interest
            double simpleInterest = (principal * rate * time) / 100;

            // Display the result
            lblResult.Text = "Simple Interest: " +simpleInterest;
        }
    
    }