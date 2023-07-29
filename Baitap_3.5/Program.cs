using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập số lượng phần tử N
            Console.Write("Nhập số lượng phần tử N: ");
            int N = int.Parse(Console.ReadLine());

            // Khai báo mảng để lưu các số thực
            double[] mang = new double[N];

            // Nhập dãy số thực từ người dùng
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhập số thứ {0}: ", i + 1);
                mang[i] = double.Parse(Console.ReadLine());
            }

            // Tìm số lớn nhất trong mảng
            double max = TimSoLonNhatTrongMang(mang);

            // In số lớn nhất ra màn hình
            Console.WriteLine("Số lớn nhất trong dãy: " + max);

            Console.ReadKey();

        }

        // Phương thức tìm số lớn nhất trong mảng
        static double TimSoLonNhatTrongMang(double[] arr)
        {
            double max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
