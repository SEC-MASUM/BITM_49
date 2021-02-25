using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateWebApp
{
    public partial class HomeUI : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            string name;
            name = nameTextBox.Text;
            ViewState["name"] = name;
            ViewState["number"] = 100;
            nameTextBox.Text = "";
        }

        protected void shoowButton_Click(object sender, EventArgs e)
        {
            int number = (int)ViewState["number"];
            string name = ViewState["name"].ToString();
            outputTextBox.Text = name + " " + number.ToString();
            
        }
    }
}