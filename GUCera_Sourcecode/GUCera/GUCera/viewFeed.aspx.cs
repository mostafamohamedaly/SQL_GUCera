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
    public partial class viewFeed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                
            }

        protected void open_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand instregproc = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
                instregproc.CommandType = CommandType.StoredProcedure;


                int ciid = Int16.Parse(courseid.Text.ToString());
                int iid = Int16.Parse(Session["user"].ToString());


                


                instregproc.Parameters.Add(new SqlParameter("@cid", ciid));
                instregproc.Parameters.Add(new SqlParameter("@instrId", iid));
                conn.Open();
                SqlDataReader rdr = instregproc.ExecuteReader(CommandBehavior.CloseConnection);
                instregproc.CommandType = CommandType.StoredProcedure;

                while (rdr.Read())
                {
                    int f = rdr.GetInt32(rdr.GetOrdinal("number"));
                    Label feedback = new Label();
                    feedback.Text = "Course number: " + f + " <br> ";
                    form1.Controls.Add(feedback);

                    String n = rdr.GetString(rdr.GetOrdinal("comment"));
                    Label nu = new Label();
                    nu.Text = "Comment: " + n + " <br> ";
                    form1.Controls.Add(nu);


                    int p = rdr.GetInt32(rdr.GetOrdinal("numberOfLikes"));
                    Label pu = new Label();
                    pu.Text = "Number of likes: " + p + " <br> ";
                    form1.Controls.Add(pu);


                }
            }
            catch
            {
                Response.Write("Feedback could not be viewed!");
            }
            

        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorHome.aspx");
        }
    }

    }

