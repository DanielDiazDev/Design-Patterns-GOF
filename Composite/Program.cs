namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            ImageEditor image = new ImageEditor();
            image.Load();

            image.GroupSelected(image.compoundGraphic.childrens);
        }
    }
}