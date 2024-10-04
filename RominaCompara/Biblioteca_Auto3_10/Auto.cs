namespace Biblioteca_Auto3_10
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
        //Constructor estatico(no tienen visibilidad, no puedo pasarle atributos, no reciben parametros,siempre privado)
        static Auto()
        {
            Auto.nacionalidad = "Argentina";
        }
        //Propiedades:
        public double CantCombustible
        {
            get
            {
                return this.cantCombustible;
            }
            set
            {
                this.cantCombustible = value;
            }
        }
        //Propertie de solo lectura
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }
        public string Patente 
        {
            get
            { 
                return this.patente;        
            } 
        }
        //Propertie-> a la que no le puedo poner logica
        //public string Patente { get => patente; set => patente = value; }

        //public string Patente 
        //{   //puedo trabajar con logica(poner if, logica, calculos)
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value)) 
        //        { 
        //        }
        //    } 
        //}

        //public void SetCantCombustible(double cantidad)
        //{
        //    this.cantCombustible = cantidad;
        //}
        //public double GetCantCombustible()
        //{
        //    return this.cantCombustible;
        //}

        //Metodos:
        //Metodo para mostrar informacion:
        public string MostrarInfo()
        {
            return $"Marca: {this.marca} - Patente: {this.patente} - Cant. de combustible: {this.cantCombustible} - Nacionalidad: {Auto.nacionalidad}";
        }


        //Metodo estatico para comparar si mi auto1 es igual a mi auto2
        public static bool CompararAuto(Auto a1, Auto a2)//Metodo de instancia
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
