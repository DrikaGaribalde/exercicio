using System;

namespace exercicio19 {
    class Program {
        static void Main(string[] args) {
            ContaCorrente c1 = new ContaCorrente(100, 'D');
            c1.ImpressaoTransESaldo();
            ContaCorrente c2 = new ContaCorrente(50, 'L');
            c2.ImpressaoTransESaldo();
            ContaCorrente c3 = new ContaCorrente(1000, 'D');
            c3.ImpressaoTransESaldo();
            ContaCorrente c4 = new ContaCorrente(500, 'L');
            c4.ImpressaoTransESaldo();

        }
    }
}
