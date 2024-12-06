public class ContaBancaria
{
    public string Titular { get; }
    public decimal Saldo { get; private set; }
    public string TipoConta { get; }

    public ContaBancaria(string titular, decimal saldoInicial, string tipoConta)
    {
        Titular = titular;
        Saldo = saldoInicial;
        TipoConta = tipoConta;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
        Saldo -= valor;
    }

    public void Transferir(decimal valor, ContaBancaria contaDestino)
    {
        Sacar(valor);
        contaDestino.Depositar(valor);
    }
}
