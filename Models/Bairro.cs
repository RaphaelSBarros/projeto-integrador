using System;

namespace Models {
    public class Bairro {
        public int ID_Bairro { get; set; }
        public string Bairro_Nome { get; set; }
        public static void Sincronizar(){
            Repositories.BairroRepository.Sincronizar();
        }

        public static List<Models.Bairro> ListarBairros() {
            return Repositories.BairroRepository.ListarBairros();
        }

        public static Bairro? GetBairro(int index) {
            return Repositories.BairroRepository.GetBairro(index);
        }
    }
}