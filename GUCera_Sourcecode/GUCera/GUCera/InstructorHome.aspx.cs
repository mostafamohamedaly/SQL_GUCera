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
    public partial class InstructorHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddMobile(object sender, EventArgs e)
        {
            try
            {

                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();


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

                Response.Write("Phone number added!");
            }
            catch
            {
                Response.Write("Phone nuumber could not be added!");
            }
        }

        protected void addCourse(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("addCourse.aspx", true);
        }

        protected void courseContent(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("courseContent.aspx", true);
        }

        protected void viewAssign(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("viewAssign.aspx", true);
        }

        protected void gradeAssign(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

           
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("gradeAssign.aspx", true);
        }

        protected void viewFeed(object sender, EventArgs e)
        {
           
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("viewFeed.aspx", true);
        }

        protected void issueCert(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

           
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("issueCert.aspx", true);
        }
    }
}