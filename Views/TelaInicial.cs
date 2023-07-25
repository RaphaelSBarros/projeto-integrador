using System;
using System.Windows.Forms;

namespace Views {

    public class TelaInicial : Form {
        private Label labelFundo;
        private Label labelDivisao1;
        private Label labelDivisao2;
        private Label labelLinha1;
        private Label labelLinha2;
        private Label labelFoto;
        private Label labelOla;
        private Label labelNome;
        private Label labelIconeInicioSelecionado;
        private Label labelIconeInicio;
        private Label labelIconeRelatarSelecionado;
        private Label labelIconeRelatar;
         

        public TelaInicial() {
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

            /*labelFundo = new Label();
            labelFundo.Location = new System.Drawing.Point(650, 0);
            labelFundo.Size = new System.Drawing.Size(550, 970);
            labelFundo.BackColor = Color.LightGray;
            labelFundo.SendToBack();*/

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

            labelOla = new Label();
            labelOla.Text = "Olá";
            labelOla.Location = new System.Drawing.Point(790, 80);
            labelOla.Size = new System.Drawing.Size(41, 25);
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

            labelIconeInicioSelecionado = new Label();
            labelIconeInicioSelecionado.Location = new System.Drawing.Point(700, 50);
            labelIconeInicioSelecionado.Size = new System.Drawing.Size(80, 80);

            labelIconeRelatar = new Label();
            labelIconeRelatar.Location = new System.Drawing.Point(700, 50);
            labelIconeRelatar.Size = new System.Drawing.Size(80, 80);

            labelIconeInicio = new Label();
            labelIconeInicio.Location = new System.Drawing.Point(700, 50);
            labelIconeInicio.Size = new System.Drawing.Size(80, 80);

            labelIconeRelatarSelecionado = new Label();
            labelIconeRelatarSelecionado.Location = new System.Drawing.Point(700, 50);
            labelIconeRelatarSelecionado.Size = new System.Drawing.Size(80, 80);

            Controls.Add(panel);
            Controls.Add(labelDivisao1);
            Controls.Add(labelDivisao2);
            Controls.Add(labelLinha1);
            Controls.Add(labelLinha2);
            Controls.Add(labelOla);
            Controls.Add(labelNome);
            Controls.Add(labelFoto);
            Controls.Add(labelIconeInicioSelecionado);
            Controls.Add(labelIconeInicio);
            Controls.Add(labelIconeRelatarSelecionado);
            Controls.Add(labelIconeRelatar);
            Controls.Add(labelFundo);
        }

    }

}