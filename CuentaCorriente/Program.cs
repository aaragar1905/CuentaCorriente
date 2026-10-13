namespace CuentaCorriente;

class Program
{
    static void Main(string[] args)
    {
        CuentaCorriente Cuenta1 = new CuentaCorriente(200.0f);
        
        Cuenta1.ConsultarSaldo();
        Cuenta1.IngresarDinero(30.0f);
        Cuenta1.ConsultarSaldo();
        
        Cuenta1.RetirarDinero(15.0f);
        Cuenta1.ConsultarSaldo();
    }
}