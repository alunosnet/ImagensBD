using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImagensBD
{
    public partial class listar : System.Web.UI.Page
    {
        BaseDados bd = new BaseDados();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dados = bd.devolveSQL("SELECT * FROM Imagens");
            lb_texto.Text = dados.Rows[0][1].ToString();
            byte[] imagem = (byte[])dados.Rows[0][2];
            img_foto.ImageUrl = "data:image/png;base64,"+Utils.ConvertImageToBase64(imagem);
        }
    }
}