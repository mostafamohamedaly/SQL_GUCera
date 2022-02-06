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
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddMobile(object sender, EventArgs e)
        {
            try
            {
                Response.Clear();
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);


                string mob = phonenumber.Text;
                int id = Int16.Parse(Session["user"].ToString());

                SqlCommand addmobproc = new SqlCommand("addMobile", conn);
                addmobproc.CommandType = CommandType.StoredProcedure;

                addmobproc.Parameters.Add(new SqlParameter("@id", id));
                addmobproc.Parameters.Add(new SqlParameter("@mobile_number", mob));

                conn.Open();
                addmobproc.ExecuteNonQuery();
                conn.Close();

                Response.Write("Phone number added");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void viewProfile(object sender, EventArgs e)
        {
            Response.Redirect("StudentProfile.aspx");


        }

        protected void viewAvailableCourses(object sender, EventArgs e)
        {
            Response.Redirect("AvailableCourses.aspx");

        }

        protected void addCreditCard(object sender, EventArgs e)
        {
            try
            {

                Response.Clear();


                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                int id = Int16.Parse(Session["user"].ToString());
                string number = ccn.Text;
                string hname = name.Text;
                DateTime expiry = DateTime.Parse(edate.Text);
                string CVV = cvv.Text;

                SqlCommand addccproc = new SqlCommand("addCreditCard", conn);
                addccproc.CommandType = CommandType.StoredProcedure;

                addccproc.Parameters.Add(new SqlParameter("@sid", id));
                addccproc.Parameters.Add(new SqlParameter("@number", number));
                addccproc.Parameters.Add(new SqlParameter("@cardHolderName", hname));
                addccproc.Parameters.Add(new SqlParameter("@expiryDate", expiry));
                addccproc.Parameters.Add(new SqlParameter("@cvv", CVV));



                conn.Open();
                addccproc.ExecuteNonQuery();
                conn.Close();

                Response.Write("Credit card added");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void ViewPromocodes(object sender, EventArgs e)
        {
            Response.Redirect("StudentPromocodes.aspx");

        }

        protected void ViewAssi(object sender, EventArgs e)
        {
            Response.Redirect("StudentViewAssign.aspx", true);
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Response.Redirect("submitAssign.aspx", true);
        }

        protected void Grade_Click(object sender, EventArgs e)
        {
            Response.Redirect("gradeView.aspx", true);
        }

        protected void Feedback_Click(object sender, EventArgs e)
        {
            Response.Redirect("eval.aspx", true);
        }

        protected void Certificate_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewCertificate.aspx", true);
        }
    }
}