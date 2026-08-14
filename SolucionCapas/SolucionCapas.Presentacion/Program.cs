using System;
using SolucionCapas.Negocio;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingrese DNI: ");
        string dni = Console.ReadLine();

        PersonaNegocio negocio = new PersonaNegocio();

        Persona persona = negocio.ObtenerPersona(dni);

        if (persona != null)
        {
            Console.WriteLine("Persona encontrada:");
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Telefono: {persona.Telefono}");
            Console.WriteLine($"Direccion: {persona.Direccion}");
            Console.WriteLine($"Ciudad: {persona.Ciudad}");
        }
        else
        {
            Console.WriteLine("No existe.");
        }
    }
}