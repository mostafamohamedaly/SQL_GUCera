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
    public partial class AvailableCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand viewcoursesproc = new SqlCommand("availableCourses", conn);
                viewcoursesproc.CommandType = CommandType.StoredProcedure;


                conn.Open();
                SqlDataReader rdr = viewcoursesproc.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {

                    String name = rdr.GetString(rdr.GetOrdinal("name"));
                    Label cname = new Label();
                    cname.Text = "- " + name + "  <br>  ";

                    form1.Controls.Add(cname);


                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void backhome(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx");

        }

        protected void viewInfo(object sender, EventArgs e)
        {
            Response.Redirect("ViewEnrollCourse.aspx");
        }
    }
}