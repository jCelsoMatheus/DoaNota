using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DoaNota
{
    public partial class Doacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ListBox1.Items.Clear();


                using (SqlConnection conn = sql.OpenConnection())
                {


                    // Cria um comando para selecionar registros da tabela, trazendo todas as pessoas que nasceram depois de 1/1/1900
                    using (SqlCommand cmd = new SqlCommand(@"SELECT
	                                                        dbo.ENTIDADE_DOACAO.ID,	                                                        
	                                                        dbo.ENTIDADE_DOACAO.NOME
                                                        FROM
	                                                        dbo.ENTIDADE_DOACAO", conn))
                    {


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ListBox1.Items.Clear();

                            //Obtém os registros, um por vez
                            while (reader.Read() == true)
                            {
                                int ID = reader.GetInt32(0);
                                string NOME = reader.GetString(1);
                               

                                ListItem item = new ListItem(NOME, ID.ToString());
                                ListBox1.Items.Add(item);

                                //***********************************************
                                // Aqui você pode trabalhar com as variáveis id,
                                // nome, email e nascimento conforme necessário
                                //***********************************************
                            }
                        }
                    }
                }
            }
            else {
                // O usuário clicou em um botão, ou realizou alguma ação!
            }
        }

        protected void btnQrCode_Click(object sender, EventArgs e)
        {
            Response.Redirect("QrCode.aspx?id=" + ListBox1.SelectedValue);
        }

        protected void btnQrCode_Click1(object sender, EventArgs e)
        {

        }
    }
}