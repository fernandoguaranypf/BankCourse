using System.Globalization;
using BankCourse;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta;

        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char resp = char.Parse(Console.ReadLine().ToLower());

        if (resp == 's')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Utiliza o construtor com 3 argumentos
            conta = new ContaBancaria(numero, titular, depositoInicial);
        }
        else
        {
            // Utiliza o construtor com 2 argumentos (sobrecarga)
            conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine("\nDados da conta:");
        Console.WriteLine(conta);
    }
}
