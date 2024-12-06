// Padrão Factory Method: Define uma interface para criação de objetos (Contas Bancárias) sem especificar diretamente suas classes concretas.
public abstract class ContaFactory
{
    public abstract ContaBancaria CriarConta(string titular, decimal saldoInicial);
}

// Implementação do Factory Method para criar uma Conta Corrente.
public class ContaCorrenteFactory : ContaFactory
{
    public override ContaBancaria CriarConta(string titular, decimal saldoInicial)
    {
        // Criação de uma Conta Corrente.
        return new ContaBancaria(titular, saldoInicial, "Corrente");
    }
}

// Implementação do Factory Method para criar uma Conta Poupança.
public class ContaPoupancaFactory : ContaFactory
{
    public override ContaBancaria CriarConta(string titular, decimal saldoInicial)
    {
        // Criação de uma Conta Poupança.
        return new ContaBancaria(titular, saldoInicial, "Poupança");
    }
}
