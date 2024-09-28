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
            //1)-Que no reciben parametros y q no devuelven nada
            //2)-Que recibe y no retorna
            //3)-Recibe y retorna ->>Es la q usamos
            //4)-No recibe y retorna

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

            Auto a1 = new Auto("AD456DE","Ford",70);
            Auto a2 = new Auto("AD456DE", "Ford", 60);
            EstacionDeServicio e1 = new EstacionDeServicio();//creo una nueva instancia   

            #region Usando metodo de instancia CompararAuto*******
            ////Para poder usar el metodo de instancia CompararAuto tengo que tener creados los objetos a1 y a2
            ////tengo q tener una instancia de un auto
            //if (a1.CompararAuto(a2))
            //{
            //    Console.WriteLine("son iguales");
            //}
            //else 
            //{
            //    Console.WriteLine("son distintos");  

            //}
            #endregion
            #region Usando metodo estatico CompararAuto*****
            //siempre que quiero acceder a algo estatico tengo que acceder por medio del nombre de la clase

            //if (Auto.CompararAuto(a1,a2))
            //{
            //    Console.WriteLine("son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("son distintos");
            //}
            #endregion
            #region Usando metodo static GetNacionalidad
            ////veo de que nacionalidad son los objetos auto
            //Console.WriteLine(Auto.GetNacionalidad());

            //Console.WriteLine(a1.GetNacionalidad());
            //Console.WriteLine(a2.GetNacionalidad());
            #endregion
            //*******************************
            ////Por mas de que modifique el atributo estatico(propio de la clase) en cualquier instancia(ejemplo auto 2-a2)
            ////modifico todos los autos.Modifico todos los valores para la clase auto
            #region Usando metodo de instanca SetNacionalidad

            //Console.WriteLine("AUTO 1: ");
            //Console.WriteLine($"{a1.GetNacionalidad()} - {a1.GetMarca()}");
            //Console.WriteLine("AUTO 2: ");
            //Console.WriteLine($"{a2.GetNacionalidad()} - {a2.GetMarca()}");

            //Console.WriteLine("******Modificando el atributo static (nacionalidad) en a2******");
            //a2.SetNacionalidad("Alemana");// modifico usando la instancia del objeto
            //Console.WriteLine("******Modificando el atributo de instancia (marca) en a2******");
            //a2.SetMarca("Fiat");

            //Console.WriteLine("AUTO 1: ");
            //Console.WriteLine($"{a1.GetNacionalidad()} - {a1.GetMarca()}");
            //Console.WriteLine("AUTO 2: ");
            //Console.WriteLine($"{a2.GetNacionalidad()} - {a2.GetMarca()}");
            #endregion

            #region Usando metodo estatico SetNacionalidad:*****
            ////Siempre que quiera modificar un atributo estatico, el modificador deberia ser estatico 
            //Console.WriteLine("AUTO 1: ");
            //Console.WriteLine($"{a1.GetNacionalidad()} - {a1.GetMarca()}");
            //Console.WriteLine("AUTO 2: ");
            //Console.WriteLine($"{a2.GetNacionalidad()} - {a2.GetMarca()}");

            //Console.WriteLine("******Modificando el atributo static (nacionalidad) en a2******");
            //Auto.SetNacionalidad("Alemana");//modifico por medio de la clase(se modifica para todos los autos)

            //Console.WriteLine("******Modificando el atributo de instancia (marca) en a2******");
            //a2.SetMarca("Fiat");//modifico algo propio del objeto(afecta solo a la instancia del objeto a2)

            //Console.WriteLine("AUTO 1: ");
            //Console.WriteLine($"{a1.GetNacionalidad()} - {a1.GetMarca()}");
            //Console.WriteLine("AUTO 2: ");
            //Console.WriteLine($"{a2.GetNacionalidad()} - {a2.GetMarca()}");
            #endregion

            #region Usando la clase estatica EstacionDeServicio
            //Console.WriteLine($"Auto 1 antes de recargar : {a1.GetCantCombustible}");

            //EstacionDeServicio.RecargarCombustible(a1,100);// -> usando clase estatica
            //Console.WriteLine($"Auto 1 despues de recargar : {a1.GetCantCombustible}");
            #endregion

            //Usando la clase de instancia EstacionDeServicio
            Console.WriteLine($"Auto 1 antes de recargar : {a1.GetCantCombustible}");

            e1.RecargarCombustible(a1, 100); //-> usando clase de instancia
            Console.WriteLine($"Auto 1 despues de recargar : {a1.GetCantCombustible}");
        }

    }
}
