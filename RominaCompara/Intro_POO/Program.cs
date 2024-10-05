//Clase 18/09
namespace Intro_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {            
//nombre de la clase --nombre de la variable
            Gato unGato;//Es una variable del tipo gato.DECLARACION DE LA VARIABLE->DECLARO

//variable del tipo gato(contenedor) = Palabra new + constructor de la clase (metodo especial q se llama igual que la clase)             
            unGato = new Gato();//Construccion de un objeto(intanciando)-> INSTANCIO(EL OBJETO EN MEMORIA)

            unGato.nombre = "Agatha";//asigno valor al atributo del objeto gato
            unGato.edad = 3;//por defecto si no le doy valor se muestra en cero
            
            Gato otroGato = new Gato();//DECLARANDO E INSTANCIANDO EN LA MISMA LINEA(EL OBJETO EXISTE)
            //PUEDO LLAMAR A SUS ATRIBUTO Y METODOS(UNA VEZ CREADO EL OBJETO)
            otroGato.nombre = "Chatran";
            otroGato.edad = 10;

            Console.WriteLine(unGato.nombre);
            Console.WriteLine($"{unGato.nombre} - {unGato.edad}");

            
            Console.WriteLine($"{otroGato.nombre} - {otroGato.edad}");
            unGato.Comer("Atuncito");
            otroGato.Saltar();
            
            int alturaSalto; //metodo devolvia un entero 
            alturaSalto = otroGato.Saltar();
            Console.WriteLine($"{otroGato.nombre} saltó: {alturaSalto} cm");
        
        
        }
    }
}
