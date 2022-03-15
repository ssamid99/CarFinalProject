using ConsoleApp.CarsFinalProject.Infracture;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CarsFinalProject
{
    internal class ScanerManager
    {
        public static int ReadInteger(string caption)
        {
            l1:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(caption);
            if(!int.TryParse(Console.ReadLine(), out int value))
            {
                PrintError("Düzgün Məlumat Deyil,Yenidən Cəhd Edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static double ReadDouble(string caption)
        {
            l2:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(caption);
            if(!double.TryParse(Console.ReadLine(), out double value))
            {
                PrintError("Düzgün Məlumat Deyil,Yenidən Cəhd Edin");
                goto l2;
            }
            Console.ResetColor();
            return value;
        }
        public static string ReadString(string caption)
        {
            l3:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string value = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(value))
            {
                PrintError("Düzgün Məlumat Deyil,Yenidən Cəhd Edin");
                    goto l3;
            }
            Console.ResetColor();
            return value;
        }
        public static DateTime ReadDate(string caption)

        {
        l1:
            Console.ForegroundColor = ConsoleColor.DarkGreen;            
            Console.Write($"{caption} [yyyy]");
            if (!DateTime.TryParseExact(Console.ReadLine(), "yyyy", null, DateTimeStyles.None, out DateTime value))
            {
                PrintError("Düzgün Məlumat Deyil,Yenidən Cəhd Edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static Menu ReadMenu(string caption)
        {
        l1:
            Console.Write(caption);

            if (!Enum.TryParse(Console.ReadLine(), out Menu m))
            {
                PrintError("Menudan Secin");
                goto l1;
            }
            Console.ResetColor();
            return m;
        }
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
