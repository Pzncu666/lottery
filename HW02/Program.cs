using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 更變顏色
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            // 產生新變數
            Random rand = new Random();
            
            // 輸出變數
            int i = 0;
            while (i < 10)
            {
                int r1 = rand.Next(0, 43);
                int r2 = rand.Next(0, 43);
                int r3 = rand.Next(0, 43);
                int r4 = rand.Next(0, 43);
                int r5 = rand.Next(0, 43);
                int r6 = rand.Next(0, 43);
                Console.Write("\n號碼{0:00},{1:00},{2:00},{3:00},{4:00},{5:00}", r1, r2, r3, r4, r5, r6);
                i += 1;
            }
            
            // 停住畫面
            Console.ReadLine();

        }
    }
}
