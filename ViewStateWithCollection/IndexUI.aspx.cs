using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateWithCollection
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        List<string> namesList = new List<string>();
        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (ViewState["nameState"]!=null)
            {
                namesList = (List<string>)ViewState["nameState"];
            }
            namesList.Add(name);
            ViewState["nameState"] = namesList;
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            namesList = (List<string>)ViewState["nameState"];
            nameListBox.Items.Clear();
            foreach (var data in namesList)
            {
                nameListBox.Items.Add(data);
            }
        }
    }
}