using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.Networking;


#region Materials
public static class MaterialSelector
{
    public const string CATEGORY1 = "OC";
    public const string CATEGORY2 = "AS";
    public const string CATEGORY3 = "EU";
    public const string CATEGORY4 = "AF";
    public const string CATEGORY5 = "NA";
    public const string CATEGORY6 = "01";
    public const string CATEGORY7 = "02";
    public const string CATEGORY8 = "03";
}
#endregion

[AddComponentMenu("Scripts/BarChartComponent")]
public class BarChartComponent : MonoBehaviour
{

    private bool activeComponent = false;
    private GameObject _temObj = null;
    private JSONArray dataRequest;
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
        _tempData = (JSONArray)JSON.Parse(_data.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveGameObject()
    {
        gameObject.SetActive(activeComponent);
        activeComponent = !activeComponent;
    }

    IEnumerator ResetBarChartCoroutine()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(Constants.ENDPOINT_BARCHART_RESET))
        {
            yield return request.SendWebRequest();
            if (request.isHttpError || request.isNetworkError)
                Debug.Log("Error Request");
            else
            {
                dataRequest = (JSONArray)JSON.Parse(request.downloadHandler.text);
                for (int i = 0; _tempData.Count > i; i++)
                {
                    for (int j = 0; _tempData[i]["parameter3"].Count > j; j++)
                    {
                        _temObj = GameObject.Find(string.Concat("bar-", i, "-", j));
                        SetMaterial(_temObj, _tempData[i]["parameter1"]);

                    }
                }

            }
        }
    }


    public void ResetBarChart ()
    {
        StartCoroutine(ResetBarChartCoroutine());
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
