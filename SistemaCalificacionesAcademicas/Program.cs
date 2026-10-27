using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCalificacionesAcademicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sistema Calificaciones Académicas
            decimal calificaiones, nota1, nota2, nota3, nota4, promedio;
            string nombreEstudiante,condicion,clasificacion =  string.Empty;

            // 1. solicitar el nombre del estudiantes 
            Console.Write("Ingrese el nombre del estudiantes: ");
            nombreEstudiante = Console.ReadLine().ToUpper();

            // 2 solicitar calificacion
            Console.Write(" La Nota del P1: ");
            if (!decimal.TryParse(Console.ReadLine(), out nota1) || nota1 >= 0 && nota1 >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No puede ingresar texto en la calificacion");
                Console.WriteLine("Intentelo de nuevo");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" LNota del P1: ");
            }

            Console.Write(" La Nota del P2: ");
            if (!decimal.TryParse(Console.ReadLine(), out nota2) || nota2 >= 0 && nota2 >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No puede ingresar texto en la calificacion");
                Console.WriteLine("Intentelo de nuevo");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" LNota del P2: ");
            }

            Console.Write(" La Nota del P3: ");
            if (!decimal.TryParse(Console.ReadLine(), out nota3) || nota3 >= 0 && nota3 >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No puede ingresar texto en la calificacion");
                Console.WriteLine("Intentelo de nuevo");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" LNota del P3: ");
            }

            Console.Write(" La Nota del P4: ");
            if (!decimal.TryParse(Console.ReadLine(), out nota4) || nota4 >=0  && nota4 <=100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No puede ingresar texto en la calificacion");
                Console.WriteLine("Intentelo de nuevo");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" LNota del P4: ");
            }



        }
    }
}
