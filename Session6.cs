using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
    //MẢNG MỘT CHIỀU
    internal class Session6
    {
        static void Main()
        {
            //1.Khai báo mảng gồm N phần tử
            Console.Write("Nhap so phan tu cua mang: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            //1.1.Nhập giá trị cho từng phần tử của mảng
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            //1.2. In các phần tử ra màn hình
            Console.Write("Cac phan tu trong mang:  ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{array[i]}   ");
            }
            //1.3. Tăng các phần tử trong mảng lên 2
            Console.WriteLine();
            TangPhanTuTrongMang(array);
            Console.Write("Cac phan tu trong mang sau khi tang len 2:  ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }
        //Hàm tăng các phần tử lên 2
        static void TangPhanTuTrongMang(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 2;
            }
        }
    }
    internal class BaiTapSlide18
    {
        private static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            generateRandomArray(a);
            InMang(a);
            Console.WriteLine();
            double trungbinhcong = CalculateAverage(a);
            Console.WriteLine($"Gia tri trung binh cua mang la: {trungbinhcong}");
            Console.Write("Nhap so can kiem tra: "); int sokiemtra = int.Parse(Console.ReadLine());
            bool check = KiemTraPhanTu(a, sokiemtra);
            if (check == false)
                Console.WriteLine($"KHONG CO {sokiemtra} TRONG MANG");
            else Console.WriteLine($"CO {sokiemtra} TRONG MANG");
            Console.Write("Nhap so can tim kiem: ");
            int socantim = int.Parse(Console.ReadLine());
            int pos = Timkiem(a, socantim);
            if (pos == -1)
                Console.WriteLine($"SO {socantim} KHONG TON TAI TRONG MANG");
            else
                Console.WriteLine($"SO {socantim} XUAT HIEN TAI VI TRI THU {pos + 1} TRONG MANG");
            Console.Write("Nhap phan tu can xoa: "); int socanxoa = int.Parse(Console.ReadLine());
            a = XoaPhanTu(a, socanxoa);
            Console.Write("Mang sau khi xoa: "); InMang(a);
            Console.WriteLine();
            int max = FindMaxInArray(a);
            Console.WriteLine($"Gia tri lon nhat trong mang la: {max}");
            int min = FindMinInArray(a);
            Console.WriteLine($"Gia tri nho nhat trong mang la: {min}");
            Console.Write("Mang sau khi dao nguoc: "); DaoNguocMang(a); InMang(a);
        }
        //Tạo mảng bất kỳ gồm n phần tử
        static void generateRandomArray(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);
            }
        }
        //In mảng ra màn hình
        static void InMang(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write($"{i}, ");
            }
        }
        //1.Tính giá trị trung bình của các phần tử mảng
        static double CalculateAverage(int[] a)
        {
            if (a.Length == 0)
                return 0;
            int sum = 0;
            foreach (int number in a)
            {
                sum += number; //Tính tổng các phần tử
            }
            return sum / a.Length;
        }
        //2.kiểm tra xem mảng có chứa một giá trị cụ thể hay không.
        static bool KiemTraPhanTu(int[] a, int sokiemtra)
        {
            foreach (int number in a)
            {
                if (number == sokiemtra)
                    return true;
            }
            return false;
        }
        //3.để tìm chỉ mục của một phần tử mảng.
        static int Timkiem(int[] a, int socantim)
        {
            for (int i = 0; i < a.Length; i++) //duyệt qua từng phần tử 
            {
                if (a[i] == socantim)
                    return i; //trả về vị trí xuất hiện nếu tìm thấy
            }
            return -1; //trả về -1 nếu không tìm thấy
        }
        //4.để xóa một phần tử cụ thể khỏi mảng.
        static int[] XoaPhanTu(int[] a, int socanxoa)
        {
            //đếm số phần tử khác với số cần xóa
            int count = 0;
            foreach (int number in a)
            {
                if (number != socanxoa) count++;
            }
            //Tạo một mảng mới để lưu kết quả
            int[] result = new int[count];
            int index = 0;
            //Sao chép các phần tử khác với giá trị cần xóa vào mảng mới
            foreach (int item in a)
            {
                if (item != socanxoa)
                {
                    result[index++] = item;
                }
            }
            return result;
        }
        //5.để tìm giá trị lớn nhất và nhỏ nhất của mảng.
        static int FindMaxInArray(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
        static int FindMinInArray(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }
        //6.đảo ngược một mảng các giá trị số nguyên.
        static void DaoNguocMang(int[] a)
        {
            int start = 0;
            int end = a.Length - 1;
            //Dùng vòng lặp để hoán đổi các phần tử từ đầu và cuối mảng
            while (start < end)
            {
                //Hoán đổi phần tử ở vị trí start và end
                int temp = a[start];
                a[start] = a[end];
                a[end] = temp;
                //Di chuyển chỉ số start lên và end xuống
                start++;
                end--;
            }
        }
    }
    internal class TimKiem_NhiPhan
    {
        static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2; //mid là phần tử được kiểm tra trong mỗi vòng lặp
                if (key == inputArray[mid])
                    return ++mid;  //Nếu key bằng với giá trị tại inputArray[mid], hàm sẽ trả về ++mid
                else if (key < inputArray[mid])
                {
                    max = mid - 1; //Nếu key nhỏ hơn giá trị tại inputArray[mid]
                                   //nghĩa là key nằm ở nửa đầu của mảng nên max được cập nhật thành mid - 1.
                }
                else
                {
                    min = mid + 1; //Nếu key lớn hơn giá trị tại inputArray[mid]
                                   //nghĩa là key nằm ở nửa sau, nên min được cập nhật thành mid + 1.
                }
            }
            return -1; //Nếu vòng lặp while kết thúc mà không tìm thấy key
                       //hàm trả về -1, biểu thị rằng key không tồn tại trong inputArray.
        }
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int key = 7;
            int result = BinarySearchIterative(inputArray, key);
            if (result != -1)
            {
                Console.WriteLine($"Phan tu tim thay tai vi tri: {result}");
            }
            else
            {
                Console.WriteLine("Phan tu khong ton tai trong mang.");
            }
        }
    }
}
