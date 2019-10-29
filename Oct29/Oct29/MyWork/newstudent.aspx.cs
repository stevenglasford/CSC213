using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace Oct29.MyWork
{
    public partial class newstudent : System.Web.UI.Page
    {
        StudentDataBaseEntities dbcon = new StudentDataBaseEntities();

        StudentDataBaseEntities dbconUsers = new StudentDataBaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //add data to the gridview
            dbcon.Students.Load();
            GridView1.DataSource = dbcon.Students.Local;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student myStudent = new Student();
            myStudent.FirstName = txtFirst.Text;
            myStudent.LastName = txtLast.Text;
            myStudent.GPA = Convert.ToDecimal(txtGPA.Text);
            myStudent.LoginName = txtUserName.Text;

            Oct29.User myUser = new Oct29.User();
            myUser.LoginName = txtUserName.Text;
            myUser.Password = txtPassword.Text;

            //add data to the table Student
            dbcon.Students.Add(myStudent);
            dbcon.SaveChanges();
            GridView1.DataBind();

            //add data to the table Student
            dbconUsers.Users.Add(myUser);
            dbconUsers.SaveChanges();

        }
    }
}