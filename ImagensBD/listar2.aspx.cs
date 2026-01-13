using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImagensBD
{
    public partial class listar2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string caminho = Server.MapPath("~/Imagens");
            string[] ficheiros = System.IO.Directory.GetFiles(caminho);
            string html = "";
            foreach(string ficheiro in ficheiros)
            {

                string ficheiro_so_nome ="/Imagens/" + System.IO.Path.GetFileName(ficheiro); 
                html = html + $"<img src='{ficheiro_so_nome}' /><br/>";
            }
            imagens.InnerHtml = html;
        }
    }
}