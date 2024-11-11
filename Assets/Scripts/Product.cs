using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class Product
{
    [JsonProperty("name")]
    public string Name {  get; set; }
    [JsonProperty("description")]
    public string Description { get; set; }
    [JsonProperty("price")]
    public float Price {  get; set; }

    public Product()
    {

    }
    public Product(Product p)
    {
        Name = p.Name;
        Description = p.Description;
        Price = p.Price;
    }

    internal void Update(string name, string description, float price)
    {
        Name = name;
        Description = description;
        Price = price; //todo: make sure the input field is always with numbers only
    }
}
public class ProductsList
{
    public List<Product> products { get; set; }
}
