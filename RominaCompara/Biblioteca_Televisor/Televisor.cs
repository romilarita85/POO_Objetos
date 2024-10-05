//Clase 24/09
namespace Biblioteca_Televisor
{
    public class Televisor
    {
        private string marca;
        private int pulgadas;
        private int volumen;
        private bool estaEncendido;

        public Televisor() //Constructor por defecto(vacio)
        { 
        
        }

        public Televisor(string marca, int pulgadas, int volumen, bool estaEncendido) //Constructor parametrizado
        {
            this.marca = marca;
            this.pulgadas = pulgadas;
            this.volumen = volumen;
            this.estaEncendido = estaEncendido;
        }
       
        public string GetMarca() 
        {
            return this.marca;
        }
        public void SetMarca(string valor)
        {
            this.marca = valor;
        }
        public int GetPulgadas()
        {
            return this.pulgadas;
        }
        public void SetPulgadas(int valor) 
        {
            this.pulgadas = valor;
        }
        public int GetVolumen()
        {
            return this.volumen;
        }
        public void SetVolumen(int valor)
        {
            this.volumen = valor;
        }
        public bool GetEstaEncendido()
        {
            return this.estaEncendido;
        }
        public void SetEstaEncendido(bool valor)
        {
            this.estaEncendido = valor;
        }
        //Metodo Encender
        public void Encender()//si esta encendido la voy apagar
        {
            //if (this.estaEncendido == true)// si esta encendido
            //{
            //    this.estaEncendido = false;//debo apagarla
            //}
            //else 
            //{//si esta apagado
            //    this.estaEncendido = true;//la prendo
            //}
            this.estaEncendido = !this.estaEncendido;
        }
        public void SubirVolumen() 
        {
            this.volumen++; //volumen = volumen + 1 o volumen+=1 -> valor entero q uso como contador
        }
        public void BajarVolumen()
        {
            this.volumen--; //volumen = volumen - 1 o volumen-=1 -> valor entero q uso como contador
        }
        public string MostrarTelevisor() //Metodo definido
        {
            string mensaje;//tipo de dato
            mensaje = $"Marca: {this.marca} \nPulgadas: {this.pulgadas}´´ \nVolumen: {this.volumen} \nEsta encendida: {this.estaEncendido}";
            return mensaje;
        }
    }
}
