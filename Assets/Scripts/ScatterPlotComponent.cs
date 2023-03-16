using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

[AddComponentMenu("Scripts/ScatterPlotComponent")]
public class ScatterPlotComponent : MonoBehaviour
{
    private bool activeComponent = false;
    private GameObject tem;
    private JSONArray dataRequest;
    // Start is called before the first frame update
    void Start()
    {
        
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

    IEnumerator UpdatePostionCorutine()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(Constants.ENDPOINT_BARCHART_RESET))
        {
            yield return request.SendWebRequest();
            if (request.isHttpError || request.isNetworkError)
                Debug.Log("Error Request");
            else
            {
                dataRequest = (JSONArray)JSON.Parse(request.downloadHandler.text);
                if (dataRequest["state"])
                {
                    tem = GameObject.Find("Yell");
                    tem.transform.position = new Vector3(dataRequest["x"], dataRequest["y"], dataRequest["z"]);
                }
            }
        }
    }

}
