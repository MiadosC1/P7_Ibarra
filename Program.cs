using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_Ibarra
{
    internal class Program
    {
        struct Datos_Persona
        {
            //Variables struct Datos Persona
            public string NombreCompleto;
            public DateTime FechaNacimiento;
            public int Edad;
            public string LugarNacimiento;
        }

        static void Main(string[] args)
        {
            //Objeto de registro
            Datos_Persona datos_Persona = new Datos_Persona();
            //Ingresar Datos de la persona
                //Nombre Completo
                Console.Write("Ingrese su Nombre Completo: ");
                datos_Persona.NombreCompleto = Console.ReadLine();
                //Fecha de nacimiento
                Console.Write("Ingrese su fecha de nacimiento con este formato DD/MM/YYYY: ");  
                string FechaNacimientostring = Console.ReadLine();  
                DateTime FechaNacimientoDate = DateTime.Now;
                Console.WriteLine(FechaNacimientostring);
                //Edad


                //Lugar de Nacimiento
                Console.Write("Ingrese su lugar de nacimiento con el siguiente formato (Municipio, Estado): ");
                datos_Persona.LugarNacimiento = Console.ReadLine();

            //Desplegar datos

        }
    }
}