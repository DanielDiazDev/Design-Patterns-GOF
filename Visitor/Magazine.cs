namespace Visitor
{
    class Magazine : Book
    {
        public override void Accept(IBookExportVisitor visitor)
        {
            visitor.ExportVisit(this);
        }
    }
}