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

    private string RawData = null;
    private GenericObjects DataObject = null;

    void Start()
    {
        GetData();
        InitialInstantiateObjects();
        StartCoroutine(WaitOneSecond());
        UpdatePositionObjects();
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

    public IEnumerator GetDataServer()
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
                //DataObject = UtilIO.GenericObjecsJson(client.downloadHandler.text);
                Debug.Log(client.downloadHandler.text);
            }
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

    void UpdatePositionObjects(int year = 0, int axesX = 1, int axesY = 2, int axesZ = 3)
    {
        CountryA.transform.localPosition = new Vector3(
            Util.ScaleEnergyConsumption(DataObject.countries[0].year[0].energy_consumption),
            Util.ScaleGDPPercapita(DataObject.countries[0].year[0].gdp_per_capita), 0);
        CountryB.transform.localPosition = new Vector3(
            Util.ScaleEnergyConsumption(DataObject.countries[1].year[0].energy_consumption),
            Util.ScaleGDPPercapita(DataObject.countries[1].year[0].gdp_per_capita), 0);
        CountryC.transform.localPosition = new Vector3(
            Util.ScaleEnergyConsumption(DataObject.countries[2].year[0].energy_consumption),
            Util.ScaleGDPPercapita(DataObject.countries[2].year[0].gdp_per_capita), 0);
        CountryD.transform.localPosition = new Vector3(
            Util.ScaleEnergyConsumption(DataObject.countries[3].year[0].energy_consumption),
            Util.ScaleGDPPercapita(DataObject.countries[3].year[0].gdp_per_capita), 0);
    }

    void GetData()
    {   RawData = UtilIO.ReadFile("Data", "data.json");

        if (RawData != "Error")
            DataObject = UtilIO.GenericObjecsJson(RawData);
        else
            StartCoroutine(GetDataServer());

    }

}
