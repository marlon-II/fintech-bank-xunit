namespace ContaCorrenteService1;

public class ContaCorrenteService()
{
    public decimal CalcularTaxaManutencao(decimal saldo, bool clienteEspecial)
    {
        if (saldo >= 5000 || clienteEspecial == true) {
        return 0.0m;
    }
        if (saldo >= 1000 && saldo < 5000 && clienteEspecial == false)
        {
            return 12.50m;
        }
        return 25m;
    }

    public bool PodeRealizarSaque(decimal saldo, decimal limiteChequeEspecial, decimal valorSaque)
    {
        decimal somaSaldoEChequeEspecial = saldo + limiteChequeEspecial;
        if (valorSaque <= somaSaldoEChequeEspecial)
        {
            return true;
        }
        return false;
    }
}