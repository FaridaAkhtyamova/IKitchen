using IKitchen.DAL;
using System.Collections;
using System;

namespace IKitchen.BLL
{
    public class Fridge : IEnumerable
    {
        //public bool ContainsProduct(this Fridge fridge, string productType)
        //{
        //    foreach (var products in fridge)
        //    {
        //        if (products.ProductType == productType)
        //            return true;
        //        break;
        //    }
        //    return false;
        //}

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}