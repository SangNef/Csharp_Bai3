using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._7
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

            // Đếm số lượng số chính phương trong mảng
            int soLuongChinhPhuong = DemSoChinhPhuongTrongMang(mang);

            // In số lượng số chính phương ra màn hình
            Console.WriteLine("Số lượng số chính phương trong dãy: " + soLuongChinhPhuong);
            Console.ReadKey();
        }

        // Phương thức kiểm tra xem một số có phải là số chính phương hay không
        static bool LaSoChinhPhuong(int num)
        {
            int sqrt = (int)Math.Sqrt(num);
            return sqrt * sqrt == num;
        }

        // Phương thức đếm số lượng số chính phương trong mảng
        static int DemSoChinhPhuongTrongMang(int[] arr)
        {
            int dem = 0;
            foreach (var item in arr)
            {
                if (LaSoChinhPhuong(item))
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
