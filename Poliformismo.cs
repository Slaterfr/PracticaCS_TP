// Clase Calculadora con mwtodos sobrecargados para sumar
public class Calculadora
{
    // Mwtodo para sumar dos enteros
    public int Sumar(int a, int b)
    {
        Console.WriteLine($"La suma de {a} + {b} es igual a {a+b}");
        return a + b;
    }

    // Metodo sobrecargado para sumar tres enteros
    public int Sumar(int a, int b, int c)
    {
        Console.WriteLine($"La suma de {a} + {b} + {c} es igual a {a+b+c}");
        return a + b + c;
    }

    // Metodo sobrecargado para sumar dos numeros double
    public double Sumar(double a, double b)
    {
        Console.WriteLine($"La suma de {a} + {b} es igual a {a+b}");
        return a + b;
    }
}

// Programa principal para probar los metodos sobrecargados
class Program
{
    static void Main(string[] args)
    {
        Calculadora Calc1 = new Calculadora();
        Calc1.Sumar(3, 2);
        Calc1.Sumar(3, 2, 5);
        Calc1.Sumar(250.5, 250.3);
    }
}











