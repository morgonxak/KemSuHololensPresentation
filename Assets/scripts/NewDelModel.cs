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
            modelDel.SetActive(false);
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            modelDel.SetActive(true);
            GetComponent<SpriteRenderer>().color = Color.blue;
        }

    }
}
