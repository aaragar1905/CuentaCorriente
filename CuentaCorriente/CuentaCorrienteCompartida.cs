using System.Collections;

namespace CuentaCorriente;

public class CuentaCorrienteCompartida
{
    static private float Balance;

    public CuentaCorrienteCompartida()
    {
        Balance = 0.0f;
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