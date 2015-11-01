using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoggerEvsSpace;
namespace LoggerEv
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerEvs.messageCame += testToConsole;
            
            for (int i = 0; i < 10; i++ )
                LoggerEvs.writeLog("Test note №" + i.ToString());
            
            Console.ReadKey();
        }

        public static void testToConsole(String message)
        {
            Console.Write(message);
        }
    }
}
