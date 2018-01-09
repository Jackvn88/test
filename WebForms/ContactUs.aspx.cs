using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlackLight.Recruitment.WebForms
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                validationMessage.Text = "Valid";
                ContactFormPanel.Visible = false;
                FeedbackPanel.Visible = true;
                UserName.Text = Name.Text;
            }
            else
            {
                validationMessage.Text = "Not Valid";
            }
        }

        
    }
}