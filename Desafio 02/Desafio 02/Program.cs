using System;


internal class Program
{
    static void Main(string[] args)
    {
        int[] tempoChegada = new int[] { -2, -1, 0, 1, 2 };
        int quantidadeMinima = 3;
        VerificarEntradaAlunos(tempoChegada, quantidadeMinima);
        Console.ReadKey();
    }

    private static void VerificarEntradaAlunos(int[] entradas, int quantidadeMinima)
    {
        int quantidadeAlunosQueEntraramNoHorario = 0;

        foreach (int entrada in entradas)
        {
            if (entrada <= 0)
                quantidadeAlunosQueEntraramNoHorario++;
        }
        if (quantidadeAlunosQueEntraramNoHorario >= quantidadeMinima)
            Console.WriteLine("Aula Normal");
        else
            Console.WriteLine("Aula Cancelada");
    }
}