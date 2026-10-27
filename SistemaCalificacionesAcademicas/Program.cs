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
            decimal calificacion, nota1, nota2, nota3, nota4;
            string nombreEstudiante = string.Empty;
            string clasificacion = string.Empty;
            string condicion = string.Empty;


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====================================================");
            Console.WriteLine("           Sistema de Calificaciones Académicas");
            Console.WriteLine("====================================================");
            Console.WriteLine("\n");
            Console.ResetColor(); 


            // 1. solicitar el nombre del estudiantes 
            Console.Write("Ingrese el nombre del estudiantes: ");
            nombreEstudiante = Console.ReadLine().ToUpper();

            // 2 solicitar calificacion
            // 3 valicacion que en en lugar de texto sea numero
            // 4 validacion de calificacion mayor a cero y menor a 100

            // 2.1. CALIFICACIÓN DEL P1

            Console.Write(" La Nota del P1: ");
            if (!decimal.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese una nota entre 0 y 100.");
                Console.WriteLine("Intentelo de nuevo");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese nuevamente la Nota del P1: ");
                if (!decimal.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 100)
                {
                   Console.WriteLine("Segundo intento incorrecto.");
                   return;
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nota registrada correctamente.");
            Console.ResetColor();


            // 2.2. CALIFICACIÓN DEL P2
            Console.Write(" La Nota del P2: ");
            if (!decimal.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese una nota entre 0 y 100.");
                Console.WriteLine("Intentelo de nuevo");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese nuevamente la Nota del P2: ");
                if (!decimal.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 100)
                {
                    Console.WriteLine("Segundo intento incorrecto.");
                    return;
                    
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nota registrada correctamente.");
            Console.ResetColor();

            // 2.3. CALIFICACIÓN DEL P3
            Console.Write(" La Nota del P3: ");
            if (!decimal.TryParse(Console.ReadLine(), out nota3) || nota3 < 0 || nota3 > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese una nota entre 0 y 100.");
                Console.WriteLine("Intentelo de nuevo");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese nuevamente la Nota del P3: ");
                if (!decimal.TryParse(Console.ReadLine(), out nota3) || nota3 < 0 || nota3 >   100)
                {
                    Console.WriteLine("Segundo intento incorrecto.");
                    return;

                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nota registrada correctamente.");
            Console.ResetColor();



            // 2.4. CALIFICACIÓN DEL P4
            Console.Write(" La Nota del P4: ");
            if (!decimal.TryParse(Console.ReadLine(), out nota4) || nota4 < 0 || nota4 > 100)
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingrese una nota entre 0 y 100.");
                Console.WriteLine("Intentelo de nuevo");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese nuevamente la Nota del P4: ");
                if (!decimal.TryParse(Console.ReadLine(), out nota4) || nota4 < 0 || nota4 > 100)
                {
                    Console.WriteLine("Segundo intento incorrecto.");
                    return;

                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nota registrada correctamente.");
            Console.ResetColor();

            // 5 evaluacion de escala de calificaciones
            calificacion = ((nota1 + nota2 + nota3 + nota4) / 4);


            if (calificacion >= 90 && calificacion <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                clasificacion = ("Excelente");
                condicion = ("Aprobado");

            }
            else if (calificacion >= 80 && calificacion <= 89)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                clasificacion = ("Muy bueno");
                condicion = ("Aprobado");
            }
            else if (calificacion >= 70 && calificacion <= 79)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                clasificacion = ("Aprobado");
                condicion = ("Aprobado");
            }
            else if (calificacion >= 60 && calificacion <= 69)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                clasificacion = ("Repobado");
                condicion = ("Reprobado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                clasificacion = ("Reprobado");
                condicion = ("Reprobado");

            }
            // Resumen final 
            Console.WriteLine("====================================================");
            Console.WriteLine("================= RESUMEN FINAL ====================");
            Console.WriteLine("====================================================");
            Console.WriteLine($"La calificacion del estudiante {nombreEstudiante} ");
            Console.WriteLine($"Su promedio Final es {calificacion:F2}");
            Console.WriteLine($"Su Calificacion Final es {calificacion:N0}");
            Console.WriteLine($"{clasificacion}; {condicion}");

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
