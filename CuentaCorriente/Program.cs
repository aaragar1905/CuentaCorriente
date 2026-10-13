namespace CuentaCorriente;

class Program
{
    static void Main(string[] args)
    {
        /*CuentaCorriente Cuenta1 = new CuentaCorriente(200.0f);
        
        Cuenta1.ConsultarSaldo();
        Cuenta1.IngresarDinero(30.0f);
        Cuenta1.ConsultarSaldo();
        
        Cuenta1.RetirarDinero(15.0f);
        Cuenta1.ConsultarSaldo();

        CuentaCorriente Cuenta2 = new CuentaCorriente(500.0f);
        
        Cuenta2.ConsultarSaldo();
        Cuenta2.IngresarDinero(250.5f);
        Cuenta2.ConsultarSaldo();
        
        Cuenta2.RetirarDinero(56.99f);
        Cuenta2.ConsultarSaldo();*/
        
        // -----------------------------------------------------------------------------
        
        CuentaCorrienteCompartida CuentaC1 = new CuentaCorrienteCompartida();
        CuentaCorrienteCompartida CuentaC2 = new CuentaCorrienteCompartida();
        
        CuentaC1.ConsultarSaldo();
        CuentaC2.ConsultarSaldo();
        
        CuentaC1.IngresarDinero(500);
        CuentaC2.ConsultarSaldo();
        
        CuentaC2.IngresarDinero(400);
        CuentaC2.ConsultarSaldo();
        
        CuentaC2.RetirarDinero(200);
        CuentaC1.ConsultarSaldo();
    }
}