using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelvesManager : MonoBehaviour
{

    public static List<ShelfElement> elements = new List<ShelfElement>();
    public static void OrderAll()
    {
        int productsBeingDisplayed = 0;
        for (int i = 0; i < elements.Count; i++)
        {
            int quantityToDisplay = 0;
            if (productsBeingDisplayed + elements[i].PlacementsCount > ProductsDBProxy.Products.Count)
                quantityToDisplay = elements[i].PlacementsCount - ((productsBeingDisplayed + elements[i].PlacementsCount) % ProductsDBProxy.Products.Count);
            else
                quantityToDisplay = elements[i].PlacementsCount;

            elements[i].Init(ProductsDBProxy.Products.GetRange(productsBeingDisplayed, quantityToDisplay));
            productsBeingDisplayed += elements[i].PlacementsCount;
            
            if(productsBeingDisplayed > ProductsDBProxy.Products.Count)
                break;
        }

    }
    public static void UpdateAll()
    {
        elements.ForEach(e => {e.UpdateProductsVisuals();});
    }
}
