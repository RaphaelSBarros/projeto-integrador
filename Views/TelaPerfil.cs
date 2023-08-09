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
            Models.Usuario usuarioconectado = Controllers.UsuarioController.ListarUsuarioConectado();

            this.Icon = new Icon("Layout/Resolville.ico");
            this.Text = "Resolville";
            this.WindowState = FormWindowState.Maximized;
            InfoInicial.AdicionarTelaBasica(this);

            labelLinha3 = new Label();
            labelLinha3.Text = "";
            labelLinha3.Location = new System.Drawing.Point(700, 275);
            labelLinha3.Size = new System.Drawing.Size(450, 5);
            labelLinha3.BackColor = Color.Gray;
            labelLinha3.SendToBack();

            pictureBoxFoto = new PictureBox();
            pictureBoxFoto.Location = new System.Drawing.Point(700, 50);
            pictureBoxFoto.Size = new System.Drawing.Size(80, 80);

            if(usuarioconectado.Foto == null){
                pictureBoxFoto.Image = Image.FromFile("Layout/FotoUsuario.png");
            }else{
                pictureBoxFoto.Image = InfoInicial.ByteArrayToImage(usuarioconectado.Foto);
            }
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;

            textPostagens = new TextBox();
            textPostagens.Location = new System.Drawing.Point(700, 295);
            textPostagens.Size = new System.Drawing.Size(450, 495);
            textPostagens.Multiline = true;
            textPostagens.ScrollBars = ScrollBars.Vertical;

            labelSeusRelatos = new Label();
            labelSeusRelatos.Text = "SEUS RELATOS";
            labelSeusRelatos.Location = new System.Drawing.Point(870, 262);
            labelSeusRelatos.Size = new System.Drawing.Size(115, 30);
            labelSeusRelatos.ForeColor = Color.Gray;
            labelSeusRelatos.TextAlign = ContentAlignment.MiddleCenter;
            labelSeusRelatos.Font = InfoInicial.fonteTexto2;

            buttonEditarPerfil = new Button();
            buttonEditarPerfil.Text = "EDITAR PERFIL                                                >";
            buttonEditarPerfil.Location = new System.Drawing.Point(725, 200);
            buttonEditarPerfil.Size = new System.Drawing.Size(400, 30);
            buttonEditarPerfil.BackColor = Color.White;
            buttonEditarPerfil.ForeColor = Color.Gray;
            buttonEditarPerfil.Font = InfoInicial.fonteTexto2;
            buttonEditarPerfil.TextAlign = ContentAlignment.MiddleCenter;

            buttonInicio = new Button();
            buttonInicio.Text = "INÍCIO";
            buttonInicio.Location = new System.Drawing.Point(700, 808);
            buttonInicio.Size = new System.Drawing.Size(225, 50);
            buttonInicio.BackColor = Color.White;
            buttonInicio.ForeColor = ColorTranslator.FromHtml("#5271FF");
            buttonInicio.Font = InfoInicial.fonteTitulo;
            buttonInicio.TextAlign = ContentAlignment.MiddleCenter;

            buttonRelatar = new Button();
            buttonRelatar.Text = "RELATAR";
            buttonRelatar.Location = new System.Drawing.Point(925, 808);
            buttonRelatar.Size = new System.Drawing.Size(225, 50);
            buttonRelatar.BackColor = Color.White;
            buttonRelatar.ForeColor = ColorTranslator.FromHtml("#5271FF");
            buttonRelatar.Font = InfoInicial.fonteTitulo;
            buttonRelatar.TextAlign = ContentAlignment.MiddleCenter;

            buttonEditarPerfil.Click += buttonEditarPerfil_Click;
            buttonInicio.Click += buttonInicio_Click;
            buttonRelatar.Click += buttonRelatar_Click;

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