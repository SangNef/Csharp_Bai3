using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._2
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

            // In dãy số trước khi đổi chỗ
            Console.WriteLine("Dãy số trước khi đổi chỗ:");
            InMang(mang);

            // Đổi chỗ các phần tử đối xứng nhau
            DoiChoCacPhanTuDoiXung(mang);

            // In dãy số sau khi đổi chỗ
            Console.WriteLine("Dãy số sau khi đổi chỗ:");
            InMang(mang);

            Console.ReadKey();
        }

        // Phương thức đổi chỗ các phần tử đối xứng nhau
        static void DoiChoCacPhanTuDoiXung(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                double temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
        }

        // Phương thức in mảng
        static void InMang(double[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
