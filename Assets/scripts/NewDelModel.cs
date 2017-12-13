using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDelModel : MonoBehaviour
{

    public GameObject modelDel;
    
    // Use this for initialization
    SpriteRenderer buttonColor;

    public bool activ = true;

    void OnSelect()
    {
        
        if (activ)
        {
            
            activ = false;
            GetComponent<SpriteRenderer>().color = Color.red;
            modelDel.SetActive(false);
        }
        else
        {
            
            activ = true;
            GetComponent<SpriteRenderer>().color = Color.blue;
            modelDel.SetActive(true);
        }

    }
}
