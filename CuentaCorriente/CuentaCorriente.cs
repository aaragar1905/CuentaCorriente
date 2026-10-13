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
    
    public float GetSaldo()
    {
        return Balance;
    }

    public void IngresarDinero(float Dinero)
    {
        if (Dinero > 0.0f)
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