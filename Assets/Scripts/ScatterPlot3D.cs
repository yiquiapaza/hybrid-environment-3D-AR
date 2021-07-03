using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ScatterPlot3D : MonoBehaviour
{
    [Tooltip("Object Template, with this you can manipulate position, traslation and size")]
    [SerializeField]
    private GameObject TemplateObject = null;

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

    private GameObject CountryA = null;
    private GameObject CountryB = null;
    private GameObject CountryC = null;
    private GameObject CountryD = null;

    void Start()
    {
        InitialInstantiateObjects();
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
                CountryA.GetComponent<Renderer>().material = Region1;
            else
                CountryA.GetComponent<Renderer>().material = Region2;
            yield return StartCoroutine(ObjectPositionUpdate());
        }
    }

    void InitialInstantiateObjects()
    {
        CountryA = Instantiate(TemplateObject);
        CountryB = Instantiate(TemplateObject);
        CountryC = Instantiate(TemplateObject);
        CountryD = Instantiate(TemplateObject);

        CountryA.GetComponent<Renderer>().material = Region1;
        CountryB.GetComponent<Renderer>().material = Region2;
        CountryC.GetComponent<Renderer>().material = Region3;
        CountryD.GetComponent<Renderer>().material = Region4;

        Debug.Log(CountryA.gameObject.name);
        Debug.Log(CountryB.gameObject.name);
    }


    void UpdatePositionObjects(int year = 1975)
    {
        Vector3 CurrentPosition = YearPosition(year);

    }

    Vector3 YearPosition(int year)
    {
        return new Vector3(0,0,0); 
    }

}
