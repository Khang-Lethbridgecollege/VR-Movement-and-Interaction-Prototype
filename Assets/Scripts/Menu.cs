using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{

    // Start is called before the first frame update

    public void EventClicker(string text)
    {//finds the text componentt under button to change it
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;
     
    }
    
}