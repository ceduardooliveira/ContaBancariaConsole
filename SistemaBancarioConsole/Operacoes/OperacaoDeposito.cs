// Implementação do comando para depósito.
public class OperacaoDeposito : IOperacao
{
    private ContaBancaria _conta;
    private decimal _valor;

    public OperacaoDeposito(ContaBancaria conta, decimal valor)
    {
        _conta = conta;
        _valor = valor;
    }

    public void Executar()
    {
        // Realiza o depósito na conta.
        _conta.Depositar(_valor);
    }
}