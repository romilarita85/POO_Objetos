namespace clase25_09_MetodosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Empresa.EstablecerFechaInicio();//atributo estatico se comparte p/todas las clases
            ////No necesito un objeto para poder establecer el inicio de actividad
            ////lo llamo directamente desde la clase(Empresa)
            //Empresa miEmpresa = new Empresa("CFP 6");
            //Console.WriteLine(miEmpresa.GetInicioActividades());
            //Console.ReadKey();

            //Empresa.EstablecerFechaInicio(); //estableci una nueva fecha p/todos los objetos(para las nuevas instancias)
            ////cada vez que llamo al metodo a traves de la clase se actualiza la fecha para todos los objetos
            //Empresa otraEmpresa = new Empresa("CFP 25");
            //Console.WriteLine(otraEmpresa.GetInicioActividades());
            //Console.WriteLine(miEmpresa.GetInicioActividades());
            //--------------------------------------------------------------------------------

            //Empresa miEmpresa = new Empresa("Avianca");
            //Empresa otraEmpresa = new Empresa("Coca-Cola");
            //int retorno = Empresa.CompararPorRazonSocial(miEmpresa, otraEmpresa);
            //Console.WriteLine(retorno);

            //Empresa miEmpresa = new Empresa("Avianca");
            //Empresa otraEmpresa = new Empresa("Coca-Cola");
            //int retorno = Empresa.CompararPorRazonSocial(otraEmpresa, miEmpresa);
            //Console.WriteLine(retorno);

            //Empresa miEmpresa = new Empresa("Avianca");
            //Empresa otraEmpresa = new Empresa("Avianca");
            //int retorno = Empresa.CompararPorRazonSocial(miEmpresa, otraEmpresa);
            //Console.WriteLine(retorno);

            //------------------------------------------------------------------------------
            //CADENAS-CARACTERES-STRING-METODOS DE LA CLASE STRING
            //Concat,Join,CompareTo

            //PROPIEDAD LEGTH:para obtener el largo de una cadena: LENGTH
            //Devuelbe la cantidad de espacios de la cadena (incluye espacios y caracteres).obtengo la longitud

            //string cadena = "Hola CFP N° 6";
            //int longitud = cadena.Length;
            //Console.WriteLine(cadena);
            //---------------------------------------------------------------------------
            //METODOS PARA CONVERTIR CADENA A MAYUSCULA O MINUSCULA:
            //1-ToUpper: Convierte la cadena a mayuscula
            //2-ToLower: Convierte la todo a minuscula
            //string cadena = "Hola CFP N° 6";

            //string cadenaMayuscula = cadena.ToUpper();
            //Console.WriteLine(cadenaMayuscula);

            //string cadenaMinuscula = cadenaMayuscula.ToLower();
            //Console.WriteLine(cadenaMinuscula);

            //---------------------------------------------------------------------------
            //METODO INDICE: INDEXOF: para saber en que indice esta el caracter
            //string cadena = "Hola CFP N° 6";
            //int indice = cadena.IndexOf('C');
            //Console.WriteLine(indice);

            //--------------------------------------------------------------------------
            //METODO CONTAINS: Me dice si una cadena contiene otra cadena
            //string cadena = "Hola CFP N° C6";
            //bool contiene = cadena.Contains("CFP");
            //Console.WriteLine(contiene);

            //---------------------------------------------------------------------------
            //METODO REPLACE: Reemplaza.Devuelve un string.Devuelve una cadena con la secuencia modificada
            //no cambia el valor real
            //string cadena = "Hola CFP N° C6 CFP";
            //string reemplazado = cadena.Replace("CFP", "C#");
            //Console.WriteLine(reemplazado); 
            //-----------------------------------------------------------------------------
            //METODO TRIM: Borra espacios vacios

            //string nombre = "    Pepe    ";
            //Console.WriteLine(nombre);
            //string nuevoNombre = nombre.Trim();//borra los espacios
            //Console.WriteLine(nombre);

            //string nombre = "rrrrPeperrrr";
            //Console.WriteLine(nombre);
            //string nuevoNombre = nombre.Trim('r'); //borra las r
            //Console.WriteLine(nuevoNombre);

            //string nombre = "   Pepe     ";
            //Console.WriteLine(nombre);
            //string nuevoNombre = nombre.TrimEnd(' '); //borra espacios del final
            //Console.WriteLine(nuevoNombre);

            string nombre = "   Pepe   ";
            Console.WriteLine(nombre);
            string nuevoNombre = nombre.TrimStart(' '); //borra espacios del principio
            Console.WriteLine(nuevoNombre + "lalala");

        }
    }
}
