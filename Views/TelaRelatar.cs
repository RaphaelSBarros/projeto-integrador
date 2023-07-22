using System;
using System.Windows.Forms;

namespace Views {

    public class TelaRelatar : Form {
        private Label labelFundo;
        private Label labelDivisao1;
        private Label labelDivisao2;
        private Label labelLinha1;
        private Label labelLinha2;
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
        private PictureBox pictureBoxFotoUsuario;
        private PictureBox pictureBoxProblema;
        private Button buttonEnviarRelato;

        public TelaRelatar() {
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

            labelFundo = new Label();
            labelFundo.Location = new System.Drawing.Point(650, 0);
            labelFundo.Size = new System.Drawing.Size(550, 970);
            labelFundo.BackColor = Color.LightGray;
            labelFundo.SendToBack();

            labelOla = new Label();
            labelOla.Text = "Olá";
            labelOla.Location = new System.Drawing.Point(790, 80);
            labelOla.Size = new System.Drawing.Size(38, 25);
            labelOla.ForeColor = Color.Blue;
            Font fonte = new Font("Arial", 14, FontStyle.Bold);
            labelOla.Font = fonte;

            labelNome = new Label();
            labelNome.Text = "";
            labelNome.Location = new System.Drawing.Point(830, 80);
            labelNome.Size = new System.Drawing.Size(225, 25);
            labelNome.ForeColor = Color.Blue;
            fonte = new Font("Arial", 14, FontStyle.Bold);
            labelOla.Font = fonte;           

            labelLinha1 = new Label();
            labelLinha1.Text = "";
            labelLinha1.Location = new System.Drawing.Point(700, 150);
            labelLinha1.Size = new System.Drawing.Size(450, 8);
            labelLinha1.BackColor = Color.Blue;

            labelLinha2 = new Label();
            labelLinha2.Text = "";
            labelLinha2.Location = new System.Drawing.Point(700, 800);
            labelLinha2.Size = new System.Drawing.Size(450, 8);
            labelLinha2.BackColor = Color.Blue;           

            labelEscrevaRelato = new Label();
            labelEscrevaRelato.Text = "ESCREVA SEU RELATO DE PROBLEMA";
            labelEscrevaRelato.Location = new System.Drawing.Point(730, 185);
            labelEscrevaRelato.Size = new System.Drawing.Size(400, 25);
            labelEscrevaRelato.ForeColor = Color.LimeGreen;
            fonte = new Font("Arial", 15, FontStyle.Bold);
            labelEscrevaRelato.Font = fonte;

            labelTipoProblema = new Label();
            labelTipoProblema.Text = "Selecione o tipo de problema";
            labelTipoProblema.Location = new System.Drawing.Point(725, 230);
            labelTipoProblema.Size = new System.Drawing.Size(400, 20);

            comboBoxTipoProblema = new ComboBox();
            comboBoxTipoProblema.Text = "Tipo de Problema";
            comboBoxTipoProblema.Location = new System.Drawing.Point(725, 250);
            comboBoxTipoProblema.Size = new System.Drawing.Size(400, 20);
            comboBoxTipoProblema.ForeColor = Color.Gray;

            labelBairroProblema = new Label();
            labelBairroProblema.Text = "Selecione o bairro do problema";
            labelBairroProblema.Location = new System.Drawing.Point(725, 290);
            labelBairroProblema.Size = new System.Drawing.Size(400, 20);

            comboBoxBairroProblema = new ComboBox();
            comboBoxBairroProblema.Text = "Bairro do Problema";
            comboBoxBairroProblema.Location = new System.Drawing.Point(725, 310);
            comboBoxBairroProblema.Size = new System.Drawing.Size(400, 20);
            comboBoxBairroProblema.ForeColor = Color.Gray;

            labelLogradouroProblema = new Label();
            labelLogradouroProblema.Text = "Escreva o logradouro (Rua) do problema";
            labelLogradouroProblema.Location = new System.Drawing.Point(725, 350);
            labelLogradouroProblema.Size = new System.Drawing.Size(400, 20);

            textBoxLogradouroProblema = new TextBox();
            textBoxLogradouroProblema.Name = "Logradouro";
            textBoxLogradouroProblema.Location = new System.Drawing.Point(725, 370);
            textBoxLogradouroProblema.Size = new System.Drawing.Size(400, 100);

            labelDescricaoProblema = new Label();
            labelDescricaoProblema.Text = "Escreva uma descrição para o problema";
            labelDescricaoProblema.Location = new System.Drawing.Point(725, 410);
            labelDescricaoProblema.Size = new System.Drawing.Size(400, 20);

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

            pictureBoxProblema = new PictureBox();
            pictureBoxProblema.Location = new System.Drawing.Point(725, 620);
            pictureBoxProblema.Size = new System.Drawing.Size(400, 110);     

            pictureBoxFotoUsuario = new PictureBox();
            pictureBoxFotoUsuario.Image = Image.FromFile("Layout/FotoUsuario.png");
            pictureBoxFotoUsuario.Location = new System.Drawing.Point(700, 50);
            pictureBoxFotoUsuario.Size = new System.Drawing.Size(80, 80);
            pictureBoxFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage; 

            buttonEnviarRelato = new Button();
            buttonEnviarRelato.Text = "ENVIAR RELATO";
            buttonEnviarRelato.Location = new System.Drawing.Point(775, 750);
            buttonEnviarRelato.Size = new System.Drawing.Size(300, 30);
            buttonEnviarRelato.BackColor = Color.LimeGreen;

            textBoxDescricaoProblema.TextChanged += textBoxDescricaoProblema_TextChanged;

            Controls.Add(panel);
            Controls.Add(labelDivisao1);
            Controls.Add(labelDivisao2);
            Controls.Add(labelOla);
            Controls.Add(labelNome);
            Controls.Add(labelLinha1);
            Controls.Add(labelLinha2);            
            Controls.Add(labelEscrevaRelato);
            Controls.Add(labelTipoProblema);
            Controls.Add(labelBairroProblema);
            Controls.Add(labelLogradouroProblema);
            Controls.Add(labelDescricaoProblema);
            Controls.Add(labelFotoProblema);
            Controls.Add(textBoxLogradouroProblema);
            Controls.Add(textBoxDescricaoProblema);
            Controls.Add(comboBoxTipoProblema);
            Controls.Add(comboBoxBairroProblema);
            Controls.Add(pictureBoxFotoUsuario);
            Controls.Add(pictureBoxProblema);
            Controls.Add(buttonEnviarRelato);
            Controls.Add(labelFundo);
            
        }

        private void textBoxDescricaoProblema_TextChanged(object sender, EventArgs e) {
            int linhaAtual = textBoxDescricaoProblema.GetLineFromCharIndex(textBoxDescricaoProblema.TextLength) + 1;
            int linhaHeight = textBoxDescricaoProblema.Font.Height;
            int novaAltura = linhaHeight * linhaAtual + 4;
            textBoxDescricaoProblema.Height = novaAltura;
        }

    }

}