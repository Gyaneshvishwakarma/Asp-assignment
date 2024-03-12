using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class matchvalue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
            protected void btnMatch_Click(object sender, EventArgs e)
        {
            string value1 = txtBox1.Text;
            string value2 = txtBox2.Text;

            if (string.Equals(value1, value2))
            {
                lblResult.Text = "Values match!";
            }
            else
            {
                lblResult.Text = "Values do not match.";
            }
        }
    }