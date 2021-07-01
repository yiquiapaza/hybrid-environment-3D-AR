using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ScatterPlot3D : MonoBehaviour
{
    [Tooltip("Country A Object, with this you can manipulate position, traslation and size")]
    [SerializeField]
    private GameObject CountryA = null;
    [Tooltip("Country B Object, with this you can manipulate position, traslation and size")]
    [SerializeField]
    private GameObject CountryB = null;
    [Tooltip("Country C Object, with this you can manipulate position, traslation and size")]
    [SerializeField]
    private GameObject CountryC = null;
    [Tooltip("Country D Object, with this you can manipulate position, traslation and size")]
    [SerializeField]
    private GameObject CountryD = null;

    [Tooltip("Material that use for regin 1")]
    [SerializeField]
    private Material Region1 = null;
    [Tooltip("Material that use for regin 2")]
    [SerializeField]
    private Material Region2 = null;
    [Tooltip("Material that use for regin 3")]
    [SerializeField]
    private Material Region3 = null;
    [Tooltip("Material that use for regin 4")]
    [SerializeField]
    private Material Region4 = null;

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
            if (client.isHttpError)
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
        while (true)
        {
            //Debug.Log(tmp);
            //LogToUnityConsole(i, flag);
            tmp++;
            if (tmp % 2 == 0)
                gameObject.GetComponent<Renderer>().material = Region1;
            else
                gameObject.GetComponent<Renderer>().material = Region2;
            yield return StartCoroutine(ObjectPositionUpdate());
        }
    }
}
