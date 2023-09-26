using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grafo2 = new int[6, 6];
            int origen = 1;
            int destino = 3;
            int[] unionesorigen;
            int[] unionesdestino;
            int tamaorigen = 0;
            int tamadestino = 0;
            int contador = 0;
            int contador2 = 0;
            int posmatrizMenor = 0;
            int sumamenor = 0;

            //A = 0
            grafo2[0, 1] = 2;
            grafo2[0, 2] = 1;
            grafo2[0, 3] = 4;

            // B = 1
            grafo2[1, 0] = 2;
            grafo2[1, 2] = 1;
            grafo2[1, 4] = 2;
            grafo2[1, 5] = 3;

            //C = 2
            grafo2[2, 0] = 1;
            grafo2[2, 1] = 1;
            grafo2[2, 3] = 1;
            grafo2[2, 4] = 2;

            //D = 3
            grafo2[3, 0] = 4;
            grafo2[3, 2] = 1;
            grafo2[3, 4] = 3;

            //E = 4
            grafo2[4, 1] = 2;
            grafo2[4, 2] = 2;
            grafo2[4, 3] = 3;
            grafo2[4, 5] = 4;

            // F = 5
            grafo2[5, 1] = 3;
            grafo2[5, 4] = 4;

            //Imprimir
            for (int i = 0; i < grafo2.GetLength(1); i++)
            {
                for ( int j=0; j< grafo2.GetLength(1); j++)
                {
                    if (j==0)
                    {
                        Console.Write(grafo2[i, j]);
                    }
                    else
                    {
                        Console.Write("-" + grafo2[i,j]);
                    }
                }
                Console.WriteLine();
            }

            //Obtener tamaño de los vectores con los vertices
            for (int i=0;i<grafo2.GetLength(1); i++)
            {
                for ( int j=0;j<grafo2.GetLength(1);j++)
                {
                    if (i == origen)
                    {
                        if (grafo2[i,j] != 0)
                        {
                            tamaorigen++;
                            //unionesorigen[contador] =j;
                            //contador++;

                        }
                    }
                    if (i ==destino)
                    {
                        if (grafo2[i,j]!=0)
                        {
                            tamadestino++;
                            //unionesdestino[contador2]=j;
                            //contador2++;
                        }
                    }
                }
            }
            unionesorigen = new int[tamaorigen];
            unionesdestino = new int[tamadestino];

            //Almacena las vertices del origen y el destino
            for (int i = 0;i<grafo2.GetLength(1);i++)
            {
                for (int j=0;j<grafo2.GetLength(1);j++)
                {
                    if (i ==origen)
                    {
                        if (grafo2[i,j] != 0)
                        {
                            unionesorigen[contador] = j;
                            contador++;
                        }
                    }
                    if (i ==destino)
                    {
                        if (grafo2[i,j]!=0)
                        {
                            unionesdestino[contador2] = j;
                            contador2++;
                        }
                    }
                }
            }
            if(unionesorigen.Length>unionesdestino.Length)
            {
                for (int i = 0; i < unionesdestino.Length; i++)
                {
                    if (unionesorigen[i] == unionesdestino[i])
                    {
                        int suma = grafo2[origen, unionesdestino[i]]+grafo2[destino, unionesdestino[i]];

                        if (sumamenor == 0)
                        {
                            sumamenor = suma;
                        }
                        else
                        {
                            if (suma < sumamenor)
                            {
                                sumamenor = suma;
                                posmatrizMenor = unionesorigen[i];
                            }
                        }
                    }
                }
                Console.WriteLine("El camino mas corto entre " + origen + " y " + destino + "es el camino " + origen + "-" + posmatrizMenor + "-" + destino);
            }
            else
            {
                for (int i = 0;i<unionesorigen.Length;i++)
                {
                    if (unionesorigen[i] == unionesdestino[i])
                    {
                        int suma = grafo2[origen, unionesdestino[i]] + grafo2[destino, unionesdestino[i]];

                        if (sumamenor == 0)
                        {
                            sumamenor = suma;
                        }
                        else
                        {
                            if (suma < sumamenor)
                            {
                                sumamenor = suma;
                                posmatrizMenor = unionesorigen[i];
                            }
                        }
                    }
                }
                Console.WriteLine("El camino mas corto entre " + origen + " y " + destino + "es el camino " + origen + "-" + posmatrizMenor + "-" + destino);
            }

            Console.ReadLine();
        }
    }
}
    

