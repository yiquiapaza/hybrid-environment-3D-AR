using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

[AddComponentMenu("General/Menu/ClientPosition")]
public class ClientPosition : MonoBehaviour
{
    private GameObject tem;
    private JSONNode dataRequest;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePosition ()
    {
        StartCoroutine(UpdatePostionCorutine());
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
                dataRequest = JSON.Parse(request.downloadHandler.text);
                if (dataRequest["state"])
                {
                    tem = GameObject.Find("Yell");
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
