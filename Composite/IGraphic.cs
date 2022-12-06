namespace Composite
{
    interface IGraphic
    {
        IGraphic Move(int x, int y);
        IGraphic Draw();
    }
}