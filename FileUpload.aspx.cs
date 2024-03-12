using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FileUpload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
     protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                    string filename = fileUpload.FileName;                    
                    fileUpload.SaveAs(Server.MapPath (filename));

                    // Display a success message
                    lblStatus.Text = "Fileuploaded successfully!";
             }
             
            else
            {
                // Display a message if no file is selected
                lblStatus.Text = "Please select a file to upload.";
            }
        }
}