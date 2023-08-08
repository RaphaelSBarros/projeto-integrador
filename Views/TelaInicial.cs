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
            Models.Usuario usuarioconectado = Controllers.UsuarioController.ListarUsuarioConectado();
            
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
            labelOla.Text = "Olá " + usuarioconectado.Nome_Usuario + "!";
            labelOla.Location = new System.Drawing.Point(790, 80);
            labelOla.Size = new System.Drawing.Size(225, 25);
            labelOla.ForeColor = ColorTranslator.FromHtml("#5271FF");
            Font fonte = new Font("Arial", 14, FontStyle.Bold);
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