using System;
using System.Windows.Forms;

namespace Views {

    public class TelaInicial : Form {
        private Label labelFundo;
        private Label labelLinha1;
        private Label labelLinha2;
        private Label labelLinha3;
        private Label labelOla;
        private Label labelNome;
        private Label labelFoto;

        public TelaInicial() {
            this.WindowState = FormWindowState.Maximized;

            Image image = Image.FromFile("Layout/IconeResolville.png");
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(1070, 50);
            panel.Size = new Size(80, 80);
            panel.BackgroundImage = image;
            panel.BackgroundImageLayout = ImageLayout.Zoom;

            labelFundo = new Label();
            labelFundo.Location = new System.Drawing.Point(650, 0);
            labelFundo.Size = new System.Drawing.Size(550, 970);
            labelFundo.BackColor = Color.LightGray;
            labelFundo.SendToBack();

            labelLinha1 = new Label();
            labelLinha1.Text = "";
            labelLinha1.Location = new System.Drawing.Point(700, 150);
            labelLinha1.Size = new System.Drawing.Size(225, 8);
            labelLinha1.BackColor = Color.Blue;

            labelLinha2 = new Label();
            labelLinha2.Text = "";
            labelLinha2.Location = new System.Drawing.Point(925, 150);
            labelLinha2.Size = new System.Drawing.Size(225, 8);
            labelLinha2.BackColor = Color.LimeGreen;

            labelLinha3 = new Label();
            labelLinha3.Text = "";
            labelLinha3.Location = new System.Drawing.Point(700, 800);
            labelLinha3.Size = new System.Drawing.Size(450, 8);
            labelLinha3.BackColor = Color.Blue;

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
            labelNome.ForeColor = Color.LimeGreen;
            fonte = new Font("Arial", 14, FontStyle.Bold);
            labelOla.Font = fonte;

            labelFoto = new Label();
            labelFoto.Location = new System.Drawing.Point(700, 50);
            labelFoto.Size = new System.Drawing.Size(80, 80);

            Controls.Add(panel);
            Controls.Add(labelLinha1);
            Controls.Add(labelLinha2);
            Controls.Add(labelLinha3);
            Controls.Add(labelOla);
            Controls.Add(labelNome);
            Controls.Add(labelFoto);
            Controls.Add(labelFundo);
        }

    }

}