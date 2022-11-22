using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLicense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть код доступу:");
            var keylicesnse = Console.ReadLine();
            ApplicationLicense license = new ApplicationLicense(keylicesnse);
            License(license);
        }

        private static void License(ApplicationLicense license)
        {
            try
            {
                license.AllowPro();
                license.AllowTrial();
            }
            finally
            {
                license.AllowCommon();
            }
        }
    }
}