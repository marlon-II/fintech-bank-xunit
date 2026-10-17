namespace EmprestimoService;

public class EmprestimoService()
{
    public decimal CalcularValorParcela(decimal valorTotal, int parcelas, int scoreCredito)
    {
        if (parcelas <= 0)
        {
            return 0m;
        }
        decimal valorComJuros;

        if (scoreCredito >= 700)
        {
            valorComJuros = valorTotal * 1.05m;
        }
        else if (scoreCredito >= 500)
        {
            valorComJuros = valorTotal * 1.12m;
        }
        else
        {
            valorComJuros = valorTotal * 1.2m;
        }
        return valorComJuros / parcelas;
    }

    public bool AprovarEmprestimo(decimal rendaMensal, decimal valorParcela)
    {
        if (valorParcela <= rendaMensal * 0.30m)
        {
            return true;
        }
        return false;
    }
}