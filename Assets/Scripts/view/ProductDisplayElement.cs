using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProductDisplayElement : MonoBehaviour
{
    Product product;
    [SerializeField] TextMeshProUGUI displayName;
    [SerializeField] TextMeshProUGUI displayDescription;
    [SerializeField] TextMeshProUGUI displayPrice;

    public void Init(Product p)
    {
        product = p;
        UpdateVisuals();
    }
    public void EditElement()
    {
        ProductEditingPanel.Instance.Open(product);
    }

    public void UpdateVisuals()
    {
        if (product != null)
        {
            displayName.text = product.Name;
            displayDescription.text = product.Description;
            displayPrice.text = product.Price.ToString();
        }
    }
}
