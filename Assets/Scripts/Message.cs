using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Input;

public class Message : MonoBehaviour, IMixedRealityInputHandler
{
    [SerializeField]
    private GameObject display;
    [SerializeField]
    private TextMeshPro text;
    [SerializeField]
    private bool state;
    [SerializeField]
    private Material correct;
    [SerializeField]
    private Material error;
    public void OnInputDown(InputEventData eventData)
    {
        if(state)
        {
            Debug.Log("state " + state);
            display.GetComponent<Renderer>().material = correct;
            text.text = "Correct";
        }
        else
        {
            Debug.Log("state " + state);
            display.GetComponent<Renderer>().material = error;
            text.text = "Chosse again";
        }
    }

    public void OnInputUp(InputEventData eventData)
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Select a Country";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
