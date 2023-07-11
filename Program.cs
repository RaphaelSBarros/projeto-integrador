using System;
using System.Collections.Generic;

namespace introCSharp
{
    class Program
    {
        static void Main(string[] args) {
            int op = 0;
            do{
                Console.WriteLine("\n\n");
                Console.WriteLine("Informe uma opção abaixo: ");
                Console.WriteLine(
                    "1- Adicionar um Usuario\n"+
                    "2- Listar todos os Usuarios\n"+
                    "3- Alterar um Usuario \n"+
                    "4- Excluir um Usuario \n"+
                    "5- Sair \n"
                );
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch (op)
                {
                    case 1:{
                        Views.UsuarioView.addUsuario();
                        break;
                    }
                    case 2:{
                        Views.UsuarioView.ListarUsuarios();
                        break;
                    }
                    case 3:{
                        Views.UsuarioView.AlterarUsuario();
                        break;
                    }
                    case 4:{
                        Views.UsuarioView.RemoverUsuario();
                        break;
                    }
                    case 5:{
                        Console.WriteLine("Finalizando . . .");
                        break;
                    }
                    default:{
                        Console.WriteLine("Número inválido");
                        break;
                    }
                }
            }while(op!=5);
        }
    }
}
