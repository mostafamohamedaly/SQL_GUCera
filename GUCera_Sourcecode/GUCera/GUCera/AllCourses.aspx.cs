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
    public partial class AllCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                conn.Open();

                SqlCommand viewAllCourses = new SqlCommand("AdminViewAllCourses", conn);
                viewAllCourses.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = viewAllCourses.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    String coursename = rdr.GetString(rdr.GetOrdinal("name"));
                    Label namelabel = new Label();
                    namelabel.Text = "Course Name: " + coursename + " , ";
                    form1.Controls.Add(namelabel);

                    int credithours = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                    Label credithourslabel = new Label();
                    credithourslabel.Text = "Credit Hours: " + credithours.ToString() + " , ";
                    form1.Controls.Add(credithourslabel);

                    decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                    Label pricelabel = new Label();
                    pricelabel.Text = "Price: " + price.ToString() + " , ";
                    form1.Controls.Add(pricelabel);



                    if (rdr.IsDBNull(rdr.GetOrdinal("content")))
                    {
                        Label contentlabel = new Label();
                        contentlabel.Text = "Content: " + "Not Available " + " , ";
                        form1.Controls.Add(contentlabel);

                    }
                    else
                    {
                        String content = rdr.GetString(rdr.GetOrdinal("content"));
                        Label contentlabel = new Label();
                        contentlabel.Text = "Content: " + content + " , ";
                        form1.Controls.Add(contentlabel);
                    }
                    if (rdr.IsDBNull(rdr.GetOrdinal("accepted")))
                    {
                        Label acceptedlabel = new Label();
                        acceptedlabel.Text = "Acceptance: " + "False" + "<br /> ";
                        form1.Controls.Add(acceptedlabel);

                    }
                    else
                    {
                        Boolean accepted = rdr.GetBoolean(rdr.GetOrdinal("accepted"));
                        Label acceptedlabel = new Label();
                        acceptedlabel.Text = "Acceptance: " + accepted.ToString() + "<br /> ";
                        form1.Controls.Add(acceptedlabel);
                    }









                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }

        }

            protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx", true);
        }
    }
}