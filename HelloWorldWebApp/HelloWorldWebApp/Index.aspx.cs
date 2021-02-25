using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            ViewState["name"] = nameTextBox.Text;
            //Response.Write("Hello");
            //string name = nameTextBox.Text;
            messageLabel.Text = "Hello " + ViewState["name"];
        }

    }
}