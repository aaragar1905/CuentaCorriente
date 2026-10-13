namespace CuentaCorriente;

class Program
{
    static void Main(string[] args)
    {
        CuentaCorriente Cuenta1 = new CuentaCorriente(200);
        
        Cuenta1.ConsultarSaldo();
        Cuenta1.IngresarDinero(30);
        Cuenta1.ConsultarSaldo();
        
        Cuenta1.RetirarDinero(15);
        Cuenta1.ConsultarSaldo();
    }
}