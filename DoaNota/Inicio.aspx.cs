using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace DoaNota
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //string myConnStr = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;

            // Create new connection to database and open database
            //SqlConnection myConn = new SqlConnection();
            //myConn.ConnectionString = myConnStr; // Set connection string
            //myConn.Open();
             
        }


        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastro.aspx");
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}   