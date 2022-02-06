using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace GUCera
{
    public partial class ViewEnrollCourse : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            en.Visible = false;
            iid.Visible = false;
            Label2.Visible = false;
        }

        protected void Backtocourses(object sender, EventArgs e)
        {
            Response.Redirect("AvailableCourses.aspx");
        }


        

        protected void viewInfo(object sender, EventArgs e)
        {
           // try
           // {

                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                int courseid = Int32.Parse(cid.Text);
                

                SqlCommand viewinfoproc = new SqlCommand("courseInformation", conn);
                viewinfoproc.CommandType = CommandType.StoredProcedure;

                viewinfoproc.Parameters.Add(new SqlParameter("@id", courseid));

                conn.Open();
                SqlDataReader rdr = viewinfoproc.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {

                    int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                    Label coid = new Label();
                    coid.Text = "Course ID: " + id.ToString() + "  <br>  ";

                    String cname = rdr.GetString(rdr.GetOrdinal("name"));
                    Label coname = new Label();
                    coname.Text = "Course Name: " + cname + "  <br>  ";

                    int ch = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                    Label coch = new Label();
                    coch.Text = "Credit Hours: " + ch.ToString() + "  <br>  ";

                    if (rdr.IsDBNull(rdr.GetOrdinal("courseDescription")))
                {
                    Label codesc = new Label();
                    codesc.Text = "Course Description: " + "Not Available" + "  <br>  ";
                    form1.Controls.Add(codesc);
                }
                else
                {
                    String cdesc = rdr.GetString(rdr.GetOrdinal("courseDescription"));
                    Label codesc = new Label();
                    codesc.Text = "Course Description: " + cdesc + "  <br>  ";
                    form1.Controls.Add(codesc);
                }
                    

                    decimal cp = rdr.GetDecimal(rdr.GetOrdinal("price"));
                    Label cop = new Label();
                    cop.Text = "Price: " + cp.ToString() + "  <br>  ";


                    int inid = rdr.GetInt32(rdr.GetOrdinal("instructorId"));
                    Label insid = new Label();
                    insid.Text = "Instructor ID: " + inid.ToString() + "  <br>  ";

                    String ifn = rdr.GetString(rdr.GetOrdinal("firstName"));
                    String iln = rdr.GetString(rdr.GetOrdinal("lastName"));
                    Label iname = new Label();
                    iname.Text = "Instructor Name: " + ifn + " " + iln + "  <br> <br>  ";

                    Label enteriid = new Label();
                    enteriid.Text = "(Please enter desired instructor ID in the field above to enroll) <br>";


                   

                    form1.Controls.Add(coid);
                    form1.Controls.Add(coname);
                    form1.Controls.Add(coch);
                    form1.Controls.Add(cop);
                    form1.Controls.Add(insid);
                    form1.Controls.Add(iname);

                    form1.Controls.Add(enteriid);

                    en.Visible = true;
                    iid.Visible = true;
                    Label2.Visible = true;
                    cid.Visible = false;
                    view.Visible = false;
                    Label1.Visible = false;



                }

                conn.Close();
          //  }
           /* catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }*/
        }
       

        protected void enrl(object sender, EventArgs e)
        {

            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();


                SqlConnection conn = new SqlConnection(connStr);

                int sid = Int32.Parse(Session["user"].ToString());
                int coid = Int32.Parse(cid.Text);
                int inst = Int32.Parse(iid.Text);


                SqlCommand enrollproc = new SqlCommand("enrollInCourse", conn);
                enrollproc.CommandType = CommandType.StoredProcedure;

                enrollproc.Parameters.Add(new SqlParameter("@sid", sid));
                enrollproc.Parameters.Add(new SqlParameter("@cid", coid));
                enrollproc.Parameters.Add(new SqlParameter("@instr", inst));

                conn.Open();
                enrollproc.ExecuteNonQuery();
                conn.Close();

                Response.Write("Enrolled in course successfully.");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }

        }
            
        
    }
    
}
