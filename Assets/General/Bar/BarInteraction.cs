using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Microsoft.MixedReality.Toolkit.Input;

public class BarInteraction : MonoBehaviour, IMixedRealityInputHandler
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SendRequest()
    {
        WWWForm form = new WWWForm();
        form.AddField("state", gameObject.name);
        using (UnityWebRequest request = UnityWebRequest.Post(Constants.ENDPOINT_RAWDATA, form))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                Debug.Log("Request error");
            else
                Debug.Log(request.downloadHandler.text);
        }

    }

    public void OnInputUp(InputEventData eventData)
    {
        Debug.Log(gameObject.name);
        Debug.Log("Gesture complete");
        StartCoroutine(SendRequest());
    }

    public void OnInputDown(InputEventData eventData)
    {
        Debug.Log("OnInputDown");
    }
}
