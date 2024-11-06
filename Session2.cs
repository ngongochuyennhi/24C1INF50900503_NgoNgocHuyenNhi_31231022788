using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
    internal class Session02
    {
        //public static void Main()
        //{
        //    //Question_01();
        //    //Question_02();
        //    //Question_03();
        //    //Question_04();
        //    //Question_05();
        //    Question_06();
        //    Console.ReadKey();
        //}
        public static void Question_01()
        {
            Console.Write("Vui long nhap do C: ");
            int Cel = int.Parse(Console.ReadLine());
            int Fah = Cel * 18 / 10 + 32;
            int Kel = Cel + 273;
            Console.WriteLine($"{Cel} do C = {Fah} do F = {Kel} do K");
        }
        public static void Question_02()
        {
            Console.Write("Nhap ban kinh cua hinh cau: ");
            double r = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Dien tich cua hinh cau la: {surface}");
            Console.WriteLine($"The tich cua hinh cau la: {volume}");
        }
        public static void Question_03()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int phepcong = a + b;
            int pheptru = a - b;
            int phepnhan = a * b;
            int phepchia = a / b;
            float phanconlai = a % b;
            Console.WriteLine($"a + b = {phepcong} ");
            Console.WriteLine($"a - b = {pheptru}");
            Console.WriteLine($"a x b = {phepnhan}");
            Console.WriteLine($"a : b = {phepchia}, phan du = {phanconlai}");
        }
        public static void Question_04()
        {
            Console.Write("Nhap khoang cach (km): ");
            double distancekm = double.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian (gio): ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian (phut): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian (giay): ");
            int seconds = int.Parse(Console.ReadLine());
            double tongsogio = hours + (minutes / 60.0) + (seconds / 3600.0);
            double kmtrengio = distancekm / tongsogio;
            double distancem = distancekm * 0.621371;
            double mtrengio = distancem / tongsogio;
            Console.WriteLine($"Toc do km/h: {kmtrengio}");
            Console.WriteLine($"Toc do m/h: {mtrengio}");
        }
        public static void Question_05()
        {
            Console.Write("Nhap vao y: ");
            int y = int.Parse(Console.ReadLine());
            double x = Math.Pow(y, 2) + 2 * y + 1;
            Console.WriteLine($"Gia tri y = {y}, x = {x}");
        }
        public static void Question_06()
        {
            Console.Write("Nhap mot ky tu: ");
            char kytu = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ("AEIOUaeiou".IndexOf(kytu) >= 0)
            {
                Console.WriteLine($"{kytu} la mot nguyen am.");
            }
            else if (char.IsDigit(kytu))
            {
                Console.WriteLine($"{kytu} la mot chu so.");
            }
            else
            {
                Console.WriteLine($"{kytu} la mot ky hieu khac.");
            }
        }
    }
}
