using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;


namespace ScatterPlot
{
    public class ScatterPlotClient : MonoBehaviour
    {
        #region Features
        [SerializeField] Material _changeMaterial;
        private JSONArray _dataRequest;
        private readonly string _nameObject = "scatter";
        private GameObject _tempObject;
        #endregion

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
            using (UnityWebRequest request = UnityWebRequest.Get(Constants.ENDPOINT_SCATTERPLOT_GET))
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
                    if (_dataRequest.Count > 0)
                    {
                        for (int i = 0; i < _dataRequest.Count; i++)
                        {
                            Debug.Log(string.Concat(_nameObject, "-", _dataRequest[i]["element"], "-", _dataRequest[i]["value"]));
                            _tempObject = GameObject.Find(string.Concat(_nameObject, "-", _dataRequest[i]["element"], "-", _dataRequest[i]["value"]));
                            _tempObject.GetComponent<MeshRenderer>().material = _changeMaterial;
                        }
                    }
                }
            
            }                
        }

        IEnumerator WaitServer()
        {
            while (true)
            {
                StartCoroutine(RequestServer());
                yield return new WaitForSecondsRealtime(1f);
            }
        }
    }
}