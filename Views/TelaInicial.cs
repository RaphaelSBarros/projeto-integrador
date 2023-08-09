using System;
using System.Windows.Forms;

namespace Views {

    public class TelaInicial : Form {
        private Models.Postagem postagem;
        private PictureBox pictureBoxFoto;
        private ListBox textPostagens;
        private Button buttonInicio;
        private Button buttonRelatar;        

        public TelaInicial() {
            Controllers.PostagemController.Sincronizar();
            Models.Usuario usuarioconectado = Controllers.UsuarioController.ListarUsuarioConectado();
            List<Models.Postagem> postagens = Controllers.PostagemController.ListarPostagens();

            this.Icon = new Icon("Layout/Resolville.ico");
            this.Text = "Resolville";
            this.WindowState = FormWindowState.Maximized;
            
            InfoInicial.AdicionarTelaBasica(this);

            Panel flowLayoutPanel = new Panel();
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new System.Drawing.Point(700, 170);
            flowLayoutPanel.Size = new System.Drawing.Size(450, 615);

            int y = 170;

            foreach(Models.Postagem postagem in postagens){
                InfoInicial.AdicionarPostagem(flowLayoutPanel, postagem, y);
                y += 220;
            }
            
            PictureBox pictureBoxFoto = new PictureBox();
            pictureBoxFoto.Location = new System.Drawing.Point(700, 50);
            pictureBoxFoto.Size = new System.Drawing.Size(80, 80);
            if(usuarioconectado.Foto == null){
                pictureBoxFoto.Image = Image.FromFile("Layout/FotoUsuario.png");
            }else{
                pictureBoxFoto.Image = InfoInicial.ByteArrayToImage(usuarioconectado.Foto);
            }
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;

            buttonInicio = new Button();
            buttonInicio.Text = "INÍCIO";
            buttonInicio.Location = new System.Drawing.Point(700, 808);
            buttonInicio.Size = new System.Drawing.Size(225, 50);
            buttonInicio.BackColor = ColorTranslator.FromHtml("#5271FF");
            buttonInicio.ForeColor = Color.White;
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

            pictureBoxFoto.Click += pictureBoxFoto_Click;
            buttonRelatar.Click += buttonRelatar_Click;

            Controls.Add(flowLayoutPanel);
            Controls.Add(pictureBoxFoto);
            Controls.Add(buttonInicio);
            Controls.Add(textPostagens);
            Controls.Add(buttonRelatar);
        }

        /*private void postagem() {
            private PictureBox pictureBoxFotoUsuario;
            private Label labelNomeUsuario;
            private Label labelData;
            private Label labelTitulo;
            private Label labelDescricao;          
        }*/

        // private void cu()
        // {
        //     int y = 10; // posição y inicial
        //     // foreach (Postagem postagem in postagens)
        //     // {
        //         // criar um novo PictureBox
        //         PictureBox pictureBoxFotoUsuario = new PictureBox();
        //         pictureBoxFotoUsuario.Location = new Point(10, y);
        //         pictureBoxFotoUsuario.Size = new Size(50, 50);
        //         // pictureBoxFotoUsuario.Image = postagem.Imagem;

        //         // criar um novo Label para o nome do usuário
        //         Label labelNomeUsuario = new Label();
        //         labelNomeUsuario.Location = new Point(70, y);
        //         labelNomeUsuario.Size = new Size(200, 20);
        //         // labelNomeUsuario.Text = postagem.NomeUsuario;

        //         // criar um novo Label para a data
        //         Label labelData = new Label();
        //         labelData.Location = new Point(70, y + 20);
        //         labelData.Size = new Size(200, 20);
        //         // labelData.Text = postagem.Data.ToString("dd/MM/yyyy");

        //         // criar um novo Label para o título
        //         Label labelTitulo = new Label();
        //         labelTitulo.Location = new Point(10, y + 50);
        //         labelTitulo.Size = new Size(260, 20);
        //         labelTitulo.Font = new Font(labelTitulo.Font, FontStyle.Bold);
        //         // labelTitulo.Text = postagem.Titulo;

        //         // criar um novo Label para a descrição
        //         Label labelDescricao = new Label();
        //         labelDescricao.Location = new Point(10, y + 70);
        //         labelDescricao.Size = new Size(260, 40);
        //         // labelDescricao.Text = postagem.Descricao;

        //         // adicionar os controles ao formulário ou painel
        //         this.Controls.Add(pictureBoxFotoUsuario);
        //         this.Controls.Add(labelNomeUsuario);
        //         this.Controls.Add(labelData);
        //         this.Controls.Add(labelTitulo);
        //         this.Controls.Add(labelDescricao);

        //         // y += 120; // incrementar a posição y para o próximo item
        //     }

        private void pictureBoxFoto_Click(object sender, EventArgs e) {
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