
using clase19_09;
using System.Drawing;

namespace clase19_09
{
    internal class Program
    {
        //La clase main por defecto es estatica
        static void Main(string[] args)
        {     //Variables definidas dentro del main
            string patente = "AA456CV";//inicialiar la variable
            int cantidadRuedas = 4;
            string tipo = "Sedan";
            double cantidadCombustible = 0;
            Color color = Color.DarkGreen;
                            //constructor
            Auto auto1 = new Auto(patente,cantidadRuedas,"compacto",cantidadCombustible);
  
            Console.WriteLine(auto1.MostrarInformacion());

            //--------------------------------------------
            Calculadora calc = new Calculadora(8,4);//espera recibir dos enteros
            Console.WriteLine(calc.Sumar());
            Console.WriteLine(calc.Dividir());
        }
    }
}
//-----------------------------------
//static void Main(string[] args)
//{                    //constructor
//    Auto auto1 = new Auto();
//    Console.WriteLine(auto1.MostrarInformacion());

//    auto1.patente = "AA456CV";
//    auto1.color = Color.DarkMagenta;
//    auto1.cantidadRuedas = 4;
//    auto1.cantidadCombustible = 70;
//    auto1.tipo = "Sedan";
//    Console.WriteLine(auto1.MostrarInformacion());

//    
//}
//--------------------------------------
//static void Main(string[] args)
//{                    //constructor
//    Auto auto1 = new Auto();

//    //Variables definidas dentro del main
//    string patente = string.Empty;//inicialiar la variable
//    int cantidadRuedas = 0;
//    string tipo = string.Empty;
//    double cantidadCombustible = 0;
//    Color color = Color.DarkGreen;

//    //paso las variables a mi auto
//    auto1.patente = patente;
//    auto1.color = color;
//    auto1.cantidadRuedas = cantidadRuedas;
//    auto1.cantidadCombustible = cantidadCombustible;
//    auto1.tipo = tipo;
//    Console.WriteLine(auto1.MostrarInformacion());


//}
//---------------------------------------------
//static void Main(string[] args)
//{                    //constructor
//    Auto auto1 = new Auto();

//    //Variables definidas dentro del main
//    string patente = "AA456CV";//inicialiar la variable
//    int cantidadRuedas = 4;
//    string tipo = "Sedan";
//    double cantidadCombustible = 70;
//    Color color = Color.DarkGreen;

//    //paso las variables a mi auto
//    auto1.patente = patente;
//    auto1.color = color;
//    auto1.cantidadRuedas = cantidadRuedas;
//    auto1.cantidadCombustible = cantidadCombustible;
//    auto1.tipo = tipo;
//    Console.WriteLine(auto1.MostrarInformacion());

//    auto1.patente = "FD123WS"; //cualquier usuario puede modificar
//                               //no esta protegido, no hay encapsulamiento
//    Console.WriteLine(auto1.MostrarInformacion());
//}
//------------------------------------
//namespace clase19_09
//{
//    internal class Program
//    {
//        //La clase main por defecto es estatica
//        static void Main(string[] args)
//        {
//            //constructor
//            Auto auto1 = new Auto();


//            //Variables definidas dentro del main
//            string patente = "AA456CV";//inicialiar la variable
//            int cantidadRuedas = 4;
//            string tipo = "Sedan";
//            double cantidadCombustible = 0;
//            Color color = Color.DarkGreen;
//            //atributos estan ocultos y los uso atraves de metodos set
//            //auto1.SetPatente(patente);
//            //auto1.SetTipo(tipo);
//            //auto1.SetCantRuedas(cantidadRuedas);

//            if (auto1.SetCantCombustible(cantidadCombustible))
//            {
//                Console.WriteLine("Se pudo ingresar la cantidad de combustible");
//            }
//            else
//            {
//                Console.WriteLine("El valo de cant de combustible es incorrecto");
//            }
//            auto1.SetColor(color);

//            Console.WriteLine(auto1.GetPatente());
//            Console.WriteLine(auto1.MostrarInformacion());


//        }
//    }
//}