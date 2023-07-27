using System;
using System.Windows.Forms;

namespace Views {
    public class Login : Form {
        //private Exemplo exemplo;
        private Label labelFundo;
        private Label labelDivisao1;
        private Label labelDivisao2;
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
            Controls.Add(labelCPF);
            Controls.Add(labelSenha);
            Controls.Add(labelNaoTemConta);
            Controls.Add(inputCPF);
            Controls.Add(inputSenha); 
            Controls.Add(checkBoxSenha);
            Controls.Add(buttonLogar);
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

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e) {
            inputSenha.UseSystemPasswordChar = !checkBoxSenha.Checked;
        }

        private void buttonLogar_Click(object sender, EventArgs e) {
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