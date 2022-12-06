namespace Factory
{
    public class Program
    {
        public static void Main()
        {
            Dialog dialog = new WindowsDialog();
            dialog.render();

            dialog = new WebDialog();
            dialog.render();
        }
    }
}