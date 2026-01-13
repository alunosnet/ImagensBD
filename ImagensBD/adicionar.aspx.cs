using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImagensBD
{
    public partial class adicionar : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_enviar_Click(object sender, EventArgs e)
        {
            string texto = tb_texto.Text;
            string ficheiro = Path.GetTempPath() + "temp.img";
            //guardar o ficheiro 
            //Request.Files[0].SaveAs(ficheiro);
            //sem guardar
            Stream dados = Request.Files[0].InputStream;
            byte[] imagem = Utils.ReadFully(dados);
            string sql = "INSERT INTO imagens(texto,foto)values(@texto,@foto);";
            var parametros = new List<SqlParameter>()
            {
                new SqlParameter(){
                    ParameterName="@texto",
                    SqlDbType=SqlDbType.VarChar,
                    Value=texto
                },
                new SqlParameter(){
                    ParameterName="@foto",
                    SqlDbType=SqlDbType.VarBinary,
                    Value=imagem
                },
            };
            bd.executaSQL(sql,parametros);
            ClientScript.RegisterStartupScript(this.GetType(),"Aviso", "alert('guardado com sucesso');",true);
            bd = null;
        }
    }
}