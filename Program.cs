using System;
using bytebank;
using bytebank.Titular;


class Program{
    public static void Main (string[] args){
        Console.WriteLine ("Boas Vindas ao seu banco, ByteBank");

        ContaCorrente conta1 = new ContaCorrente();
        //conta1.titular = "André Silva";
        conta1.Conta = "10123-X";
        conta1.Numero_agencia = 23;
        conta1.Nome_agencia = "Agência Central";
        conta1.Saldo = 100;

        ContaCorrente conta2 = new ContaCorrente();
        //conta2.titular = "Isadora Garcia";
        conta2.Conta = "111999-X";
        conta2.Numero_agencia = 58;
        conta2.Nome_agencia = "Agência Central";
        conta2.Saldo = 100;

        // Console.WriteLine("Titular: " + conta1.titular);
        // Console.WriteLine("Conta: " + conta1.conta);
        // Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
        // Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
        // Console.WriteLine("Saldo: " + conta1.saldo);

        // Comparacao de conteúdo >> tipagem por valor 
        // double saldo = 100;
        // double saldo2 = conta1.saldo;
        // Console.WriteLine(saldo == saldo2); 

        // Tipagem por referência
        // conta1 = conta2; // aponta para o mesmo endereço de memória, por isso agora se comparadas o resultado será TRUE

        // Console.WriteLine("Saldo atual: " + conta1.saldo);
        // bool saque = conta1.Sacar(50);
        // Console.WriteLine("Saque realizado? " + saque);
        // Console.WriteLine("Saldo pós saque: " + conta1.saldo);
        // conta1.Depositar(60);
        // Console.WriteLine("Saldo pós deposito: " + conta1.saldo);

        // Console.WriteLine("Saldo conta 2 pré transferencia: " + conta2.saldo);
        // Console.WriteLine("Saldo conta 1 pré transferencia: " + conta1.saldo);

        // bool transferencia = conta1.Transferir(50, conta2);

        // Console.WriteLine("A transferência deu certo? " + transferencia);
        // Console.WriteLine("Saldo conta 2 pos transferencia: " + conta2.saldo);
        // Console.WriteLine("Saldo conta 1 pos transferencia: " + conta1.saldo);

        // Cliente cliente = new Cliente();
        // cliente.nome = "André Silva";
        // cliente.cpf = "43680971818";
        // cliente.profissao = "Programadora C#";

        ContaCorrente conta3 = new ContaCorrente();
        conta3.titular = new Cliente(); 
        conta3.titular.Nome = "André Silva"; // essa referência seria nula se a classe Cliente não fosse chamada asssim
        conta3.Conta = "2513252-X";
        conta3.Numero_agencia = 35;
        conta3.Nome_agencia = "Agência Central";

        Cliente sarah = new Cliente();
        sarah.Nome = "Sara Silva";

        ContaCorrente conta4 = new ContaCorrente();
        conta4.Saldo = 100;
        conta4.Titular =  sarah;
        conta4.Numero_agencia = -10;
        conta4.Conta = "";


        Console.WriteLine("Saldo "+ conta4.Saldo);

        Console.ReadKey();
    }
}