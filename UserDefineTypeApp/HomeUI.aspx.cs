using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefineTypeApp
{
    public partial class HomeUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            List<Person> personList = new List<Person>();
            Person aPerson = new Person();
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;
            
            if (ViewState["person"] != null)
            {
                personList = (List<Person>)ViewState["person"];
            }
            personList.Add(aPerson);
            ViewState["person"] = personList;

            firstNameTextBox.Text = String.Empty;
            middleNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
        }

        protected void showAllFullNameButton_Click(object sender, EventArgs e)
        {
            //Person bPerson = (Person)ViewState["person"];
            List<Person> bPerson = (List<Person>)ViewState["person"];
            foreach (var data in bPerson)
            {
                string fullName = data.GetFullName();
                fullNameListBox.Items.Add(fullName);
            }
            
        }
    }
}