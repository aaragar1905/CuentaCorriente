namespace CuentaCorriente;

public class CuentaCorriente
{
    private int Balance;

    public CuentaCorriente(int Balance)
    {
        this.Balance = Balance;
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine("Saldo: " + Balance + " euros.");
    }

    public void IngresarDinero(int Dinero)
    {
        if (Dinero > 0)
        {
            Balance += Dinero;
        }
        else
        {
            Console.WriteLine("Dinero insuficiente.");
        }
    }

    public void RetirarDinero(int Dinero)
    {
        if (Balance >= Dinero)
        {
            Balance -= Dinero;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}