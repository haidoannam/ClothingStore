using ClothingStoreImprove.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStoreImprove.Factory
{
    abstract class ClothingFactory
    {
        public abstract Clothing GetClothing();
    }
}
