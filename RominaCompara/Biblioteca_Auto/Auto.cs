namespace Biblioteca_Auto
{
    public class Auto
    {
        //Atributos
        private string patente;
        private string marca;
        private double cantCombustible;

        //Constructor
        public Auto(string patente, string marca, double cantCombustible)
        {
            this.patente = patente;
            this.marca = marca;
            this.cantCombustible = cantCombustible;
        }
        //Setters:
        public void SetCombustible(double cantidad) 
        {
            this.cantCombustible = cantidad;
        }
        //Getters:
        public double GetCombustible() 
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
        //Metodos:
        public string MostrarInfo() 
        {
            return $"Marca: {this.marca} - Patente: {this.patente} - Cant. de combustible: {this.cantCombustible}";
        }

    }
}
