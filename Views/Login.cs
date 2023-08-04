using System;
using System.Windows.Forms;

namespace Views {
    public class Login : Form {
        private Label labelFundo;
        private Label labelDivisao1;
        private Label labelDivisao2;
        private Label labelCPFErro;
        private Label labelSenhaErro;
        private Label labelSenha;
        private Label labelCPF;
        private Label labelNaoTemConta; 
        private TextBox inputSenha;
        private MaskedTextBox inputCPF;
        private CheckBox checkBoxSenha;
        private Button buttonLogar;

        public Login() {
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

            labelCPF = new Label();
            labelCPF.Text = "CPF";
            labelCPF.Location = new System.Drawing.Point(700, 250);
            labelCPF.Size = new System.Drawing.Size(220, 20);

            labelCPFErro = new Label();
            labelCPFErro.Text = "";
            labelCPFErro.TextAlign = ContentAlignment.MiddleRight;
            labelCPFErro.Location = new System.Drawing.Point(925, 250);
            labelCPFErro.Size = new System.Drawing.Size(225, 20);
            labelCPFErro.ForeColor = Color.Red;

            inputCPF = new MaskedTextBox();
            inputCPF.Location = new System.Drawing.Point(700, 270); 
            inputCPF.Name = "CPF";
            inputCPF.Size = new System.Drawing.Size(450, 20);
            inputCPF.MaxLength = 14;
            inputCPF.Mask = "000,000,000-00";

            labelSenha = new Label();
            labelSenha.Text = "Senha";
            labelSenha.Location = new System.Drawing.Point(700, 310);
            labelSenha.Size = new System.Drawing.Size(220, 20);

            labelSenhaErro = new Label();
            labelSenhaErro.Text = "";
            labelSenhaErro.TextAlign = ContentAlignment.MiddleRight;
            labelSenhaErro.Location = new System.Drawing.Point(925, 310);
            labelSenhaErro.Size = new System.Drawing.Size(225, 20);
            labelSenhaErro.ForeColor = Color.Red;

            inputSenha = new TextBox();
            inputSenha.Location = new System.Drawing.Point(700, 330); 
            inputSenha.Name = "Senha";
            inputSenha.PasswordChar = '•';
            inputSenha.Size = new System.Drawing.Size(450, 20);
            inputSenha.MaxLength = 20;

            labelNaoTemConta = new Label();
            labelNaoTemConta.Location = new System.Drawing.Point(870, 425);
            labelNaoTemConta.Text = "Não tem uma conta?";
            labelNaoTemConta.Size = new System.Drawing.Size(119, 15);
            labelNaoTemConta.ForeColor = ColorTranslator.FromHtml("#5271FF");

            /*CheckBoxSenha = new CheckBox();
            checkBoxSenha.Image = Image.FromFile("Layout/VerSenha.png");
            checkBoxSenha.Location = new Point(1050, 330);
            checkBoxSenha.Size = new Size(200, 35);*/

            buttonLogar = new Button();
            buttonLogar.Location = new System.Drawing.Point(725, 390);
            buttonLogar.Name = "Login";
            buttonLogar.Size = new System.Drawing.Size(400, 30);  
            buttonLogar.Text = "ENTRAR";
            buttonLogar.BackColor = ColorTranslator.FromHtml("#7ed957");

            inputCPF.Click += inputCPF_Click;
            buttonLogar.Click += buttonLogar_Click;
            buttonLogar.MouseEnter += buttonLogar_MouseEnter;
            buttonLogar.MouseLeave += buttonLogar_MouseLeave;
            labelNaoTemConta.Click += labelNaoTemConta_MouseClick;
            labelNaoTemConta.MouseEnter += labelNaoTemConta_MouseEnter;
            labelNaoTemConta.MouseLeave += labelNaoTemConta_MouseLeave;
            //checkBoxSenha.CheckedChanged += checkBoxSenha_CheckedChanged;

            Controls.Add(panel);
            Controls.Add(labelDivisao1);
            Controls.Add(labelDivisao2);
            Controls.Add(labelCPFErro);
            Controls.Add(labelSenhaErro);
            Controls.Add(labelCPF);
            Controls.Add(labelSenha);
            Controls.Add(labelNaoTemConta);
            Controls.Add(inputCPF);
            Controls.Add(inputSenha); 
            Controls.Add(checkBoxSenha);
            Controls.Add(buttonLogar);
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

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e) {
            inputSenha.UseSystemPasswordChar = !checkBoxSenha.Checked;
        }

        private void buttonLogar_Click(object sender, EventArgs e) {
            string cpf, senha;
            List<string> errors = new List<string>();

            labelSenhaErro.Text = "";
            labelCPFErro.Text = "";

            if (string.IsNullOrEmpty(inputSenha.Text)) {
                labelSenhaErro.Text = "Campo Obrigatório*";
                errors.Add("Senha é obrigatória");
            } else if (inputSenha.Text.Length < 8 || inputSenha.Text.Length > 40) {
                labelSenhaErro.Text = "Sintaxe Incorreta*";
                errors.Add("Senha deve ter entre 8 e 40 caracteres");
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

            cpf = inputCPF.Text;
            senha = inputSenha.Text;

            Controllers.UsuarioController.VerificaLogin(inputCPF.Text, inputSenha.Text);

            inputCPF.Text = "";
            inputSenha.Text = "";

            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Hide();
        }

        private void buttonLogar_MouseEnter(object sender, EventArgs e) {
            buttonLogar.BackColor = Color.PaleGreen;
        }

        private void buttonLogar_MouseLeave(object sender, EventArgs e) {
            buttonLogar.BackColor = ColorTranslator.FromHtml("#7ed957");
        }

        private void labelNaoTemConta_MouseClick(object sender, EventArgs e) {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void labelNaoTemConta_MouseEnter(object sender, EventArgs e) {
            labelNaoTemConta.ForeColor = Color.Blue;
        }

        private void labelNaoTemConta_MouseLeave(object sender, EventArgs e) {
            labelNaoTemConta.ForeColor = ColorTranslator.FromHtml("#5271FF");
        }

    }

}