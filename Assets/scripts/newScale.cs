using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScale : MonoBehaviour {

    public GameObject model;
    // Use this for initialization

    void OnSelect()
    {
        
        model.GetComponent<HandRotate>().rotatingEnabled = false;
        model.GetComponent<HandDragging>().draggingEnabled = false;

        if (model.GetComponent<HandResize>().resizingEnabled)
        {
            model.GetComponent<HandResize>().resizingEnabled = false;
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else
        {
            model.GetComponent<HandResize>().resizingEnabled = true;
            GetComponent<SpriteRenderer>().color = Color.red;
        }


    }
}
