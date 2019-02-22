using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore.Models
{
    public  class ShirtModel
    {
        public double Price { get; set; }

        public IList<string> Colors { get; set; }

        public IList<string> Sizes { get; set; }

        public string Name { get; set; }
    }
}
