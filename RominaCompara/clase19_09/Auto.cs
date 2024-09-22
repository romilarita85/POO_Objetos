//Encapsulamiento: forma de restringir el acceso total o parcial de nuestros atributos o metodos dentro de la clase
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase19_09
{
    //visibilidad de la clase: siempre publica
    //Clases de instancia
    public class Auto // si no dice static la clase es de INSTANCIA
    {
        private string patente;
        private int cantidadRuedas;
        private string tipo;
        private double cantidadCombustible;
        private Color color;
        
        //METODOS SETTERS Y GETTERS
        public void SetPatente(string patente) 
        {
            this.patente = patente;
        }
        //this: para saber a que hago referencia. Identifica cual es la instancia
        public void SetCantRuedas(int cant) 
        { 
            this.cantidadRuedas = cant;
        }
        public void SetTipo(string tipo) 
        {
            this.tipo = tipo;   
        }
        public bool SetCantCombustible(double cant) 
        {//validaciones dentro del set
            bool ok = false; //por defecto
            if (cant > 0) 
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

        //Metodos -> funciones
        //Visibilidad-comportamiento-retorno-nombre-parametros(opcional)
        public bool Conducir(double distancia) 
        {//por cada litro de combustible yo puedo hacer cierta distancia
            bool sePudo = false;//por defecto lo inicializo en false
            double consumo = distancia / 4;//por cada litro puedo hacer 4 kilometros

            if (cantidadCombustible > consumo) 
            {
                sePudo = true;
                cantidadCombustible -= consumo;
            }
            return sePudo;//retorno
        }
        public string MostrarInformacion() 
        {
            return $"Patente: {patente} - Tipo: {tipo} - Color: {color.Name} - Cantidad de ruedad: {cantidadRuedas} - Cantidad de combustible {cantidadCombustible}";
        }
    }
}
