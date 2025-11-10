using System;
using System.Collections.Generic;

public class Curso
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }

    public override string ToString()
    {
        return $"{Id}. {Nombre} - {Descripcion}";
    }
}

class Program
{
    static void Main()
    {

        List<Curso> cursos = new List<Curso>
{
    new Curso { Id = 1, Nombre = "C# Básico", Descripcion = "Aprende los fundamentos de C#." },
    new Curso { Id = 2, Nombre = "Python para principiantes", Descripcion = "Comienza a programar con Python." },
    new Curso { Id = 3, Nombre = "HTML y CSS desde cero", Descripcion = "Crea páginas web con HTML y CSS." },
    new Curso { Id = 4, Nombre = "Java intermedio", Descripcion = "Conceptos intermedios y buenas prácticas en Java." },
    new Curso { Id = 5, Nombre = "Node.js y APIs", Descripcion = "Construye APIs REST con Node.js y Express." },
};

        Console.WriteLine("=== Catálogo de Cursos ===\n");

        while (true)
        {
            Console.WriteLine("1. Ver cursos");
            Console.WriteLine("2. Buscar curso");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                MostrarCursos(cursos);
            }
            else if (opcion == "2")
            {
                BuscarCurso(cursos);
            }
            else if (opcion == "3")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida.\n");
            }
        }
    }

    static void MostrarCursos(List<Curso> cursos)
    {
        Console.WriteLine("\nLista de cursos:\n");
        foreach (var curso in cursos)
        {
            Console.WriteLine(curso);
        }
        Console.WriteLine();
    }

    static void BuscarCurso(List<Curso> cursos)
    {
        Console.Write("\nEscribe una palabra para buscar: ");
        string texto = Console.ReadLine().ToLower();
        bool encontrado = false;

        foreach (var curso in cursos)
        {
            if (curso.Nombre.ToLower().Contains(texto))
            {
                Console.WriteLine($"Encontrado: {curso}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontró ningún curso con ese nombre.");
        }

        Console.WriteLine();
    }
}
