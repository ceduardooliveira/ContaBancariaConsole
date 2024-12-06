// Padrão Strategy: Define uma família de algoritmos (estratégias de cálculo de taxas) e permite alternar entre eles.
public interface ITaxaEstrategia
{
    decimal CalcularTaxa(decimal valor);
}