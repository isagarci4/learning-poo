using System;
using bytebank;

class Program{
    public static void Main (string[] args){
        Console.WriteLine ("Boas Vindas ao seu banco, ByteBank");

        ContaCorrente conta1 = new ContaCorrente();
        conta1.titular = "André Silva";
        conta1.conta = "10123-X";
        conta1.numero_agencia = 23;
        conta1.nome_agencia = "Agência Central";
        conta1.saldo = 100;

        ContaCorrente conta2 = new ContaCorrente();
        conta2.titular = "Isadora Garcia";
        conta2.conta = "111999-X";
        conta2.numero_agencia = 58;
        conta2.nome_agencia = "Agência Central";
        conta2.saldo = 100;

        // Console.WriteLine("Titular: " + conta1.titular);
        // Console.WriteLine("Conta: " + conta1.conta);
        // Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
        // Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
        // Console.WriteLine("Saldo: " + conta1.saldo);

        // Comparacao de conteúdo >> tipagem por valor 
        double saldo = 100;
        double saldo2 = conta1.saldo;
        Console.WriteLine(saldo == saldo2); 

        // Tipagem por referência
        // conta1 = conta2; // aponta para o mesmo endereço de memória, por isso agora se comparadas o resultado será TRUE

        Console.WriteLine("Saldo atual: " + conta1.saldo);
        bool saque = conta1.Sacar(50);
        Console.WriteLine("Saque realizado? " + saque);
        Console.WriteLine("Saldo pós saque: " + conta1.saldo);

        conta1.Depositar(60);
        Console.WriteLine("Saldo pós deposito: " + conta1.saldo);

        Console.ReadKey();
    }
}