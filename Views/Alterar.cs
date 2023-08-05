using System;
using System.Windows.Forms;

namespace Views {

    public class Alterar : Form{
        private Label labelFundo; 
        private Label labelDivisao1;
        private Label labelDivisao2;  
        private Label labelNomeErro;
        private Label labelNicknameErro;
        private Label labelEmailErro;
        private Label labelSenhaErro;
        private Label labelTelefoneErro;
        private Label labelCPFErro; 
        private Label labelNome;
        private Label labelNickname;
        private Label labelEmail;
        private Label labelSenha;
        private Label labelTelefone; 
        private Label labelCPF;      
        private Label labelFotoUsuario;
        private TextBox inputNome;
        private TextBox inputNickname;
        private TextBox inputEmail;
        private TextBox inputSenha;
        private MaskedTextBox inputTelefone; 
        private MaskedTextBox inputCPF;
        private Button buttonFotoUsuario;
        private Button buttonAlterar;

        public Alterar() {
            
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

            labelFundo = new Label();
            labelFundo.Location = new System.Drawing.Point(650, 0);
            labelFundo.Size = new System.Drawing.Size(550, 970);
            labelFundo.BackColor = Color.LightGray;
            labelFundo.SendToBack();

            labelNome = new Label();
            labelNome.Text = "Nome Completo (Nome e Sobrenome)";
            labelNome.Location = new System.Drawing.Point(700, 250);
            labelNome.Size = new System.Drawing.Size(220, 20);
            labelNome.ForeColor = ColorTranslator.FromHtml("#6f6f6f");
            Font fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelNome.Font = fonte;

            labelNomeErro = new Label();
            labelNomeErro.Text = "";
            labelNomeErro.TextAlign = ContentAlignment.MiddleRight;
            labelNomeErro.Location = new System.Drawing.Point(925, 250);
            labelNomeErro.Size = new System.Drawing.Size(225, 20);
            labelNomeErro.ForeColor = Color.Red;
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelNomeErro.Font = fonte;

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
            labelNickname.ForeColor = ColorTranslator.FromHtml("#6f6f6f");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelNickname.Font = fonte;

            labelNicknameErro = new Label();
            labelNicknameErro.Text = "";
            labelNicknameErro.TextAlign = ContentAlignment.MiddleRight;
            labelNicknameErro.Location = new System.Drawing.Point(925, 310);
            labelNicknameErro.Size = new System.Drawing.Size(225, 20);
            labelNicknameErro.ForeColor = Color.Red;
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelNicknameErro.Font = fonte;

            inputNickname = new TextBox();
            inputNickname.Location = new System.Drawing.Point(700, 330); 
            inputNickname.Name = "Nickname";
            inputNickname.Size = new System.Drawing.Size(450, 20);
            inputNickname.MaxLength = 20;

            labelEmail = new Label();
            labelEmail.Text = "Email";
            labelEmail.Location = new System.Drawing.Point(700, 370);
            labelEmail.Size = new System.Drawing.Size(220, 20);
            labelEmail.ForeColor = ColorTranslator.FromHtml("#6f6f6f");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelEmail.Font = fonte;

            labelEmailErro = new Label();
            labelEmailErro.Text = "";
            labelEmailErro.TextAlign = ContentAlignment.MiddleRight;
            labelEmailErro.Location = new System.Drawing.Point(925, 370);
            labelEmailErro.Size = new System.Drawing.Size(225, 20);
            labelEmailErro.ForeColor = Color.Red;
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelEmailErro.Font = fonte;

            inputEmail = new TextBox();
            inputEmail.Location = new System.Drawing.Point(700, 390); 
            inputEmail.Name = "Email";
            inputEmail.Size = new System.Drawing.Size(450, 20);
            inputEmail.MaxLength = 100;

            labelSenha = new Label();
            labelSenha.Text = "Senha";
            labelSenha.Location = new System.Drawing.Point(700, 430);
            labelSenha.Size = new System.Drawing.Size(220, 20);
            labelSenha.ForeColor = ColorTranslator.FromHtml("#6f6f6f");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelSenha.Font = fonte;

            labelSenhaErro = new Label();
            labelSenhaErro.Text = "";
            labelSenhaErro.TextAlign = ContentAlignment.MiddleRight;
            labelSenhaErro.Location = new System.Drawing.Point(925, 430);
            labelSenhaErro.Size = new System.Drawing.Size(225, 20);
            labelSenhaErro.ForeColor = Color.Red;
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelSenhaErro.Font = fonte;

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
            labelTelefone.ForeColor = ColorTranslator.FromHtml("#6f6f6f");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelTelefone.Font = fonte;

            labelTelefoneErro = new Label();
            labelTelefoneErro.Text = "";
            labelTelefoneErro.TextAlign = ContentAlignment.MiddleRight;
            labelTelefoneErro.Location = new System.Drawing.Point(815, 490);
            labelTelefoneErro.Size = new System.Drawing.Size(105, 20);
            labelTelefoneErro.ForeColor = Color.Red;
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelTelefoneErro.Font = fonte;

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
            labelCPF.ForeColor = ColorTranslator.FromHtml("#6f6f6f");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelCPF.Font = fonte;

            labelCPFErro = new Label();
            labelCPFErro.Text = "";
            labelCPFErro.TextAlign = ContentAlignment.MiddleRight;
            labelCPFErro.Location = new System.Drawing.Point(1050, 490);
            labelCPFErro.Size = new System.Drawing.Size(100, 20);
            labelCPFErro.ForeColor = Color.Red;
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelCPFErro.Font = fonte;

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
            labelFotoUsuario.ForeColor = ColorTranslator.FromHtml("#6f6f6f");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            labelFotoUsuario.Font = fonte;

            buttonFotoUsuario = new Button();
            buttonFotoUsuario.Location = new System.Drawing.Point(700, 570); 
            buttonFotoUsuario.Name = "Selecionar Imagem";
            buttonFotoUsuario.Size = new System.Drawing.Size(450, 30);
            buttonFotoUsuario.Text = "SELECIONAR IMAGEM";
            buttonFotoUsuario.ForeColor = Color.Gray;
            buttonFotoUsuario.ForeColor = ColorTranslator.FromHtml("#6f6f6f");
            fonte = new Font("IBM Plex Sans", 8, FontStyle.Bold);
            buttonFotoUsuario.Font = fonte;

            /*labelExibeErro = new Label();
            labelExibeErro.Text = "";
            labelExibeErro.Location = new System.Drawing.Point(700, 720);
            labelExibeErro.Size = new System.Drawing.Size(220, 20);
            labelExibeErro.ForeColor = Color.Red;*/

            buttonAlterar = new Button();
            buttonAlterar.Location = new System.Drawing.Point(725, 640); 
            buttonAlterar.Name = "Alterar";
            buttonAlterar.Size = new System.Drawing.Size(400, 30);
            buttonAlterar.Text = "ALTERAR";
            buttonAlterar.BackColor = ColorTranslator.FromHtml("#7ed957");
            buttonAlterar.ForeColor = Color.White;
            fonte = new Font("Garet", 10, FontStyle.Bold);
            buttonAlterar.Font = fonte;

            

            inputCPF.Click += inputCPF_Click;
            inputTelefone.Click += inputTelefone_Click;
            buttonFotoUsuario.Click += buttonFotoUsuario_Click;
            buttonFotoUsuario.MouseEnter += buttonFotoUsuario_MouseEnter;
            buttonFotoUsuario.MouseLeave += buttonFotoUsuario_MouseLeave;
            buttonAlterar.Click += buttonAlterar_Click;
            buttonAlterar.MouseEnter += buttonAlterar_MouseEnter;
            buttonAlterar.MouseLeave += buttonAlterar_MouseLeave;
            
            Controls.Add(panel);
            Controls.Add(labelDivisao1);
            Controls.Add(labelDivisao2);
            Controls.Add(labelNomeErro);
            Controls.Add(labelNicknameErro);
            Controls.Add(labelEmailErro);
            Controls.Add(labelSenhaErro);
            Controls.Add(labelTelefoneErro);
            Controls.Add(labelCPFErro);
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
            Controls.Add(labelFotoUsuario);
            Controls.Add(buttonFotoUsuario);
            Controls.Add(buttonAlterar);    
            Controls.Add(labelFundo);       
        }

        private void inputCPF_Click(object sender, EventArgs e) {
            string cpf = new string(inputCPF.Text.Where(Char.IsDigit).ToArray());
            inputCPF.SelectionStart = cpf.Length;

            if(cpf.Length == 4) {
                inputCPF.SelectionStart = cpf.Length + 1;
            } 
            if(cpf.Length == 5) {
                inputCPF.SelectionStart = cpf.Length + 1;
            }  
            if(cpf.Length == 6) {
                inputCPF.SelectionStart = cpf.Length + 1;
            }  
            if(cpf.Length == 7) {
                inputCPF.SelectionStart = cpf.Length + 2;
            }  
            if(cpf.Length == 8) {
                inputCPF.SelectionStart = cpf.Length + 2;
            }  
            if(cpf.Length == 9) {
                inputCPF.SelectionStart = cpf.Length + 2;
            }  
            if(cpf.Length == 10) {
                inputCPF.SelectionStart = cpf.Length + 3;
            }
            if(cpf.Length == 11) {
                inputCPF.SelectionStart = cpf.Length + 3;
            }
        }

        private void inputTelefone_Click(object sender, EventArgs e) {
            string telefone = new string(inputTelefone.Text.Where(Char.IsDigit).ToArray());
            inputTelefone.SelectionStart = telefone.Length;

            if(telefone.Length == 1) {
                inputTelefone.SelectionStart = telefone.Length + 1;
            } 
            if(telefone.Length == 2) {
                inputTelefone.SelectionStart = telefone.Length + 1;
            }  
            if(telefone.Length == 3) {
                inputTelefone.SelectionStart = telefone.Length + 3;
            }  
            if(telefone.Length == 4) {
                inputTelefone.SelectionStart = telefone.Length + 3;
            }  
            if(telefone.Length == 5) {
                inputTelefone.SelectionStart = telefone.Length + 3;
            }  
            if(telefone.Length == 6) {
                inputTelefone.SelectionStart = telefone.Length + 3;
            }  
            if(telefone.Length == 7) {
                inputTelefone.SelectionStart = telefone.Length + 4;
            }
            if(telefone.Length == 8) {
                inputTelefone.SelectionStart = telefone.Length + 4;
            }
            if(telefone.Length == 9) {
                inputTelefone.SelectionStart = telefone.Length + 4;
            }
            if(telefone.Length == 10) {
                inputTelefone.SelectionStart = telefone.Length + 4;
            }
            if(telefone.Length == 11) {
                inputTelefone.SelectionStart = telefone.Length + 4;
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e) {
            string nome, nome_Usuario, email, cpf, senha, telefone;
            List<string> errors = new List<string>();

            labelNomeErro.Text = "";
            labelNicknameErro.Text = "";
            labelEmailErro.Text = "";
            labelSenhaErro.Text = "";
            labelTelefoneErro.Text = "";
            labelCPFErro.Text = "";

            if (string.IsNullOrEmpty(inputNome.Text)) {
                labelNomeErro.Text = "Campo Obrigatório*";
                errors.Add("Nome Completo é obrigatório*");
            } else if (inputNome.Text.Length < 2 || inputNome.Text.Length > 80) {
                labelNomeErro.Text = "Sintaxe Incorreta*";
                errors.Add("Nome Completo deve ter entre 2 e 80 caracteres");
            }

            if (string.IsNullOrEmpty(inputNickname.Text)) {
                labelNicknameErro.Text = "Campo Obrigatório*";
                errors.Add("Nome do Usuário* é obrigatório*");
            } else if (inputNickname.Text.Length < 2 || inputNickname.Text.Length > 20) {
                labelNicknameErro.Text = "Sintaxe Incorreta*";
                errors.Add("Nome do Usuário* deve ter entre 2 e 20 caracteres");
            }

            if (string.IsNullOrEmpty(inputEmail.Text)) {
                labelEmailErro.Text = "Campo Obrigatório*";
                errors.Add("Email é obrigatório*");
            } else if (inputEmail.Text.Length < 2 || inputEmail.Text.Length > 80 || !IsValidEmail(inputEmail.Text)) {
                labelEmailErro.Text = "Sintaxe Incorreta*";
                errors.Add("Email deve ter entre 2 e 80 caracteres");
            }

            if (string.IsNullOrEmpty(inputSenha.Text)) {
                labelSenhaErro.Text = "Campo Obrigatório*";
                errors.Add("Senha é obrigatória");
            } else if (inputSenha.Text.Length < 8 || inputSenha.Text.Length > 40) {
                labelSenhaErro.Text = "Sintaxe Incorreta*";
                errors.Add("Senha deve ter entre 8 e 40 caracteres");
            }

            if (string.IsNullOrEmpty(inputTelefone.Text)) {
                labelTelefoneErro.Text = "Campo Obrigatório*";
                errors.Add("Telefone é obrigatório*");
            } else if (inputTelefone.Text.Length != 15) {
                labelTelefoneErro.Text = "Sintaxe Incorreta*";
                errors.Add("Telefone deve estar no formato (00) 00000-0000");
            }

            if (string.IsNullOrEmpty(inputCPF.Text)) {
                labelCPFErro.Text = "Campo Obrigatório*";
                errors.Add("CPF é obrigatório*");
            } else if (inputCPF.Text.Length != 14) {
                labelCPFErro.Text = "Sintaxe Incorreta*";
                errors.Add("CPF deve estar no formato 000,000,000-00");
            }

            if (errors.Count > 0) {
                return;
            }

            nome = inputNome.Text;
            nome_Usuario = inputNickname.Text;
            email = inputEmail.Text;
            cpf = inputCPF.Text;
            senha = inputSenha.Text;
            telefone = inputTelefone.Text;
            
            //Controllers.UsuarioController.UpdateUsuario(nome, nome_Usuario, email, cpf, senha, telefone);

            inputNome.Text = "";
            inputNickname.Text = "";
            inputEmail.Text = "";
            inputCPF.Text = "";
            inputSenha.Text = "";
            inputTelefone.Text = "";

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK);

            Login login = new Login();
            login.Show();
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

        private void buttonAlterar_MouseEnter(object sender, EventArgs e) {
            buttonAlterar.BackColor = Color.PaleGreen;
        }

        private void buttonAlterar_MouseLeave(object sender, EventArgs e) {
            buttonAlterar.BackColor = ColorTranslator.FromHtml("#7ed957");
        }

    }

}