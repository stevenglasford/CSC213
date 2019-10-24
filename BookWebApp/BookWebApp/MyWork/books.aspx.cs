using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookWebApp.MyWork
{
    public partial class books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string result = GridView1.SelectedDataKey[0] +
                " " + GridView1.SelectedDataKey[1] + " " +
                GridView1.SelectedDataKey[2];
            Label1.Text = result;
        }
    }
}