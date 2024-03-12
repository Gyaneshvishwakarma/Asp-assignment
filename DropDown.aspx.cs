using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropDown : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Add some initial items to the DropDownList
            ddlItems.Items.Add("Item 1");
            ddlItems.Items.Add("Item 2");
            ddlItems.Items.Add("Item 3");
        }
    }
    protected void btnAddFirst_Click(object sender, EventArgs e)
        {
            // Add a new item at the first position
            string newItem = txtNewItem.Text;
            if (!string.IsNullOrEmpty(newItem))
            {
                ddlItems.Items.Insert(0, newItem);
                txtNewItem.Text = string.Empty;
            }
        }

        protected void btnAddLast_Click(object sender, EventArgs e)
        {
            // Add a new item at the last position
            string newItem = txtNewItem.Text;
            if (!string.IsNullOrEmpty(newItem))
            {
                ddlItems.Items.Add(newItem);
                txtNewItem.Text = string.Empty;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the selected item
            ListItem selectedItem = ddlItems.SelectedItem;
            if (selectedItem != null)
            {
                ddlItems.Items.Remove(selectedItem);
            }
        }
    }
