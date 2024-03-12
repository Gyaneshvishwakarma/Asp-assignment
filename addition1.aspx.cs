using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addition1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void add(object o, EventArgs e)
    {
        int a = int.Parse(val1.Text);
        int b = int.Parse(val2.Text);
        int c = a + b;
        result.Text = "Addition is " + c;
    }
}