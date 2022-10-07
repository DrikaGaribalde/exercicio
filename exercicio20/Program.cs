using System;

namespace exercicio20 {
    class Program {
        static void Main(string[] args) {
            ContaCorrente2 c1 = new ContaCorrente2(100, 'D');
            c1.ImpressaoTransESaldo();

            ContaCorrente2 c2 = new ContaCorrente2(1000, 'L');
            c2.ImpressaoTransESaldo();

            ContaCorrente2 c3 = new ContaCorrente2(200, 'D');
            c3.ImpressaoTransESaldo();

            ContaCorrente2 c4 = new ContaCorrente2(50, 'L');
            c4.ImpressaoTransESaldo();
        }
    }
}
