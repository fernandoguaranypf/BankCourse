using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCourse
{
    class ContaBancaria
    {
        // ENCAPSULAMENTO: Private set para que o saldo e a conta não sejam alterados livremente
        public int Numero { get; private set; }
        public string Titular { get; set; } // Titular pode mudar de nome
        public double Saldo { get; private set; }

        // CONSTRUTOR 1: Para quando NÃO há depósito inicial
        public ContaBancaria(int numero, string titular)
        {
            this.Numero = numero; // Uso do 'this' para referenciar o atributo da classe
            this.Titular = titular;
        }

        // SOBRECARGA: Construtor 2 para quando HÁ depósito inicial
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        // Método para depósito
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
