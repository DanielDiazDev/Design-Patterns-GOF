namespace Visitor
{
    interface IBookExportVisitor
    {
        void ExportVisit(Magazine magazine);
        void ExportVisit(Encyclopedia encyclopedia);
    }
}