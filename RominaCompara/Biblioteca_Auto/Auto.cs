namespace Biblioteca_Auto
{
    public class Auto
    {
        //Atributos
        private string patente;
        private string marca;
        private double cantCombustible;
        private static string nacionalidad;//-> si tengo atributo estatico tengo que generar constructor estatico
        //Constructores:
        public Auto(string patente, string marca, double cantCombustible) //Constructor de instancia
        {
            this.patente = patente;
            this.marca = marca;
            this.cantCombustible = cantCombustible;
        }
        static Auto()//Constructor estatico(no tienen visibilidad, no puedo pasarle atributos, no reciben parametros,siempre privado)
        {
            Auto.nacionalidad = "Argentina";
        }
        //Setters:
        public void SetCantCombustible(double cantidad)
        {
            this.cantCombustible = cantidad;
        }
        #region Metodo SetNacionalidad de instancia
        //public void SetNacionalidad(string nacionalidad) 
        //{
        //    Auto.nacionalidad = nacionalidad;
        //}
        #endregion
        
        //Metodo SetNacionalidad estatico
        public static void SetNacionalidad(string nacionalidad)
        {
            Auto.nacionalidad = nacionalidad;
        }
        public void SetMarca(string marca)
        {
           this.marca = marca;
        }
        //Getters:
        public double GetCantCombustible()
        {
            return this.cantCombustible;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public string GetPatente()
        {
            return this.patente;
        }

        ////Metodo get estatico:
        //public static string GetNacionalidad() 
        //{
        //    return Auto.nacionalidad;
        //}
        public string GetNacionalidad() //Metodo get de instancia
        {
            return Auto.nacionalidad;//puedo retornar algo estatico o de instancia
        }


        //Metodos:
        //Metodo para mostrar informacion:
        public string MostrarInfo()
        {
            return $"Marca: {this.marca} - Patente: {this.patente} - Cant. de combustible: {this.cantCombustible} - Nacionalidad: {Auto.nacionalidad}";
        }

        #region Metodo de instancia CompararAuto
        //Metodo de instancia que compare si el auto actual es igual a otro auto
        //public bool CompararAuto(Auto autoComparar)//Metodo de instancia
        //{
        //    bool iguales = false;
        //    if (autoComparar.marca == this.marca && autoComparar.patente == this.patente)
        //    {
        //        iguales = true;
        //    }
        //    return iguales;
        //}
        //this:hace referencia a la instancia del objeto (en este caso los objetos a1 y a2)
        #endregion

        //Metodo estatico para comparar si mi auto1 es igual a mi auto2
        public static bool CompararAuto(Auto a1, Auto a2 )//Metodo de instancia
        {
            bool iguales = false;
            if (a1.marca == a2.marca && a1.patente == a2.patente)
            {
                iguales = true;
            }
            return iguales;
        }
        //lo estatico no se puede instanciar- son propios de la clase
    }
}
