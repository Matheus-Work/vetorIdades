using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] vet = new int[8];
            Preencher(vet);
        }
        static void Preencher(int[] idade)
        {
            int soma = 0;
            for(int i = 0; i <= 7; i++)
            {
                Console.WriteLine("Digite a {0}º idade: ", i+1);
                idade[i] = int.Parse(Console.ReadLine());
                Validar(ref idade[i]);
                soma = soma + idade[i];
            }
             Media(ref soma);
        }
        static void Validar(ref int x)
        {
            while(x<1 || x > 120)
            {
                Console.WriteLine("Redigite a sua idade");
                x = int.Parse(Console.ReadLine());
            }
        }
        static void Media(ref int soma)
        {
            double media = soma / 8;
            Console.WriteLine("A media entre essas idades são: {0}", media);
        }
    }
}