using ClothingStoreImprove.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStoreImprove.Factory
{
    class ShoeFactory : ClothingFactory
    {
        private IList<string> _colors;
        private IList<string> _sizes;
        private double _price;

        public ShoeFactory(IList<string> colors, IList<string> sizes, double price)
        {
            _colors = colors;
            _sizes = sizes;
            _price = price;
        }

        public override Clothing GetClothing()
        {
            return new Shoe(_colors, _sizes, _price);
        }
    }
}
