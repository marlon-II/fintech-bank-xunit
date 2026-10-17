namespace EmprestimoServiceTests;
using EmprestimoService;
using Xunit;

public class EmprestimoServiceTests
{

[Theory]
[InlineData(10000.00, 10, 800, 1050.00)] //(Score alto: 5% de juros ->R$ 10.500 / 10 = R$ 1.050)
[InlineData(10000.00, 10, 600, 1120.00)]// (Score médio: 12% dejuros -> R$ 11.200 / 10 = R$ 1.120)
[InlineData(10000.00, 10, 400, 1200.00)] //(Score baixo: 20% de juros-> R$ 12.000 / 10 = R$ 1.200)
    
    public void CalcularValorParcela(decimal valorTotal, int parcelas, int scoreCredito, decimal resultadoEsperado)
    {
        var service = new EmprestimoService();

        var resultadoObtido = service.CalcularValorParcela(valorTotal, parcelas, scoreCredito);

        Assert.Equal(resultadoEsperado , resultadoObtido);
        
    }


    [Theory]
    [InlineData(5000.00, 1500.00, true)] // (Parcela = 30% da renda -> Aprovado)
    [InlineData(5000.00, 1600.00, false)] // (Parcela > 30% da renda -> Recusado)
    public void AprovarEmprestimo(decimal rendaMensal, decimal valorParcela, bool resultadoEsperado)
    {
        var service = new EmprestimoService();

        var resultadoObtido = service.AprovarEmprestimo(rendaMensal, valorParcela);
        
        Assert.Equal(resultadoEsperado , resultadoObtido);
    }
    
}