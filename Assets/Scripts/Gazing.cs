using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class Gazing : MonoBehaviour, IMixedRealityInputHandler
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
        Debug.Log(gameObject.name);
        Debug.Log("OnInputUp");
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    public void OnInputDown(InputEventData eventData)
    {
        Debug.Log(gameObject.name);
        Debug.Log("OnInputDown");
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
