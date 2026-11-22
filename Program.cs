using System;

class Program
{
    static string[] codigos = { "20260001", "20260002", "20260003", "20260004",
                                "20260005", "20260006", "20260007", "20260008" };
    static string[] archivos = { "tarea1_final.pdf", "informe_v2.docx", "practica3.cs", "proyecto_final.zip",
                                 "lab5_v2.pdf", "resumen.docx", "ejercicio4.cs", "examen_final.pdf" };
    static int[] puntajes = { 18, 15, 12, 20, 16, 9, 14, 17 };

    static void Main()
    {
        int opcion;
        do
        {
            MostrarMenu();

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Escribe solo números.");
                opcion = -1;
                continue;
            }

            if (opcion == 1)
            {
                MostrarEntregas();
            }
            else if (opcion == 2)
            {
                OpcionSumar();
            }
            else if (opcion == 3)
            {
                OpcionBuscar();
            }
            else if (opcion != 0)
            {
                Console.WriteLine("Opción no válida.");
            }
        } while (opcion != 0);

        Console.WriteLine("Programa terminado.");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n===== ANÁLISIS DE ENTREGAS DIGITALES =====");
        Console.WriteLine("1. Ver entregas");
        Console.WriteLine("2. Sumar puntajes (recursivo e iterativo)");
        Console.WriteLine("3. Buscar código de estudiante (recursivo e iterativo)");
        Console.WriteLine("0. Salir");
        Console.Write("Elige una opción: ");
    }

    static void MostrarEntregas()
    {
        for (int i = 0; i < codigos.Length; i++)
        {
            Console.WriteLine(codigos[i] + " | " + archivos[i] + " | " + puntajes[i]);
        }
    }

    static void OpcionSumar()
    {
        int recursiva = Recursivas.SumarPuntajes(puntajes);
        int iterativa = Iterativas.SumarPuntajes(puntajes);
        Console.WriteLine("Suma de puntajes (recursiva): " + recursiva);
        Console.WriteLine("Suma de puntajes (iterativa): " + iterativa);
    }

    static void OpcionBuscar()
    {
        Console.Write("Código de estudiante: ");
        string codigo = Console.ReadLine();
        if (codigo == "")
        {
            Console.WriteLine("Error: el código no puede estar vacío.");
            return;
        }

        int recursiva = Recursivas.BuscarCodigo(codigos, codigo);
        int iterativa = Iterativas.BuscarCodigo(codigos, codigo);
        if (recursiva == -1)
        {
            Console.WriteLine("Código no encontrado (resultado -1).");
        }
        else
        {
            Console.WriteLine("Encontrado en la posición " + recursiva + " (recursiva).");
            Console.WriteLine("Encontrado en la posición " + iterativa + " (iterativa).");
        }
    }
}