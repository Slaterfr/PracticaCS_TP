interface IAnimal
{
    void HacerSonido();
}

// Implementación de la interfaz en la clase Perro
class Perro : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("Woof woof");
    }
}

// Implementación de la interfaz en la clase Gato
class Gato : IAnimal
{
    public void HacerSonido()
    {
        Console.WriteLine("Meow");
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        // Crear lista de IAnimal
        List<IAnimal> animales = new List<IAnimal>();
        animales.Add(new Perro());
        animales.Add(new Gato());
        animales.Add(new Perro());
        animales.Add(new Gato());

        // Iterar la lista y llamar a HacerSonido en cada animal
        foreach (IAnimal animal in animales)
        {
            animal.HacerSonido();
        }
    }
}






