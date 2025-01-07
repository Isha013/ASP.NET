using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string fileName = FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath("~/FILES/") + fileName);
                    Label1.Text = "File uploaded successfully!";
                }
                catch (Exception ex)
                {
                    Label1.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                Label1.Text = "Please select a file to upload!";
            }
            }
        }
    }

