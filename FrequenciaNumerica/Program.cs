using System;

namespace FrequenciaNumerica
{
    internal class Program
    {
        static void Main(string[] args)
        {


           

            string opcao;
            int tamanhoArray;
            int contador = 0;
            int numero;



            Console.WriteLine("Digite o valor para o tamanho da array:");
            tamanhoArray = Convert.ToInt32(Console.ReadLine());

            int[] listaNumeros = new int [tamanhoArray];

            for (int i = 0; i < tamanhoArray; i++)
            {
                Console.WriteLine("Digite o valor desejado:");

                listaNumeros[i] = Convert.ToInt32(Console.ReadLine());


            }


            for (int i = 0; i < listaNumeros.Length; i++)
            {
                for (int j = i; j <listaNumeros.Length; j++)
                {
                    if ( i != j && listaNumeros[j] == listaNumeros[i])
                    {

                        numero = listaNumeros[j];
                        contador++;

                          
                    }

                }   


            }


            Console.WriteLine("Numeros repetidos -> " + contador);

            Console.ReadLine();
        }
    }
}
