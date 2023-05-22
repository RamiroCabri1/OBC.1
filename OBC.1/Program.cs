namespace OBC._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1 ");
            
            Console.WriteLine("Ingrese nombre ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hello, World! "+ nombre);
            Console.WriteLine("_____________ ");

            Console.WriteLine("Ejercicio 2 ");
            
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine("La hora actual es: "+ datetime);
            

        }
    }
}