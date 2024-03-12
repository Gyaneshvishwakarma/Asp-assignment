using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CheckBox_CheckedChanged(object sender, EventArgs e)
    {
        UpdateListBox("PHP", chkPhp);
        UpdateListBox("Java", chkJava);
        UpdateListBox("C#", chkCSharp);
    }

    private void UpdateListBox(string technology, CheckBox checkBox)
    {
        if (checkBox.Checked)
        {
            if (!lstTechnologies.Items.Contains(new ListItem(technology)))
            {
                lstTechnologies.Items.Add(new ListItem(technology));
            }
        }
        else
        {
            lstTechnologies.Items.Remove(technology);
        }
    }
}