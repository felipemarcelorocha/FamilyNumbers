using System;

namespace FamilyNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Digite um número inteiro: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("INSIRA APENAS NÚMEROS INTEIROS");
                Console.Write("Digite um número inteiro: ");
            }

            GetNumber.startUp(number.ToString());
        }
    }
}
