using System;
using System.Drawing;
using System.IO;

class Utils
{
    /// <summary>
    /// Lê um ficheiro para um array de bytes
    /// </summary>
    /// <param name="ficheiro">Caminho para o ficheiro</param>
    /// <returns>Array com os dados do ficheiro</returns>
    static public byte[] ImagemParaVetor(string ficheiro)
    {
        FileStream fs = new FileStream(ficheiro, FileMode.Open, FileAccess.Read);
        byte[] dados = new byte[fs.Length];
        fs.Read(dados, 0, (int)fs.Length);
        fs.Close();
        return dados;
    }
    /// <summary>
    /// Guarda num ficheiro os dados de um array
    /// </summary>
    /// <param name="imagem">Array com os dados a guardar</param>
    /// <param name="ficheiro">Caminho para o ficheiro a criar</param>
    static public void VetorParaImagem(byte[] imagem, string ficheiro)
    {
        FileStream fs = new FileStream(ficheiro, FileMode.Create, FileAccess.Write);
        fs.Write(imagem, 0, imagem.GetUpperBound(0));
        fs.Close();
    }
    /// <summary>
    /// Criar uma pasta para o programa com o nome indicado
    /// </summary>
    /// <returns>Devolve o caminho completo sem \ no final</returns>
    static public string pastaDoPrograma(string nome)
    {
        string pastaInicial = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        pastaInicial += @"\" + nome;
        if (System.IO.Directory.Exists(pastaInicial) == false)
            System.IO.Directory.CreateDirectory(pastaInicial);
        return pastaInicial;
    }
    public static string ConvertImageToBase64(string imagePath)
    {
        using (Image image = Image.FromFile(imagePath))
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
    public static string ConvertImageToBase64(byte[] imageBytes)
    {

        return Convert.ToBase64String(imageBytes);
    }
    /// <summary>
    /// Lê todos os bytes de uma stream e devolve um array de bytes
    /// </summary>
    /// <param name="input">Stream que tem os dados</param>
    /// <returns>Array de bytes</returns>
    public static byte[] ReadFully(Stream input)
    {
        byte[] buffer = new byte[16 * 1024];
        using (MemoryStream ms = new MemoryStream())
        {
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }
    }
}

