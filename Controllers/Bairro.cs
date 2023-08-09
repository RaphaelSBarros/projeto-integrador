using System;
using System.Collections.Generic;

namespace Controllers {
    public static class BairroController {
        public static void Sincronizar(){
            Models.Bairro.Sincronizar();
        }

        public static List<Models.Bairro> ListarBairros() {
            return Models.Bairro.ListarBairros();
        }

        public static Models.Bairro? GetBairro(int index) {
            return Models.Bairro.GetBairro(index);
        }
    }
}