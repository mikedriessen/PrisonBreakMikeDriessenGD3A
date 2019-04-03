using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.WebSockets;
using SimpleJSON;
using UnityEngine;
using UnityEngine.UI;


public class EYAGEKWEER : MonoBehaviour
{

    public Text kutweer;
    public bool canOpen= false;
    public string theWeather;
    
    // Start is called before the first frame update
    void Start()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?APPID=23e8ea0234aaa687c4dfd79495463076&q=Hapert,nl");

        WebResponse response = (HttpWebResponse)request.GetResponse();

        string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        
   
        string weer = JSON.Parse(responseString)["weather"].AsArray[0].AsObject["main"];
        Debug.Log(weer);
        kutweer.text = "Bad weather today is : " + weer;
        if (weer == "Rain")
        {
            Rain();
        }
    }

    public void Rain()
    {
        if (!canOpen)
        {
            canOpen = true;
        }
        
    }

}
