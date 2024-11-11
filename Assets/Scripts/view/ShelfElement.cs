using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfElement : MonoBehaviour
{

    [SerializeField] ProductDisplayElement productPF;
    [SerializeField] List<Placement> placements;
    public int PlacementsCount {  get { return placements.Count; } }
    List<ProductDisplayElement> productElements = new List<ProductDisplayElement>();

    private void Start()
    {
        ShelvesManager.elements.Add(this);
        gameObject.SetActive(false);
    }

    public bool Init(List<Product> products)
    {
        DestroyElements();
        for (int i = 0; i < products.Count && i < placements.Count; i++)
        {
            ProductDisplayElement pde = Instantiate(productPF);
            pde.Init(products[i]);
            placements[i].Place(pde.gameObject);
            productElements.Add(pde);
        }
        return true;
    }
    public void DestroyElements()
    {
        productElements.ForEach(p => Destroy(p.gameObject));
        productElements.Clear();

    }
    public void UpdateProductsVisuals()
    {
        productElements.ForEach(p => p.UpdateVisuals());
    }
}
