﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price) 
            :base(title, author, price)
        {

        }

        public override decimal Price
        {
            get { return (base.Price * (decimal)0.3) + base.Price; }
        }

    }
}
