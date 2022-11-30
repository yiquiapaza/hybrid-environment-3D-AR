using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Microsoft.MixedReality.Toolkit.Input;

public class ScatterInteraction : MonoBehaviour, IMixedRealityInputHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SendResquest()
    {
        WWWForm form = new WWWForm();
        form.AddField("id", gameObject.name);
        form.AddField("state", 0);
        using (UnityWebRequest request = UnityWebRequest.Post(Constants.ENDPOINT_BARCHART_HOLOLENS_POST, form))
        {
            yield return request.SendWebRequest();
            if (!request.isNetworkError || !request.isHttpError)
                Debug.Log(request.downloadHandler.text);
            else
                Debug.Log("Request error");
        }
    }

    public void OnInputUp(InputEventData eventData)
    {
        StartCoroutine(SendResquest());
    }

    public void OnInputDown(InputEventData eventData)
    {
    }
}
