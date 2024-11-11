using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBController : MonoBehaviour
{
    public void SaveToDB()
    {
        ProductsDBProxy.SaveToDB();
        Popup.Instance.Pop("Session saved to DB");
    }
}
