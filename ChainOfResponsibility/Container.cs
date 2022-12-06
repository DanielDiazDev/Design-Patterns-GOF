using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public abstract class Container : UIComponent
    {
        private List<UIComponent> children;

        public void Add(UIComponent child)
        {
            children.Add(child);
            child.container = this;
        }
    }
}