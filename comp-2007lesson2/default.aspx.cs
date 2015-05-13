using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp_2007lesson2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblMessage.Text = "";
                btnCopyText.Enabled = true;
            }
        }

        protected void btnCopyText_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtMessage.Text;
            btnCopyText.Enabled = false;
        }

        protected void btnShowSelection_Click(object sender, EventArgs e)
        {
            //clear out the previos label
            lblTopings.Text = "";
            //loop through the list opf checkbox
            foreach (ListItem topping in cblToppings.Items)
            {
                //check if the current topping checked or not
                if (topping.Selected)
                {
                    lblTopings.Text += topping.Text+' ';
                }
            }
            //display the selected size from dropdown list
            lblSize.Text = ddlSize.SelectedItem.Text;
      }
        
    }
}