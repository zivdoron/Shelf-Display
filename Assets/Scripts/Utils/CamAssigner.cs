using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAssigner : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    private void Awake()
    {
        Assign();
    }
    public void Assign()
    {
        if(canvas == null)
            canvas = GetComponent<Canvas>();
        if(canvas == null)
            return;
        canvas.worldCamera = Camera.main;
    }
}
