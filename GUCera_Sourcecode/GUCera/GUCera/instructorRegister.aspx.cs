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
    public partial class instructorRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void instRegister(object sender, EventArgs e)
        {
            try
            {
                //Get the information of the connection to the database
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);


                // int id = Int16.Parse(userID.Text);
                string password = pass.Text;
                string firstname = fname.Text;
                string lastname = lname.Text;
                string genderr = gender.Text;
                string emaill = email.Text;
                string addresss = address.Text;





                /*create a new SQL command which takes as parameters the name of the stored procedure and
                the SQLconnection name*/
                SqlCommand instregproc = new SqlCommand("InstructorRegister", conn);
                instregproc.CommandType = CommandType.StoredProcedure;

                instregproc.Parameters.Add(new SqlParameter("@first_name", firstname));
                instregproc.Parameters.Add(new SqlParameter("@last_name", lastname));
                instregproc.Parameters.Add(new SqlParameter("@password", password));
                instregproc.Parameters.Add(new SqlParameter("@email", emaill));
                instregproc.Parameters.Add(new SqlParameter("@address", addresss));

                bool g = false;

                if (genderr == "male")
                {
                    g = false;
                }
                if (genderr == "female")
                {
                    g = true;
                }

                instregproc.Parameters.Add(new SqlParameter("@gender", g));



                //Executing the SQLCommand
                conn.Open();
                instregproc.ExecuteNonQuery();
                conn.Close();

                Response.Redirect("Login.aspx", true);
            }

            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }


    }
}