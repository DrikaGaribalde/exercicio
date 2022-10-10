using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio21 {
    class Amigo {
        private string Nome;
        private string Apelido;

        public Amigo(string N, string A) {
            Nome = N;
            Apelido = A;
        }

        public override string ToString() {
            return Apelido + ", " + Nome;
        }
    }
}
