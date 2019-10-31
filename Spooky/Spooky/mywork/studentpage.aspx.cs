using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace Spooky.mywork
{
    public partial class studentpage : System.Web.UI.Page
    {
        StudentDBEntities dbcon = new StudentDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student myStudent = new Student();
            myStudent.FirstName = TextBox1.Text;
            myStudent.LastName = TextBox2.Text;
            myStudent.Email = TextBox3.Text;
            myStudent.GPA = Convert.ToDecimal(TextBox4.Text);

            //add data to the table Students
            dbcon.Students.Add(myStudent);
            dbcon.SaveChanges();

            //show data in the gridview
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedDataKey != null)
            {
                Session.Add(GridView1.SelectedDataKey[0].ToString(),
                    GridView1.SelectedDataKey[1].ToString() + " " +
                    GridView1.SelectedDataKey[1].ToString() + "; GPA = " +
                    GridView1.SelectedDataKey[2].ToString());
            }
        }
    }
}