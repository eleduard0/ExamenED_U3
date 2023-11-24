namespace ExamenED_U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada listaEnlazada = new ListaEnlazada();
            Console.WriteLine("Agrega 5 personas con su nombre y su edad: ");
            string nombre1 = Console.ReadLine();
            int edad1 = int.Parse(Console.ReadLine());
            string nombre2 = Console.ReadLine();
            int edad2 = int.Parse(Console.ReadLine());
            string nombre3 = Console.ReadLine();
            int edad3 = int.Parse(Console.ReadLine());
            string nombre4 = Console.ReadLine();
            int edad4 = int.Parse(Console.ReadLine());
            string nombre5 = Console.ReadLine();
            int edad5 = int.Parse(Console.ReadLine());
            listaEnlazada.InsertarAlFinal(new Persona {Nombre=nombre1, Edad = edad1 });
            listaEnlazada.InsertarAlFinal(new Persona {Nombre=nombre2, Edad = edad2 });
            listaEnlazada.InsertarAlFinal(new Persona {Nombre=nombre3, Edad = edad3 });
            listaEnlazada.InsertarAlFinal(new Persona {Nombre=nombre4, Edad = edad4 });
            listaEnlazada.InsertarAlFinal(new Persona {Nombre=nombre5, Edad = edad5 });
            listaEnlazada.ImprimirLista();
        }
    }
}