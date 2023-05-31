using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit;
using TMPro;
using System;

public class ScatterData : MonoBehaviour, IMixedRealityFocusHandler
{
    #region Features
    [SerializeField] TextAsset _data;
    [SerializeField] GameObject _message;

    private string[] data;
    private JSONArray _temData;
    private GameObject message;
    private GameObject tmpGameObject;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        message = Instantiate(_message);
        message.SetActive(false);
        //message.transform.parent = transform;
        _temData = (JSONArray)JSON.Parse(_data.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFocusEnter(FocusEventData eventData)
    {
        if (CoreServices.InputSystem.GazeProvider.GazeTarget != null)
        {
            string[] data = CoreServices.InputSystem.GazeProvider.GazeTarget.name.Split('-');
            message.SetActive(true);
            message.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y + 0.2f, gameObject.transform.position.z);
            tmpGameObject = message.transform.GetChild(1).gameObject;
            tmpGameObject.GetComponent<TextMeshPro>().text = _temData[short.Parse(data[1])]["parameter"] + "\n" + "Energy Consumption: " + _temData[short.Parse(data[1])]["parameter3"][short.Parse(data[2])] + "\n" + "PDG Per Capita: " + _temData[short.Parse(data[1])]["parameter4"][short.Parse(data[2])] + "\n";
        }
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        message.SetActive(false);
    }

    
}
