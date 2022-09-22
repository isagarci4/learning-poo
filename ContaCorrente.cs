using bytebank.Titular;

namespace bytebank{
    public class ContaCorrente 
    {
        // Corpo da classe
        public Cliente titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        private double saldo; // o atributo privado só pode ser acessado através de um método

        // Método(comportamento de uma classe) sacar
        public bool Sacar(double valor)
        {
            if(saldo < valor){
                return false;
            }
            if(valor < 0){
                return false;
            }else{
                saldo = saldo - valor;
                return true;
            }
        }

        // Método(void) não retorna valor, só é executado
        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(saldo < valor){
                return false;
            }
            if(valor < 0){
                return false;
            }
            else{
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
        
        public void DefinirSaldo(double valor)
        {
            if(valor < 0){
                return;
            }else{
                saldo = saldo + valor;
            }
        }

        public double ObterSaldo()
        {
            return saldo;
        }
    }
}
