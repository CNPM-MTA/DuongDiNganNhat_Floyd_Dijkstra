using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_Dijkstra
{
    class Program
    {
        public const int VC = 1000;
        /// <summary>
        /// Đường đi ngắn nhất
        /// Đồ thị G=(V, E) là đơn dthi liên thông(vô hướng hoặc có hướng)
        /// có trọng số. V- tập đỉnh, E- tập cạnh
        /// Tìm đường đi ngắn nhất từ s0 thuộc V đến tất cả các đỉnh còn lại.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            class_Dijkstra dijk = new class_Dijkstra();
            Dijstra1 d = new Dijstra1();
            int[,] arr = new int[6, 6] {
                { 0, 20, 15, VC, 80, VC }, 
                { 40, 0, VC, VC, 10, 30 },
                { 20, 4, 0, VC, VC , 10},
                { 36, 18, 15, 0, VC, VC },
                { VC, VC, 90, 15,0, VC},
                {VC, VC, 45, 4, 10 ,0} };

            dijk.function_Dijkstra(arr, 6, 1);
            //d.func_Dijkstra(6, arr, 0);
            int[,] arr1 = new int[VC, VC];
           // arr1= ReadFile("Dijkstra.txt");
            
            Console.ReadKey();
        }
        public static int[,] ReadFile(String filePath)
        {
            int[,] arr = new int[VC,VC];
            System.IO.StreamReader reader = new System.IO.StreamReader(filePath);
            String a = reader.ReadLine();
            int i = 0, j = 0;
            foreach (var row in a.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    arr[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            return arr;
        }
    }
}
