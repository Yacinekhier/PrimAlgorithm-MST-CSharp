using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimsAlgoCSharp
{
    class Program
    {
       
        static void Main(string[] args)
        {


            // Adjacency matrix of G
            int[,] matAdj = new int[,]{{0,  15, 12, 9,  0, 0,  0},
                                       {15, 0,  0,  16, 0, 0,  0},
                                       {12, 0,  0,  7,  6, 0,  0},
                                       {9,  16, 7,  0,  0, 13, 0},
                                       {0,  0,  6,  0,  0, 5,  8},
                                       {0,  0,  0,  13, 5, 0,  0},
                                       {0,  0,  0,  0,  8, 0,  0}};
            // 
            Dictionary<int, string> sommet = new Dictionary<int, string>{
                    { 0, "A" },
                    { 1, "B" },
                    { 2, "C" },
                    { 3, "D" },
                    { 4, "E" },
                    { 5, "F" },
                    { 6, "G" }
                };

            //
            Graph G = new Graph();
            // 
            G.ACM(7, matAdj, sommet);
            Console.ReadKey();
        }
    }
}
