using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System;
using Newtonsoft.Json;
using System.Diagnostics;

public static class ProductServer
{
    public static ProductsList GetProducts()
    {
        WebRequest request = WebRequest.Create("https://homework.mocart.io/api/products");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        UnityEngine.Debug.Log(response.StatusDescription);
        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        UnityEngine.Debug.Log(responseFromServer);
        reader.Close();
        dataStream.Close();
        response.Close();
        ProductsList jsonResponse = JsonConvert.DeserializeObject<ProductsList>(responseFromServer);
        UnityEngine.Debug.Log(jsonResponse.products[0].Name);
        return jsonResponse;
    }
}
