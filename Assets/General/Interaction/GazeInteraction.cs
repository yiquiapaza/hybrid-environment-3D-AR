﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;

public class GazeInteraction : MonoBehaviour
{
    private GameObject _gazeTargetObject;

    private Vector3 _initialPososition;

    // Start is called before the first frame update
    void Start()
    {
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
            //_gazeTargetObject = CoreServices.InputSystem.GazeProvider.GazeTarget;
            //_gazeTargetObject = transform.GetChild(1).gameObject;
            //_messageBar.transform.position = new Vector3(_gazeTargetObject.transform.position.x, _gazeTargetObject.transform.position.y + 0.2f, _gazeTargetObject.transform.position.z);
            //Debug.Log(_messageBar.transform.localScale);
            //_gazeTargetObject.SetActive(true);

        }
        else
        {
        }
    }
}
