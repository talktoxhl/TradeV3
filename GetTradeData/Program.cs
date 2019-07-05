using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTradeDataConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = string.Empty;

            while (true)
            {
                inputStr = Console.ReadLine();
                if (inputStr == "esc")
                    break;
                if (inputStr == "startTrade")
                {
                    GetTradeData();
                }
            }

            
            
        }



        public static  void GetTradeData()
        {
            Console.WriteLine("11111");
        }

    }
}
