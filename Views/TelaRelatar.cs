using System;
using System.Windows.Forms;

namespace Views {

    public class TelaRelatar : Form {
        private Label labelFundo;
        private Label labelDivisao1;
        private Label labelDivisao2;
        private Label labelLinha1;
        private Label labelLinha2;
        private Label labelTipoProblemaErro;
        private Label labelBairroProblemaErro;
        private Label labelLogradouroProblemaErro;
        private Label labelDescricaoProblemaErro;
        private Label labelFoto;
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

            labelOla = new Label();
            labelOla.Text = "Olá";
            labelOla.Location = new System.Drawing.Point(790, 80);
            labelOla.Size = new System.Drawing.Size(41, 25);
            labelOla.ForeColor = ColorTranslator.FromHtml("#5271FF");
            Font fonte = new Font("IBM Plex Sans", 12, FontStyle.Bold);
            labelOla.Font = fonte;

            labelNome = new Label();
            labelNome.Text = "";
            labelNome.Location = new System.Drawing.Point(830, 80);
            labelNome.Size = new System.Drawing.Size(225, 25);
            labelNome.ForeColor = ColorTranslator.FromHtml("#5271FF");
            fonte = new Font("IBM Plex Sans", 12, FontStyle.Bold);
            labelOla.Font = fonte;           

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
            labelFoto.Text = "";
            labelFoto.Image = Image.FromFile("Layout/FotoUsuario.png");
            labelFoto.Location = new System.Drawing.Point(700, 50);
            labelFoto.Size = new System.Drawing.Size(80, 80);
            labelFoto.BackgroundImageLayout = ImageLayout.Zoom;          

            labelEscrevaRelato = new Label();
            labelEscrevaRelato.Text = "     ESCREVA SEU RELATO DE PROBLEMA";
            labelEscrevaRelato.Location = new System.Drawing.Point(730, 185);
            labelEscrevaRelato.Size = new System.Drawing.Size(400, 25);
            labelEscrevaRelato.ForeColor = ColorTranslator.FromHtml("#7ed957");
            fonte = new Font("IBM Plex Sans", 12, FontStyle.Bold);
            labelEscrevaRelato.Font = fonte;

            labelTipoProblema = new Label();
            labelTipoProblema.Text = "Selecione o tipo de problema";
            labelTipoProblema.Location = new System.Drawing.Point(725, 230);
            labelTipoProblema.Size = new System.Drawing.Size(400, 20);
            labelTipoProblema.ForeColor = ColorTranslator.FromHtml("#4B4B4B");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelTipoProblema.Font = fonte;


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
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelBairroProblema.Font = fonte;


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
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelLogradouroProblema.Font = fonte;


            textBoxLogradouroProblema = new TextBox();
            textBoxLogradouroProblema.Name = "Logradouro";
            textBoxLogradouroProblema.Location = new System.Drawing.Point(725, 370);
            textBoxLogradouroProblema.Size = new System.Drawing.Size(400, 100);

            labelDescricaoProblema = new Label();
            labelDescricaoProblema.Text = "Escreva um ponto de referência e descrição para o problema";
            labelDescricaoProblema.Location = new System.Drawing.Point(725, 410);
            labelDescricaoProblema.Size = new System.Drawing.Size(400, 20);
            labelDescricaoProblema.ForeColor = ColorTranslator.FromHtml("#4B4B4B");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelDescricaoProblema.Font = fonte;


            textBoxDescricaoProblema = new TextBox();
            textBoxDescricaoProblema.Multiline = true;
            textBoxDescricaoProblema.Name = "Descricao";
            textBoxDescricaoProblema.Location = new System.Drawing.Point(725, 430);
            textBoxDescricaoProblema.Size = new System.Drawing.Size(400, 150);
            textBoxDescricaoProblema.MaxLength = 576;

            labelFotoProblema = new Label();
            labelFotoProblema.Text = "Anexe uma imagem do problema (opcional)";
            labelFotoProblema.Location = new System.Drawing.Point(725, 600);
            labelFotoProblema.Size = new System.Drawing.Size(400, 20);
            labelFotoProblema.ForeColor = ColorTranslator.FromHtml("#4B4B4B");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelFotoProblema.Font = fonte;


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
            buttonRelatar.BackColor = ColorTranslator.FromHtml("#5271FF");
            buttonRelatar.ForeColor = Color.White;
            fonte = new Font("Garet", 14, FontStyle.Bold);
            buttonRelatar.Font = fonte;
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
            fonte = new Font("Garet", 12, FontStyle.Bold);
            buttonEnviarRelato.Font = fonte;

            labelFoto.Click += labelFoto_Click;
            textBoxDescricaoProblema.TextChanged += textBoxDescricaoProblema_TextChanged;
            buttonEnviarRelato.Click += buttonEnviarRelato_Click;
            buttonEnviarRelato.MouseEnter += buttonEnviarRelato_MouseEnter;
            buttonEnviarRelato.MouseLeave += buttonEnviarRelato_MouseLeave;
            buttonInicio.Click += buttonInicio_Click;
            buttonFotoProblema.Click += buttonFotoProblema_Click;
            buttonFotoProblema.MouseEnter += buttonFotoProblema_MouseEnter;
            buttonFotoProblema.MouseLeave += buttonFotoProblema_MouseLeave;

            Controls.Add(panel);
            Controls.Add(labelDivisao1);
            Controls.Add(labelDivisao2);
            Controls.Add(labelOla);
            Controls.Add(labelNome);
            Controls.Add(labelLinha1);
            Controls.Add(labelLinha2); 
            Controls.Add(labelFoto);           
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
            Controls.Add(labelFundo);
            
        }

        private void labelFoto_Click(object sender, EventArgs e) {
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
            string logradouro, outros_problemas, observacao, data;
            Image foto;

            string tipoProblema, bairroProblema, logradouroProblema, descricaoProblema;
            List<string> errors = new List<string>();

            labelTipoProblemaErro.Text = "";
            labelBairroProblemaErro.Text = "";
            labelLogradouroProblemaErro.Text = "";
            labelDescricaoProblemaErro.Text = "";

            if (string.IsNullOrEmpty(comboBoxTipoProblema.Text)) {
                labelTipoProblemaErro.Text = "Campo Obrigatório*";
                errors.Add("TipoProblema Completo é obrigatório*");
            } else if (comboBoxTipoProblema.Text.Length < 2 || comboBoxTipoProblema.Text.Length > 80) {
                labelTipoProblemaErro.Text = "Sintaxe Incorreta*";
                errors.Add("TipoProblema Completo deve ter entre 2 e 80 caracteres");
            }

            if (string.IsNullOrEmpty(comboBoxBairroProblema.Text)) {
                labelBairroProblemaErro.Text = "Campo Obrigatório*";
                errors.Add("Nome Completo é obrigatório*");
            } else if (comboBoxBairroProblema.Text.Length < 2 || comboBoxBairroProblema.Text.Length > 80) {
                labelBairroProblemaErro.Text = "Sintaxe Incorreta*";
                errors.Add("Nome Completo deve ter entre 2 e 80 caracteres");
            }

            if (string.IsNullOrEmpty(textBoxLogradouroProblema.Text)) {
                labelLogradouroProblemaErro.Text = "Campo Obrigatório*";
                errors.Add("Nome Completo é obrigatório*");
            } else if (textBoxLogradouroProblema.Text.Length < 2 || textBoxLogradouroProblema.Text.Length > 80) {
                labelLogradouroProblemaErro.Text = "Sintaxe Incorreta*";
                errors.Add("Nome Completo deve ter entre 2 e 80 caracteres");
            } 

            if (string.IsNullOrEmpty(textBoxDescricaoProblema.Text)) {
                labelDescricaoProblemaErro.Text = "Campo Obrigatório*";
                errors.Add("Nome Completo é obrigatório*");
            } else if (textBoxDescricaoProblema.Text.Length < 2 || textBoxDescricaoProblema.Text.Length > 80) {
                labelDescricaoProblemaErro.Text = "Sintaxe Incorreta*";
                errors.Add("Nome Completo deve ter entre 2 e 80 caracteres");
            } 

            if (errors.Count > 0) {
                return;
            }

            comboBoxTipoProblema.Text = "";
                comboBoxBairroProblema.Text = "";
                textBoxLogradouroProblema.Text = "";
                textBoxDescricaoProblema.Text = "";
        
                MessageBox.Show(
                    "Postagem realizada com sucesso!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK
                );
        }

        private void buttonEnviarRelato_MouseEnter(object sender, EventArgs e) {
            buttonEnviarRelato.BackColor = Color.PaleGreen;
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