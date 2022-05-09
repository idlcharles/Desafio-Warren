using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 12; i < 1000000; i++)
            {
                int numero = i;
                string numeroReversoString = InverterNumero(i);
                if (numeroReversoString[0] != '0')
                {
                    int somaNumeros = numero + int.Parse(numeroReversoString);

                    if (somaNumeros % 2 != 0)
                    {
                        Console.WriteLine($"Soma encontrada numeros, numero: {numero} reverso: {numeroReversoString} soma: {somaNumeros}");
                        list.Add(somaNumeros);
                    }
                }
            }

            //codigo abaixo remove itens duplicados
            //list = list.Distinct().ToList();
            Console.WriteLine($"Quantidade total de numeros encontrados é de {list.Count}");
            Console.ReadKey();
        }

        private static string InverterNumero(int num)
        {
            string numeroConvertido = "";
            char[] charArray = num.ToString().ToArray().Reverse().ToArray();
            for (int i = 0; i < charArray.Count(); i++)
            {
                numeroConvertido += charArray[i].ToString();
            }
            return numeroConvertido;

            Console.ReadKey();
        }
    }
}
    
