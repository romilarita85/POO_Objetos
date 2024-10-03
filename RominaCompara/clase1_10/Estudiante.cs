using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1_10_Stringbuilder
{
    public class Estudiante
    {
        string nombre;
        int nota;
        float promedio;
        bool rindioParcial;

        public Estudiante(string nombre, int nota, float promedio, bool parcial)
        {
            this.nombre = nombre;
            this.nota = nota;
            this.promedio = promedio;
            this.rindioParcial = parcial;
        }
        #region Metodo mostrar que va a devolver un string
        //public string ImprimirEstudiante() 
        //{
        //    string mensaje;
        //    mensaje = $"Nombre: {this.nombre} -Nota: {this.nota} -Promedio: {this.promedio} -Rindio parcial: {this.rindoParcial}";
        //    return mensaje;
        //}
        #endregion

        #region Armar cadena con formato: Concatenar con el formato q quiero

        //public string ImprimirEstudiante()
        //{
        //    string mensaje;
        //    mensaje = $"Su nombre es: {this.nombre}\n" ;
        //    mensaje += $"Nota: {this.nota}\n" ;
        //    mensaje += $"El promedio es: {this.promedio}\n";

        //    if (this.rindioParcial == true)
        //    {
        //        mensaje += "Rindio parcial";
        //    }
        //    else 
        //    {
        //        mensaje += "No rindio parcial";
        //    }
        //    return mensaje;
        //}
        #endregion

        //Metodo ImprimirEstudiante usando StringBuilder
        public string ImprimirEstudiante()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Su nombre es: {this.nombre}");
            sb.AppendLine($"Nota: {this.nota}");
            sb.AppendLine($"El promedio es: {this.promedio}");


            if (this.rindioParcial == true)
            {
                sb.AppendLine("Rindio parcial");
            }
            else
            {
                sb.AppendLine("No rindio parcial");
            }

            return sb.ToString();
        }
    }
}
