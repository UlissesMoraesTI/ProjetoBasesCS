ContaBancaria conta1 = new ContaBancaria();

conta1.Depositar(100);
Console.WriteLine($"Saldo: {conta1.Saldo}");

conta1.Sacar(50);
Console.WriteLine($"Saldo após saque: {conta1.Saldo}");

conta1.Depositar(10);
Console.WriteLine($"Saldo após depósito: {conta1.Saldo}");

Console.WriteLine($"Saldo final: {conta1.ConsultarSaldo()}");

class ContaBancaria
{
    private double saldo;

    public double Saldo
    {
        get { return saldo; }
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor do depósito inválido. Deve ser maior que zero.");
        }
        saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saque inválido. Verifique o valor e o saldo disponível.");
        }
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }
}


