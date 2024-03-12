using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class factorial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calculate_Click(object sender, EventArgs e)
    {
        int i = 1;
        int f = 1;
        int n = int.Parse(txtNumber.Text);
        for (i = 1; i <= n; i++)
        {
            f = f * i;
        }
        lblResult.Text = "factorial is :" + f;
    }
}