using System;
using System.Windows.Forms;

namespace Views {

    public class TelaRelatar : Form {
        private Models.Usuario usuarioconectado = Controllers.UsuarioController.ListarUsuarioConectado();
        private Label labelFundo;
        private Label labelDivisao1;
        private Label labelDivisao2;
        private Label labelLinha1;
        private Label labelLinha2;
        private Label labelTipoProblemaErro;
        private Label labelBairroProblemaErro;
        private Label labelLogradouroProblemaErro;
        private Label labelDescricaoProblemaErro;
        private PictureBox pictureBoxFoto;
        private Label labelOla;
        private Label labelNome;        
        private Label labelEscrevaRelato;
        private Label labelTipoProblema;
        private Label labelBairroProblema;
        private Label labelLogradouroProblema;
        private Label labelDescricaoProblema;
        private Label labelFotoProblema;
        private TextBox textBoxLogradouroProblema;
        private TextBox textBoxDescricaoProblema;
        private ComboBox comboBoxTipoProblema;
        private ComboBox comboBoxBairroProblema;
        private Button buttonInicio;
        private Button buttonRelatar;
        private Button buttonFotoProblema;
        private Button buttonEnviarRelato;

        public TelaRelatar() {
            Controllers.Tipo_ProblemaController.Sincronizar();
            Controllers.BairroController.Sincronizar();

            this.Icon = new Icon("Layout/Resolville.ico");
            this.Text = "Resolville";
            this.WindowState = FormWindowState.Maximized;
            InfoInicial.AdicionarTelaBasica(this);

            pictureBoxFoto = new PictureBox();
            pictureBoxFoto.Location = new System.Drawing.Point(700, 50);
            pictureBoxFoto.Size = new System.Drawing.Size(80, 80);
            if(usuarioconectado.Foto == null){
                pictureBoxFoto.Image = Image.FromFile("Layout/FotoUsuario.png");
            }else{
                pictureBoxFoto.Image = InfoInicial.ByteArrayToImage(usuarioconectado.Foto);
            }
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;

            labelEscrevaRelato = new Label();
            labelEscrevaRelato.Text = "     ESCREVA SEU RELATO DE PROBLEMA";
            labelEscrevaRelato.Location = new System.Drawing.Point(730, 185);
            labelEscrevaRelato.Size = new System.Drawing.Size(400, 25);
            labelEscrevaRelato.ForeColor = ColorTranslator.FromHtml("#7ed957");
            labelEscrevaRelato.Font = InfoInicial.fonteTexto2;

            labelTipoProblema = new Label();
            labelTipoProblema.Text = "Selecione o tipo de problema";
            labelTipoProblema.Location = new System.Drawing.Point(725, 230);
            labelTipoProblema.Size = new System.Drawing.Size(400, 20);
            labelTipoProblema.ForeColor = ColorTranslator.FromHtml("#4B4B4B");
            labelTipoProblema.Font = InfoInicial.fontTexto2Small;

            comboBoxTipoProblema = new ComboBox();
            comboBoxTipoProblema.Text = "Tipo de Problema";
            comboBoxTipoProblema.Location = new System.Drawing.Point(725, 250);
            comboBoxTipoProblema.Size = new System.Drawing.Size(400, 20);
            comboBoxTipoProblema.ForeColor = Color.Gray;
            this.GetTipoProblema();

            labelBairroProblema = new Label();
            labelBairroProblema.Text = "Selecione o bairro do problema";
            labelBairroProblema.Location = new System.Drawing.Point(725, 290);
            labelBairroProblema.Size = new System.Drawing.Size(400, 20);
            labelBairroProblema.ForeColor = ColorTranslator.FromHtml("#4B4B4B");
            labelBairroProblema.Font = InfoInicial.fontTexto2Small;

            comboBoxBairroProblema = new ComboBox();
            comboBoxBairroProblema.Text = "Bairro do Problema";
            comboBoxBairroProblema.Location = new System.Drawing.Point(725, 310);
            comboBoxBairroProblema.Size = new System.Drawing.Size(400, 20);
            comboBoxBairroProblema.ForeColor = Color.Gray; 
            this.GetBairros();

            labelLogradouroProblema = new Label();
            labelLogradouroProblema.Text = "Escreva o logradouro (Rua) do problema";
            labelLogradouroProblema.Location = new System.Drawing.Point(725, 350);
            labelLogradouroProblema.Size = new System.Drawing.Size(400, 20);
            labelLogradouroProblema.ForeColor = ColorTranslator.FromHtml("#4B4B4B");
            labelLogradouroProblema.Font = InfoInicial.fontTexto2Small;

            textBoxLogradouroProblema = new TextBox();
            textBoxLogradouroProblema.Name = "Logradouro";
            textBoxLogradouroProblema.Location = new System.Drawing.Point(725, 370);
            textBoxLogradouroProblema.Size = new System.Drawing.Size(400, 100);

            labelDescricaoProblema = new Label();
            labelDescricaoProblema.Text = "Escreva um ponto de referência e descrição";
            labelDescricaoProblema.Location = new System.Drawing.Point(725, 410);
            labelDescricaoProblema.Size = new System.Drawing.Size(400, 20);
            labelDescricaoProblema.ForeColor = ColorTranslator.FromHtml("#4B4B4B");
            labelDescricaoProblema.Font = InfoInicial.fontTexto2Small;

            textBoxDescricaoProblema = new TextBox();
            textBoxDescricaoProblema.Multiline = true;
            textBoxDescricaoProblema.ScrollBars = ScrollBars.Vertical;
            textBoxDescricaoProblema.Name = "Descricao";
            textBoxDescricaoProblema.Location = new System.Drawing.Point(725, 430);
            textBoxDescricaoProblema.Size = new System.Drawing.Size(400, 150);
            textBoxDescricaoProblema.AutoSize = false;
            textBoxDescricaoProblema.MaxLength = 576;

            labelFotoProblema = new Label();
            labelFotoProblema.Text = "Anexe uma imagem do problema (opcional)";
            labelFotoProblema.Location = new System.Drawing.Point(725, 600);
            labelFotoProblema.Size = new System.Drawing.Size(400, 20);
            labelFotoProblema.ForeColor = ColorTranslator.FromHtml("#4B4B4B");
            labelFotoProblema.Font = InfoInicial.fontTexto2Small;

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
            buttonRelatar.BackColor = ColorTranslator.FromHtml("#5271FF");
            buttonRelatar.ForeColor = Color.White;
            buttonRelatar.Font = InfoInicial.fonteTitulo;
            buttonRelatar.TextAlign = ContentAlignment.MiddleCenter;

            buttonFotoProblema = new Button();
            buttonFotoProblema.Location = new System.Drawing.Point(725, 620); 
            buttonFotoProblema.Size = new System.Drawing.Size(400, 120);
            buttonFotoProblema.Name = "Selecionar Imagem";
            buttonFotoProblema.Text = "SELECIONAR IMAGEM";
            buttonFotoProblema.ForeColor = Color.Gray; 
            buttonFotoProblema.BackgroundImageLayout = ImageLayout.Zoom;

            buttonEnviarRelato = new Button();
            buttonEnviarRelato.Text = "ENVIAR RELATO";
            buttonEnviarRelato.Location = new System.Drawing.Point(775, 750);
            buttonEnviarRelato.Size = new System.Drawing.Size(300, 30);
            buttonEnviarRelato.BackColor = ColorTranslator.FromHtml("#7ed957");
            buttonEnviarRelato.ForeColor = Color.White;
            buttonEnviarRelato.Font = InfoInicial.fonteTitulo;

            textBoxDescricaoProblema.Enter += textBoxDescricaoProblema_Enter;
            textBoxDescricaoProblema.Leave += textBoxDescricaoProblema_Leave;
            pictureBoxFoto.Click += pictureBoxFoto_Click;
            textBoxDescricaoProblema.TextChanged += textBoxDescricaoProblema_TextChanged;
            buttonEnviarRelato.Click += buttonEnviarRelato_Click;
            buttonEnviarRelato.MouseEnter += buttonEnviarRelato_MouseEnter;
            buttonEnviarRelato.MouseLeave += buttonEnviarRelato_MouseLeave;
            buttonInicio.Click += buttonInicio_Click;
            buttonFotoProblema.Click += buttonFotoProblema_Click;
            buttonFotoProblema.MouseEnter += buttonFotoProblema_MouseEnter;
            buttonFotoProblema.MouseLeave += buttonFotoProblema_MouseLeave;

            textBoxDescricaoProblema.ShortcutsEnabled = false;

            Controls.Add(pictureBoxFoto);           
            Controls.Add(labelEscrevaRelato);
            Controls.Add(labelTipoProblemaErro);
            Controls.Add(labelBairroProblemaErro);
            Controls.Add(labelLogradouroProblemaErro);
            Controls.Add(labelDescricaoProblemaErro);
            Controls.Add(labelTipoProblema);
            Controls.Add(labelBairroProblema);
            Controls.Add(labelLogradouroProblema);
            Controls.Add(labelDescricaoProblema);
            Controls.Add(labelFotoProblema);
            Controls.Add(textBoxLogradouroProblema);
            Controls.Add(textBoxDescricaoProblema);
            Controls.Add(comboBoxTipoProblema);
            Controls.Add(comboBoxBairroProblema);
            Controls.Add(buttonInicio);
            Controls.Add(buttonRelatar);
            Controls.Add(buttonFotoProblema);
            Controls.Add(buttonEnviarRelato);       
        }

        private void textBoxDescricaoProblema_Enter(object sender, EventArgs e) {
            textBoxDescricaoProblema.Size = new Size(400, 150);
        }

        private void textBoxDescricaoProblema_Leave(object sender, EventArgs e) {
            textBoxDescricaoProblema.Size = new Size(400, 150);
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e) {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.Show();
            this.Hide();
        }

        private void textBoxDescricaoProblema_TextChanged(object sender, EventArgs e) {
            int linhaAtual = textBoxDescricaoProblema.GetLineFromCharIndex(textBoxDescricaoProblema.TextLength) + 1;
            int linhaHeight = textBoxDescricaoProblema.Font.Height;
            int novaAltura = linhaHeight * linhaAtual + 4;
            textBoxDescricaoProblema.Height = novaAltura;           
        }

        private void buttonEnviarRelato_Click(object sender, EventArgs e) { // FAZER
            int fk_id_usuario, fk_code_problema, fk_id_bairro;
            string logradouro, outros_problemas, observacao;
            Image foto;

            // List<string> errors = new List<string>();

            // // IF AQUI
            // fk_id_usuario = 1;
            // fk_code_problema = 
            // foto = buttonFotoProblema.Image;

            // if (comboBoxTipoProblema.Text == "Tipo de Problema") {
            //     labelTipoProblemaErro.Text = "Campo Obrigatório*";
            //     errors.Add("TipoProblema Completo é obrigatório*");
            // }

            // if (comboBoxBairroProblema.Text == "Bairro do Problema") {
            //     labelBairroProblemaErro.Text = "Campo Obrigatório*";
            //     errors.Add("Nome Completo é obrigatório*");
            // }

            // if (string.IsNullOrEmpty(comboBoxTipoProblema.Text)) {
            //     labelTipoProblemaErro.Text = "Campo Obrigatório*";
            //     errors.Add("TipoProblema Completo é obrigatório*");
            // } else if (comboBoxTipoProblema.Text.Length < 2 || comboBoxTipoProblema.Text.Length > 80) {
            //     labelTipoProblemaErro.Text = "Sintaxe Incorreta*";
            //     errors.Add("TipoProblema Completo deve ter entre 2 e 80 caracteres");
            // }

            // if (string.IsNullOrEmpty(comboBoxBairroProblema.Text)) {
            //     labelBairroProblemaErro.Text = "Campo Obrigatório*";
            //     errors.Add("Nome Completo é obrigatório*");
            // } else if (comboBoxBairroProblema.Text.Length < 2 || comboBoxBairroProblema.Text.Length > 80) {
            //     labelBairroProblemaErro.Text = "Sintaxe Incorreta*";
            //     errors.Add("Nome Completo deve ter entre 2 e 80 caracteres");
            // }

            // if (string.IsNullOrEmpty(textBoxLogradouroProblema.Text)) {
            //     labelLogradouroProblemaErro.Text = "Campo Obrigatório*";
            //     errors.Add("Nome Completo é obrigatório*");
            // } else if (textBoxLogradouroProblema.Text.Length < 2 || textBoxLogradouroProblema.Text.Length > 80) {
            //     labelLogradouroProblemaErro.Text = "Sintaxe Incorreta*";
            //     errors.Add("Nome Completo deve ter entre 2 e 80 caracteres");
            // } 

            // comboBoxTipoProblema.Text = "";
            // comboBoxBairroProblema.Text = "";
            // textBoxLogradouroProblema.Text = "";
            // textBoxDescricaoProblema.Text = "";

            if(comboBoxTipoProblema.Text != "" && comboBoxBairroProblema.Text != "" && textBoxDescricaoProblema.Text != ""){
                fk_id_usuario = usuarioconectado.ID_Usuario;
                fk_code_problema = comboBoxTipoProblema.FindString(comboBoxTipoProblema.Text); // INDEX DO PROBLEMA
                fk_id_bairro = comboBoxBairroProblema.FindString(comboBoxBairroProblema.Text); // INDEX DO BAIRRO
                logradouro = textBoxLogradouroProblema.Text;
                observacao = textBoxDescricaoProblema.Text;
                foto = buttonFotoProblema.Image;

                Controllers.PostagemController.AddPostagem(fk_id_usuario, fk_code_problema+1, fk_id_bairro+1, logradouro, observacao, InfoInicial.ImageToByteArray(foto));

                comboBoxTipoProblema.Text = "";
                comboBoxBairroProblema.Text = "";
                textBoxLogradouroProblema.Text = "";
                textBoxDescricaoProblema.Text = "";
        
                MessageBox.Show(
                    "Postagem realizada com sucesso!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK
                );
            }else{
                MessageBox.Show(
                    "ERRO: Preencha todos os campos necessários!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK
                );
            }
        }

        private void buttonEnviarRelato_MouseEnter(object sender, EventArgs e) {
            buttonEnviarRelato.BackColor = ColorTranslator.FromHtml("#6dbb4c");
        }

        private void buttonEnviarRelato_MouseLeave(object sender, EventArgs e) {
            buttonEnviarRelato.BackColor = ColorTranslator.FromHtml("#7ed957");
        }

        private void buttonInicio_Click(object sender, EventArgs e) {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Hide();
        }

        private void buttonFotoProblema_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Selecione uma Imagem";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = openFileDialog.FileName;

                if (File.Exists(filePath)) {
                    try {
                        Image imagemSelecionada = Image.FromFile(filePath);
                        buttonFotoProblema.Image = imagemSelecionada;
                    } catch (Exception ex) when (ex is OutOfMemoryException || ex is FileNotFoundException) {
                        MessageBox.Show("Erro ao abrir a imagem: Arquivo inválido ou não é uma imagem suportada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("O arquivo selecionado não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void buttonFotoProblema_MouseEnter(object sender, EventArgs e ) {
            buttonFotoProblema.BackColor = Color.LightGray;
        }

        private void buttonFotoProblema_MouseLeave(object sender, EventArgs e ) {
            buttonFotoProblema.BackColor = Color.White;
        }

        private void GetBairros() {
            List<Models.Bairro> bairros = Controllers.BairroController.ListarBairros();

            comboBoxBairroProblema.Items.Clear();
            foreach (var bairro in bairros)
            {
                comboBoxBairroProblema.Items.Add(bairro.Bairro_Nome);
            }
        }

        private void GetTipoProblema(){
            List<Models.Tipo_Problema> tipo_problema = Controllers.Tipo_ProblemaController.ListarProblemas();

            comboBoxTipoProblema.Items.Clear();
            foreach(var problema in tipo_problema)
            {
                comboBoxTipoProblema.Items.Add(problema.Problema_Nome);
            }
        }
    }
}