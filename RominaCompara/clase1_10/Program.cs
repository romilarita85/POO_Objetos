namespace clase1_10_Stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Juan", 10, 7.5f, true);
            Console.WriteLine(estudiante1.ImprimirEstudiante());
        }
    }
}
