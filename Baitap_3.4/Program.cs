using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._4
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

            // Đếm số lượng số âm trong mảng
            int soLuongAm = DemSoAmTrongMang(mang);

            // In số lượng số âm ra màn hình
            Console.WriteLine("Số lượng số âm trong dãy: " + soLuongAm);

            Console.ReadKey();
        }

        // Phương thức đếm số lượng số âm trong mảng
        static int DemSoAmTrongMang(double[] arr)
        {
            int dem = 0;
            foreach (var item in arr)
            {
                if (item < 0) // Kiểm tra số âm
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
