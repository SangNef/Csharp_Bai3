using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập số lượng phần tử N
            Console.Write("Nhập số lượng phần tử N: ");
            int N = int.Parse(Console.ReadLine());

            // Khai báo mảng để lưu các số nguyên
            int[] mang = new int[N];

            // Nhập dãy số nguyên từ người dùng
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhập số thứ {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }

            // In dãy số trước khi sắp xếp
            Console.WriteLine("Dãy số trước khi sắp xếp:");
            InMang(mang);

            // Sắp xếp mảng theo thứ tự giảm dần
            SapXepGiamDan(mang);

            // In dãy số sau khi sắp xếp
            Console.WriteLine("Dãy số sau khi sắp xếp giảm dần:");
            InMang(mang);

            Console.ReadKey();
        }

        // Phương thức sắp xếp mảng giảm dần
        static void SapXepGiamDan(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        // Phương thức in mảng
        static void InMang(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        
    }
}
