using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Microsoft.MixedReality.Toolkit.Input;

public class ObjectClient : MonoBehaviour, IMixedRealityInputHandler
{
    private WWWForm objectPost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SendSelect()
    {
        objectPost.AddField("name", gameObject.name);
        objectPost.AddField("state", "true");
        using (UnityWebRequest client = UnityWebRequest.Post("http://192.168.0.104:3000/object", objectPost))
        {
            yield return client.SendWebRequest();
            if (client.isHttpError)
            {
                Debug.Log(client.error);
            }
            else
            {
                Debug.Log("Object form upload complete");
            }
        }
    }

    public void OnInputUp(InputEventData eventData)
    {
        StartCoroutine(SendSelect());
    }

    public void OnInputDown(InputEventData eventData)
    {
        Debug.Log("Execute OnInputDown");
    }
}
