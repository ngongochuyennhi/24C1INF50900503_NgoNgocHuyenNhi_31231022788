using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
    internal class Session03
    {
        //public static void Main()
        //{
        //    //vidugame();
        //    //Question_01();
        //    //Question_02();
        //    //Question_03();
        //    //Exercise_1();
        //    //Exercise_2();
        //    //Exercise_3();
        //    //Exercise_4_1();
        //    //Exercise_4_2();
        //    //Exercise_4_3();
        //    //Exercise_6();
        //    //Exercise_7();
        //    //Exercise_8();
        //    Console.ReadKey();
        //}
        public static void vidugame()
        {
            do
            {
                //1.Máy nghĩ ngẫu nhiên 1 số
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                //2. Yêu cầu người dùng đoán số
                // đoán đến khi nào đúng thì thôi
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.Write("Ban doan so may? <1...10> ");
                    int user_num = int.Parse(Console.ReadLine());
                    //3. Kiểm tra kết quả
                    if (user_num == comp_num)
                    {
                        Console.WriteLine($"Ban doan trung sau {count} lan ");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("So ban doan lon hon so may nghi");
                        else
                            Console.WriteLine("So ban doan nho hon so may nghi");
                    }
                } while (isContinue);
                Console.WriteLine("================================");
                Console.Write("Choi nua khong? <C/K> ");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("THANG MA KHONG CHO GO. LAN SAU KHONG CHOI NUA!");
                    return;
                }
            } while (true);
        }
        public static void Question_01() //1. Kiểm tra xem một số là số chẵn hay số lẻ
        {
            Console.Write("Hay nhap mot so: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} la mot so chan");
            }
            else
            {
                Console.WriteLine($"{num} la mot so le");
            }
        }
        public static void Question_02() //2. Tìm số lớn nhất trong 3 số nhập vào
        {
            Console.Write("Nhap so dau tien: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            double c = double.Parse(Console.ReadLine());
            double solonnhat;
            if (a > b && a > c)
            {
                solonnhat = a;
            }
            else if (b > a && b > c)
            {
                solonnhat = b;
            }
            else
            {
                solonnhat = c;
            }
            Console.WriteLine($"So lon nhat trong 3 so la {solonnhat}");
        }
        public static void Question_03() //3.Nhập một điểm trong hệ tọa độ XY và xác định góc phần tư
        {
            Console.Write("Nhap toa do x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y= ");
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) thuoc goc phan tu thu nhat");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) thuoc goc phan tu thu hai");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) thuoc goc phan tu thu ba");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam tren truc tung Y");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam tren truc hoanh X");
            }
            else
            {
                Console.WriteLine($"Toa do ({x},{y}) nam tai goc toa do (0,0)");
            }
        }
        public static void Exercise_1() //1. Kiểm tra tam giác đều, cân, hay không cân
        {
            Console.WriteLine("Hay nhap ba canh cua tam giac: ");
            Console.Write("Canh a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Canh b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Canh c = ");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c || a + c > b || b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Day la mot tam giac deu");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Day la mot tam giac can");
                }
                else
                {
                    Console.WriteLine("Day la mot tam giac khong can");
                }
            }
            else
            {
                Console.WriteLine("Ba canh khong tao thanh mot tam giac hop le");
            }
        }
        public static void Exercise_2() //2. Nhập 10 số, sau đó tính tổng và trung bình cộng
        {
            double tong = 0;
            double trungbinhcong = 0;
            int tongso = 10;
            Console.WriteLine("Nhap 10 so: ");
            for (int i = 1; i <= tongso; i++)
            {
                Console.Write($"So {i}: ");
                double number = double.Parse(Console.ReadLine());
                tong += number;
            }
            trungbinhcong = tong / tongso;
            Console.WriteLine($"Tong cua 10 so = {tong}");
            Console.WriteLine($"Trung bing cong cua 10 so la = {trungbinhcong}");
        }
        public static void Exercise_3() // 3. Hiển thị bảng cửu chương của một số nguyên
        {
            Console.Write("Hay nhap so: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong cua {number} la:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        public static void Exercise_4_1() //4.1. Hiển thị một tam giác (Pattern 1)
        {
            Console.Write("Nhap so ket thuc cua day: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) //Lặp lại theo chiều dọc
            {
                for (int j = 1; j <= i; j++) //Lặp lại theo chiều ngang
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Exercise_4_2() //4.2. Hiển thị một tam giác (Pattern 2)
        {
            Console.Write("Hay nhap so bat dau: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dong cua tam giac: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++) //Lặp lại số dòng theo chiều dọc
            {
                for (int j = 1; j <= i; j++) //Lặp theo chiều ngang
                {
                    Console.Write($"{n} ");
                    n++;
                }
                Console.WriteLine();
            }
        }
        public static void Exercise_4_3() //4.3. Hiển thị một tam giác (Pattern 3)
        {
            int n = 1;
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = 1; k <= rows - i; k++) //In khoảng trắng cho mỗi dòng, số khoảng trắng dòng thứ i giảm 1
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{n} ");
                    n++;
                }
                Console.WriteLine();
            }
        }
        public static void Exercise_6() //6.Nhập số n và trả về tổng của dãy vô hạn Harmonic 1 + 1/2 +...+ 1/n
        {
            Console.Write("Moi ban nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            Console.Write("Day vo han Harmonic: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($" 1/{i} ");
                if (i < n)
                    Console.Write("+");
                sum += 1.0 / i; //sum += có nghĩa là sum' = sum + 1/i
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua day vo han = {sum}");
        }
        public static void Exercise_7() //7. Kiểm tra số nhập vào có phải số hoàn hảo không
        {
            int number;
            do //Yêu cầu người dùng nhập số nguyên dương, yêu cầu nhập lại khi số nhỏ hơn hoặc bằng 0
               //Số hoàn hảo phải là một số dương
            {
                Console.Write("Nhap vao mot so nguyen duong: ");
                number = int.Parse(Console.ReadLine());
            }
            while (number <= 0);
            int sum = 0; //Tính tổng các ước số dương của số đã nhập
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0) // 
                {
                    sum += i;
                }
            }
            //So sánh tổng với số ban đầu
            if (sum == number)
            {
                Console.WriteLine($"{number} la mot so hoan hao");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la mot so hoan hao");
            }
        }
        public static void Exercise_8()
        {
            int num;
            do //Yêu cầu người dùng nhập số nguyên dương, yêu cầu nhập lại khi số nhỏ hơn hoặc bằng 0
            {
                Console.Write("Nhap vao mot so nguyen: ");
                num = int.Parse(Console.ReadLine());
            }
            while (num <= 0);
            //Kiểm tra đó có phải số nguyên tố không
            if (num <= 1)
            {
                Console.WriteLine($"{num} khong phai la so nguyen to");
            }
            else
            {
                for (int i = 2; i <= (int)Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} khong phai la so nguyen to");
                        return;
                    }
                }
                Console.WriteLine($"{num} la so nguyen to");
            }
        }
    }
}