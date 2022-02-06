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
    public partial class gradeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int sid = Int16.Parse(Session["user"].ToString());
            int course = Int16.Parse(coursID.Text.ToString());
            int assignmNum = Int16.Parse(assignNum.Text.ToString());
            String assignmType = assignType.Text.ToString();

            SqlCommand assignments = new SqlCommand("viewAssignGrades", conn);
            assignments.CommandType = CommandType.StoredProcedure;

            assignments.Parameters.Add(new SqlParameter("@sid", sid));
            assignments.Parameters.Add(new SqlParameter("@cid", course));
            assignments.Parameters.Add(new SqlParameter("@assignnumber", assignmNum));
            assignments.Parameters.Add(new SqlParameter("@assignType", assignmType));

            SqlParameter grade = assignments.Parameters.Add("@assignGrade", SqlDbType.Int);
            grade.Direction = ParameterDirection.Output;

       
            //Executing the SQLCommand
            conn.Open();
            assignments.ExecuteNonQuery();
            conn.Close();
        }
    }
}