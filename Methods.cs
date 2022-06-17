using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_CLI
{
    class Methods
    {
        public bool TcControl(string tc)
        {
            if (tc.Length != 5)
            {
                Console.WriteLine("Tc must be 5 characters");
                return false;
            }
            return true;
        }
    }
}
