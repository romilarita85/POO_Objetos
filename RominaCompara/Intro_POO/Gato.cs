using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO
{
    //clase: plano de lo abstracto
    //define cuales son las caracteristicas y las acciones que va a realizar un objeto
    public class Gato
    {
        //Atributos:datos
        public string nombre;
        public int cantidadPatas;
        public Color color;
        public string raza;
        public string genero;
        public int edad;

        //Metodos:Comportamiento del gato (acciones)
        public void Comer(string queCome) 
        {
            Console.WriteLine($"Hola soy {nombre} y estoy comiendo {queCome}");
        }
        public int Saltar()//Metodo para generar un numero aleatorio
        {
            Random rnd = new Random();//intanciar variable de tipo random
            int altura = rnd.Next(10,50);//genero la altura de manera aleatoria
           
            Console.WriteLine("Estoy saltando");
           
            return altura;//devuelve
        }
    }
}
