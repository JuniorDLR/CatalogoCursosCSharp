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
        Console.WriteLine("Junaxer estuvo aqui!");
    }

}
