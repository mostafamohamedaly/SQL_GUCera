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
    public partial class submitAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                int sid = Int16.Parse(Session["user"].ToString());
                String assignmentType = asstype.Text;
                int assignmentNum = Int16.Parse(assnum.Text);
                int cid = Int16.Parse(courseID.Text);

                /*create a new SQL command which takes as parameters the name of the stored procedure and
               the SQLconnection name*/
                SqlCommand sturegproc = new SqlCommand("submitAssign", conn);
                sturegproc.CommandType = CommandType.StoredProcedure;

                sturegproc.Parameters.Add(new SqlParameter("@assignType", assignmentType));
                sturegproc.Parameters.Add(new SqlParameter("@assignnumber", assignmentNum));
                sturegproc.Parameters.Add(new SqlParameter("@cid", cid));
                sturegproc.Parameters.Add(new SqlParameter("@sid", sid));

                conn.Open();
                sturegproc.ExecuteNonQuery();
                conn.Close();

                Response.Write("Your assignment has been submitted !");
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }
    }
}