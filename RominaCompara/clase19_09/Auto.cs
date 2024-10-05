//Encapsulamiento: forma de restringir el acceso total o parcial de nuestros atributos o metodos dentro de la clase
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase19_09
{
    //Visibilidad de la clase: siempre publica
    //Clases de instancia
    public class Auto // si no dice static la clase es de INSTANCIA
    {
        private string patente;
        private int cantidadRuedas;
        private string tipo;
        private double cantidadCombustible;
        private Color color;

        //METODO CONSTRUCTOR
        public Auto(string patente, int cantidadRuedas, string tipo, double cantidadCombustible)
        {//no estoy obligato a que reciba todos los atributos dentro del constructor
            this.patente = patente;
            this.cantidadRuedas = cantidadRuedas;
            this.tipo = tipo;
            this.cantidadCombustible = cantidadCombustible;
            this.color = Color.White;// puedo pasarselo por defacult
        }

        ////METODOS SETTERS Y GETTERS
        //public void SetPatente(string patente) 
        //{
        //    this.patente = patente;
        //}
        ////this: para saber a que hago referencia. Identifica cual es la instancia
        //public void SetCantRuedas(int cant) 
        //{ 
        //    this.cantidadRuedas = cant;
        //}

        public bool SetTipo(string tipo)
        {//Validacion (logica de validacion)
            bool result = false; //por defecto es false(funcioa comu un else)

            if (!string.IsNullOrEmpty(tipo))//variable de string no este vacio ni nula 
            {//si tiene valores para trabajar
                this.tipo = tipo;
                result = true;
            }
            return result;
        }
        public bool SetCantCombustible(double cant) 
        {//validaciones dentro del set
            bool ok = false; //por defecto
            if (cant > 0 && cant < 150) //que tega numeros positivos hasta 150
            {
                this.cantidadCombustible = cant; 
                ok = true;
            }
            return ok;
        }
        public void SetColor(Color color)
        {
            this.color = color; 
        }
        public string GetPatente() 
        {
            return this.patente;
        }
        public double GetCantCombustible() 
        {
            return this.cantidadCombustible;
        }
        //METODOS -> FUNCIONES
        //Visibilidad-comportamiento-retorno-nombre-parametros(opcional)
        
        //Metodo Conducir(double distancia) Por cada litro de combustible yo puedo hacer 4 kilometros de distancia
        public bool Conducir(double distancia) 
        {
            bool sePudo = false;//por defecto lo inicializo en false
            double consumo = distancia / 4;//por cada litro puedo hacer 4 kilometros

            if (cantidadCombustible > consumo) 
            {
                cantidadCombustible -= consumo;
                sePudo = true;
            }
            return sePudo;//retorno
        }
        public string MostrarInformacion() 
        {
            return $"Patente: {this.patente} - Tipo: {this.tipo} - Color: {this.color.Name} - Cantidad de ruedad: {this.cantidadRuedas} - Cantidad de combustible {this.cantidadCombustible}";
        }
    }
}
