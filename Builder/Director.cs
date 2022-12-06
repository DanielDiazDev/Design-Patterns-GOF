namespace Builder
{
    public class Director
    {
        private IBuilder builder;
        
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine();
            builder.SetTripComputer(false);
            builder.SetGPS(true);
        }
    }
}