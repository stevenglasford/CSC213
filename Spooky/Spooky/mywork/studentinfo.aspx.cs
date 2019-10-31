using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spooky.mywork
{
    public partial class studentinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session.Count > 0)
            {
                foreach(string item in Session.Keys)
                {
                    ListBox1.Items.Add(item + " " + Session[item]);
                }

            }
        }
    }
}