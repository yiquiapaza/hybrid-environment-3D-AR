﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine.Networking;

namespace BarChart
{
    public class BarElementClient : MonoBehaviour, IMixedRealityInputHandler
    {
        private WWWForm elementInfo = null;
        private string[] dataElement;

        // Start is called before the first frame update
        void Start()
        {
            dataElement = gameObject.name.Split('-');
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator SendElementInfo()
        {
            elementInfo = new WWWForm();
            elementInfo.AddField("element", dataElement[1]);
            elementInfo.AddField("value", dataElement[2]);
            using (UnityWebRequest client = UnityWebRequest.Post(Constants.ENDPOINT_BARCHART_HOLOLENS_POST + "?task=3", elementInfo))
            {
                yield return client.SendWebRequest();
                if (client.isHttpError)
                    Debug.LogError(client.error);
            }
        }

        void IMixedRealityInputHandler.OnInputDown(InputEventData eventData)
        {
            StartCoroutine(SendElementInfo());
        }

        void IMixedRealityInputHandler.OnInputUp(InputEventData eventData)
        {

        }

    }

}
