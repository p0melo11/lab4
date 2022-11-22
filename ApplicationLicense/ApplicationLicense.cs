using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLicense
{
    public class ApplicationLicense
    {
        private readonly string ProKey = "pro";
        private readonly string TrialKey = "trial";
        private readonly string Key;

        public ApplicationLicense(string key)
        {
            this.Key = key;
        }

        public void AllowTrial()
        {
            if (Key == TrialKey)
                Console.WriteLine("Trial версiя");
        }
        public void AllowPro()
        {
            if (Key == ProKey)
                Console.WriteLine("Pro версiя");
        }
        public void AllowCommon()
        {
            if (Key != TrialKey && Key != ProKey)
                Console.WriteLine("Безкоштовна версія");
        }

    }
}
