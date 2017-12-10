using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newRotation : MonoBehaviour {
    public GameObject model;
    // Use this for initialization

    void OnSelect()
    {
        model.GetComponent<HandResize>().resizingEnabled = false;
        model.GetComponent<HandDragging>().draggingEnabled = false;

        //Destroy(model); 
        if (model.GetComponent<HandRotate>().rotatingEnabled)
        {
            model.GetComponent<HandRotate>().rotatingEnabled = false;
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else
        {
            model.GetComponent<HandRotate>().rotatingEnabled = true;
            GetComponent<SpriteRenderer>().color = Color.red;
        }


    }
}
