namespace FintechBank.Tests;

public class ContaCorrenteServiceTests()
{

[Theory]
[InlineData(6000.00, false, 0.00)] //(Saldo alto -> Isento)
[InlineData(500.00, true, 0.00)] //(Cliente Especial -> Isento)
[InlineData(2500.00, false, 12.50)] //(Saldo intermediário -> R$12,50)
[InlineData(300.00, false, 25.00)] //(Saldo baixo -> R$ 25,00)
    
    public void ()
    {
        Assert.True();
        Assert.Equal();
    }


[Theory]
[InlineData(1000.00, 500.00, 1200.00, true)] //(Dentro do limite total -> true)
[InlineData(1000.00, 500.00, 1600.00, false)] //(Excede saldo + limite-> false)

    public void ()
    {
        Assert.True();
        Assert.Equal();
    }
    
}
