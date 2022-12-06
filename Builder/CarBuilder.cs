using System;

namespace Builder
{
    public class CarBuilder: IBuilder
    {
        private Car car;

        public CarBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.car = new Car();
        }

        public void SetSeats(int number)
        {
    
        }

        public void SetEngine()
        {
            
        }

        public void SetTripComputer(bool isON)
        {
            
        }

        public void SetGPS(bool isON)
        {
            
        }

        public Car getProduct()
        {
            Car product = this.car;
            this.Reset();
            return product;
        }
    }
}