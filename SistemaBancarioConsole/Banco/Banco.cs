using System.Collections.Generic;

// Padrão Singleton: Garante que o sistema use apenas uma instância da classe Banco.
public class Banco
{
    private static Banco _instancia; // Instância única do Banco.

    public List<ContaBancaria> Contas { get; private set; }

    private Banco()
    {
        Contas = new List<ContaBancaria>();
    }

    public static Banco Instancia
    {
        get
        {
            // Se a instância ainda não existe, cria uma nova. Caso contrário, retorna a já existente.
            if (_instancia == null)
            {
                _instancia = new Banco();
            }
            return _instancia;
        }
    }

    public void AdicionarConta(ContaBancaria conta)
    {
        Contas.Add(conta);
    }
}
