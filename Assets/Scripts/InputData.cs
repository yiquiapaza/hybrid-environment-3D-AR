using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class InputData : MonoBehaviour
{
    Stopwatch stopwatch;
    // Start is called before the first frame update
    void Start()
    {
        stopwatch = new System.Diagnostics.Stopwatch();
        stopwatch.Start();
        //StartCoroutine(CoroutineCountDown(1000, "Basic Corutine A"));
        //StartCoroutine(CoroutineCountDown(1000, "Basic Corutine B"));
        var a = Task.Run(() => TaskAsyncCountDown(10, "BasicAsyncCasll"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LogToUnityConsole(object content, string flag, [CallerMemberName] string callerName = null )
    {
        UnityEngine.Debug.Log($"{callerName}: \t{flag}{content}\t at {stopwatch.ElapsedMilliseconds}\t in thread {Thread.CurrentThread.ManagedThreadId}");
    }

    /*public IEnumerator CoroutineCountDown(int count, string flag = "")
    {
        for( int i = count; i>= 0; i--)
        {
            LogToUnityConsole(i, flag);
            if (i % 2 == 0)
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            else
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            yield return new  WaitForSeconds(1);
        }
    }*/

    public async Task TaskAsyncCountDown(int count, string flag = "")
    {
        for (int i = count; i >= 0; i--)
        {
            LogToUnityConsole(i, flag);
            //ColorObjectUpdate(i);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            await Task.Delay(1000);
        }
    }

    void ColorObjectUpdate(int color)
    {
        if (color % 2 == 0)
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        else
            gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
