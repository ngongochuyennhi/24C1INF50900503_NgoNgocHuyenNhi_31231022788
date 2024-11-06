using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
    internal class Session01
    {
        //public static void Main()
        //{
        //    //Question_01();
        //    //Question_02();
        //    //Question_03();
        //    //Question_04();
        //    //Question_05();
        //    //Question_06();
        //    //Question_07();
        //    //Question_08();
        //    //Question_09();
        //    //Question_10();
        //    Console.ReadKey();
        //}
        public static void Question_01()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

        }
        public static void Question_02()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int hoanvi = a;
            a = b;
            b = hoanvi;
            Console.WriteLine($"Sau khi hoan doi: gia tri cua a = {a} , gia tri cua b = {b}");
        }
        public static void Question_03()
        {
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"Ket qua: {a} x {b} = {c}");
        }
        public static void Question_04()
        {
            Console.Write("Nhap gia tri feet: ");
            float feet = float.Parse(Console.ReadLine());
            double Ketqua = feet * 0.3048;
            Console.WriteLine($"Gia tri meter la {Ketqua}m");
        }
        public static void Question_05()
        {
            Console.Write("Nhap gia tri do C: ");
            float a = float.Parse(Console.ReadLine());
            float giatri = a * 9 / 5 + 32;
            Console.WriteLine($"{a} do C tuong duong {giatri} do F");
            Console.Write("Nhap gia tri do F: ");
            float b = float.Parse(Console.ReadLine());
            float phepdoi = (b - 32) * 5 / 9;
            Console.WriteLine($"{b} do F tuong duong {phepdoi} do C");
        }
        public static void Question_06()
        {
            Console.WriteLine("Kich thuoc cua int: " + sizeof(int) + "bytes");
            Console.WriteLine("Kich thuoc cua float: " + sizeof(float) + "bytes");
            Console.WriteLine("Kich thuoc cua double: " + sizeof(double) + "bytes");
            Console.WriteLine("Kich thuoc cua char: " + sizeof(char) + "bytes");
            Console.WriteLine("Kich thuoc cua long: " + sizeof(long) + "bytes");
            Console.WriteLine("Kich thuoc cua bool: " + sizeof(bool) + "bytes");
            Console.WriteLine("Kich thuoc cua short: " + sizeof(short) + "bytes");
            Console.WriteLine("Kich thuoc cua byte: " + sizeof(byte) + "bytes");
        }
        public static void Question_07()
        {
            Console.Write("Hay nhap mot ky tu: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int asciiValue = (int)input;
            Console.WriteLine($"Gia tri ASCII cua {input} la: {asciiValue}");
        }
        public static void Question_08()
        {
            Console.Write("Nhap ban kinh hinh tron: ");
            float r = float.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Dien tich hinh tron la: {area}");
        }
        public static void Question_09()
        {
            Console.Write("Nhap do dai canh cua hinh vuong: ");
            float a = float.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine($"Dien tich hinh vuong la: {area}");
        }
        public static void Question_10()
        {
            Console.Write("Nhap so ngay: ");
            int days = int.Parse(Console.ReadLine());
            int year = days / 365;
            int week = (days - year * 365) / 7;
            int day = (days - year * 365) % 7;
            Console.WriteLine($"{days} days = {year} years, {week} weeks, {day} days");
        }
    }
}
