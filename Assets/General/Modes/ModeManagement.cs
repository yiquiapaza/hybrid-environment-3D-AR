using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;

public class ModeManagement : MonoBehaviour, IMixedRealitySpeechHandler
{
    private GameObject _tempGameObject;
    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        #region Visualization
        if (eventData.Command.Keyword == "barchart on")
        {
            _tempGameObject = GameObject.Find("BarChart");
            _tempGameObject.SetActive(true);
        }
        if (eventData.Command.Keyword == "scartterplot on")
        {
            _tempGameObject = GameObject.Find("ScatterPlot");
            _tempGameObject.SetActive(true);
        }
        if (eventData.Command.Keyword == "barchart off")
        {
            _tempGameObject = GameObject.Find("BarChart");
            _tempGameObject.SetActive(false);
        }
        if (eventData.Command.Keyword == "scartterplot off")
        {
            _tempGameObject = GameObject.Find("ScatterPlot");
            _tempGameObject.SetActive(false);
        }
        #endregion

        #region Mode
        if (eventData.Command.Keyword == "manipulation on")
        {
            _tempGameObject = transform.GetChild(0).gameObject;
            _tempGameObject.GetComponent<ObjectManipulator>().enabled = true;
        }
        if (eventData.Command.Keyword == "manipulation off")
        {
            _tempGameObject = transform.GetChild(0).gameObject;
            _tempGameObject.GetComponent<ObjectManipulator>().enabled = false;
        }
        #endregion
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
