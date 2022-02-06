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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            try
            {
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);


                int id = Int16.Parse(userID.Text);
                string pass = password.Text;

                /*create a new SQL command which takes as parameters the name of the stored procedure and
                the SQLconnection name*/
                SqlCommand loginproc = new SqlCommand("userLogin", conn);
                loginproc.CommandType = CommandType.StoredProcedure;

                loginproc.Parameters.Add(new SqlParameter("@id", id));
                loginproc.Parameters.Add(new SqlParameter("@password", pass));

                //Save the output from the procedure
                SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;

                SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);
                type.Direction = ParameterDirection.Output;

                //Executing the SQLCommand
                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();



                if (success.Value.ToString().Equals("1"))
                {

                    Session["user"] = id;

                    Response.Write("Login Successful");

                    if (type.Value.ToString().Equals("0"))
                        Response.Redirect("InstructorHome.aspx", true);

                    else if (type.Value.ToString().Equals("1"))
                        Response.Redirect("AdminHome.aspx", true);

                    else if (type.Value.ToString().Equals("2"))
                        Response.Redirect("StudentHome.aspx", true);


                }
                else
                {
                    Response.Write("Login Failed");
                }
            }
            catch(Exception ex) 
            {
                Response.Write(ex.Message.ToString());
            }
        }

        protected void studentRegister(object sender, EventArgs e)
        {

            
            Response.Redirect("studentRegister.aspx", true);


        }

        protected void instructorRegister(object sender, EventArgs e)
        {

            
            Response.Redirect("instructorRegister.aspx", true);


        }
    }
}