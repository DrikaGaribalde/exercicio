using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio19 {
    class ContaCorrente {
        private double Valor;
        private char Transacao;
        private static double Saldo = 0;
        private static int NumTrans = 0;
        public ContaCorrente(double V, char T) {
            Valor = V;
            Transacao = T;
            NumTransESaldo();
        }

        public void NumTransESaldo() {
            NumTrans++;
            if (Transacao == 'D') {
                Saldo += Valor;
            }
            else {
                Saldo -= Valor;
            }
        }

        public void ImpressaoTransESaldo() {
            Console.WriteLine($"Transação número {NumTrans}");
            if (Transacao == 'D') {
                Console.WriteLine($"Depósito de {Valor} reais");
            }
            else {
                Console.WriteLine($"Levantamento de {Valor} reais");
            }
            Console.WriteLine($"Saldo {Saldo} reais");
        }
    }
}
