using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int valorBuscar = 10;
        int[] valoresDisponiveis = new int[] { 2, 3, 4 };
        BuscarValor(valorBuscar, valoresDisponiveis);
    }

    private static void BuscarValor(int valorBuscar, int[] valoresDisponiveis)
    {
        int valorEncontrado = 0;
        int indice = 0;
        List<int[]> valoresEncontrados = new List<int[]>();

        while (true)
        {
            List<int> valoresUtilizados = new List<int>();

            while (true)
            {
                if (valorEncontrado < valorBuscar)
                {
                    int valorDescobrir = valorBuscar - valorEncontrado;
                    if (valoresDisponiveis.Any(x => x == valorDescobrir))
                    {
                        int valorFaltante = valoresDisponiveis.First(x => x == valorDescobrir);
                        valorEncontrado += valorFaltante;
                        valoresUtilizados.Add(valorFaltante);
                    }
                }

                if (valorEncontrado == valorBuscar)
                    break;

                if (valorEncontrado > valorBuscar)
                    break;

                valorEncontrado += valoresDisponiveis[indice];
                valoresUtilizados.Add(valoresDisponiveis[indice]);
            }


            if (valoresUtilizados.Sum() == valorBuscar)
                valoresEncontrados.Add(valoresUtilizados.ToArray());
            else
                valoresUtilizados.Clear();



            valorEncontrado = 0;

            indice++;

            if (indice > valoresDisponiveis.Length - 1)
                break;
        }

        int quantidadeMinima = valoresEncontrados.Min(x => x.Count());
        var listaUtilizada = valoresEncontrados.First(x => x.Count() == quantidadeMinima);
        string numerosUtilizados = "";
        for (int i = 0; i < listaUtilizada.Count(); i++)
        {
            numerosUtilizados += listaUtilizada[i] + ",";
        }
        Console.WriteLine(numerosUtilizados.TrimEnd(','));

        Console.ReadKey();

    }
}