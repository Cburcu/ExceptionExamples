using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwException
{
    public class CarModelException
        : Exception
    {
        public override string Message => "Araba ile ilgili bir sorun var";
        public int CarModel { get; set; }
    }
}
