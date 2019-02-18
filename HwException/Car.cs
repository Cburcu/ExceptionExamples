using NLog;

namespace HwException
{
    public delegate void KmControl(object source);
    public class Car
    {
        public event KmControl KmControlEvent;

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
                    CarModelException ex = new CarModelException();
                    ex.CarModel = value;
                    throw ex;
                }

                else
                    _model = value;
            }
        }

        private int _kilometers;
        public int Kilometers
        {
            get { return _kilometers; }

            set
            {
                _kilometers = value;
                if (value >= 45)
                {
                    KmControlEvent(this);
                }
            }
        }
    }
}
