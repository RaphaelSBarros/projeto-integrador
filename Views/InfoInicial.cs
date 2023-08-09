using System;
using System.Windows.Forms;

namespace Views {

    public class InfoInicial{
        public static Font fonteTitulo = new Font("Garet", 14, FontStyle.Bold);
        public static Font fonteTexto = new Font("Arial", 14, FontStyle.Bold);
        public static Font fonteTexto2 = new Font("IBM Plex Sans", 12, FontStyle.Bold);
        public static Font fontTexto2Small = new Font("IBM Plex Sans", 8, FontStyle.Bold);

        public static void AdicionarTelaBasica(Form form){
            
            Models.Usuario usuarioconectado = Controllers.UsuarioController.ListarUsuarioConectado();

            Image image = Image.FromFile("Layout/IconeResolville.png");
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(1070, 50);
            panel.Size = new Size(80, 80);
            panel.BackgroundImage = image;
            panel.BackgroundImageLayout = ImageLayout.Zoom;

            Label labelDivisao1 = new Label();
            labelDivisao1.Location = new System.Drawing.Point(650, 0);
            labelDivisao1.Size = new System.Drawing.Size(10, 970);
            labelDivisao1.BackColor = Color.LightGray;

            Label labelDivisao2 = new Label();
            labelDivisao2.Location = new System.Drawing.Point(1190, 0);
            labelDivisao2.Size = new System.Drawing.Size(10, 970);
            labelDivisao2.BackColor = Color.LightGray;

            Label labelFundo = new Label();
            labelFundo.Location = new System.Drawing.Point(650, 0);
            labelFundo.Size = new System.Drawing.Size(550, 970);
            labelFundo.BackColor = Color.LightGray;
            labelFundo.SendToBack();

            Label labelLinha1 = new Label();
            labelLinha1.Text = "";
            labelLinha1.Location = new System.Drawing.Point(700, 150);
            labelLinha1.Size = new System.Drawing.Size(450, 8);
            labelLinha1.BackColor = ColorTranslator.FromHtml("#5271FF");

            Label labelLinha2 = new Label();
            labelLinha2.Text = "";
            labelLinha2.Location = new System.Drawing.Point(700, 800);
            labelLinha2.Size = new System.Drawing.Size(450, 8);
            labelLinha2.BackColor = ColorTranslator.FromHtml("#5271FF");

            Label labelOla = new Label();
            labelOla.Text = "Olá " + usuarioconectado.Nome_Usuario + "!";
            labelOla.Location = new System.Drawing.Point(790, 80);
            labelOla.Size = new System.Drawing.Size(225, 25);
            labelOla.ForeColor = ColorTranslator.FromHtml("#5271FF");
            labelOla.Font = fonteTexto;

            form.Controls.Add(panel);
            form.Controls.Add(labelDivisao1);
            form.Controls.Add(labelDivisao2);
            form.Controls.Add(labelLinha1);
            form.Controls.Add(labelLinha2);
            form.Controls.Add(labelOla);
        }
        public static Image ByteArrayToImage(byte[]? byteArray){
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(memoryStream);
                return image;
            }
        }
        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }
        }
    }
}