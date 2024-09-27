using Biblioteca_Auto;

namespace clase26_09_Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region resumen
            //Conceptos:

            //FUNCIONES:***********************************************************************
            //realizan una tarea,son especificas,independientes,reutilizables
            //

            //PROTOTIPOS:**********************************************************************
            //Que no reciben parametros y q no devuelven nada
            //Que recibe y no retorna
            //Recibe y retorna ->>Es la q usamos
            //No recibe y retorna

            //PASOS A TENER PRESENTE AL CREAR UNA FUNCION-METODO*******************************
            //visibilidad-comportamiento-retorno-nombre-parametros(opcional)
            //Cambiamos el nombre de funcion a metodo al trabajar con Clases

            //CLASE:****************************************************************************
            //-Molde con el que vamos a crear los objetos.
            //-Creo un nuevo TIPO de dato
            //Molde o plantilla dentro de un contexto para representar un nuevo objeto
            //Conjunto de datos para representar en la programacion objetos de la vida real

            //OBJETOS:*************************+*************************************************
            //Es la instancia de una clase. Lo concreto.

            //PILARES de la POO-ABSTRACCION- ENCAPSULAMIENTO-HERENCIA-POLIMORFISMO*****************************
            //*no puede haber polimorfismo si primeramente no hay herencia(polimorfismo depende de la herencia)
            //-Abstraccion: Tengo que abstraerme a lo minimo y indispensable.
            //"Capacidad de enfocarse en un contexto para identificar lo minimo y indispensable para poder
            //representar un objeto dado."

            //-Encapsulamiento:(evito que tengan acceso directo a mis atributos ej:la cafetera)
            //"Limitar el acceso, visibilidad de mis atributos y/o comportamientos"
            //protejo el funcionamiento y oculto procesos.

            //Parte de encapsular mis atributos lleva a que los tenga q exponer de alguna forma:
            //GETTERS Y SETTERS**********************************************************
            //sirven para exponer y modificar los atributos.
            //Get->Retorna el valor de un atributo
            //Set->Modifican el valor de un atributo
            //Estos metodos pueden tener logica para condicionar el acceso a los datos

            //CONSTRUCTORES CON Y SIN PARAMETROS*****************************************
            //Constructor:
            //-Es un metodo especial por que no tiene retorno
            //-Su nombre siempre va a ser el mismo q la clase

            //-Visibilidad:public o privado
            //-Comportamiento: estatico o de instancia
            //-Parametros:puede o no tener

            //CLASES Y METODOS ESTATICOS*************************************************

            //-CLASE DE INSTANCIA:
            //clases q permiten generar nuevas instancia de un objeto
            //precisan un constructor
            //Atributos y metodos de instancia, son propios del objeto.
            //Pueden tener metodos y atributos de instancia y/o estaticos

            //-CLASE ESTATICA(static va especificado explicitamente)
            //es una clase q no se puede instanciar
            //nunca podes crear un objeto(nueva instancia) de esa clase - uso la clase como tal
            //No precisan un constructor pero puedo modificar su comportamiento
            //atributos y metodos estaticos son propios de la clase.

            //Biblioteca de clases -> es un contenedor de clases no es ejecutable
            //Window forms -> es ejecutable
            //Proyecto de consola -> es ejecutable
            #endregion resumen
            Auto auto1 = new Auto("AD456DE","Ford",70);
            Auto auto2 = new Auto("AD456DE", "Ford", 60);
        }

    }
}
