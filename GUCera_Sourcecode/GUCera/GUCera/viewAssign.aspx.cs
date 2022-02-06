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
    public partial class viewAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void vieww_Click(object sender, EventArgs e)
        {
            try
            {

                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();


                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand instregproc = new SqlCommand("InstructorViewAssignmentsStudents", conn);
                instregproc.CommandType = CommandType.StoredProcedure;


                int course = Int16.Parse(courseid.Text.ToString());
                int iid = Int16.Parse(Session["user"].ToString());






                instregproc.Parameters.Add(new SqlParameter("@instrId", iid));
                instregproc.Parameters.Add(new SqlParameter("@cid", course));
                conn.Open();
                SqlDataReader rdr = instregproc.ExecuteReader(CommandBehavior.CloseConnection);
                instregproc.CommandType = CommandType.StoredProcedure;

                while (rdr.Read())
                {
                    int userid = rdr.GetInt32(rdr.GetOrdinal("sid"));
                    Label user = new Label();
                    user.Text = "Student ID: " + userid + " <br> ";
                    form1.Controls.Add(user);

                    int fname = rdr.GetInt32(rdr.GetOrdinal("cid"));
                    Label first = new Label();
                    first.Text = "Course ID" + fname + " <br> ";
                    form1.Controls.Add(first);

                    String lname = rdr.GetString(rdr.GetOrdinal("assignmenttype"));
                    Label last = new Label();
                    last.Text = "type: " + lname + " <br> ";
                    form1.Controls.Add(last);

                    int gender = rdr.GetInt32(rdr.GetOrdinal("assignmentNumber"));
                    Label g = new Label();
                    g.Text = "Assignment number" + gender + " <br> ";
                    form1.Controls.Add(g);

                    //int gradee = rdr.GetInt32(rdr.GetOrdinal("grade"));
                    //Label gg = new Label();
                    //g.Text = "full grade: " + gradee + " <br> ";
                    //form1.Controls.Add(gg);

                    decimal mail = rdr.GetDecimal(rdr.GetOrdinal("grade"));
                    Label email = new Label();
                    email.Text = "Grade: " + mail + " <br> ";
                    form1.Controls.Add(email);

                    //String add = rdr.GetString(rdr.GetOrdinal("content"));
                    //Label address = new Label();
                    //address.Text = "content: " + add + " <br> ";
                    //form1.Controls.Add(address);

                    // DateTime addd = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                    //Label adddress = new Label();
                    //adddress.Text = "deadline: " + addd + " <br> ";
                    //form1.Controls.Add(adddress);
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorHome.aspx");
        }
    }

}

