using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
    internal class Session05
    {
        static int maxOfThreeNumbers(int a, int b, int c) //1.Tìm số lớn nhất trong 3 số
        {
            //return Math.Max(Math.Max(a,b),c);
            int max = 0;
            if (a > b && a > c)
                max = a;
            else if (b > c && b > a)
                max = b;
            else
                max = c;
            return max;
        }
        static bool isPrime(int number) //3.Kiểm tra số nguyên tố
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
        static void printPrimeNumberUnderN(int n) //4.1.In tất cả các số nguyên tố bé hơn N
        {
            for (int i = 2; i <= n; i++)
                if (isPrime(i))
                    Console.WriteLine(i);
        }
        static void printFirstNprime(int n) //4.2. In N số nguyên tố đầu tiên
        {
            int so = 2;
            int dem = 0;
            while (dem < n)
            {
                if (isPrime(so))
                {
                    Console.Write(so + ", ");
                    dem++;
                }
                so++;
            }
        }
        static long factorial(int n) //2.Tính giai thừa của một số nguyên không âm
        {
            if (n < 0)
            {
                throw new ArgumentException("VUI LONG NHAP SO NGUYEN KHONG AM!");
            }
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static bool isPerfect(int n) //5.1. Kiểm tra số hoàn hảo
        {
            int tonguocso = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tonguocso += i;
            }
            if (tonguocso == n) return true;
            return false;
        }
        //5.2. In các số hoàn hảo nhỏ hơn 1000
        static void Main(string[] args)
        {
            Console.Write("Cac so hoan hao nho hon 1000 la: ");
            for (int i = 1; i < 1000; i++)
            {
                if (isPerfect(i))
                    Console.Write(i + "   ");
            }
        }
        static bool KiemTraPangram(string chuoi)
        {
            chuoi = chuoi.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
            {
                // Nếu thiếu bất kỳ chữ cái nào trong chuỗi thì không phải là pangram
                if (!chuoi.Contains(c))
                    return false;
            }
            // Nếu không thiếu chữ cái nào, thì chuỗi là pangram
            return true;
        }
        static void Main(string[] args)
        {
            if (KiemTraPangram("The quick brown fox jumps over the lazy dog"))
                Console.WriteLine("Chuoi la pangram");
            else
                Console.WriteLine("Chuoi khong phai la pangram");
        }
    }
}