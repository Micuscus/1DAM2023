// --------------------------------------------
// Marcos Alfonso Cantero
// Curso DAM
// Modalidad Presencial/
// Práctica nº 2
// --------------------------------------------
using System;
public class practica2
{
    public static void Main()
    {
        char letra;
        string secreto;
        int fallos = 6;
        bool correcto = false;

        Console.WriteLine("Introduce la palabra para adivinar");
        secreto = Console.ReadLine();
        char[] palabramostrar = new char[secreto.Length];
        int longitud = secreto.Length;
        Console.WriteLine();

        while (correcto)
        {
            Console.WriteLine("\nIntroduce una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            if (secreto.IndexOf(letra) == -1)
                fallos--;

            for (int x = 0; x < longitud; x++)
            {
                if (secreto[x] == letra)
                {
                    palabramostrar[x] = letra;
                    Console.Write("");
                }
                else{
                    Console.Write("_");
                }
                //introducir un switch con los fallos para el monigote
            }
            Console.WriteLine(palabramostrar);
        }

        for (int i = 0; i < fallos;)
        {
            Console.WriteLine("\n\n┌───┐");
            Console.WriteLine("│");
            Console.WriteLine("│");
            Console.WriteLine("│");
            Console.WriteLine("│");
            Console.WriteLine("┴───────");
        }
    }
}
