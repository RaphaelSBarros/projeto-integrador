using System;
using System.Windows.Forms;

namespace Views {   
    public class Cadastro : Form {       
        private Label labelNome;
        private Label labelNickname;
        private Label labelEmail;
        private Label labelSenha;
        private Label labelTelefone; 
        private Label labelCPF;   
        //private Label labelCEP;
        private Label labelLogradouro;
        private Label labelNumeroResidencia;
        private Label labelBairro;                 
        private TextBox inputNome;
        private TextBox inputNickname;
        private TextBox inputEmail;
        private TextBox inputSenha;
        private TextBox inputTelefone;
        private TextBox inputCPF;
        //private TextBox inputCEP;
        private TextBox inputLogradouro;
        private TextBox inputNumeroResidencia;
        private TextBox inputBairro;   
        private Button buttonCadastrar;
        
        public Cadastro() {   
            Image image = Image.FromFile("Layout/LogoResolville.png");
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(700, 50);
            panel.Size = new Size(450, 200);
            panel.BackgroundImage = image;
            panel.BackgroundImageLayout = ImageLayout.Zoom;

            labelNome = new Label();
            labelNome.Text = "Nome Completo(Nome e Sobrenome)";
            labelNome.Location = new System.Drawing.Point(700, 250);
            labelNome.Size = new System.Drawing.Size(220, 20);

            inputNome = new TextBox();
            inputNome.Location = new System.Drawing.Point(700, 270); 
            inputNome.Name = "Nome";
            inputNome.Size = new System.Drawing.Size(450, 20);
            inputNome.MaxLength = 100;

            labelNickname = new Label();
            labelNickname.Text = "Nome de Usuário";
            labelNickname.Location = new System.Drawing.Point(700, 310);
            labelNickname.Size = new System.Drawing.Size(220, 20);

            inputNickname = new TextBox();
            inputNickname.Location = new System.Drawing.Point(700, 330); 
            inputNickname.Name = "Nickname";
            inputNickname.Size = new System.Drawing.Size(450, 20);
            inputNickname.MaxLength = 20;

            labelEmail = new Label();
            labelEmail.Text = "Email";
            labelEmail.Location = new System.Drawing.Point(700, 370);
            labelEmail.Size = new System.Drawing.Size(220, 20);

            inputEmail = new TextBox();
            inputEmail.Location = new System.Drawing.Point(700, 390); 
            inputEmail.Name = "Email";
            inputEmail.Size = new System.Drawing.Size(450, 20);
            inputEmail.MaxLength = 100;

            labelSenha = new Label();
            labelSenha.Text = "Senha";
            labelSenha.Location = new System.Drawing.Point(700, 430);
            labelSenha.Size = new System.Drawing.Size(220, 20);

            inputSenha = new TextBox();
            inputSenha.Location = new System.Drawing.Point(700, 450); 
            inputSenha.Name = "Senha";
            inputSenha.PasswordChar = '*';
            inputSenha.Size = new System.Drawing.Size(450, 20);
            inputSenha.MaxLength = 20;

            labelTelefone = new Label();
            labelTelefone.Text = "Telefone";
            labelTelefone.Location = new System.Drawing.Point(700, 490);
            labelTelefone.Size = new System.Drawing.Size(110, 20);

            inputTelefone = new TextBox();
            inputTelefone.Location = new System.Drawing.Point(700, 510); 
            inputTelefone.Name = "Telefone";
            inputTelefone.Size = new System.Drawing.Size(220, 20);
            inputTelefone.MaxLength = 15;

            labelCPF = new Label();
            labelCPF.Text = "CPF";
            labelCPF.Location = new System.Drawing.Point(935, 490);
            labelCPF.Size = new System.Drawing.Size(110, 20);

            inputCPF = new TextBox();
            inputCPF.Location = new System.Drawing.Point(935, 510); 
            inputCPF.Name = "CPF";
            inputCPF.Size = new System.Drawing.Size(215, 20);
            inputCPF.MaxLength = 14;

            /*labelCEP = new Label();
            labelCEP.Text = "CEP";
            labelCEP.Location = new System.Drawing.Point(700, 700);
            labelCEP.Size = new System.Drawing.Size(220, 20);

            inputCEP = new TextBox();
            inputCEP.Location = new System.Drawing.Point(700, 700); 
            inputCEP.Name = "CEP";
            inputCEP.Size = new System.Drawing.Size(450, 20);*/
            
            labelLogradouro = new Label();
            labelLogradouro.Text = "Logradouro";
            labelLogradouro.Location = new System.Drawing.Point(700, 550);
            labelLogradouro.Size = new System.Drawing.Size(220, 20);

            inputLogradouro = new TextBox();
            inputLogradouro.Location = new System.Drawing.Point(700, 570); 
            inputLogradouro.Name = "Logradouro";
            inputLogradouro.Size = new System.Drawing.Size(450, 20);
            inputLogradouro.MaxLength = 100;

            labelNumeroResidencia = new Label();
            labelNumeroResidencia.Text = "Número de Residência";
            labelNumeroResidencia.Location = new System.Drawing.Point(700, 610);
            labelNumeroResidencia.Size = new System.Drawing.Size(220, 20);

            inputNumeroResidencia = new TextBox();
            inputNumeroResidencia.Location = new System.Drawing.Point(700, 630); 
            inputNumeroResidencia.Name = "NumeroResidencia";
            inputNumeroResidencia.Size = new System.Drawing.Size(450, 20);
            inputNumeroResidencia.MaxLength = 10;

            labelBairro = new Label();
            labelBairro.Text = "Bairro";
            labelBairro.Location = new System.Drawing.Point(700, 670);
            labelBairro.Size = new System.Drawing.Size(220, 20);

            inputBairro = new TextBox();
            inputBairro.Location = new System.Drawing.Point(700, 690); 
            inputBairro.Name = "Bairro";
            inputBairro.Size = new System.Drawing.Size(450, 20);
            inputBairro.MaxLength = 50;

            buttonCadastrar = new Button();
            buttonCadastrar.Location = new System.Drawing.Point(725, 740); 
            buttonCadastrar.Name = "Cadastrar";
            buttonCadastrar.Size = new System.Drawing.Size(400, 30);
            buttonCadastrar.Text = "Cadastrar-se";
            buttonCadastrar.BackColor = Color.LimeGreen;

            buttonCadastrar.MouseEnter += buttonCadastrar_MouseEnter;
            buttonCadastrar.MouseLeave += buttonCadastrar_MouseLeave;

            this.Size = new System.Drawing.Size(2000, 2000);
         
            Controls.Add(panel);
            Controls.Add(labelNome);
            Controls.Add(inputNome);
            Controls.Add(labelNickname);
            Controls.Add(inputNickname);
            Controls.Add(labelEmail);
            Controls.Add(inputEmail);
            Controls.Add(labelSenha);
            Controls.Add(inputSenha); 
            Controls.Add(labelTelefone);
            Controls.Add(inputTelefone);
            Controls.Add(labelCPF);
            Controls.Add(inputCPF);
            //Controls.Add(labelCEP);
            //Controls.Add(inputCEP);
            Controls.Add(labelLogradouro);
            Controls.Add(inputLogradouro);
            Controls.Add(labelNumeroResidencia);
            Controls.Add(inputNumeroResidencia);
            Controls.Add(labelBairro);
            Controls.Add(inputBairro);
            Controls.Add(buttonCadastrar);

        }

        private void buttonCadastrar_Click(object sender, EventArgs e) {
            string nome, apelido, email, cpf, endereco, telefone, senha;

            nome = inputNome.Text;
            apelido = inputNickname.Text;
            email = inputEmail.Text;
            cpf = inputCPF.Text;
            endereco = inputLogradouro.Text + ", " + inputBairro.Text + ", nº "+ inputNumeroResidencia.Text;
            telefone = inputTelefone.Text;
            senha = inputSenha.Text;

            Controllers.UsuarioController.addUsuario(nome, apelido, email, cpf, endereco, telefone, senha);

            inputNome.Text = "";
            inputNickname.Text = "";
            inputEmail.Text = "";
            inputCPF.Text = "";
            inputLogradouro.Text = "";
            inputBairro.Text = "";
            inputNumeroResidencia.Text = "";
            inputTelefone.Text = "";
            inputSenha.Text = "";

            /*string nome = inputNome.Text;
            if(!IsAlpha(nome)) {
                inputNome.ForeColor = Color.Red;
                inputNome.Text = "O campo deve conter apenas letras";
                return;
            }*/
        }

        private void buttonCadastrar_MouseEnter(object sender, EventArgs e) {
            buttonCadastrar.BackColor = Color.PaleGreen;
        }

        private void buttonCadastrar_MouseLeave(object sender, EventArgs e) {
            buttonCadastrar.BackColor = Color.LimeGreen;
        }

        private bool IsAlpha(string text) {
            foreach(char c in text) {
                if(!char.IsLetter(c)) {
                    return false;
                }
            }
            return true;

        }
        
    }

}