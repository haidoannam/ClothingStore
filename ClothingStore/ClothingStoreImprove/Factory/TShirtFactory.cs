using ClothingStoreImprove.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStoreImprove.Factory
{
    class TShirtFactory : ClothingFactory
    {
        private readonly IList<string> _colors;
        private readonly IList<string> _sizes;
        private readonly double _price;

        public TShirtFactory(IList<string> colors, IList<string> sizes, double price)
        {
            _colors = colors;
            _sizes = sizes;
            _price = price;
        }

        public override Clothing GetClothing()
        {
            return new TShirt(_colors, _sizes, _price);
        }
    }
}
