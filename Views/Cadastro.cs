using System;
using System.Windows.Forms;
using System.Drawing;

namespace Views {   
    public class Cadastro : Form {   
        private Label labelFundo; 
        private Label labelDivisao1;
        private Label labelDivisao2;   
        private Label labelNome;
        private Label labelNickname;
        private Label labelEmail;
        private Label labelSenha;
        private Label labelTelefone; 
        private Label labelCPF;      
        private Label labelJaTemConta;   
        private Label labelExibeErro; 
        private Label labelFotoUsuario;
        private TextBox inputNome;
        private TextBox inputNickname;
        private TextBox inputEmail;
        private TextBox inputSenha;
        private MaskedTextBox inputTelefone; 
        private MaskedTextBox inputCPF;
        private Button buttonFotoUsuario;
        private Button buttonCadastrar;
        
        public Cadastro() {   
            this.WindowState = FormWindowState.Maximized;

            Image image = Image.FromFile("Layout/LogoResolville.png");
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(700, 50);
            panel.Size = new Size(450, 150);
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

            labelNome = new Label();
            labelNome.Text = "Nome Completo (Nome e Sobrenome)";
            labelNome.Location = new System.Drawing.Point(700, 250);
            labelNome.Size = new System.Drawing.Size(220, 20);

            inputNome = new TextBox();
            inputNome.Location = new System.Drawing.Point(700, 270); 
            inputNome.Name = "Nome";
            inputNome.Size = new System.Drawing.Size(450, 20);
            inputNome.MaxLength = 80;
            inputNome.ForeColor = Color.Black;

            labelNickname = new Label();
            labelNickname.Text = "Nome do Usuário";
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
            inputSenha.PasswordChar = '•';
            inputSenha.Size = new System.Drawing.Size(450, 20);
            inputSenha.MaxLength = 20;

            labelTelefone = new Label();
            labelTelefone.Text = "Telefone";
            labelTelefone.Location = new System.Drawing.Point(700, 490);
            labelTelefone.Size = new System.Drawing.Size(220, 20);

            inputTelefone = new MaskedTextBox();
            inputTelefone.Location = new System.Drawing.Point(700, 510); 
            inputTelefone.Name = "Telefone";
            inputTelefone.Size = new System.Drawing.Size(220, 20);
            inputTelefone.MaxLength = 15;
            inputTelefone.Mask = "(00) 00000-0000";

            labelCPF = new Label();
            labelCPF.Text = "CPF";
            labelCPF.Location = new System.Drawing.Point(935, 490);
            labelCPF.Size = new System.Drawing.Size(215, 20);

            inputCPF = new MaskedTextBox();
            inputCPF.Location = new System.Drawing.Point(935, 510); 
            inputCPF.Name = "CPF";
            inputCPF.Size = new System.Drawing.Size(215, 20);
            inputCPF.MaxLength = 14;
            inputCPF.Mask = "000,000,000-00";

            labelFotoUsuario = new Label();
            labelFotoUsuario.Location = new System.Drawing.Point(700, 550);
            labelFotoUsuario.Text = "Foto do Perfil do Usuário";
            labelFotoUsuario.Size = new System.Drawing.Size(220, 20);

            buttonFotoUsuario = new Button();
            buttonFotoUsuario.Location = new System.Drawing.Point(700, 570); 
            buttonFotoUsuario.Name = "Selecionar Imagem";
            buttonFotoUsuario.Size = new System.Drawing.Size(450, 30);
            buttonFotoUsuario.Text = "SELECIONAR IMAGEM";
            buttonFotoUsuario.ForeColor = Color.Gray;

            /*labelExibeErro = new Label();
            labelExibeErro.Text = "";
            labelExibeErro.Location = new System.Drawing.Point(700, 720);
            labelExibeErro.Size = new System.Drawing.Size(220, 20);
            labelExibeErro.ForeColor = Color.Red;*/

            labelJaTemConta = new Label();
            labelJaTemConta.Location = new System.Drawing.Point(875, 670);
            labelJaTemConta.Text = "Já tem uma conta?";
            labelJaTemConta.Size = new System.Drawing.Size(107, 15);
            labelJaTemConta.ForeColor = Color.Blue;
           
            buttonCadastrar = new Button();
            buttonCadastrar.Location = new System.Drawing.Point(725, 640); 
            buttonCadastrar.Name = "Cadastrar";
            buttonCadastrar.Size = new System.Drawing.Size(400, 30);
            buttonCadastrar.Text = "CADASTRAR-SE";
            buttonCadastrar.BackColor = Color.LimeGreen;

            buttonFotoUsuario.Click += buttonFotoUsuario_Click;
            buttonFotoUsuario.MouseEnter += buttonFotoUsuario_MouseEnter;
            buttonFotoUsuario.MouseLeave += buttonFotoUsuario_MouseLeave;
            buttonCadastrar.Click += buttonCadastrar_Click;
            buttonCadastrar.MouseEnter += buttonCadastrar_MouseEnter;
            buttonCadastrar.MouseLeave += buttonCadastrar_MouseLeave;
            labelJaTemConta.MouseClick += labelJaTemConta_MouseClick;
            labelJaTemConta.MouseEnter += labelJaTemConta_MouseEnter;
            labelJaTemConta.MouseLeave += labelJaTemConta_MouseLeave;
            
            Controls.Add(panel);
            Controls.Add(labelDivisao1);
            Controls.Add(labelDivisao2);
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
            Controls.Add(labelJaTemConta);
            Controls.Add(labelExibeErro);
            Controls.Add(labelFotoUsuario);
            Controls.Add(buttonFotoUsuario);
            Controls.Add(buttonCadastrar);    
            Controls.Add(labelFundo);       
        }

        private void inputCPF_KeyPress(object sender, KeyPressEventArgs e) {
            string cpf = new string(inputCPF.Text.Where(Char.IsDigit).ToArray());
            if(cpf.Length >= 3) {
                cpf = ".";
            } if (cpf.Length >= 7) {
                cpf = cpf.Insert(7, ".");
            } if (cpf.Length >= 11) {
                cpf = cpf.Insert(11, "-");
            }
            
            inputCPF.SelectionStart = cpf.Length;
            e.Handled = true;
        }

        private void inputTelefone_KeyPress(object sender, KeyPressEventArgs e) {
            string telefone = new string(inputTelefone.Text.Where(Char.IsDigit).ToArray());
            if(telefone.Length >= 2) {
                telefone = "(" + telefone.Substring(0, 2) + ")";
            } if (telefone.Length >= 5) {
                telefone = telefone.Insert(5, " ");
            } if (telefone.Length >= 10) {
                telefone = telefone.Insert(10, "-");
            }

            inputTelefone.Text = telefone;
            inputTelefone.SelectionStart = telefone.Length;
            e.Handled = true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e) {
            string nome, apelido, email, cpf, telefone, senha;

            if(inputNome.Text != "" && inputNickname.Text != "" && inputEmail.Text != "" && inputCPF.Text != "" &&  inputTelefone.Text != "" &&  inputSenha.Text != ""){
                nome = inputNome.Text;
                apelido = inputNickname.Text;
                email = inputEmail.Text;
                cpf = inputCPF.Text;
                telefone = inputTelefone.Text;
                senha = inputSenha.Text;

                Controllers.UsuarioController.addUsuario(nome, apelido, email, cpf, telefone, senha);

                inputNome.Text = "";
                inputNickname.Text = "";
                inputEmail.Text = "";
                inputCPF.Text = "";
                inputTelefone.Text = "";
                inputSenha.Text = "";

                MessageBox.Show(
                    "Cadastro realizado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK
                );
            }

            /*string nome = inputNome.Text;
            if(!IsValidName(nome)) {
                labelExibeErro.Text = "*Preencha os campos corretamente*";
                return;
            } else {
                labelExibeErro.Text = "";
                return;
            }

            //Validação do Email
            string email = inputEmail.Text;
            if(!IsValidEmail(email)) {
                labelExibeErro.Text = "*Preencha os campos corretamente*";
                return;
            } else {
                labelExibeErro.Text = "";
                return;
            }

            string logradouro = inputLogradouro.Text;
            if(!IsValidLogradouro(logradouro)) {
                labelExibeErro.Text = "*Preencha os campos corretamente*";
                return;
            } else {
                labelExibeErro.Text = "";
                return;
            }*/

            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Hide();
        }

        private bool IsValidName(string name) {
            string pattern = @"^[\p{L}\p{M}]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(name, pattern);
        }

        private bool IsValidEmail(string email) {
            string pattern = @"^[\w\.-]+@[\w-]+(\.[\w-]+)*$";           
            if(!System.Text.RegularExpressions.Regex.IsMatch(email, pattern)) {
                return false;
            }

            int atIndex = email.IndexOf('@');
            if(atIndex != -1) {
                string afterAt = email.Substring(atIndex + 1);
                if(System.Text.RegularExpressions.Regex.IsMatch(afterAt, @"[^.a-zA-Z]|\d")) {
                    return false;
                }
            }

            return true;
        }

        private void buttonFotoUsuario_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Selecione uma Imagem";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = openFileDialog.FileName;

                if (File.Exists(filePath)) {
                    try {
                        Image imagemSelecionada = Image.FromFile(filePath);
                        buttonFotoUsuario.Image = imagemSelecionada;
                    } catch (Exception ex) when (ex is OutOfMemoryException || ex is FileNotFoundException) {
                        MessageBox.Show("Erro ao abrir a imagem: Arquivo inválido ou não é uma imagem suportada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("O arquivo selecionado não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonFotoUsuario_MouseEnter(object sender, EventArgs e ) {
            buttonFotoUsuario.BackColor = Color.LightGray;
        }

        private void buttonFotoUsuario_MouseLeave(object sender, EventArgs e ) {
            buttonFotoUsuario.BackColor = Color.White;
        }

        private void buttonCadastrar_MouseEnter(object sender, EventArgs e) {
            buttonCadastrar.BackColor = Color.PaleGreen;
        }

        private void buttonCadastrar_MouseLeave(object sender, EventArgs e) {
            buttonCadastrar.BackColor = Color.LimeGreen;
        }

        private void labelJaTemConta_MouseClick(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void labelJaTemConta_MouseEnter(object sender, EventArgs e) {
            labelJaTemConta.ForeColor = Color.RoyalBlue;
        }

        private void labelJaTemConta_MouseLeave(object sender, EventArgs e) {
            labelJaTemConta.ForeColor = Color.Blue;
        }
       
    }

}