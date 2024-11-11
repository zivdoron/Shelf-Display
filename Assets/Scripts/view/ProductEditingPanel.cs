using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProductEditingPanel : MonoBehaviour
{
    public static ProductEditingPanel Instance;
    Product product;

    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_InputField descriptionInput;
    [SerializeField] TMP_InputField priceInput;

    public void Init()
    {
        if(Instance != null && Instance != this)
            Destroy(gameObject);
        Instance = this;
        gameObject.SetActive(false);
    }
    private void Start()
    {
        Init();
    }
    public void Open(Product p)
    {
        gameObject.SetActive(true);
        product = p;

        nameInput.text = product.Name;
        descriptionInput.text = product.Description;
        priceInput.text = product.Price.ToString();
    }
    public void Save()
    {
        if (nameInput.text == "" || descriptionInput.text == "" && priceInput.text == "")
        {
            Popup.Instance.Pop("not all input fields are populated");
            return;
        }
        product.Update(nameInput.text, descriptionInput.text, float.Parse(priceInput.text));
        Popup.Instance.Pop("the product " + product.Name + " has changed");
        ShelvesManager.UpdateAll();
        //todo: make sure the input field is always with numbers only
    
    }
    public void Abort()
    {
        product = null;
        nameInput.text = "";
        descriptionInput.text = "";
        priceInput.text = "";

    }
}
