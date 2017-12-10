using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HandDragging : MonoBehaviour, IManipulationHandler
{
    public GameObject m;
    [SerializeField]
    float DragSpeed = 1.5f;

    [SerializeField]
    float DragScale = 1.5f;

    [SerializeField]
    float MaxDragDistance = 3f;
        
    Vector3 lastPosition;
   

    [SerializeField]
    public bool draggingEnabled = true;
    public void SetDragging(bool enabled)
    {
        draggingEnabled = enabled;
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        InputManager.Instance.PushModalInputHandler(m.gameObject);
        lastPosition = m.transform.position;
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        if (draggingEnabled)
        {       
           // if(!buttonClic)
            Drag(eventData.CumulativeDelta);

            //sharing & messaging
            //SharingMessages.Instance.SendDragging(Id, eventData.CumulativeDelta);
        }
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        InputManager.Instance.PopModalInputHandler();
    }

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        InputManager.Instance.PopModalInputHandler();
    }

    void Drag(Vector3 positon)
    {
        var targetPosition = lastPosition + positon * DragScale;
        if (Vector3.Distance(lastPosition, targetPosition) <= MaxDragDistance)
        {
            m.transform.position = Vector3.Lerp(m.transform.position, targetPosition, DragSpeed);
        }
    }
}
