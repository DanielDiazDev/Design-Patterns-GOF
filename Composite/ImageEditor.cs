using System.Collections.Generic;

namespace Composite
{
    class ImageEditor
    {
        public CompoundGraphic compoundGraphic { get; set; }

        public void Load()
        {
            compoundGraphic = new CompoundGraphic();
            compoundGraphic.Add(new Circle(10,9,14));
            compoundGraphic.Add(new Dot(1, 2));
        }


        public void GroupSelected(List<IGraphic> graphics)
        {
            var group = new CompoundGraphic();
            for (int i = 0; i < graphics.Count; i++)
            {
                group.Add(graphics[i]);
                compoundGraphic.Remove(graphics[i]);
            }
            compoundGraphic.Add(group);
            compoundGraphic.Draw();
        }

    }
}