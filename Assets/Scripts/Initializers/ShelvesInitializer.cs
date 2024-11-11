using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ShelvesInitializer : MonoInitializer
{
    public override void Init()
    {
        ShelvesManager.elements.ForEach(element => element.gameObject.SetActive(true));
        ShelvesManager.OrderAll();

    }
}
