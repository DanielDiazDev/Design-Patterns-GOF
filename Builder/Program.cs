namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            Director director = new Director();

            CarBuilder builder = new CarBuilder();
            director.ConstructSportsCar(builder);
            Car car = builder.getProduct();

            CarManualBuilder builder2 = new CarManualBuilder();
            director.ConstructSportsCar(builder2);

            Manual manual = builder2.getProduct();
        }
    }
}