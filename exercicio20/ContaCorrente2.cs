using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio20 {
    class ContaCorrente2 {
        private double Valor;
        private char Transacao;
        private bool Valida;
        private static double Saldo = 0;
        private static int NumTrans = 0;

        public ContaCorrente2(double V, char T ) {
            if (Validar (V,T) == true)  {
                Valida = true;
                NumTrans++;
                Valor = V;
                Transacao = T;
                NumTrasESaldo();
            }
        }

        private static bool Validar(double V, char T) {
            if (T == 'L' && V > Saldo) {
                return false;
            }
            else {
                return true;
            }
        }

        private void NumTrasESaldo() {
            if (Transacao == 'D') {
                Saldo += Valor;
            }
            else {
                Saldo -= Valor;
            }
        }
        //impressão
        public void ImpressaoTransESaldo() {
            if (Valida == false) {
                Console.WriteLine("Transação anulada", NumTrans);
            }
            else {
                Console.WriteLine($"Transação número  {NumTrans}");
                if (Transacao == 'D') {
                    Console.WriteLine($"Depósito de {Valor}");
                }
                else {
                    Console.WriteLine($"Levantamento de {Valor}");
                }
            }
            Console.WriteLine($"Saldo {Saldo}");
        }
    }
}
