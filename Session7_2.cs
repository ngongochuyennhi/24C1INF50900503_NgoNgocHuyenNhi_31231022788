using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
    internal class Session7_2
    {
        public static void Main()
        {
            int[][] a;
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            a = new int[rows][];
            TaoMangTuDong(a);
            InMang(a);
            int val = FindMaxInArray(a);
            Console.WriteLine($"So lon nhat trong mang la: {val}");
            Console.WriteLine("So lon nhat cua moi dong la:");
            FindMaxOfEachRow(a);
            Console.Write("Nhap dong can sap xep: ");
            int index = int.Parse(Console.ReadLine());
            SortRowAtoZ(a, index);
            Console.WriteLine();
            InMang(a);
            SortEachRow(a);
            Console.WriteLine("Mang sau khi sap xep tang dan:");
            InMang(a);
            Console.WriteLine("Cac so nguyen to cua mang la: ");
            PrintPrimeNumbers(a);
            Console.Write("Nhap so can tim: ");
            int socantim = int.Parse(Console.ReadLine());
            Console.Write($"Vi tri cua {socantim} trong mang la: ");
            FindAllPositions(a, socantim);
        }
        private static void TaoMangTuDong(int[][] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols]; //cấp phát vùng nhớ cho các phần tư
                for (int j = 0; j < cols; j++)
                {
                    a[i][j] = random.Next(0, 100);
                    //Nếu tự nhập:
                    //Console.Write($"a[{i}][{j}]= ");
                    //a[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        private static void InMang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
        //1. Hàm in số lớn nhất trong mảng và số lớn nhất của mỗi hàng
        static int FindMaxInArray(int[][] a)
        {
            int max = a[0][0]; // Giả sử phần tử đầu tiên là lớn nhất
            foreach (var row in a)
            {
                foreach (var value in row)
                {
                    if (value > max)
                    {
                        max = value; // Cập nhật max nếu tìm thấy phần tử lớn hơn
                    }
                }
            }
            return max;
        }
        static void FindMaxOfEachRow(int[][] a)
        {
            foreach (var row in a) //Duyệt qua từng hàng của mảng
            {
                int max = row[0];
                foreach (var value in row) //Duyệt qua từng phần tử trong hàng
                {
                    if (value > max)
                        max = value;
                }
                Console.WriteLine(max);
            }
        }
        //2. Hàm sắp xếp giá trị tăng dần của mỗi hàng
        static void SortEachRow(int[][] a)
        {
            foreach (var row in a)
            {
                Array.Sort(row);
            }
        }
        //3.Hàm in các số nguyên tố của mảng
        static bool isPrime(int number) //Kiểm tra số nguyên tố
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
        static void PrintPrimeNumbers(int[][] a) //Duyệt từng phần tử của mảng và in nếu là số nguyên tố
        {
            foreach (var row in a)
            {
                foreach (var value in row)
                {
                    if (isPrime(value))
                        Console.Write(value + " ");
                }
            }
            Console.WriteLine();
        }
        //4. Hàm tìm và in tất cả vị trí của một số(nhập bởi người dùng)
        static void FindAllPositions(int[][] a, int socantim)
        {
            bool found = false;
            for (int i = 0; i < a.Length; i++) //Duyệt qua từng hàng trong mảng
            {
                for (int j = 0; j < a[i].Length; j++) //Duyệt qua từng phần tử trong hàng
                {
                    if (a[i][j] == socantim)
                    {
                        Console.WriteLine($"[{i}][{j}]");
                        found = true; //Đánh dấu đã tìm thấy số
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Khong tim thay so trong mang!");
            }
        }
        static void SortRowAtoZ(int[][] a, int index) //index là dòng sẽ sắp xếp
        {
            int[] line = a[index - 1];
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (line[i] < line[j])
                    {
                        int temp = line[i];
                        line[i] = line[j];
                        line[j] = temp;
                    }
                }

            }
        }
    }
    internal class Exercise1_1
    {
        public static void Main()
        {
            int[][] a = new int[4][];  //Mảng gồm có 4 hàng

            // Khởi tạo từng hàng của mảng với các cột tương ứng
            a[0] = new int[] { 1, 1, 1, 1, 1 };
            a[1] = new int[] { 2, 2 };
            a[2] = new int[] { 3, 3, 3, 3 };
            a[3] = new int[] { 4, 4 };

            // Hiển thị các phần tử của mảng
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
