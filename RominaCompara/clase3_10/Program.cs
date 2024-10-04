using Biblioteca_Auto3_10;

namespace clase3_10_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("AD456DE", "Ford", 70);
            Auto a2 = new Auto("AD456DE", "Ford", 60);
            double combustible = 0;
           
           // //Modificando un valor:
           // //Usando metodo set:
           // a1.SetCantCombustible(250);
            
           // //Usando properties:
           // a1.CantCombustible = 250;//funciona igual q el metodo set
           //                          //al usar un igual se q le estoy asignando un valor.
           
           ////Consultar valor de la cantidad d combustible
           ////Usando metodo Get:

           // combustible = a1.GetCantCombustible();
            
           // //Usando propertie:
           // combustible = a1.CantCombustible;
        }
    }
}
