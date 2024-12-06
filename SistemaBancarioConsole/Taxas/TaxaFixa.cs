// Estratégia de cálculo com taxa fixa.
public class TaxaFixa : ITaxaEstrategia
{
    public decimal CalcularTaxa(decimal valor) => 5;
}