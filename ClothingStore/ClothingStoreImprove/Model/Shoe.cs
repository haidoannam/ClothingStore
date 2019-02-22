using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStoreImprove.Model
{
    class Shoe : Clothing
    {
        private readonly string _name;
        private IList<string> _colors;
        private IList<string> _sizes;
        private double _price;
        public Shoe(IList<string> colors, IList<string> sizes, double price)
        {
            _colors = colors;
            _sizes = sizes;
            _price = price;
            _name = "Shoe";
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
