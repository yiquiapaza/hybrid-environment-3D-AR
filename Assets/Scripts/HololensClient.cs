using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class HololensClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    #if UNITY_WSA
        Debug.Log("Hello desde Hololens");
        StartCoroutine(WaitGetRotation());
    #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetRotation()
    {
        using (UnityWebRequest client = UnityWebRequest.Get("http://192.168.0.104:3000/rotation"))
        {
            yield return client.SendWebRequest();
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
