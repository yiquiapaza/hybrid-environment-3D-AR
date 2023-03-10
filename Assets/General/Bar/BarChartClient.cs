using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using System;

namespace BarChart { 

    public class BarChartClient : MonoBehaviour
    {
        [SerializeField] Material _changeMaterial;
        private JSONArray _dataRequest;
        private JSONNode _resetData;
        private Material _tempMaterial;
        private readonly string _nameObject = "bar";
        private GameObject _tempObject;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(WaitServer());
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator RequestServer()
        {
            using (UnityWebRequest request = UnityWebRequest.Get(Constants.ENDPOINT_BARCHART_GET))
            {
                yield return request.SendWebRequest();
                if (request.isHttpError || request.isNetworkError)
                {
                    Debug.Log(request.error);
                }
                else
                {
                    Debug.Log(request.downloadHandler.text);
                    _dataRequest = (JSONArray)JSON.Parse(request.downloadHandler.text);
                    Debug.Log(_dataRequest);
                    if (_dataRequest.Count > 0)
                    {
                        for (int i = 0; i < _dataRequest.Count; i++)
                        {
                            _tempObject = GameObject.Find(string.Concat(_nameObject, "-", _dataRequest[i]["element"], "-", _dataRequest[i]["value"]));
                            Debug.Log(string.Concat(_nameObject, "-", _dataRequest[i]["element"], "-", _dataRequest[i]["value"]));
                            _tempObject.GetComponent<MeshRenderer>().material = _changeMaterial;
                        }
                    }
                    else 
                    Debug.Log(_dataRequest["state"]);
                }

            }
        }

        IEnumerator ResetData()
        {
            using (UnityWebRequest request = UnityWebRequest.Get(Constants.ENDPOINT_BARCHART_RESET))
            {
                yield return request.SendWebRequest();
                if (request.isHttpError || request.isNetworkError)
                {
                    Debug.Log(request.error);
                }
                else
                {
                    _resetData = JSON.Parse(request.downloadHandler.text);
                    if (string.Equals(_resetData["active"], "normal"))
                    {

                    }
                }
            }
        }

        IEnumerator WaitServer()
        {
            while (true)
            {
                StartCoroutine(RequestServer());
                StartCoroutine(ResetData());
                Debug.Log("Wait for next Update");
                yield return new WaitForSecondsRealtime(1f);
            }
        }
    }
}