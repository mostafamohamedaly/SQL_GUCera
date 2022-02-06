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
    public partial class StudentPromocodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                int id = Int16.Parse(Session["user"].ToString());

                SqlCommand viewpromoproc = new SqlCommand("viewPromocode", conn);
                viewpromoproc.CommandType = CommandType.StoredProcedure;

                viewpromoproc.Parameters.Add(new SqlParameter("@sid", id));

                conn.Open();
                SqlDataReader rdr = viewpromoproc.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {

                    String code = rdr.GetString(rdr.GetOrdinal("code"));
                    Label promoc = new Label();
                    promoc.Text = "Code: " + code + "  ||  ";

                    DateTime idate = rdr.GetDateTime(rdr.GetOrdinal("isuueDate"));
                    Label issue = new Label();
                    issue.Text = "Issue date: " + idate.ToString() + "  ||  ";

                    DateTime edate = rdr.GetDateTime(rdr.GetOrdinal("expiryDate"));
                    Label exp = new Label();
                    exp.Text = "Expiry date: " + edate.ToString() + "  ||  ";

                    Decimal discount = rdr.GetDecimal(rdr.GetOrdinal("discount"));
                    Label disc = new Label();
                    disc.Text = "Discount: " + discount.ToString() + "  ||  ";

                    int aid = rdr.GetInt32(rdr.GetOrdinal("adminId"));
                    Label admin = new Label();
                    admin.Text = "Admin ID: " + aid.ToString() + "<br>";





                    form1.Controls.Add(promoc);
                    form1.Controls.Add(issue);
                    form1.Controls.Add(exp);
                    form1.Controls.Add(disc);
                    form1.Controls.Add(admin);

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
    }
}