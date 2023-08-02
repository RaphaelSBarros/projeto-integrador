using System;
using System.Windows.Forms;

namespace Views {

    public class TelaInicial : Form {
        private Label labelFundo;
        private Label labelDivisao1;
        private Label labelDivisao2;
        private Label labelLinha1;
        private Label labelLinha2;
        private Label labelFoto;
        private Label labelOla;
        private Label labelNome;
        private Button buttonInicio;
        private Button buttonRelatar;        

        public TelaInicial() {
            this.WindowState = FormWindowState.Maximized;

            Image image = Image.FromFile("Layout/IconeResolville.png");
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(1070, 50);
            panel.Size = new Size(80, 80);
            panel.BackgroundImage = image;
            panel.BackgroundImageLayout = ImageLayout.Zoom;

            labelDivisao1 = new Label();
            labelDivisao1.Location = new System.Drawing.Point(650, 0);
            labelDivisao1.Size = new System.Drawing.Size(10, 970);
            labelDivisao1.BackColor = Color.LightGray;

            labelDivisao2 = new Label();
            labelDivisao2.Location = new System.Drawing.Point(1190, 0);
            labelDivisao2.Size = new System.Drawing.Size(10, 970);
            labelDivisao2.BackColor = Color.LightGray;

            /*labelFundo = new Label();
            labelFundo.Location = new System.Drawing.Point(650, 0);
            labelFundo.Size = new System.Drawing.Size(550, 970);
            labelFundo.BackColor = Color.LightGray;
            labelFundo.SendToBack();*/

            labelLinha1 = new Label();
            labelLinha1.Text = "";
            labelLinha1.Location = new System.Drawing.Point(700, 150);
            labelLinha1.Size = new System.Drawing.Size(450, 8);
            labelLinha1.BackColor = ColorTranslator.FromHtml("#5271FF");

            labelLinha2 = new Label();
            labelLinha2.Text = "";
            labelLinha2.Location = new System.Drawing.Point(700, 800);
            labelLinha2.Size = new System.Drawing.Size(450, 8);
            labelLinha2.BackColor = ColorTranslator.FromHtml("#5271FF");

            labelFoto = new Label();
            labelFoto.Image = Image.FromFile("Layout/FotoUsuario.png");
            labelFoto.Location = new System.Drawing.Point(700, 50);
            labelFoto.Size = new System.Drawing.Size(80, 80);
            labelFoto.BackgroundImageLayout = ImageLayout.Zoom;

            labelOla = new Label();
            labelOla.Text = "Olá";
            labelOla.Location = new System.Drawing.Point(790, 80);
            labelOla.Size = new System.Drawing.Size(41, 25);
            labelOla.ForeColor = ColorTranslator.FromHtml("#5271FF");
            Font fonte = new Font("Arial", 14, FontStyle.Bold);
            labelOla.Font = fonte;

            labelNome = new Label();
            labelNome.Text = "";
            labelNome.Location = new System.Drawing.Point(830, 80);
            labelNome.Size = new System.Drawing.Size(225, 25);
            labelNome.ForeColor = ColorTranslator.FromHtml("#5271FF");
            fonte = new Font("Arial", 14, FontStyle.Bold);
            labelOla.Font = fonte;

            labelNome = new Label();
            labelNome.Text = "";
            labelNome.Location = new System.Drawing.Point(830, 80);
            labelNome.Size = new System.Drawing.Size(225, 25);
            labelNome.ForeColor = ColorTranslator.FromHtml("#5271FF");
            fonte = new Font("Arial", 14, FontStyle.Bold);
            labelOla.Font = fonte;

            buttonInicio = new Button();
            buttonInicio.Text = "INÍCIO";
            buttonInicio.Location = new System.Drawing.Point(700, 808);
            buttonInicio.Size = new System.Drawing.Size(225, 50);
            buttonInicio.BackColor = ColorTranslator.FromHtml("#5271FF");
            buttonInicio.ForeColor = Color.White;
            fonte = new Font("Arial", 14, FontStyle.Bold);
            buttonInicio.Font = fonte;
            buttonInicio.TextAlign = ContentAlignment.MiddleCenter;

            buttonRelatar = new Button();
            buttonRelatar.Text = "RELATAR";
            buttonRelatar.Location = new System.Drawing.Point(925, 808);
            buttonRelatar.Size = new System.Drawing.Size(225, 50);
            buttonRelatar.BackColor = Color.White;
            buttonRelatar.ForeColor = ColorTranslator.FromHtml("#5271FF");
            fonte = new Font("Arial", 14, FontStyle.Bold);
            buttonRelatar.Font = fonte;
            buttonRelatar.TextAlign = ContentAlignment.MiddleCenter;

            string nomeUsuario = "João da Silva";
            string dataPostagem = "31/07/2023";
            string descricaoProblema = "Views.TelaRelatar.buttonFotoProblema";
            Image fotoUsuario = Image.FromFile("Layout/FotoUsuario.png");
            Image fotoProblema = Image.FromFile("caminho_da_imagem_problema.jpg");
            ExibirPostagem();

            labelFoto.Click += labelFoto_Click;
            buttonRelatar.Click += buttonRelatar_Click;

            Controls.Add(panel);
            Controls.Add(labelDivisao1);
            Controls.Add(labelDivisao2);
            Controls.Add(labelLinha1);
            Controls.Add(labelLinha2);
            Controls.Add(labelOla);
            Controls.Add(labelNome);
            Controls.Add(labelFoto);
            Controls.Add(buttonInicio);
            Controls.Add(buttonRelatar);
            Controls.Add(labelFundo);
        }

        private void ExibirPostagem() {
            string nomeUsuario = "João da Silva";
            string dataPostagem = "31/07/2023";
            string descricaoProblema = "Views.TelaRelatar.buttonFotoProblema";
            Image fotoUsuario = Image.FromFile("Layout/FotoUsuario.png");
            Image fotoProblema = Image.FromFile("caminho_da_imagem_problema.jpg");

            PictureBox pictureBoxFotoUsuario = new PictureBox();
            pictureBoxFotoUsuario.Location = new Point(700, 200);
            pictureBoxFotoUsuario.Size = new Size(50, 50);
            pictureBoxFotoUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFotoUsuario.Image = fotoUsuario;

            Label labelNomeUsuario = new Label();
            labelNomeUsuario.Location = new Point(730, 200);
            labelNomeUsuario.Size = new Size(50, 20);
            labelNomeUsuario.Text = nomeUsuario;

            Label labelDataPostagem = new Label();
            labelDataPostagem.Location = new Point(70, 30);
            labelDataPostagem.Size = new Size(100, 20);
            labelDataPostagem.Text = dataPostagem;

            TextBox textBoxDescricaoProblema = new TextBox();
            textBoxDescricaoProblema.Location = new Point(10, 70);
            textBoxDescricaoProblema.Size = new Size(300, 100);
            textBoxDescricaoProblema.Multiline = true;
            textBoxDescricaoProblema.ReadOnly = true;
            textBoxDescricaoProblema.Text = descricaoProblema;

            PictureBox pictureBoxFotoProblema = new PictureBox();
            pictureBoxFotoProblema.Location = new Point(10, 180);
            pictureBoxFotoProblema.Size = new Size(300, 200);
            pictureBoxFotoProblema.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFotoProblema.Image = fotoProblema;

            Panel panelPostagem = new Panel();
            panelPostagem.Location = new Point(10, 10);
            panelPostagem.Size = new Size(320, 400);
            panelPostagem.BorderStyle = BorderStyle.FixedSingle;
            panelPostagem.Controls.Add(pictureBoxFotoUsuario);
            panelPostagem.Controls.Add(labelNomeUsuario);
            panelPostagem.Controls.Add(labelDataPostagem);
            panelPostagem.Controls.Add(textBoxDescricaoProblema);
            panelPostagem.Controls.Add(pictureBoxFotoProblema);

            this.Controls.Add(panelPostagem);
        }

        private void labelFoto_Click(object sender, EventArgs e) {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.Show();
            this.Hide();
        }

        private void buttonRelatar_Click(object sender, EventArgs e) {
            TelaRelatar telaRelatar = new TelaRelatar();
            telaRelatar.Show();
            this.Hide();
        }

    }

}