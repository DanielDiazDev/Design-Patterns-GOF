namespace Visitor
{
    abstract class Book
    {
        public string name;
        public string author;
        public string categoryName;

        public abstract void Accept(IBookExportVisitor visitor);
    }
}