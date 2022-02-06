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
    public partial class viewCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Vieww_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                int sid = Int16.Parse(Session["user"].ToString());
                int course = Int16.Parse(courseeID.Text.ToString());

                SqlCommand assignments = new SqlCommand("viewCertificate", conn);
                assignments.CommandType = CommandType.StoredProcedure;

                assignments.Parameters.Add(new SqlParameter("@sid", sid));
                assignments.Parameters.Add(new SqlParameter("@cid", course));

                conn.Open();
                SqlDataReader rdr = assignments.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    int certificate = rdr.GetInt32(rdr.GetOrdinal("sid"));
                    Label stuid = new Label();
                    stuid.Text = certificate.ToString() + "<br>";
                    form1.Controls.Add(stuid);

                    int certificate2 = rdr.GetInt32(rdr.GetOrdinal("cid"));
                    Label cid = new Label();
                    cid.Text = certificate2.ToString() + "<br>";
                    form1.Controls.Add(cid);

                    DateTime certificate3 = rdr.GetDateTime(rdr.GetOrdinal("issueDate"));
                    Label issDate = new Label();
                    issDate.Text = certificate3.ToString() + "<br>";
                    form1.Controls.Add(issDate);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }
    }
}