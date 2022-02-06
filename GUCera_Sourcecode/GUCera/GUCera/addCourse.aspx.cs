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
    public partial class addCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                
                SqlConnection conn = new SqlConnection(connStr);


                
                string creditHour = creditHours.Text;
                string name = Name.Text;
                string prices = price.Text;
                int id = Int16.Parse(Session["user"].ToString());


                
                SqlCommand instregproc = new SqlCommand("InstAddCourse", conn);
                instregproc.CommandType = CommandType.StoredProcedure;

                instregproc.Parameters.Add(new SqlParameter("@CreditHours", creditHour));
                instregproc.Parameters.Add(new SqlParameter("@name", name));
                instregproc.Parameters.Add(new SqlParameter("@price", prices));
                instregproc.Parameters.Add(new SqlParameter("@instructorId", id));

                
                conn.Open();
                instregproc.ExecuteNonQuery();
                conn.Close();

                Response.Write("Course Added!");
            }
            catch
            {
                Response.Write("already Added!");
            }
        }
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorHome.aspx", true);
        }
    }
}