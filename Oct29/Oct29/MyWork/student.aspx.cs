using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oct29.MyWork
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(GridView1.SelectedDataKey != null)
            {
                Session.Add(GridView1.SelectedDataKey[0].ToString(),
                    GridView1.SelectedDataKey[1] +
                    " " + GridView1.SelectedDataKey[2] +
                    " GPA: " + GridView1.SelectedDataKey[3]);
            }
        }
    }
}