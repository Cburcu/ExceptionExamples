using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwException
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected int _model;
        public int Model
        {
            get { return _model; }
            set
            {
                if (value < 2010)
                {
                    CarException ex = new CarException();
                    ex.CarModel = value;
                    throw ex;
                }

                else
                    _model = value;
            }
        }
    }
}
