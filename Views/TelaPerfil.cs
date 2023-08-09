using System;
using System.Windows.Forms;

namespace Views {

    public class TelaPerfil : Form {
        private Label labelFundo;
        private Label labelDivisao1;
        private Label labelDivisao2;
        private Label labelLinha1;
        private Label labelLinha2;
        private Label labelLinha3;
        private PictureBox pictureBoxFoto;
        private Label labelOla;
        private Label labelNome;
        private Label labelSeusRelatos;
        private TextBox textPostagens;
        private Button buttonEditarPerfil;
        private Button buttonInicio;
        private Button buttonRelatar;

        public TelaPerfil() {
            this.WindowState = FormWindowState.Maximized;
            this.Icon = new Icon("Layout/Resolville.ico");
            this.Text = "Resolville";

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

            labelFundo = new Label();
            labelFundo.Location = new System.Drawing.Point(650, 0);
            labelFundo.Size = new System.Drawing.Size(550, 970);
            labelFundo.BackColor = Color.LightGray;
            labelFundo.SendToBack();

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

            labelLinha3 = new Label();
            labelLinha3.Text = "";
            labelLinha3.Location = new System.Drawing.Point(700, 275);
            labelLinha3.Size = new System.Drawing.Size(450, 5);
            labelLinha3.BackColor = Color.Gray;
            labelLinha3.SendToBack();

            pictureBoxFoto = new PictureBox();
            pictureBoxFoto.Location = new System.Drawing.Point(700, 50);
            pictureBoxFoto.Size = new System.Drawing.Size(80, 80);
            pictureBoxFoto.Image = Image.FromFile("Layout/FotoUsuario.png");
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;

            textPostagens = new TextBox();
            textPostagens.Location = new System.Drawing.Point(700, 295);
            textPostagens.Size = new System.Drawing.Size(450, 495);
            textPostagens.Multiline = true;
            textPostagens.ScrollBars = ScrollBars.Vertical;

            labelOla = new Label();
            labelOla.Text = "Olá";
            labelOla.Location = new System.Drawing.Point(790, 80);
            labelOla.Size = new System.Drawing.Size(41, 25);
            labelOla.ForeColor = ColorTranslator.FromHtml("#5271FF");
            Font fonte = new Font("IBM Plex Sans", 14, FontStyle.Bold);
            labelOla.Font = fonte;

            labelNome = new Label();
            labelNome.Text = "";
            labelNome.Location = new System.Drawing.Point(830, 80);
            labelNome.Size = new System.Drawing.Size(225, 25);
            labelNome.ForeColor = ColorTranslator.FromHtml("#5271FF");
            fonte = new Font("IBM Plex Sans", 14, FontStyle.Bold);
            labelOla.Font = fonte;

            labelSeusRelatos = new Label();
            labelSeusRelatos.Text = "SEUS RELATOS";
            labelSeusRelatos.Location = new System.Drawing.Point(870, 262);
            labelSeusRelatos.Size = new System.Drawing.Size(115, 30);
            labelSeusRelatos.ForeColor = Color.Gray;
            labelSeusRelatos.TextAlign = ContentAlignment.MiddleCenter;
            fonte = new Font("IBM Plex Sans", 9, FontStyle.Bold);
            labelSeusRelatos.Font = fonte;

            buttonEditarPerfil = new Button();
            buttonEditarPerfil.Text = "EDITAR PERFIL                                                >";
            buttonEditarPerfil.Location = new System.Drawing.Point(725, 200);
            buttonEditarPerfil.Size = new System.Drawing.Size(400, 30);
            buttonEditarPerfil.BackColor = Color.White;
            buttonEditarPerfil.ForeColor = Color.Gray;
            fonte = new Font("IBM Plex Sans", 12, FontStyle.Bold);
            buttonEditarPerfil.Font = fonte;
            buttonEditarPerfil.TextAlign = ContentAlignment.MiddleCenter;

            buttonInicio = new Button();
            buttonInicio.Text = "INÍCIO";
            buttonInicio.Location = new System.Drawing.Point(700, 808);
            buttonInicio.Size = new System.Drawing.Size(225, 50);
            buttonInicio.BackColor = Color.White;
            buttonInicio.ForeColor = ColorTranslator.FromHtml("#5271FF");
            fonte = new Font("Garet", 14, FontStyle.Bold);
            buttonInicio.Font = fonte;
            buttonInicio.TextAlign = ContentAlignment.MiddleCenter;

            buttonRelatar = new Button();
            buttonRelatar.Text = "RELATAR";
            buttonRelatar.Location = new System.Drawing.Point(925, 808);
            buttonRelatar.Size = new System.Drawing.Size(225, 50);
            buttonRelatar.BackColor = Color.White;
            buttonRelatar.ForeColor = ColorTranslator.FromHtml("#5271FF");
            fonte = new Font("Garet", 14, FontStyle.Bold);
            buttonRelatar.Font = fonte;
            buttonRelatar.TextAlign = ContentAlignment.MiddleCenter;

            buttonEditarPerfil.Click += buttonEditarPerfil_Click;
            buttonInicio.Click += buttonInicio_Click;
            buttonRelatar.Click += buttonRelatar_Click;

            Controls.Add(panel);
            Controls.Add(labelDivisao1);
            Controls.Add(labelDivisao2);
            Controls.Add(labelLinha1);     
            Controls.Add(labelLinha2);           
            Controls.Add(labelOla);
            Controls.Add(labelNome);
            Controls.Add(pictureBoxFoto);
            Controls.Add(labelSeusRelatos);
            Controls.Add(textPostagens);
            Controls.Add(buttonEditarPerfil);
            Controls.Add(buttonInicio);
            Controls.Add(buttonRelatar);
            Controls.Add(labelLinha3);
            Controls.Add(labelFundo);
        }

        private void buttonEditarPerfil_Click(object sender, EventArgs e) {
            Alterar alterar = new Alterar();
            alterar.Show();
            this.Hide();
        }

        private void buttonInicio_Click(object sender, EventArgs e) {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Hide();
        }

        private void buttonRelatar_Click(object sender, EventArgs e) {
            TelaRelatar telaRelatar = new TelaRelatar();
            telaRelatar.Show();
            this.Hide();
        }

    }

}