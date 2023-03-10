using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

[AddComponentMenu("General/Menu/GeneralPosition")]
public class GeneralPosition : MonoBehaviour
{
    private WWWForm sendPosition = null;
    private JSONNode dataRequest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPosition ()
    {
        StartCoroutine(SendPositionCorutine());
    }

    IEnumerator SendPositionCorutine()
    {
        sendPosition = new WWWForm();
        sendPosition.AddField("x", gameObject.transform.position.x.ToString());
        sendPosition.AddField("y", gameObject.transform.position.y.ToString());
        sendPosition.AddField("z", gameObject.transform.position.z.ToString());

        using (UnityWebRequest client = UnityWebRequest.Post(Constants.ENDPOINT_POSITION_POST, sendPosition))
        {
            yield return client.SendWebRequest();
            if (client.isHttpError)
                Debug.LogError(client.error);
        }
    }

    public void UpdatePosition()
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
                Debug.Log(dataRequest.ToString());
                gameObject.transform.position = new Vector3(float.Parse(dataRequest["x"]), float.Parse(dataRequest["y"]), float.Parse(dataRequest["z"]));
                
            }
        }
    }
}
