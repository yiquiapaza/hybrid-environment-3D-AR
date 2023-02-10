using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

namespace BarChart { 

    public class BarChartClient : MonoBehaviour
    {
        [SerializeField] Material _changeMaterial;
        private JSONNode _dataRequest;
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
                    if (!_dataRequest.IsNull)
                    {
                        for (int i = 0; i < _dataRequest.Count; i++)
                        {
                            Debug.Log(_dataRequest[i]["element"]);
                            Debug.Log(_dataRequest[i]["element"]["value"]);
                            //_tempObject = GameObject.Find(string.Concat(_nameObject, "-", _dataRequest[i]["element"], _dataRequest[i]["element"]["value"]));
                            //_tempObject.GetComponent<MeshRenderer>().material = _changeMaterial;
                        }
                        //_tempMaterial = _tempObject.GetComponent<MeshRenderer>().material;
                    }
                    Debug.Log(_dataRequest["state"]);
                }

            }
        }

        IEnumerator WaitServer()
        {
            while (true)
            {
                StartCoroutine(RequestServer());
                Debug.Log("Wait for next Update");
                yield return new WaitForSecondsRealtime(1f);
            }
        }
    }
}