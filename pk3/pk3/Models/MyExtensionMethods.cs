using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pk3.Models
{
    public static class MyExtensionMethods
    {
        public static float TotalPrices(this ShopingCart cartParam)//cartParam el objeto de ShopingCart podra usar el metodo TotalPrices
        {
            float total = 0;
            foreach (Product prod in cartParam.Products)//para limpiar una lista
            {
                total += prod.Price;
            }

            return total;
        }
    }
}