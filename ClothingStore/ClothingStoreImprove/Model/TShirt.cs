using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStoreImprove.Model
{
    class TShirt : Clothing
    {

        private readonly string _name;
        private IList<string> _colors;
        private IList<string> _sizes;
        private double _price;
        public TShirt(IList<string> colors, IList<string> sizes, double price)
        {
            _colors = colors;
            _sizes = sizes;
            _price = price;
            _name = "TShirt";
        }

        public override IList<string> Colors
        {
            get { return _colors; }
            set { _colors = value; }
        }

        public override IList<string> Sizes
        {
            get { return _sizes; }
            set { _sizes = value; }
        }

        public override double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public override string Name
        {
            get { return _name; }
        }
    }
}
