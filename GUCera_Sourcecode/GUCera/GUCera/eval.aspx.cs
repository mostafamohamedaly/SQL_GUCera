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
    public partial class eval : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Send_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int cid = Int16.Parse(courID.Text);
            string comm = comment.Text;
            int sid = Int16.Parse(Session["user"].ToString());

            /*create a new SQL command which takes as parameters the name of the stored procedure and
            the SQLconnection name*/
            SqlCommand sturegproc = new SqlCommand("addFeedback", conn);
            sturegproc.CommandType = CommandType.StoredProcedure;

            sturegproc.Parameters.Add(new SqlParameter("@comment", comm));
            sturegproc.Parameters.Add(new SqlParameter("@cid", cid));
            sturegproc.Parameters.Add(new SqlParameter("@sid", sid));

            //Executing the SQLCommand
            conn.Open();
            sturegproc.ExecuteNonQuery();
            conn.Close();

            Response.Write("Thank you for you feedback!");
        }
    }
}