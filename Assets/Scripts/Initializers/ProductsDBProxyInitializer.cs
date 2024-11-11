using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductsDBProxyInitializer : MonoInitializer
{
    public override void Init()
    {
        ProductsDBProxy.Init();
    }
}
