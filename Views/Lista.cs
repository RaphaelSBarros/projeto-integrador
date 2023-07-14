using System;
using System.Windows.Forms;

namespace Views
{
    public class Lista : Form
    {
        private Form parent;
        private ListBox lstItems;
        private Button btnButton;

        public Lista(Form parent)
        {
            this.parent = parent;
            
            this.Size = new System.Drawing.Size(400, 400);
            
            this.lstItems = new ListBox();
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(12, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(200, 147);
            this.lstItems.TabIndex = 0;
            this.GetPessoas();

            btnButton = new Button();
            btnButton.Text = "Alterar";
            btnButton.Location = new System.Drawing.Point(150, 200);
            btnButton.Click += FuncUpd;

            //Image image = Image.FromFile("Layout/sextou.png");
            // this.BackgroundImage = image;

            Panel panel = new Panel();
            panel.Location = new Point(250, 50);
            panel.Size = new Size(200, 200);
            //panel.BackgroundImage = image;
            //panel.BackgroundImageLayout = ImageLayout.Zoom;

            Controls.Add(lstItems);
            Controls.Add(btnButton);
            Controls.Add(panel);

            FormClosed += AoFechar;
        }

        private void GetPessoas(){
            List<Models.Usuario> usuarios = Controllers.UsuarioController.ListarUsuarios();

            foreach (var usuario in usuarios)
            {
                this.lstItems.Items.Add(usuario.Nome);
            }
        }
        
        private void FuncAdd(object sender, EventArgs e){
            // Chama a pagina de cadastrar com o controller de cadastrar
        }
        
        private void FuncUpd(object sender, EventArgs e){
            // Chama a pagina de alterar e manda o id do selecionado na lista com o controller de alterar
            MessageBox.Show(
                this.lstItems.SelectedItem.ToString(),
                "Info",
                MessageBoxButtons.OK
            );
        }

        private void FuncDel(object sender, EventArgs e){
            // Chama a função de deletar e passa o id
        }

        private void AoFechar(object sender, FormClosedEventArgs e){
            this.parent.Show();
        }
    }
}
