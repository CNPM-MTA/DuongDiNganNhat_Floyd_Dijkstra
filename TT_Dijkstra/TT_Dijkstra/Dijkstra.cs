using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_Dijkstra
{
    class class_Dijkstra
    {
        //a[i, j] là ma trận trọng số cạnh
        //L[i] là nhãn đỉnh I
        // mảng Daxet[i] = 0 - đỉnh i chưa xét, 1 - đỉnh i đã xét
        //Ddnn[i]: giá trị của nó là đỉnh trong đường đi ngắn nhất đến i
        //Dht: Đỉnh hiện thời
        public const int MAX = 100;
        public const int VC = int.MaxValue;
        public void function_Dijkstra(int[,] arr, int number, int s)
        {
            if (s >= number) return;
            //s--;
            int[] Ddnn = new int[number];//đường đi ngắn nhất
           
            int len_ddnn;
            int[] Daxet = new int[number];//tập đỉnh đã xét
            int[] L = new int[number];//Nhãn của đỉnh I, khoảng cách từ đỉnh I đến điểm S
            int i = 0, k = 0, Dht, Min;
            for (i = 0; i < number; i++)
            {
                Daxet[i] = 0;
                L[i] = VC;
                Ddnn[i] = -1;
            }
            //Dua dinh s vao tap dinh S da xet
            Daxet[s] = 1;
            L[s] = 0;
            Dht = s;
            
            int count = 1;//đếm mỗi bước cho đủ n-1 bước

            while (count <= number - 1)
            {
                Min = VC;
                for (i = 0; i < number; i++)
                {
                    if (Daxet[i] == 0)//chua xet
                    {
                        if (L[Dht] + arr[Dht, i] < L[i] && arr[Dht, i]!= VC) //tinh lai nhan
                        {
                            L[i] = L[Dht] + arr[Dht, i];
                            Ddnn[i] = Dht;
                        }
                        //gán đỉnh hiện tại là đỉnh trước đỉnh i trên lộ trình

                        if (L[i] < Min)//chọn đỉnh K
                        {
                            Min = L[i];
                            k = i;
                        }//tại bước h: tìm được đường đi ngắn nhất từ s đến k: Ddnn[] 
                    }
                }
                show(s, k, Ddnn);
                //Ddnn = new int[number];
                Dht = k;//khởi động lại Dht
                Daxet[Dht] = 1;//đưa nút K vào tập nút đã xét
                count++;
            }
        
        }
        //hiển thị đường đi ngắn nhất từ s đến k
        public void show(int s, int k, int[] Ddnn)
        {
            Console.WriteLine();
            int i = 0;
            Console.Write(s + "==> " + k + "\t: ");
            i = k;
            Console.Write(k );
            do
            {
                Console.Write(" <==  " + Ddnn[i] );
                i = Ddnn[i];
            } while (i != s);
            
        }
    }
}
