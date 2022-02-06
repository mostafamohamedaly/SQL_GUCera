using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
namespace GUCera
{
    public partial class issueCert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void issue_Click(object sender, EventArgs e)
        {
            try
            {

                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

               
                SqlConnection conn = new SqlConnection(connStr);


                // int id = Int16.Parse(userID.Text);

                int insid = Int16.Parse(Session["user"].ToString());
                int stuid = Int16.Parse(studentid.Text.ToString());
                int couid = Int16.Parse(courseid.Text.ToString());
                DateTime issuedate = Convert.ToDateTime(date.Text.ToString());
                

                SqlCommand instregproc = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                instregproc.CommandType = CommandType.StoredProcedure;

                instregproc.Parameters.Add(new SqlParameter("@insId", insid));
                instregproc.Parameters.Add(new SqlParameter("@cid", couid));
                instregproc.Parameters.Add(new SqlParameter("@sid", stuid));
                instregproc.Parameters.Add(new SqlParameter("@issueDate", issuedate));

                
                conn.Open();
                instregproc.ExecuteNonQuery();
                conn.Close();



                Response.Write("Certificate Issued!");
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
                
            }

        }
        protected void backw_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorHome.aspx");
        }
    }
}