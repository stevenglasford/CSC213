using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace BookWebApp.MyWork
{
    public partial class address : System.Web.UI.Page
    {
        AddressEntities dbcon = new AddressEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon.Addresses.Load();
            GridView1.DataSource = dbcon.Addresses.Local;
            //NEW - show data in the gridview
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string temp = TextBox1.Text.Trim();
            var result = from x in dbcon.Addresses.Local
                         where x.LastName.Trim().Equals(temp)
                         select x;
            GridView1.DataSource = result.ToList();
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Address myAddress = new Address();
            myAddress.FirstName = txtFirst.Text;
            myAddress.LastName = txtLast.Text;
            myAddress.PhoneNumber = txtPhone.Text;
            myAddress.Email = txtEmail.Text;

            dbcon.Addresses.Add(myAddress);
            dbcon.SaveChanges();
            GridView1.DataBind();
        }
    }
}


