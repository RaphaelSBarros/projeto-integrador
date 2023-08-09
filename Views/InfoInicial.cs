using System;
using System.Windows.Forms;

namespace Views {

    public class InfoInicial{
        public static Font fonteTitulo = new Font("Garet", 14, FontStyle.Bold);
        public static Font fonteTexto = new Font("Arial", 14, FontStyle.Bold);
        public static Font fonteTexto2 = new Font("IBM Plex Sans", 12, FontStyle.Bold);
        public static Font fonteTexto2Normal = new Font("IBM Plex Sans", 10);
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
        public static void AdicionarPostagem(Panel form, Models.Postagem postagem, int y){
            Models.Usuario usuario = Controllers.UsuarioController.GetUsuario(postagem.FK_ID_Usuario);
            Models.Tipo_Problema tipo_problema = Controllers.Tipo_ProblemaController.GetTipo_Problema(postagem.FK_Code_Problema);
            Models.Bairro bairro = Controllers.BairroController.GetBairro(postagem.FK_ID_Bairro);

            Label labelfundo = new Label();
            labelfundo.Location = new System.Drawing.Point(0, y);
            labelfundo.Size = new System.Drawing.Size(450, 210);
            labelfundo.BackColor = Color.LightGray;
            labelfundo.BorderStyle = BorderStyle.FixedSingle;

            Label labelfundo2 = new Label();
            labelfundo2.Location = new System.Drawing.Point(400, y);
            labelfundo2.Size = new System.Drawing.Size(50, 210);
            labelfundo2.BackColor = Color.LightGray;
            labelfundo2.BorderStyle = BorderStyle.FixedSingle;

            Button like = new Button();
            like.Location = new System.Drawing.Point(400, y + 10);
            like.Size = new System.Drawing.Size(35, 35);
            like.BackColor = Color.Transparent;
            like.BackgroundImage = Image.FromFile("Layout/Like.png");
            like.BackgroundImageLayout = ImageLayout.Stretch;

            PictureBox pictureBoxFoto = new PictureBox();
            pictureBoxFoto.Location = new System.Drawing.Point(20, y + 20);
            pictureBoxFoto.Size = new System.Drawing.Size(30, 30);

            if(usuario.Foto == null){
                pictureBoxFoto.Image = Image.FromFile("Layout/FotoUsuario.png");
            }else{
                pictureBoxFoto.Image = InfoInicial.ByteArrayToImage(usuario.Foto);
            }
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;

            int labelNome_UsuarioX = 55;
            Label labelNome_Usuario = new Label();
            labelNome_Usuario.Text = usuario.Nome_Usuario;
            labelNome_Usuario.Location = new System.Drawing.Point(labelNome_UsuarioX, y + 25);
            labelNome_Usuario.Size = new System.Drawing.Size(130, 20);
            labelNome_Usuario.BackColor = Color.LightGray;
            labelNome_Usuario.BorderStyle = BorderStyle.FixedSingle;
            labelNome_Usuario.Font = InfoInicial.fonteTexto2Normal;

            Label labelData = new Label();
            labelData.Text = "•" + postagem.Data;
            labelData.Location = new System.Drawing.Point(labelNome_UsuarioX + 120, y + 25);
            labelData.Size = new System.Drawing.Size(130, 20);
            labelData.BackColor = Color.LightGray;
            labelData.BorderStyle = BorderStyle.FixedSingle;
            labelData.Font = InfoInicial.fonteTexto2Normal;

            Label labelStatus = new Label();
            labelStatus.Text = "STATUS";
            labelStatus.Location = new System.Drawing.Point(labelNome_UsuarioX + 212, y + 25);
            labelStatus.Size = new System.Drawing.Size(125, 20);
            labelStatus.BackColor = Color.LightGray;
            labelStatus.BorderStyle = BorderStyle.FixedSingle;
            labelStatus.Font = InfoInicial.fonteTexto2Normal;

            Label labelTitulo = new Label();
            labelTitulo.Text = "TITULO";
            labelTitulo.Location = new System.Drawing.Point(20, y + 60);
            labelTitulo.Size = new System.Drawing.Size(360, 20);
            labelTitulo.BackColor = Color.LightGray;
            labelTitulo.BorderStyle = BorderStyle.FixedSingle;
            labelTitulo.Font = InfoInicial.fonteTexto2;

            TextBox textBoxDescricaoProblema = new TextBox();
            textBoxDescricaoProblema.Text = postagem.Observacao;
            textBoxDescricaoProblema.Location = new System.Drawing.Point(20, y + 85);
            textBoxDescricaoProblema.Size = new System.Drawing.Size(360, 100);
            textBoxDescricaoProblema.BackColor = Color.LightGray;
            textBoxDescricaoProblema.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescricaoProblema.Font = InfoInicial.fonteTexto2Normal;
            textBoxDescricaoProblema.Multiline = true;
            textBoxDescricaoProblema.ReadOnly = true;

            form.Controls.Add(like);
            form.Controls.Add(labelStatus);
            form.Controls.Add(labelData);
            form.Controls.Add(labelNome_Usuario);
            form.Controls.Add(pictureBoxFoto);
            form.Controls.Add(labelTitulo);
            form.Controls.Add(textBoxDescricaoProblema);
            form.Controls.Add(labelfundo2);
            form.Controls.Add(labelfundo);
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