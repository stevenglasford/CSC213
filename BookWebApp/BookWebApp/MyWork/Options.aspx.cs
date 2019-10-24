using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookWebApp.MyWork
{
    public partial class Options : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedItem != null)
            {
                Session.Add(RadioButtonList1.SelectedItem.Text,
                    RadioButtonList1.SelectedItem.Value);
            }
        }
    }
}