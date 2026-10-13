namespace CuentaCorriente;

public class CuentaCorriente
{
    private float Balance;

    public CuentaCorriente(float Balance)
    {
        this.Balance = Balance;
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine("Saldo: " + Balance + " euros.");
    }

    public void IngresarDinero(float Dinero)
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

    public void RetirarDinero(float Dinero)
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