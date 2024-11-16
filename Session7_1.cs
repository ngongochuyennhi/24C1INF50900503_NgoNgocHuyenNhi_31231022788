using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
    internal class Session7
    {
        //Nhập mảng từ bàn phím
        static void NhapMangBangCom(int[,] a, int rows, int columns)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        //In mảng ra màn hình
        private static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //Tìm các vị trí mà giá trị Value xuất hiện
        static void SearchLinear(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai dong {i} cot {j}\n");
                        return; //Nếu đã thấy value thì ngưng tìm, không tìm tất cả vị trí của value
                    }
                }
            }
        }
        static void NhapMangNgauNhien(int[,] a, int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
        }
        private static void Main(string[] args)
        {
            int[,] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int columns = int.Parse(Console.ReadLine());
            //Tạo mảng 2 chiều
            a = new int[rows, columns];
            NhapMangNgauNhien(a, rows, columns);
            Console.WriteLine("Mang tao duoc la: ");
            XuatMang(a);
            Console.Write("Nhap so can tim: "); int val = int.Parse(Console.ReadLine());
            SearchLinear(a, val);
        }
    }
    internal class BaiTapVanDung
    {
        static void NhapMangNgauNhien(int[,] a, int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
        }
        private static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void XuatDong(int[,] a, int dong)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (dong == i)
                        Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void XuatCot(int[,] a, int cot)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (cot == j)
                        Console.WriteLine(a[i, j]);
                }
                Console.WriteLine();
            }
        }
        //Hàm tìm giá trị lớn nhất trong mảng
        static int FindMaxValue(int[,] a)
        {
            int max = a[0, 0]; // Giả sử phần tử đầu tiên là lớn nhất
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j]; // Cập nhật max nếu tìm thấy phần tử lớn hơn
                    }
                }
            }
            return max;
        }
        //Hàm tìm giá trị nhỏ nhất trong một dòng
        static int FindMinInRow(int[,] a, int dong)
        {
            int min = a[dong, 0];
            for (int j = 1; j < a.GetLength(1); j++)
            {
                if (a[dong, j] < min)
                {
                    min = a[dong, j];
                }
            }
            return min;
        }

        // Hàm tìm giá trị nhỏ nhất trong một cột
        static int FindMinInCol(int[,] a, int cot)
        {
            int min = a[0, cot];
            for (int i = 1; i < a.GetLength(0); i++)
            {
                if (a[i, cot] < min)
                {
                    min = a[i, cot];
                }
            }
            return min;
        }
        private static void Main(string[] args)
        {
            int[,] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int columns = int.Parse(Console.ReadLine());
            //Tạo và xuất mảng 2 chiều:
            a = new int[rows, columns];
            NhapMangNgauNhien(a, rows, columns);
            XuatMang(a);
            //Tìm giá trị lớn nhất trong mảng:
            int val = FindMaxValue(a);
            Console.WriteLine($"Gia tri lon nhat trong mang la: {val}");
            //In dòng/cột:
            Console.Write("Ban muon in dong hay cot <D/C>: ");
            string choice = Console.ReadLine();
            if (choice.ToUpper() == "D")
            {
                Console.Write("In dong may: ");
                int dong = int.Parse(Console.ReadLine());
                Console.Write($"Dong thu {dong}: ");
                XuatDong(a, dong);
                int mininRow = FindMinInRow(a, dong);
                Console.Write($"Gia tri nho nhat trong dong la: {mininRow}");
            }
            else
            {
                Console.Write("In cot may: ");
                int cot = int.Parse(Console.ReadLine());
                Console.WriteLine($"Cot thu {cot}: ");
                XuatCot(a, cot);
                int mininCol = FindMinInCol(a, cot);
                Console.Write($"Gia tri nho nhat trong cot la: {mininCol}");
            }
        }
    }
}
