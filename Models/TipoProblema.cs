using System;

namespace Models {
    public class Tipo_Problema {
        public int Code_Problema { get; set; }
        public string Problema_Nome { get; set; }

        public static void Sincronizar(){
            Repositories.Tipo_ProblemaRepository.Sincronizar();
        }

        public static List<Models.Tipo_Problema> ListarProblemas() {
            return Repositories.Tipo_ProblemaRepository.ListarProblemas();
        }
    }
}