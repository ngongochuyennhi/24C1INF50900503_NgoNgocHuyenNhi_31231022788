using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
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
        internal class Vidu_TimKiemPhanTu //TÌM KIẾM PHẦN TỬ TRONG MẢNG BẤT KỲ
        {
            private static void Main(string[] args)
            {
                Console.Write("Nhap so phan tu: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                //Nhập a
                generateRandomArray(a);
                InMang(a);
                Console.WriteLine();
                Console.Write("Nhap so can tim kiem: ");
                int soCanTim = int.Parse(Console.ReadLine());
                int pos = Timkiem_Linear(a, soCanTim);
                if (pos == -1)
                    Console.WriteLine($"SO {soCanTim} KHONG TON TAI TRONG MANG");
                else
                    Console.WriteLine($"SO {soCanTim} XUAT HIEN TAI VI TRI THU {pos + 1} TRONG MANG");
            }
            //Nhập số phần tử của mảng
            static void Nhap(int[] a, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap phan tu thu {i}");
                    int v = int.Parse(Console.ReadLine());
                    a[i] = v;
                }
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
            //Tìm số có trong mảng hay không
            //a là mảng số nguyên, soCanTim là số cần tìm
            //trả về -1 nếu không tìm thấy, vị trí xuất hiện nếu tìm thấy
            static int Timkiem_Linear(int[] a, int soCanTim)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == soCanTim)
                        return i;
                }
                return -1;
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
    