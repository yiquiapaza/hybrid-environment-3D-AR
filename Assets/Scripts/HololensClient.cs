using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class HololensClient : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    //#if UNITY_WSA
        Debug.Log("Hello desde Hololens");
        StartCoroutine(WaitGetRotation());
    //#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetRotation()
    {
        using (UnityWebRequest client = UnityWebRequest.Get(Constants.ENDPOINT_ROTATE))
        {
            yield return client.SendWebRequest();
            if(client.isNetworkError)
            {
                Debug.Log(client.error);
            }
            else
            {
                Debug.Log(client.downloadHandler.text);
                
                gameObject.transform.rotation = Quaternion.Euler( Rotation.CreateFromJSON(client.downloadHandler.text).x * Mathf.Rad2Deg,
                                                                    Rotation.CreateFromJSON(client.downloadHandler.text).y * Mathf.Rad2Deg,
                                                                    Rotation.CreateFromJSON(client.downloadHandler.text).z * Mathf.Rad2Deg);

            }
        }
    }

    IEnumerator WaitGetRotation()
    {
        while (true)
        {
            StartCoroutine(GetRotation());
            yield return new WaitForSeconds(0.5F);
        }
    }

}
