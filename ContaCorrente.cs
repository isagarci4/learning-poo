namespace bytebank{
    public class ContaCorrente 
    {
        // Corpo da classe
        public string titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

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
    }
}
