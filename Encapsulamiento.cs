
// Clase que representa una cuenta bancaria con encapsulamiento
public class Cuenta_Bancaria
{
    private double Saldo; // Atributo privado para almacenar el saldo

    // Constructor que inicializa la cuenta
    public Cuenta_Bancaria(double Saldo_Inicial)
    {
        if (Saldo_Inicial >= 0)
        {
            Saldo_Inicial = Saldo;
            Console.WriteLine($"saldo inicial: {Saldo}");
        }
        else
        {
            Console.WriteLine("el saldo inicial no puede ser negativo.");
        }
    }

    // Metodo para depositar dinero 
    public void Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            Saldo = +cantidad;
        }
        else if (cantidad <= 0)
        {
            Console.WriteLine("Debe ingresar una cantidad mayor a 0");
        }
    }

    // Metodo para retirar dinero
    public void Retirar(double cantidad)
    {
        if (cantidad > 0)
        {
            Saldo = -cantidad;
        }
        else if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad a ingresar debe ser mayor a cero");
        }
        else if (Saldo <= 0)
        {
            Console.WriteLine("El saldo es insuficiente para retirar");
        }
    }

    // Metodo para obtener el saldo actual
    public double Obtener_Saldo()
    {
        return Saldo;
    }
}

// Programa principal para probar la clase
class Program
{
    static void Main(string[] args)
    {
        Cuenta_Bancaria cuenta = new Cuenta_Bancaria(2500);
        cuenta.Depositar(3000);
        Console.WriteLine($"Saldo actual: {cuenta.Obtener_Saldo()}");
        cuenta.Retirar(1300);
        Console.WriteLine($"Saldo actual: {cuenta.Obtener_Saldo()}");
    }
}











