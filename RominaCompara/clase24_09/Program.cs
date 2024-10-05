using Biblioteca_Televisor;

namespace clase24_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisor miTele = new Televisor();
            Televisor laTeleDeAnto = new Televisor("Philips",55,10,true);
            //USANDO METODO MOSTRAR TELEVISOR*******************
            //Console.WriteLine(laTeleDeAnto.MostrarTelevisor());
            //Console.WriteLine(miTele.MostrarTelevisor());
            
            //USANDO METODO SET:*****************************************************
           //Cambio el valor de la variable con un setter  de "philip" a "LG"********
            //laTeleDeAnto.SetMarca("LG");
            //Console.WriteLine(laTeleDeAnto.GetMarca());

            //Le doy valores a miTele atravez de los Setters *************************
            //miTele.SetMarca("Kenji");
            //miTele.SetPulgadas(50);
            //miTele.SetVolumen(5);
            //miTele.SetEstaEncendido(true);
            //Console.WriteLine(miTele.MostrarTelevisor());

            //**********************************************************************
            //USANDO METODO ENCENDER
            laTeleDeAnto.Encender();
            Console.WriteLine(laTeleDeAnto.MostrarTelevisor());
            laTeleDeAnto.Encender();
            Console.WriteLine(laTeleDeAnto.MostrarTelevisor());
            laTeleDeAnto.Encender();

            //USANDO METODO SUBIR VOLUMEN
            for (int i = 0; i < 10; i++) 
            { 
               laTeleDeAnto.SubirVolumen();
            }
            Console.WriteLine(laTeleDeAnto.GetVolumen());
            laTeleDeAnto.BajarVolumen();
            Console.WriteLine(laTeleDeAnto.GetVolumen()); // baja a 19
        }
    }
}
