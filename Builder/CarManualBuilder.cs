using System;

namespace Builder
{
    public class CarManualBuilder: IBuilder
    {
        private Manual manual;

        public CarManualBuilder()
        {
            this.manual = new Manual();
        }

        public void Reset()
        {
            this.manual = new Manual();
        }

        public void SetSeats(int number)
        {
            
        }

        public void SetEngine()
        {
            
        }

        public void SetTripComputer(bool isON)
        {
            if (isON)
            {
                
            }
            else
            {
                
            }
        }

        public void SetGPS(bool isON)
        {
            if (isON)
            {
                
            }
            else
            {
                
            }
        }

        public Manual getProduct()
        {
            Manual product = this.manual;
            this.Reset();
            return product;
        }
    }
}