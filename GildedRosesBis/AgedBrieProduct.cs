﻿using Kata.GildedRose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRosesBis
{
    public class AgedBrieProduct : IProduct
    {
        Item _item;
        public AgedBrieProduct(Item item)
        {
            _item = item;
        }
        public void UpdateQuality()
        {
            throw new NotImplementedException();
        }
    }
}
