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

        ContaCorrente conta3 = new ContaCorrente();


        // Console.WriteLine("Titular: " + conta1.titular);
        // Console.WriteLine("Conta: " + conta1.conta);
        // Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
        // Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
        // Console.WriteLine("Saldo: " + conta1.saldo);

        Console.WriteLine("Titular: " + conta3.titular);
        Console.WriteLine("Conta: " + conta3.conta);
        Console.WriteLine("Número Agencia: " + conta3.numero_agencia);
        Console.WriteLine("Nome da Agencia: " + conta3.nome_agencia);
        Console.WriteLine("Saldo: " + conta3.saldo);
        Console.WriteLine("Verificador: " + conta3.verificador);

        Console.ReadKey();
    }
}