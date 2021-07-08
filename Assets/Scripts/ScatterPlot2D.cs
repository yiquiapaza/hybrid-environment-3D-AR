using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ScatterPlot2D : MonoBehaviour
{
    [Tooltip("Object Template, with this you can manipulate position, traslation and size")]
    [SerializeField]
    private GameObject TemplateObject = null;

    [Tooltip("Material that use for OC region")]
    [SerializeField]
    private Material OC = null;
    [Tooltip("Material that use for AS region")]
    [SerializeField]
    private Material AS = null;
    [Tooltip("Material that use for EU region")]
    [SerializeField]
    private Material EU = null;
    [Tooltip("Material that use for AF region")]
    [SerializeField]
    private Material AF = null;
    [Tooltip("Material that use for NA region")]
    [SerializeField]
    private Material NA = null;

    private GameObject CountryA = null;
    private GameObject CountryB = null;
    private GameObject CountryC = null;
    private GameObject CountryD = null;
    private GameObject CountryE = null;
    private GameObject CountryF = null;
    private GameObject CountryG = null;
    private GameObject CountryH = null;
    private GameObject CountryI = null;
    private GameObject CountryJ = null;
    private GameObject CountryK = null;
    private GameObject CountryL = null;
    private GameObject CountryM = null;
    private GameObject CountryN = null;
    private GameObject CountryO = null;
    private GameObject CountryP = null;

    private string RawData = null;
    private GenericObjects DataObject = null;
    void Start()
    {
        GetData();
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
                UpdatePositionObjects();
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
                CountryA.GetComponent<Renderer>().material = OC;
            else
                CountryA.GetComponent<Renderer>().material = EU;
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
        CountryE = Instantiate(TemplateObject);
        CountryF = Instantiate(TemplateObject);
        CountryG = Instantiate(TemplateObject);
        CountryH = Instantiate(TemplateObject);
        CountryI = Instantiate(TemplateObject);
        CountryJ = Instantiate(TemplateObject);
        CountryK = Instantiate(TemplateObject);
        CountryL = Instantiate(TemplateObject);
        CountryM = Instantiate(TemplateObject);
        CountryN = Instantiate(TemplateObject);
        CountryO = Instantiate(TemplateObject);
        CountryP = Instantiate(TemplateObject);

        CountryA.GetComponent<Renderer>().material = OC;
        CountryB.GetComponent<Renderer>().material = AS;
        CountryC.GetComponent<Renderer>().material = EU;
        CountryD.GetComponent<Renderer>().material = AF;
        CountryE.GetComponent<Renderer>().material = EU;
        CountryF.GetComponent<Renderer>().material = AS;
        CountryG.GetComponent<Renderer>().material = AS;
        CountryH.GetComponent<Renderer>().material = AF;
        CountryI.GetComponent<Renderer>().material = AF;
        CountryJ.GetComponent<Renderer>().material = EU;
        CountryK.GetComponent<Renderer>().material = OC;
        CountryL.GetComponent<Renderer>().material = AF;
        CountryM.GetComponent<Renderer>().material = AS;
        CountryN.GetComponent<Renderer>().material = EU;
        CountryO.GetComponent<Renderer>().material = NA;
        CountryP.GetComponent<Renderer>().material = AF;
    }

    void UpdatePositionObjects(int year = 0, int axesX = 1, int axesY = 2, int axesZ = 3)
    {
        CountryA.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[0].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[0].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryB.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[1].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[1].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryC.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[2].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[2].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryD.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[3].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[3].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryE.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[4].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[4].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryF.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[5].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[5].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryG.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[6].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[6].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryH.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[7].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[7].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryI.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[8].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[8].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryJ.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[9].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[9].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryK.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[10].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[10].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryL.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[11].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[11].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryM.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[12].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[12].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryN.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[13].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[13].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryO.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[14].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[14].year[0].gdp_per_capita),
            gameObject.transform.position.z);

        CountryP.transform.localPosition = new Vector3(
            gameObject.transform.position.x + Util.ScaleEnergyConsumption(DataObject.countries[15].year[0].energy_consumption),
            gameObject.transform.position.y + Util.ScaleGDPPercapita(DataObject.countries[15].year[0].gdp_per_capita),
            gameObject.transform.position.z);
    }

    void GetData()
    {
        RawData = UtilIO.ReadFile("Data", "data.json");

        if (RawData != "Error")
            DataObject = UtilIO.GenericObjecsJson(RawData);
        else
            StartCoroutine(GetDataServer());

    }
}
