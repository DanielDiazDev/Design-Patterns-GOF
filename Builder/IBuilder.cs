namespace Builder
{
    
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int number);
        void SetEngine();
        void SetTripComputer(bool isON);
        void SetGPS(bool isON);
    }
}