namespace Mediator
{
    public class Checkbox : Component
    {
        public bool Checked { get; set; } = false;
        
        public void Check()
        {
            if (Checked)
            {
                Checked = false;
            }
            else
            {
                Checked = true;
            }
            
            dialog.Notify(this, "check");
        }
    }
}