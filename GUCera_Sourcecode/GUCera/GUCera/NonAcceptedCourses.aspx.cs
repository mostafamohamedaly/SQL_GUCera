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
    public partial class AcceptedCourses : System.Web.UI.Page
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

                SqlCommand viewNonAcceptedCourses = new SqlCommand("AdminViewNonAcceptedCourses", conn);
                viewNonAcceptedCourses.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = viewNonAcceptedCourses.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
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
                            contentlabel.Text = "Content: " + "Not Available " + "<br />";
                            form1.Controls.Add(contentlabel);

                        }
                        else
                        {
                            String content = rdr.GetString(rdr.GetOrdinal("content"));
                            Label contentlabel = new Label();
                            contentlabel.Text = "Content: " + content + " <br />";
                            form1.Controls.Add(contentlabel);
                        }

                    }


                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }

        }
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx", true);
        }
    }
}