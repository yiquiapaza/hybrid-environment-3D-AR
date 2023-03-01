using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit;

public class NewBehaviourScript : MonoBehaviour, IMixedRealityInputHandler, IMixedRealityFocusHandler
{
    [SerializeField] GameObject feedBack;
    private GameObject cursorObject;
    private GameObject _feedBack;

    public void OnFocusEnter(FocusEventData eventData)
    {
        cursorObject = CoreServices.InputSystem.GazeProvider.GazeTarget;
        if (cursorObject != null)
        {
            Debug.Log("here update");
            _feedBack.SetActive(true);
            _feedBack.transform.position = new Vector3(cursorObject.transform.position.x, cursorObject.transform.position.y + cursorObject.transform.lossyScale.y / 2 + 0.01f, cursorObject.transform.position.z);
            _feedBack.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        _feedBack.SetActive(false);
    }

    public void OnInputDown(InputEventData eventData)
    {
        cursorObject = CoreServices.InputSystem.GazeProvider.GazeTarget;
        if (cursorObject != null)
        {
            Debug.Log("here");
            _feedBack.SetActive(true);
            _feedBack.transform.position = new Vector3(cursorObject.transform.position.x, cursorObject.transform.position.y + cursorObject.transform.lossyScale.y / 2 + 0.01f, cursorObject.transform.position.z);
            _feedBack.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

  



    public void OnInputUp(InputEventData eventData)
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        _feedBack = Instantiate(feedBack);
        _feedBack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
