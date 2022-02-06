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
    public partial class gradeAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void change_Click(object sender, EventArgs e)
        {

            try
           {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                
                SqlConnection conn = new SqlConnection(connStr);


                // int id = Int16.Parse(userID.Text);
                int Studentid = Int16.Parse(stuid.Text.ToString());
                string Type = typ.Text;
                int AssignmentNumber = Int16.Parse(an.Text.ToString());
                int Grade = Int16.Parse(grad.Text.ToString());

                int Courseid = Int16.Parse(couid.Text.ToString());
                int Instructorid = Int16.Parse(Session["user"].ToString());


                
                SqlCommand instregproc = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
                instregproc.CommandType = CommandType.StoredProcedure;

                instregproc.Parameters.Add(new SqlParameter("@instrId", Instructorid));
                instregproc.Parameters.Add(new SqlParameter("@sid", Studentid));
                instregproc.Parameters.Add(new SqlParameter("@cid", Courseid));
                instregproc.Parameters.Add(new SqlParameter("@grade", Grade));
                instregproc.Parameters.Add(new SqlParameter("@assignmentNumber", AssignmentNumber));
                instregproc.Parameters.Add(new SqlParameter("@type", Type));
               



                
                conn.Open();
                instregproc.ExecuteNonQuery();

                Response.Write("Assignment Graded!");
                conn.Close();
            }
            catch
            {
                Response.Write("Assignment could not be graded!");
            }
        }


           

            protected void back_Click(object sender, EventArgs e)
            {
                Response.Redirect("InstructorHome.aspx", true);
            }
        }
    } 