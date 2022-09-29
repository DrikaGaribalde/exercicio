using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio16 {
    public class Aluno {
        private string Nome;
        private int Nota;
        private static int Inf;
        private static int Sup;

        public Aluno() {
            Nome = "";
            Nota = 0;
        }
        public Aluno(string N) {
            Nome = N;
            int X = 0;
            bool Valida = false;
            while (Valida == false) {
                try {
                    Console.Write($"Digite a nota do aluno {Nome}  ");
                    X = Convert.ToInt16(Console.ReadLine());
                    Valida = X >= Inf && X <= Sup;
                    if (Valida == false) {
                        throw new Exception();
                    }
                }
                catch (Exception) {
                    Console.WriteLine($"A nota é um número inteiro entre {Inf} e {Sup} ");
                }
            }
            Nota = X;
        }
        public static void AtribuicaoLimites(int I, int S) {
            Inf = I;
            Sup = S;
        }
        public string NomeENota() {
            return Nome + " obteve a classificação " + Nota;
        }
    }
}
