using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class InputData : MonoBehaviour
{
    //Stopwatch stopwatch;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitOneSecond());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator ObjectPositionUpdate()
    {
        using (UnityWebRequest client = UnityWebRequest.Get("127.0.0.1:3000"))
        {
            
            yield return client.SendWebRequest();
            if(client.isHttpError)
            {
                Debug.Log(client.error);
            }
            else
            {
                Debug.Log(client.downloadHandler.data);
            }
        }   
    }
    public IEnumerator WaitOneSecond()
    {
        int tmp = 0;
        while(true)
        {
            Debug.Log(tmp);
            //LogToUnityConsole(i, flag);
            tmp++;
            if (tmp % 2 == 0)
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            else
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            yield return StartCoroutine( ObjectPositionUpdate());
        }        
    }

    void CreateObject()
    { 
    
    }
}
