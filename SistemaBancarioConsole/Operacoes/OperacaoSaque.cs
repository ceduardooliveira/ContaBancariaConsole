// Implementação do comando para saque.
public class OperacaoSaque : IOperacao
{
    private ContaBancaria _conta;
    private decimal _valor;

    public OperacaoSaque(ContaBancaria conta, decimal valor)
    {
        _conta = conta;
        _valor = valor;
    }

    public void Executar()
    {
        // Realiza o saque na conta.
        _conta.Sacar(_valor);
    }
}