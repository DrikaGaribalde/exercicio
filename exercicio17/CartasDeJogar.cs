using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio17 {
    public class CartasDeJogar {
        private int Naipe;
        private int Carta;

        public CartasDeJogar() {
            Naipe = 0;
            Carta = 0;
        }

        public CartasDeJogar(int NR, int VR) {
            Naipe = NR;
            Carta = VR;
        }

        static string[] Np = { "Ouros", "Espadas", "Paus", "Copas" };
        static string[] Vp = { "2", "3", "4", "5", "6", "7", "Valete", "Dama", "Rei" };

        public string Pnaipe {
            get { return Np[Naipe]; }
        }

        public string Pcarta {
            get { return Vp[Carta]; }
        }
    }
}
