using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProductsDBProxy
{
    static List<Product> products;
    public static List<Product> Products { get { return products; } }
    public static void Init()
    {
        LoadFromDB();
    }
    public static void SaveToDB()
    {
        ProductsDB.Products = products;
        LoadFromDB();
    }
    public static void LoadFromDB()
    {
        products = new List<Product>(ProductsDB.Products);
        ProductsDB.Products.ForEach(p => products.Add(new Product(p)));
        Debug.Log(products.Count);
    }
}
