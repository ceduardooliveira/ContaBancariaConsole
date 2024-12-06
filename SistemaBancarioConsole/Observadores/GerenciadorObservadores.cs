public class GerenciadorObservadores
{
    private List<IObservador> _observadores = new List<IObservador>();

    public void AdicionarObservador(IObservador observador)
    {
        // Adiciona um observador à lista.
        _observadores.Add(observador);
    }

    public void NotificarTodos(ContaBancaria conta)
    {
        // Notifica todos os observadores sobre uma atualização.
        foreach (var observador in _observadores)
        {
            observador.Atualizar(conta);
        }
    }
}
