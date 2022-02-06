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
    public partial class StudentViewAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Show_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String sid = Session["user"].ToString();
            int course = Int16.Parse(viewassi.Text.ToString());

            SqlCommand assignments = new SqlCommand("viewAssign", conn);
            assignments.CommandType = CommandType.StoredProcedure;

            assignments.Parameters.Add(new SqlParameter("@Sid", sid));
            assignments.Parameters.Add(new SqlParameter("@courseId", course));

            conn.Open();
            SqlDataReader rdr = assignments.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String assignmentContent = rdr.GetString(rdr.GetOrdinal("content"));
                Label content = new Label();
                content.Text = assignmentContent +"<br>";
                form1.Controls.Add(content);
            }
        }
    }
}