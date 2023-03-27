using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using SimpleJSON;
using System;
using TMPro;

namespace BarChart
{
    public class BarData : MonoBehaviour, IMixedRealityFocusHandler
    {
        #region Features
        [SerializeField] TextAsset _data;
        [SerializeField] GameObject _message;

        private string[] data;
        private JSONArray _tempData;
        private GameObject message;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            message = Instantiate(_message);
            message.SetActive(false);
            _tempData = (JSONArray)JSON.Parse(_data.text);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnFocusEnter(FocusEventData eventData)
        {
            if (CoreServices.InputSystem.GazeProvider.GazeTarget != null)
            {
                message.SetActive(true);
                string[] data = CoreServices.InputSystem.GazeProvider.GazeTarget.name.Split('-');
                message.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.15f, gameObject.transform.position.z);
                message.transform.rotation =  Quaternion.LookRotation(Camera.main.transform.forward);

                Debug.Log(gameObject.transform.position.ToString());
                //var temData = _tempData[1]["parameter"];

                //Debug.Log(temData);
                GameObject tmpGameObject = message.transform.GetChild(1).gameObject;
                tmpGameObject.GetComponent<TextMeshPro>().text = _tempData[short.Parse(data[1])]["parameter"] + "\n" + _tempData[short.Parse(data[1])]["parameter3"][data[2]];
                //Debug.Log(tmpGameObject.name);

            }
        }

        public void OnFocusExit(FocusEventData eventData)
        {
            message.SetActive(false);
        }
    }

}
