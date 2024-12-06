// Estratégia de cálculo com taxa percentual.
public class TaxaPorcentagem : ITaxaEstrategia
{
    public decimal CalcularTaxa(decimal valor) => valor * 0.02m;
}