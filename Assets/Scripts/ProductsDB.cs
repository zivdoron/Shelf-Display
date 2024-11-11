using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProductsDB
{
    static List<Product> products = new List<Product>();
    public static List<Product> Products { get => products; set { products = value;} }
}
