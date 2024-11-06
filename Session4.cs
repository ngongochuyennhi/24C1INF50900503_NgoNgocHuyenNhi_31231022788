using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_NgoNgocHuyenNhi_31231022788
{
    //internal class Session04
    //{
    //    public static void swap(ref int a, ref int b)
    //    {
    //        int temp = a;
    //        a = b;
    //        b = temp;
    //    }
    //    public static void Main(string[] args)
    //    {
    //        int a = 6, b = 7;
    //        Console.WriteLine($"Before call a = {a}, b = {b}");
    //        swap(ref a, ref b);
    //        Console.WriteLine($"After call a = {a}, b = {b}");
    //        Console.ReadKey();
    //    }
    //}
    //class Game_Taixiu
    //{
    //    static int rollDice()
    //    {
    //        Random rnd = new Random();
    //        int die_1 = rnd.Next(6) + 1;
    //        int die_2 = rnd.Next(6) + 1;
    //        int die_3 = rnd.Next(6) + 1;
    //        int sum_of_dice = die_1 + die_2 + die_3;
    //        return sum_of_dice;
    //    }
    //    static void playOneRound()
    //    {
    //        int com_dice = rollDice();
    //        Console.Write("Ban doan Tai hay Xiu <T/X>: ");
    //        string user_guessing = Console.ReadLine();
    //        if (user_guessing.ToUpper().Equals("T"))
    //        {
    //            if (com_dice >= 10) //Tài
    //                Console.WriteLine("Ban thang");
    //            else
    //                Console.WriteLine("Ban thua");
    //        }
    //        else if (user_guessing.ToUpper().Equals("X"))
    //        {
    //            if (com_dice < 10) //Xỉu
    //                Console.WriteLine("Ban thang");
    //            else
    //                Console.WriteLine("Ban thua");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Vui long chon cho dung");
    //        }
    //    }
    //    static void game_engine()
    //    {
    //        do
    //        {
    //            playOneRound();
    //            Console.Write("Ban choi nua khong? <C/K>: ");
    //            string choice = Console.ReadLine();
    //            if (choice.ToUpper().Equals("K"))
    //                break;
    //        } while (true);
    //        Console.WriteLine("Mai choi nua nhe!");
    //    }
    //    static void Main()
    //    {
    //        game_engine();
    //    }
    //}
    class TaiXiu_Morong
    {
        static int rollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }
        static void playgames()
        {
            int com_dice = rollDice();
            decimal balance = 1000;
            int totalgames = 0;
            int wins = 0;
            int losses = 0;
            Console.WriteLine($"WELCOME!");
            Console.Write($"Vui long nhap so lan choi: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nLAN CHOI THU {i} ");
                Console.WriteLine($"SO TIEN HIEN CO LA {balance}");
                Console.Write($"BAN MUON CUOC BAO NHIEU: ");
                decimal bet = decimal.Parse(Console.ReadLine());
                if (bet > balance)
                {
                    Console.WriteLine("KHONG DU TIEN CUOC!");
                    break;
                }
                Console.Write("Ban doan Tai hay Xiu <T/X>: ");
                string user_guessing = Console.ReadLine();
                if (user_guessing.ToUpper().Equals("T"))
                {
                    if (com_dice >= 10) //Tài
                    {
                        Console.WriteLine("Ban thang");
                        wins++;
                        balance += bet;
                    }
                    else
                    {
                        Console.WriteLine("Ban thua");
                        losses++;
                        balance -= bet;
                    }
                    totalgames++;
                }
                else if (user_guessing.ToUpper().Equals("X"))
                {
                    if (com_dice < 10) //Xỉu
                    {
                        Console.WriteLine("Ban thang");
                        wins++;
                        balance += bet;
                    }
                    else
                    {
                        Console.WriteLine("Ban thua");
                        losses++;
                        balance -= bet;
                    }
                    totalgames++;
                }
                else
                {
                    Console.WriteLine("Vui long chon cho dung");
                }
                //THỐNG KÊ SAU MỖI LẦN CHƠI
                Console.WriteLine("----- KET QUA -----");
                Console.WriteLine($"So lan choi: {totalgames}");
                Console.WriteLine($"So lan thang: {wins}");
                Console.WriteLine($"So lan thua: {losses}");
                Console.WriteLine($"So tien con lai: {balance}");
                Console.WriteLine("Ti le thang: " + (wins * 100.0 / totalgames).ToString("0.00") + "%");
                if (balance <= 0) Console.WriteLine("BAN DA HET TIEN ROI!");
            }
        }
        public static void Main()
        {
            playgames();
        }
    }
}