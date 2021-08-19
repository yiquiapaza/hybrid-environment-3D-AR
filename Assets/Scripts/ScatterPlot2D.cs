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
    [SerializeField]
    private Material TRA = null;

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
        using (UnityWebRequest client = UnityWebRequest.Get(Constants.ENDPOINT_COUNTRY))
        {

            yield return client.SendWebRequest();
            if (client.isHttpError)
            {
                Debug.Log(client.error);
            }
            else
            {
                UpdatePositionObjects();
                SelectCountry(UtilIO.CountryJson(client.downloadHandler.text));
            }
        }
    }
    public IEnumerator WaitOneSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            yield return StartCoroutine(ObjectPositionUpdate());
        }
    }


    public IEnumerator GetDataServer()
    {
        using (UnityWebRequest client = UnityWebRequest.Get(Constants.ENDPOINT_RAWDATA))
        {

            yield return client.SendWebRequest();
            if (client.isHttpError)
            {
                Debug.Log(client.error);
            }
            else
            {
                DataObject = UtilIO.GenericObjecsJson(client.downloadHandler.text);
                Debug.Log(client.downloadHandler.text);
            }
        }
    }

    void InitialInstantiateObjects()
    {
        CountryA = Instantiate(TemplateObject);
        CountryA.name = Constants.COUNTRY_A;
        CountryB = Instantiate(TemplateObject);
        CountryB.name = Constants.COUNTRY_B;
        CountryC = Instantiate(TemplateObject);
        CountryC.name = Constants.COUNTRY_C;
        CountryD = Instantiate(TemplateObject);
        CountryD.name = Constants.COUNTRY_D;
        CountryE = Instantiate(TemplateObject);
        CountryE.name = Constants.COUNTRY_E;
        CountryF = Instantiate(TemplateObject);
        CountryF.name = Constants.COUNTRY_F;
        CountryG = Instantiate(TemplateObject);
        CountryG.name = Constants.COUNTRY_G;
        CountryH = Instantiate(TemplateObject);
        CountryH.name = Constants.COUNTRY_H;
        CountryI = Instantiate(TemplateObject);
        CountryI.name = Constants.COUNTRY_I;
        CountryJ = Instantiate(TemplateObject);
        CountryJ.name = Constants.COUNTRY_J;
        CountryK = Instantiate(TemplateObject);
        CountryK.name = Constants.COUNTRY_K;
        CountryL = Instantiate(TemplateObject);
        CountryL.name = Constants.COUNTRY_L;
        CountryM = Instantiate(TemplateObject);
        CountryM.name = Constants.COUNTRY_M;
        CountryN = Instantiate(TemplateObject);
        CountryN.name = Constants.COUNTRY_N;
        CountryO = Instantiate(TemplateObject);
        CountryO.name = Constants.COUNTRY_O;
        CountryP = Instantiate(TemplateObject);
        CountryP.name = Constants.COUNTRY_P;
    }

    void InitialMaterialObjects()
    {
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

    void SelectCountry(Country country)
    {
        InitialMaterialObjects();
        if (country.status == 1)
        {
            switch (country.name)
            {
                case Constants.COUNTRY_A:
                    CountryA.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_B:
                    CountryB.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_C:
                    CountryC.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_D:
                    CountryD.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_E:
                    CountryE.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_F:
                    CountryF.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_G:
                    CountryG.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_H:
                    CountryH.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_I:
                    CountryI.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_J:
                    CountryJ.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_K:
                    CountryK.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_L:
                    CountryL.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_M:
                    CountryM.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_N:
                    CountryN.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_O:
                    CountryO.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case Constants.COUNTRY_P:
                    CountryP.GetComponent<Renderer>().material.color = Color.red;
                    break;
            }
        }
        else
            InitialMaterialObjects();
    }

    void InitialMaterialTranparent()
    {
        CountryA.GetComponent<Renderer>().material = TRA;
        CountryB.GetComponent<Renderer>().material = TRA;
        CountryC.GetComponent<Renderer>().material = TRA;
        CountryD.GetComponent<Renderer>().material = TRA;
        CountryE.GetComponent<Renderer>().material = TRA;
        CountryF.GetComponent<Renderer>().material = TRA;
        CountryG.GetComponent<Renderer>().material = TRA;
        CountryH.GetComponent<Renderer>().material = TRA;
        CountryI.GetComponent<Renderer>().material = TRA;
        CountryJ.GetComponent<Renderer>().material = TRA;
        CountryK.GetComponent<Renderer>().material = TRA;
        CountryL.GetComponent<Renderer>().material = TRA;
        CountryM.GetComponent<Renderer>().material = TRA;
        CountryN.GetComponent<Renderer>().material = TRA;
        CountryO.GetComponent<Renderer>().material = TRA;
        CountryP.GetComponent<Renderer>().material = TRA;
    }

    void GetData()
    {
        StartCoroutine(GetDataServer());
    }
}
