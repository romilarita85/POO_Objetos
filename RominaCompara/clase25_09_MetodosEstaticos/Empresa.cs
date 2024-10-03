using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase25_09_MetodosEstaticos
{
    internal class Empresa
    {
        private string razonSocial;//atributo de instancia
        private static DateTime inicioActividades;//atributo estatico(de clase)

        //Atributo estatico: no depende del objeto si no de la clase
        //el atributo inicio de actividades es un atributo de clase

        //Constructor:
        public Empresa(string razonSocial) //de instancia
        {
            this.razonSocial = razonSocial;
            //desde la instancia no puedo ver el atributo de clase(estatico)
        }
        static Empresa() 
        {
            inicioActividades = DateTime.Now;
        }

        public static void EstablecerFechaInicio()//Metodo Estatico
        {
            inicioActividades = DateTime.Now;
        }
        //Metodos Getters y Setters:
        public string GetRazonSocial() 
        {
            return this.razonSocial;
        }
        public DateTime GetInicioActividades()
        {
            return inicioActividades;   
        }
        //Metodo para comparar por razon social dos empresas
        public static int CompararPorRazonSocial(Empresa e1, Empresa e2) //le paso las dos instancias con las q vamos a trabajar
        {//Comparo dos Strings
            //int comparacion = -1;//si estan desordenadas (dando por defecto valor)
            //if (e1.razonSocial == e2.razonSocial)
            //{
            //    comparacion = 0;//si son iguales devuelve cero
            //}
            //else 
            //{
            //    if (e1.razonSocial.CompareTo(e2.razonSocial) == 1)
            //    {//si la primera alfabeticamente es mayor q la segunda
            //        comparacion = 1;//oredenadas alfabeticamente
            //    }
            //}
            //return comparacion;

            return e1.razonSocial.CompareTo(e2.razonSocial);
        }
    }
}
//namespace clase25_09_MetodosEstaticos
//{
//    internal class Empresa
//    {
//        string razonSocial;//atributo de instancia
//        DateTime inicioActividades;//atributo de instancia

        //Atributos de instancia: Para poder otorgarle a una empresa una razon social y un inicio de actividades
        //tengo q crear un objeto-> tengo q instanciar un objeto.
        //Lo de instancia ve lo estatico y de instancia
//    }
//}
