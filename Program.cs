using System;

namespace Views // mudar para PROGRAMA?
{
    public class Program {
        
        [STAThread]
        public static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Cadastro()); 
        }    
    }
}