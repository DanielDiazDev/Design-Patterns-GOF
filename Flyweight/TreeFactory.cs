using System.Collections.Generic;

namespace Flyweight
{
    public static class TreeFactory
    {
        private static readonly List<TreeType> TreeTypes = new List<TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var type = TreeTypes.Find(x => x.Name == name && x.Color == color && x.Texture == texture);
            if (type == null)
            {
                type = new TreeType(name, color, texture);
                TreeTypes.Add(type);
            }

            return type;
        }
    }
}