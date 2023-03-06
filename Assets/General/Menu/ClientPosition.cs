using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

public class ClientPosition : MonoBehaviour
{
    private GameObject tem;
    private JSONNode dataRequest;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitServer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator UpdatePostionCorutine()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(Constants.ENDPOINT_POSITION_GET))
        {
            yield return request.SendWebRequest();
            if (request.isHttpError || request.isNetworkError)
                Debug.Log("Error Request");
            else
            {
                dataRequest = (JSONNode)JSON.Parse(request.downloadHandler.text);
                Debug.Log(dataRequest.ToString());                
                if (dataRequest["state"])
                {
                    tem = GameObject.Find("Parent");
                    tem.transform.position = new Vector3(dataRequest["x"], dataRequest["y"], dataRequest["z"]);
                }
           }
        }
    }
    IEnumerator WaitServer()
    {
        while (true)
        {
            StartCoroutine(UpdatePostionCorutine());
            yield return new WaitForSeconds(1);
        }
    }
}
