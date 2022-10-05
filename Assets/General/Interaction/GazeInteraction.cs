using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;

public class GazeInteraction : MonoBehaviour
{
    public GameObject _messageBar;
    private GameObject _gazeTargetObject;
    
    // Start is called before the first frame update
    void Start()
    {
        _messageBar = GameObject.Find("MessageBar");
        _messageBar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LogCurrentGazeTarget();
    }

    void LogCurrentGazeTarget()
    {
        if (CoreServices.InputSystem.GazeProvider.GazeTarget)
        {
            //Debug.Log("User gaze is currently over game object" + CoreServices.InputSystem.GazeProvider.GazeTarget);
            _messageBar.SetActive(true);
            _gazeTargetObject = CoreServices.InputSystem.GazeProvider.GazeTarget;
            _messageBar.transform.localPosition = new Vector3(_gazeTargetObject.transform.localPosition.x, _gazeTargetObject.transform.localPosition.y + 0.2f, _gazeTargetObject.transform.localPosition.z);
            Debug.Log(_messageBar.transform.localScale);
             
        }
        else
        {
            _messageBar.SetActive(false);
        }
    }
}
