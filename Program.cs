using System.Globalization;
using System.IO.Pipes;

namespace Course {
    class Program {
        static void Main(string[] args) {

            string nome = "Maria";
            int idade = 32;
            float saldo = 10.35784f;

            Console.WriteLine("{0} tem {1} anos e tem um saldo em conta de R$ {2:F2}", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem um saldo em conta de R$ {saldo:F2}");
            Console.WriteLine(nome + " tem " + idade + " anos e tem um saldo em conta de R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
        }
    }
}
