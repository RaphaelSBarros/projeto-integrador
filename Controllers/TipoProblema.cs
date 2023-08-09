using System;
using System.Collections.Generic;

namespace Controllers {
    public static class Tipo_ProblemaController {
        public static void Sincronizar(){
            Models.Tipo_Problema.Sincronizar();
        }

        public static List<Models.Tipo_Problema> ListarProblemas() {
            return Models.Tipo_Problema.ListarProblemas();
        }

        public static Models.Tipo_Problema? GetTipo_Problema(int index) {
            return Models.Tipo_Problema.GetTipo_Problema(index);
        }
    }
}