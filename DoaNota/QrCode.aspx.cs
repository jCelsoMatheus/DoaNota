using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoaNota
{
    public partial class QrCode : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDoar_Click(object sender, EventArgs e)
        {
            Response.Redirect("doacao.aspx");
        }
    }
}