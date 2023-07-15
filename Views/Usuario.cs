using System;
namespace Views
{
    public class UsuarioView
    {
        public static void addUsuario(){
            string nome, apelido, email, cpf, endereco, telefone, senha;

            try{
                Console.WriteLine("Digite o seu Nome Completo: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o seu Nome de Usuário: ");
                apelido = Console.ReadLine();

                Console.WriteLine("Digite o seu Email: ");
                email = Console.ReadLine();

                Console.WriteLine("Digite o seu cpf (utilize apenas números): ");
                cpf = Console.ReadLine();

                Console.WriteLine("Digite o seu endereco: ");
                endereco = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone: ");
                telefone = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();

                Controllers.UsuarioController.addUsuario(nome, apelido, email, cpf, endereco, telefone, senha);
            }catch(Exception e){
                Console.WriteLine($"Erro: {e}");
            }
        }

        public static void ListarUsuarios(){
            int i=0;
            Console.WriteLine(" - Lista de Usuarios cadastrados - \n");
            foreach(Models.Usuario Usuario in Controllers.UsuarioController.ListarUsuarios()){
                Console.WriteLine($"ID: {i}");
                Console.WriteLine(Usuario);
                Console.WriteLine("--------------\n");
                i++;
            }
        }

        public static void AlterarUsuario(){
            Console.WriteLine("Informe o ID do Usuario que deseja alterar:  ");
            int indice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os dados atualizados: \n");

            Console.WriteLine("Digite o seu Nome: ");
            string Anome = Console.ReadLine();

            Console.WriteLine("Digite o seu Nome de Usuário: ");
            string Aapelido = Console.ReadLine();

            Console.WriteLine("Digite o seu Email: ");
            string Aemail = Console.ReadLine();

            Console.WriteLine("Digite o seu cpf (utilize apenas números): ");
            string Acpf = Console.ReadLine();

            Console.WriteLine("Digite o seu endereco: ");
            string Aendereco = Console.ReadLine();

            Console.WriteLine("Digite o seu telefone: ");
            string Atelefone = Console.ReadLine();

            Console.WriteLine("Digite sua senha");
            string Asenha = Console.ReadLine();

            Controllers.UsuarioController.AlterarUsuarios(indice, Anome, Aapelido, Aemail, Acpf, Aendereco, Atelefone, Asenha);

            Console.WriteLine("Alterado com sucesso!");    
        }

        public static void RemoverUsuario(){
            Console.WriteLine("Informe o ID do Usuario que deseja remover: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            Controllers.UsuarioController.removeUsuario(indice);
        }
    }
}