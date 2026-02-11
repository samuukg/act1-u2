// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

int cantidad;

// Validar cantidad
while (true)
{
    Console.Write("Cantidad de personas: ");
    if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 1)
        break;

    Console.WriteLine("Dato incorrecto");
}

List<string> nombres = new List<string>();
List<int> edades = new List<int>();

// Registrar personas
for (int i = 0; i < cantidad; i++)
{
    Console.Write("Nombre: ");
    nombres.Add(Console.ReadLine());

    int edad;

    while (true)
    {
        Console.Write("Edad: ");
        if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
            break;

        Console.WriteLine("Edad incorrecta");
    }

    edades.Add(edad);
}

// Caso una persona
if (cantidad == 1)
{
    Console.WriteLine(nombres[0] + " - " + edades[0]);

    if (edades[0] >= 18)
        Console.WriteLine("Mayor de edad");
    else
        Console.WriteLine("Menor de edad");
}
else
{
    Console.WriteLine("Lista general:");
    for (int i = 0; i < nombres.Count; i++)
    {
        Console.WriteLine(nombres[i] + " - " + edades[i]);
    }

    List<string> mayores = new List<string>();
    List<string> menores = new List<string>();

    for (int i = 0; i < nombres.Count; i++)
    {
        if (edades[i] >= 18)
            mayores.Add(nombres[i] + " - " + edades[i]);
        else
            menores.Add(nombres[i] + " - " + edades[i]);
    }

    if (mayores.Count > 0)
    {
        Console.WriteLine("Mayores de edad:");
        foreach (string m in mayores)
            Console.WriteLine(m);
    }

    if (menores.Count > 0)
    {
        Console.WriteLine("Menores de edad:");
        foreach (string m in menores)
            Console.WriteLine(m);
    }
}

Console.ReadKey();

