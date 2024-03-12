using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void addition(object sender, EventArgs e)
    {
        int a = int.Parse(val1.Text);
        int b = int.Parse(val2.Text);
        int c = a + b;
        res.Text = "Addition is " + c;
    }

    protected void min(object sender, EventArgs e)
    {
        int a = int.Parse(val1.Text);
        int b = int.Parse(val2.Text);
        int c = a - b;
        res.Text = "Subtraction is " + c;
    }

    protected void div(object sender, EventArgs e)
    {
        int a = int.Parse(val1.Text);
        int b = int.Parse(val2.Text);
        int c = a / b;
        res.Text = "division is " + c;
    }
    protected void mul(object sender, EventArgs e)
    {
        int a = int.Parse(val1.Text);
        int b = int.Parse(val2.Text);
        int c = a * b;
        res.Text = "multiplication is " + c;
    }
}