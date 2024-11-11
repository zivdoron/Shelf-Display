using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{
    public GameObject placedObj;
    bool placed = false;
    public bool Placed { get => placed; }

    public void Place(GameObject gameObject)
    {
        if(placed)
            return;
        ForcePlace(gameObject);
    }
    public void ForcePlace(GameObject gameObject)
    {
        gameObject.transform.SetParent(transform, false);
        gameObject.transform.localPosition = Vector3.zero;
        placedObj = gameObject;
        placed = true;
    }
    public void Remove()
    {
        Destroy(placedObj);
        placedObj = null;
        placed = false;
    }
}
