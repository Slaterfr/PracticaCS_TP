// Clase abstracta Figura con metodo abstracto CalcularArea
public abstract class Figura
{
    int dato1;
    int dato2;

    // Metodo abstracto que debe ser implementado por clases hijas
    public abstract void CalcularArea(int dato1, int dato2);
}

// Clase Cuadrado que hereda de Figura e implementa CalcularArea
public class Cuadrado : Figura
{
    public override void CalcularArea(int lado1, int lado2)
    {
        double Area = lado1 * lado2;
        Console.WriteLine($"El area del Cuadrado es: {Area}");
    }
}

// Clase Triangulo que hereda de Figura e implementa CalcularArea
public class Triangulo : Figura
{
    public override void CalcularArea(int Base, int altura)
    {
        double Area = (Base * altura) / 2;
        Console.WriteLine($"El area del Triangulo es: {Area}");
    }
}

// Programa principal para probar las figuras
class Program
{
    static void Main(string[] args)
    {
        Cuadrado Cuadrado1 = new Cuadrado();
        Cuadrado1.CalcularArea(7, 7);

        Cuadrado Cuadrado2 = new Cuadrado();
        Cuadrado2.CalcularArea(5, 3);
    }
}






