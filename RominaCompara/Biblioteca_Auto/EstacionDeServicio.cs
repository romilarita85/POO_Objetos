using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Auto
{
    #region Clase estatica (con metodo estatico RecargarCombustible)
    //public static class EstacionDeServicio
    //{
    //    public static void RecargarCombustible(Auto a, double cantCombustible)
    //    {//recibe un auto y un double con la cantidad de combustible
    //        a.SetCantCombustible(cantCombustible);
    //    }

    //}
    #endregion 

    //Clase de instancia(con metodo de instancia RecargarCombustible)
    public class EstacionDeServicio
    {
        public void RecargarCombustible(Auto a, double cantCombustible) 
        {//recibe un auto y un double con la cantidad de combustible
            a.SetCantCombustible(cantCombustible);  
        }
    }
}
