using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class sumoftwonum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the numbers entered in the textboxes
                int number1 = int.Parse(TextBox1.Text);
                int number2 = int.Parse(TextBox2.Text);

                // Calculate the sum
                int sum = number1 + number2;

                // Display the result
                LableResult.Text = "The sum is: " + sum;
            }
            catch (Exception ex)
            {
                // Handle any potential exceptions
                LableResult.Text = "Error: " + ex.Message;
            }
        }
    }
}
