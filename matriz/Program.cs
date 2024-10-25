using System;
using BibliotecaMatriz;

namespace matriz
{
    internal class Program
    {
       
        
            static void Main()

            {
            int linhas, colunas;
             Console.WriteLine("*** Matrizes ***");
              Console.WriteLine("quantidade de linhas e colunas:");
              linhas= int.Parse(Console.ReadLine());
              colunas= int.Parse(Console.ReadLine());
              int[,] matrix = new int[linhas, colunas];//criando
            Console.WriteLine(" Entre com dados para matriz:");
              Matriz.leia(matrix);
            Console.WriteLine("Dados da Matriz:");
              Matriz.gera(matrix);
            Console.ReadKey();


            }
        
    }

}
    

