using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._3
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

            // Tính tổng các số lẻ trong mảng
            int tongSoLe = TinhTongSoLeTrongMang(mang);

            // In tổng các số lẻ ra màn hình
            Console.WriteLine("Tổng các số lẻ trong dãy: " + tongSoLe);
            Console.ReadKey();
        }

        // Phương thức tính tổng các số lẻ trong mảng
        static int TinhTongSoLeTrongMang(int[] arr)
        {
            int tong = 0;
            foreach (var item in arr)
            {
                if (item % 2 != 0) // Kiểm tra số lẻ
                {
                    tong += item;
                }
            }
            return tong;
        }
    }
}
