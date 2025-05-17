// Clase base Empleado con metodo virtual para mostrar información
public class Empleado
{
    protected string Nombre = "Juan Diaz";
    protected double Salario = 400000;

    // Metodo virtual que puede ser sobrescrito por clases hijas
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Puesto: Empleado");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario: {Salario}");
    }
}

// Clase Gerente que hereda de Empleado y sobrescribe el metodo
public class Gerente : Empleado
{
    public Gerente()
    {
        Nombre = "Roberto Lopez";
        Salario = 700000;
    }

    // Sobrescritura del metodo MostrarInformacion
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Puesto: Gerente");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario: {Salario}");
    }
}

// Clase Desarrollador que hereda de Empleado y sobrescribe el metodo
public class Desarrollador : Empleado
{
    public Desarrollador()
    {
        Nombre = "Alexander Pierce";
        Salario = 800000;
    }

    // Sobrescritura del metodo MostrarInformacion
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Puesto: Desarrollador");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario: {Salario}");
    }
}

// Programa principal para probar la herencia y polimorfismo
class Program
{
    static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado();
        empleado1.MostrarInformacion();

        Gerente Gerente1 = new Gerente();
        Gerente1.MostrarInformacion();

        Desarrollador desarrollador1 = new Desarrollador();
        desarrollador1.MostrarInformacion();
    }
}











