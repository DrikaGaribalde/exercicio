using System;

namespace exercicio17 {
    class Program {
        static void Main(string[] args) {
            //implementar a classe CartasDeJogar
            Random R = new Random();
            CartasDeJogar[] Extraidas = new CartasDeJogar[2];
            for (int i = 0; i <= 1; i++) {
                Extraidas[i] = new CartasDeJogar(R.Next(4), R.Next(9));
                Console.WriteLine(Extraidas[i].Pcarta + " de " + Extraidas[i].Pnaipe);
            }
        }
    }
}
