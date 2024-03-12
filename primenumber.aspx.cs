using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class primenumber : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CheckPrime_Click(object sender, EventArgs e)
{
    int n, i;
        n = Int32.Parse(txtNumber.Text);
        for (i = 2; i < n; i++)
        {
            if (n % i == 0)
            {

                lblResult.Text = "Number is not prime ";
                break;
            }
        }
  if(i==n){
      lblResult.Text="number is prime";
  }
}
            
}