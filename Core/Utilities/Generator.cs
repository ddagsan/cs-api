using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Generator
    {
        private Dictionary<Type, int> mappings;
        public Generator()
        {
            mappings = new Dictionary<Type, int>();
        }

        public int GetId<TType>()
        {
            var type = typeof(TType);
            if (mappings.ContainsKey(type)) ++mappings[type];
            else mappings.Add(type, 1);
            return mappings[type];
        }
    }
}
