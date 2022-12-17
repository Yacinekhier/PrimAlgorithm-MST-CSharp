using System;
using System.Collections.Generic;

namespace PrimsAlgoCSharp
{
        public class Graph
        {
            
            int inf = Int32.MaxValue;

            public void ACM(int nbSommet, int[,] matAdj, Dictionary<int, string> sommet)
            {

                bool[] selected = new bool[nbSommet];

                int nbArcs = 0;

                Console.WriteLine("L'arbre couvrant de poids minimal:\n\n");
                Console.WriteLine("  Arc: \t\t Poids:");
                Console.WriteLine();

                // first vertex is selected
                selected[0] = true;
                while (nbArcs < nbSommet - 1)
                {
                    int min = inf;
                    int x = 0, y = 0;
                    
                    for (int i = 0; i < nbSommet; i++)
                    {
                        // 
                        if (selected[i])
                        {
                            for (int j = 0; j < nbSommet; j++)
                            {
                            // 
                            if ((!selected[j]) && matAdj[i, j] != 0)
                                {
                                    // 
                                    if (min > matAdj[i, j])
                                    {
                                        //
                                        min = matAdj[i, j];
                                        x = i;
                                        y = j;
                                    }
                                }
                            }
                        }
                    }
                    // 
                    Console.WriteLine(" (" + sommet[x] + "-" + sommet[y] + ")  \t" + matAdj[x, y]);
                    Console.WriteLine();
                    // 
                    selected[y] = true;
                    nbArcs += 1;

                }
            }



        }
    
}
