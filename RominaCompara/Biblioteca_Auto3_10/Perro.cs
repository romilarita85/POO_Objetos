using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Auto3_10
{
    public class Perro
    {
        string nombre;
        string raza;
        Persona duenio;

        public Perro(string nombre, string raza,Persona per)
        {
            this.nombre = nombre;
            this.raza = raza;
            //this.duenio = new Persona();
            this.duenio = per;
        }

       
        //public string Nombre { set => nombre = value; }
        public string Nombre { set { nombre = value; } }
          
        //public string Raza { get => raza; set => raza = value; }
        public string Raza { get { return raza; } }
        
        //public Persona Duenio { get => duenio; set => duenio = value; }
        public Persona Duenio { get { return duenio; } set { duenio = value; } }
        
    }
}
