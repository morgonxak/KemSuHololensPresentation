using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMotion : MonoBehaviour {
    public GameObject model;
	// Use this for initialization

    void OnSelect()
    {
       
       model.GetComponent<HandResize>().resizingEnabled = false;
       model.GetComponent<HandRotate>().rotatingEnabled = false;


        if (model.GetComponent<HandDragging>().draggingEnabled)
        {
            model.GetComponent<HandDragging>().draggingEnabled = false;
            GetComponent<SpriteRenderer>().color = Color.blue;
        }else
        {
            model.GetComponent<HandDragging>().draggingEnabled = true;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
       
        //Destroy(model); 


    }
    
}
