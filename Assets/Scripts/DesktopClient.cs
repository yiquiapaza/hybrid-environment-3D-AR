using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DesktopClient : MonoBehaviour
{
    private WWWForm postRotation;
    // Start is called before the first frame update
    void Start()
    {
    #if UNITY_EDITOR
        StartCoroutine(WaitSendRotation());
    #endif
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Send the rotatio for sec
    IEnumerator SendRotation()
    {
        postRotation = new WWWForm();

        postRotation.AddField("x", gameObject.transform.rotation.x.ToString());
        postRotation.AddField("y", gameObject.transform.rotation.y.ToString());
        postRotation.AddField("z", gameObject.transform.rotation.z.ToString());
 
        using (UnityWebRequest client = UnityWebRequest.Post(Constants.ENDPOINT_ROTATE, postRotation))
        {
            yield return client.SendWebRequest();

            if (client.isHttpError || client.isHttpError)
            {
                Debug.Log(client.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }
    }

    IEnumerator WaitSendRotation()
    {
        while (true)
        {
            StartCoroutine(SendRotation());
            yield return new WaitForSeconds(0.5F);
        }
    }
}
