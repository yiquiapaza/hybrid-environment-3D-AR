using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class BarInteraction : MonoBehaviour, IMixedRealityGestureHandler
{

    public void OnGestureCanceled(InputEventData eventData)
    {
        Debug.Log("Cancel event");
    }

    public void OnGestureCompleted(InputEventData eventData)
    {
        Debug.Log(transform.position);
        Debug.Log("Gesture complete");
    }

    public void OnGestureStarted(InputEventData eventData)
    {
        Debug.Log("Gesture start");
    }

    public void OnGestureUpdated(InputEventData eventData)
    {
        Debug.Log("gesture update");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
