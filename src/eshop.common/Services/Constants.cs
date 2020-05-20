using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.common
{
    public class Constants
    {
        public class Services
        {
            //public static readonly string Catalog = "catalog";
            public static readonly string Payment = "payment";
            public static readonly string Basket = "basket";
            public static readonly string Order = "order";

            public class Catalog
            {
                public static readonly string Name = "catalog";
                public class Actions
                {
                    public static readonly string List = "list";
                }

            }
        }
    }
}
