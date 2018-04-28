using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = AppDomain.CurrentDomain.BaseDirectory + "\\OrleansHost";
            AppDomain hsotappDomain = AppDomain.CreateDomain("Host", null, new AppDomainSetup()
            {

                AppDomainInitializer = StartUp,
                AppDomainInitializerArguments = args
            });
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Orleans Silo is running.\nPress Enter to terminate...");
            Console.ReadLine();
            hsotappDomain.DoCallBack(ShutdownSilo);
        }

        static void StartUp(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);
            if (!hostWrapper.Run)
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }

        }

        static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        private static OrleansHostWrapper hostWrapper;

    }
}
