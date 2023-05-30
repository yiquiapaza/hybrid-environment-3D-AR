using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

[AddComponentMenu("Scripts/ScatterPlotComponent")]
public class ScatterPlotComponent : MonoBehaviour
{
    private bool activeComponent = false;
    private GameObject _temObj = null;
    private JSONArray dataRequest;
    private Vector3 scatterPosition;
    #region Input Features
    private JSONArray _tempData;
    [SerializeField] TextAsset _data;

    [SerializeField] Material _materialCategory1;
    [SerializeField] Material _materialCategory2;
    [SerializeField] Material _materialCategory3;
    [SerializeField] Material _materialCategory4;
    [SerializeField] Material _materialCategory5;
    [SerializeField] Material _materialCategory6;
    [SerializeField] Material _materialCategory7;
    [SerializeField] Material _materialCategory8;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        scatterPosition = gameObject.transform.position;
        _tempData = (JSONArray)JSON.Parse(_data.text);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveGameObject()
    {
        if (activeComponent)
        {
            gameObject.transform.position = new Vector3(50, 0, 0);
            activeComponent = !activeComponent;
        }
        else
        {
            gameObject.transform.position = scatterPosition;
            activeComponent = !activeComponent;
        }
    }

    IEnumerator ResetScatterPlotCoroutine()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(Constants.ENDPOINT_SCATTERPLOT_RESET))
        {
            Debug.Log("$$$$$$$$$");

            yield return request.SendWebRequest();
            if (request.isHttpError || request.isNetworkError)
                Debug.Log("Error Request");
            else
            {
                Debug.Log("$$$$$$$$$");

                dataRequest = (JSONArray)JSON.Parse(request.downloadHandler.text);
                for (int i = 0; _tempData.Count > i; i++)
                {
                    for (int j = 0; _tempData[i]["parameter3"].Count > j; j++)
                    {
                        Debug.Log(string.Concat("scatter-", i, "-", j));
                        _temObj = GameObject.Find(string.Concat("scatter-", i, "-", j));
                        if (_temObj != null)
                            SetMaterial(_temObj, _tempData[i]["parameter1"]);
                    }
                }
            }
        }
    }

    public void ResetScatterPlot()
    {
        Debug.Log("$$$$$$$$$");
        StartCoroutine(ResetScatterPlotCoroutine());
    }

    #region Select Material
    void SetMaterial(GameObject gameObject, string category)
    {
        switch (category)
        {
            case MaterialSelector.CATEGORY1:
                gameObject.GetComponent<MeshRenderer>().material = _materialCategory1;
                break;
            case MaterialSelector.CATEGORY2:
                gameObject.GetComponent<MeshRenderer>().material = _materialCategory2;
                break;
            case MaterialSelector.CATEGORY3:
                gameObject.GetComponent<MeshRenderer>().material = _materialCategory3;
                break;
            case MaterialSelector.CATEGORY4:
                gameObject.GetComponent<MeshRenderer>().material = _materialCategory4;
                break;
            case MaterialSelector.CATEGORY5:
                gameObject.GetComponent<MeshRenderer>().material = _materialCategory5;
                break;
            case MaterialSelector.CATEGORY6:
                gameObject.GetComponent<MeshRenderer>().material = _materialCategory6;
                break;
            case MaterialSelector.CATEGORY7:
                gameObject.GetComponent<MeshRenderer>().material = _materialCategory7;
                break;
            case MaterialSelector.CATEGORY8:
                gameObject.GetComponent<MeshRenderer>().material = _materialCategory8;
                break;
        }
    }
    #endregion
}
