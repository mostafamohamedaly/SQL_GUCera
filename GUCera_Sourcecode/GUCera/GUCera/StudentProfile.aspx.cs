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
    public partial class StudentProfile : System.Web.UI.Page
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

                SqlCommand viewprofproc = new SqlCommand("viewMyProfile", conn);
                viewprofproc.CommandType = CommandType.StoredProcedure;

                viewprofproc.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                SqlDataReader rdr = viewprofproc.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    int studentId = rdr.GetInt32(rdr.GetOrdinal("id"));
                    Label myid = new Label();
                    myid.Text = "ID: " + studentId.ToString() + " <br>  ";

                    String fName = rdr.GetString(rdr.GetOrdinal("firstName"));
                    Label fname = new Label();
                    fname.Text = "First Name: " + fName + "<br> ";

                    String lName = rdr.GetString(rdr.GetOrdinal("lastName"));
                    Label lname = new Label();
                    lname.Text = "Last Name: " + lName + " <br> ";

                    String password = rdr.GetString(rdr.GetOrdinal("password"));
                    Label pass = new Label();
                    pass.Text = "Password: " + password + "<br>";

                    String genout = "";
                    byte[] gender = (byte[])rdr["gender"];
                    Label gen = new Label();
                    for (int i = 0; i < gender.Length; i++)
                    {
                        if (gender[i].Equals(1))
                            genout = "Female";
                        else if (gender[i].Equals(0))
                            genout = "Male";
                    }

                    gen.Text = "gender: " + genout + " <br>  ";

                    String email = rdr.GetString(rdr.GetOrdinal("email"));
                    Label em = new Label();
                    em.Text = "Email: " + email + "<br>";

                    String address = rdr.GetString(rdr.GetOrdinal("address"));
                    Label ad = new Label();
                    ad.Text = "Address: " + address + "<br>";

                    decimal gpa = rdr.GetDecimal(rdr.GetOrdinal("gpa"));
                    Label g = new Label();
                    g.Text = "GPA: " + gpa.ToString() + "<br> ";

                    form1.Controls.Add(myid);
                    form1.Controls.Add(fname);
                    form1.Controls.Add(lname);
                    form1.Controls.Add(pass);
                    form1.Controls.Add(gen);
                    form1.Controls.Add(em);
                    form1.Controls.Add(ad);
                    form1.Controls.Add(g);



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