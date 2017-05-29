using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_Dijkstra
{
    class Dijstra1
    {
        public struct Vertices
        {
            public int id;
            public bool Check;
            public int Label;
            public int[] len;
        };
        public void func_Dijkstra(int number, int[,] tree, int start)
        {
            Vertices[] arr_vertices = createVertices(number, tree, start);
            int[] Ddnn = new int[number];
            int count = 0, i, dht, select = - 1, min;
            dht = start;
            while (count < number)
            {
                min = int.MaxValue;
                for (i = 0; i < number; i++)
                {
                    if (!arr_vertices[i].Check)
                    {
                        if (arr_vertices[dht].Label + arr_vertices[dht].len[i] < arr_vertices[i].Label)
                        {
                            arr_vertices[i].Label = arr_vertices[dht].Label + arr_vertices[dht].len[i];
                            Ddnn[i] = dht;
                        }
                        if (arr_vertices[i].Label < min)
                        {
                            min = arr_vertices[i].Label;
                            select = i;
                        }
                    }
                }
                print(start, select, Ddnn);
                dht = select;
                count++;
            }
        }
        public Vertices[] createVertices(int number, int [,] tree, int start)
        {
            Vertices []arr = new Vertices[number];
            
            int i, j;
            for (i = 0; i < number; i++)
            {
                if (i == start)
                {
                    arr[i].id = start;
                    arr[i].Check = true;
                    arr[i].Label = 0;
                }
                else
                {
                    arr[i].id = i;
                    arr[i].Check = false;
                    arr[i].Label = -1;
                }
                arr[i].len = new int[number];
                for(j = 0; j< number; j++)
                {
                    arr[i].len[j] = tree[i, j];
                }
            }
            return arr;
        }
        public void print(int start, int k, int[] Ddnn)
        {
            Console.WriteLine();
            int i = k;
            while(i!= start)
            {
                Console.Write(i + "\t");
                i = Ddnn[i];
            }
        }
    }
}
