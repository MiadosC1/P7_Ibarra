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
            //Variable


            //Objeto de registro
            Datos_Persona [] Datos_Persona = new Datos_Persona[50];
        while (Opción == 1)
        {
            //Ingresar el número de personas
            Console.Write("Ingrese el número de personas: ");
            int NumeroPersonas = int.Parse(Console.ReadLine());
            if(NumeroPersonas < 50)
            {
                //Ingresar Datos de la persona
                Console.WriteLine("Ingrese los datos de la persona {0}", i + 1);
                    //Nombre Completo
                    Console.Write("Ingrese su Nombre Completo: ");
                    Datos_Persona[i].NombreCompleto = Console.ReadLine();

                    //Fecha de nacimiento
                    Console.Write("Ingrese su fecha de nacimiento con este formato DD/MM/YYYY: ");  
                    Datos_Persona[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());  
                    DateTime FechaNacimientoDate = DateTime.Now;

                    //Edad
                    DateTime Hoy = DateTime.Now;
                    Timespan Diferencia = Hoy - FechaNacimiento;
                    Datos_Persona[i].Edad = Diferencia.Days / 365;

                    //Lugar de Nacimiento
                    Console.Write("Ingrese su lugar de nacimiento con el siguiente formato (Municipio, Estado): ");
                    Datos_Persona.LugarNacimiento = Console.ReadLine();
            }
            else if(NumeroPersonas > 50)
            {
                Console.WriteLine("El número de personas no puede ser mayor a 50");
            }
        }

            //Desplegar datos
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(NombreCompleto \t FechaNacimiento \t Edad \t LugarNacimiento);
                Console.Write();
            }
        }
    }
}