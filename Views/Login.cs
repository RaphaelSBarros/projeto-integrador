using System;
using System.Windows.Forms;

namespace Views {
    public class Login : Form {

        //private Exemplo exemplo;
        private Label labelNome;
        private Label labelSenha;
        private TextBox inputNome;
        private TextBox inputSenha;
        private Button buttonLogar;

        public Login() {
            labelNome = new Label();
            labelNome.Text = "Nome:";
            labelNome.Location = new System.Drawing.Point(50, 50);

            inputNome = new TextBox();
            inputNome.Location = new System.Drawing.Point(50, 50); 
            inputNome.Name = "Nome";
            inputNome.Size = new System.Drawing.Size(200, 20);

            labelSenha = new Label();
            labelSenha.Text = "Senha:";
            labelSenha.Location = new System.Drawing.Point(50, 50);

            inputSenha = new TextBox();
            inputSenha.Location = new System.Drawing.Point(50, 200); 
            inputSenha.Name = "Senha";
            inputSenha.PasswordChar = '*';
            inputSenha.Size = new System.Drawing.Size(200, 20);

            buttonLogar = new Button();
            buttonLogar.Text = "Clique Aqui";
            buttonLogar.Location = new System.Drawing.Point(50, 250);
            //buttonLogar.Click += ClickLogar;

            this.Size = new System.Drawing.Size(400, 400);

            Controls.Add(labelNome);
            Controls.Add(inputNome);
            Controls.Add(labelSenha);
            Controls.Add(inputSenha); 
            Controls.Add(buttonLogar);
        }

        /*private void ClickLogar(object? sender, EventArgs e) {
            exemplo = new Exemplo(this);
            exemplo.Show();
            this.Hide();
        }*/
    }
}