using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductsDBInitializer : MonoInitializer
{
    public override void Init()
    {
        ProductsDB.Products = ProductServer.GetProducts().products;
    }
}
