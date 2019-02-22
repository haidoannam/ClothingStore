using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStoreImprove.Model
{
    // I apply factory pattern to support new kind of clothing
    abstract class Clothing
    {
        public abstract IList<string> Colors { get; set; }

        public abstract IList<string> Sizes { get; set; }

        public abstract double Price { get; set; }

        public abstract string Name { get; }
    }
}
