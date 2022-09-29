using System;

namespace exercicio16 {
    class Program {
        static void Main(string[] args) {
            Aluno.AtribuicaoLimites(0,20);
            Console.WriteLine("Digite o nome do aluno:");
            string N = Console.ReadLine();
            Aluno A = new Aluno(N);
            Console.WriteLine(A.NomeENota());
        }
    }  
}
