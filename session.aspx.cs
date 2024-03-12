using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class session : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void log(object sender, EventArgs e)
    {
        Session["name"] = txtun.Text;
        Response.Redirect("Welcome.aspx");
    }
}