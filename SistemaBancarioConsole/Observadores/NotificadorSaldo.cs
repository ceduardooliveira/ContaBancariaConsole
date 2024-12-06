public class NotificadorSaldo : IObservador
{
    public void Atualizar(ContaBancaria conta)
    {
        // Exibe uma mensagem toda vez que o saldo da conta é atualizado.
        Console.WriteLine($"[Notificação] Saldo atualizado na conta de {conta.Titular}: {conta.Saldo:C}");
    }
}