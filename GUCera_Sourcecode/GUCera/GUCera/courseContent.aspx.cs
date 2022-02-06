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
    public partial class courseContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void updatecontentt(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                
                SqlConnection conn = new SqlConnection(connStr);


                // int id = Int16.Parse(userID.Text);
                int instructorid = Int16.Parse(Session["user"].ToString());
                int courseid = Int16.Parse(couid.Text);
                string updatedconent = conten.Text;



                
                SqlCommand instregproc = new SqlCommand("UpdateCourseContent", conn);
                instregproc.CommandType = CommandType.StoredProcedure;

                instregproc.Parameters.Add(new SqlParameter("@instrId", instructorid));
                instregproc.Parameters.Add(new SqlParameter("@courseId", courseid));
                instregproc.Parameters.Add(new SqlParameter("@content", updatedconent));

                
                conn.Open();
                instregproc.ExecuteNonQuery();
                conn.Close();


                Response.Write("Content Updated!");
            }
            catch {
                Response.Write("Content could not be updated!");
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorHome.aspx", true);
        }
    }
}