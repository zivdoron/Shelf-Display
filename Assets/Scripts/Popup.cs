using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public static Popup Instance;

    [SerializeField] TextMeshProUGUI messageTxt;
    private void Start()
    {
        Instance = this;
        gameObject.SetActive(false);
    }

    public void Pop(string message)
    {
        gameObject.SetActive(true);
        messageTxt.text = message;
    }
}
