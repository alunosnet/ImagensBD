using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImagensBD
{
    public partial class adicionar2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string caminho = Server.MapPath("~/Imagens");
            string ficheiro = fu_foto.FileName;
            
            string caminho_completo = System.IO.Path.Combine(caminho, ficheiro); ;
            fu_foto.SaveAs(caminho_completo);
        }
    }
}