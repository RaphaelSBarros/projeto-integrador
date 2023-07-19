using System;
using System.Windows.Forms;

namespace Views {

    public class TelaInicial : Form {
        private Label labelFundo;
        private Label labelLinha;
        private Label labelRecepcao;

        public TelaInicial() {
            this.WindowState = FormWindowState.Maximized;

            Image image = Image.FromFile("Layout/IconeResolville.png");
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(1050, 50);
            panel.Size = new Size(100, 100);
            panel.BackgroundImage = image;
            panel.BackgroundImageLayout = ImageLayout.Zoom;

            labelFundo = new Label();
            labelFundo.Location = new System.Drawing.Point(650, 0);
            labelFundo.Size = new System.Drawing.Size(550, 970);
            labelFundo.BackColor = Color.LightGray;
            labelFundo.SendToBack();

            labelLinha = new Label();
            labelLinha.Text = "";
            labelLinha.Location = new System.Drawing.Point(700, 200);
            labelLinha.Size = new System.Drawing.Size(225, 10);
            labelLinha.BackColor = Color.Blue;

            labelLinha = new Label();
            labelLinha.Text = "";
            labelLinha.Location = new System.Drawing.Point(825, 200);
            labelLinha.Size = new System.Drawing.Size(100, 10);
            labelLinha.BackColor = Color.LimeGreen;

            labelLinha = new Label();
            labelLinha.Text = "";
            labelLinha.Location = new System.Drawing.Point(700, 200);
            labelLinha.Size = new System.Drawing.Size(450, 10);
            labelLinha.BackColor = Color.LimeGreen;

            Controls.Add(panel);
            Controls.Add(labelLinha);
            Controls.Add(labelFundo);
        }

    }

}