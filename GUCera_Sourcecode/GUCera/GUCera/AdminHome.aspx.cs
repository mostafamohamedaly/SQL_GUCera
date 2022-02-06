using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace GUCera
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddMobile(object sender, EventArgs e)
        {
            try
            {
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);


                string mob = phonenumber.Text;
                int id = Int16.Parse(Session["user"].ToString());

                SqlCommand addmobproc = new SqlCommand("addMobile", conn);
                addmobproc.CommandType = CommandType.StoredProcedure;

                addmobproc.Parameters.Add(new SqlParameter("@id", id));
                addmobproc.Parameters.Add(new SqlParameter("@mobile_number", mob));


                conn.Open();
                addmobproc.ExecuteNonQuery();
                conn.Close();

                Response.Write("Phone number added");
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void viewAllCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllCourses.aspx", true);
        }

        protected void viewNonAccpetedCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("NonAcceptedCourses.aspx", true);

        }

        protected void AcceptCourse(object sender, EventArgs e)
        {
            try
            {
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                int id = Int16.Parse(Session["user"].ToString());
                int cid = Int16.Parse(CourseId.Text);

                SqlCommand acceptcourse = new SqlCommand("AdminAcceptRejectCourse", conn);
                acceptcourse.CommandType = CommandType.StoredProcedure;

                acceptcourse.Parameters.Add(new SqlParameter("@adminid", id));
                acceptcourse.Parameters.Add(new SqlParameter("@courseId", cid));

                conn.Open();
                acceptcourse.ExecuteNonQuery();
                conn.Close();

                Response.Write("Course Accepted");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void Create_Promocode(object sender, EventArgs e)
        {
            try
            {
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                int id = Int16.Parse(Session["user"].ToString());
                String code = codee.Text;
                DateTime issuedate = DateTime.Parse(issdate.Text);
                DateTime expirydate = DateTime.Parse(exdate.Text);
                decimal discoint = decimal.Parse(discountt.Text);

                SqlCommand createpromocode = new SqlCommand("AdminCreatePromocode", conn);
                createpromocode.CommandType = CommandType.StoredProcedure;

                createpromocode.Parameters.Add(new SqlParameter("@adminId", id));
                createpromocode.Parameters.Add(new SqlParameter("@code", code));
                createpromocode.Parameters.Add(new SqlParameter("@isuueDate", issuedate));
                createpromocode.Parameters.Add(new SqlParameter("@expiryDate", expirydate));
                createpromocode.Parameters.Add(new SqlParameter("@discount", discoint));


                conn.Open();
                createpromocode.ExecuteNonQuery();
                conn.Close();

                Response.Write("Promocode Created");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void issuepromo_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                int id = Int16.Parse(studentid.Text);
                String code = codeee.Text;


                SqlCommand issuepromocode = new SqlCommand("AdminIssuePromocodeToStudent", conn);
                issuepromocode.CommandType = CommandType.StoredProcedure;

                issuepromocode.Parameters.Add(new SqlParameter("@sid", id));
                issuepromocode.Parameters.Add(new SqlParameter("@pid", code));



                conn.Open();
                issuepromocode.ExecuteNonQuery();
                conn.Close();

                Response.Write("Promocode Issued");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }
    }
}