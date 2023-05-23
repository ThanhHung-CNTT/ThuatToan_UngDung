using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Heuristic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Luan_Van = new int[12];
            int[] m = new int[3] { 0, 0, 0 };
            Console.WriteLine("=======Nhap So trang cua cac luan van======\n");
            for(int i = 0; i < 12; i++)
            {
                Console.Write("Nhap Q[{0}] = ",i+1);
                Luan_Van[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
            }

            // Bubble Sort
            for (int i = 11; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (Luan_Van[j - 1] > Luan_Van[j])
                    {
                        int temp = Luan_Van[j - 1];
                        Luan_Van[j - 1] = Luan_Van[j];
                        Luan_Van[j] = temp;
                    }
                }
            }

            for(int i = 0; i < 12; i++)
            {
                if (m[0] == m[1] && m[0] == m[2])
                {
                    m[0] += Luan_Van[i];
                }
                else if (m[0] < m[1] && m[0] < m[2])
                {
                    m[0] += Luan_Van[i];
                }
                else if (m[1] < m[0] && m[1] < m[2])
                {
                    m[1] += Luan_Van[i];
                }
                else if (m[2] < m[0] && m[2] < m[0])
                {
                    m[2] += Luan_Van[i];
                }
                else if ((m[0] == m[1] && m[0] < m[2]) || (m[0] == m[2] && m[0] < m[1]))
                {
                    m[0] += Luan_Van[i];
                }
                else if (m[1] == m[2] && m[1]< m[0])
                {
                    m[1] += Luan_Van[i];
                }
            }

            Console.WriteLine("De thoi gian toi uu nhat thi m[0] = {0}, m[1] = {1}, m[2] = {2}", m[0], m[1], m[2]);

            Console.ReadLine();
        }
    }
}
