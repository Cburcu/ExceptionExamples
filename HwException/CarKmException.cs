using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwException
{
    class CarKmException : Exception
    {
        public override string Message => "Car's Kilometers are over 45!";
    }
}
