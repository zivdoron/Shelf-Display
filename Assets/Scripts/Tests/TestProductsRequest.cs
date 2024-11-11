using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProductsRequest : MonoBehaviour
{
    public void RequestProduts()
    {
        ProductServer.GetProducts();
    }
}
