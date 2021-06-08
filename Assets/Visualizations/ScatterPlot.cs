using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class ScatterPlot : MonoBehaviour
{
    [SerializeField]
    GameObject ElementsGeneric = null;

    private GameObject CountryA;
    private GameObject CountryB;
    private GameObject CountryC;
    private GameObject CountryD;
    private GameObject CountryE;
    private GameObject CountryF;

    private string JsonData = null;
    private GenericObjects genericObjects;
    private Vector3 InitialPosition;
    
    
    private readonly string FILE_NAME = "data.json";
    private readonly string DIRECTORY_NAME = "Data";
    


    void Awake()
    {
        JsonData = UtilIO.ReadFile(DIRECTORY_NAME, FILE_NAME, gameObject);
        genericObjects = UtilIO.GenericObjecsJson(JsonData);
        InitialPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        InstantiateAllObjets();
        UpdaNameGameObject();



        UpdatePositionsFirstExperiment(1975, genericObjects);
        Debug.Log(CountryA.transform.position);
        Debug.Log(CountryB.transform.position);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdaNameGameObject()
    {
        CountryA.GetComponent<ToolTipSpawner>().toolTipText = genericObjects.countries[0].country;
        CountryB.GetComponent<ToolTipSpawner>().toolTipText = genericObjects.countries[1].country;
        CountryC.GetComponent<ToolTipSpawner>().toolTipText = genericObjects.countries[2].country;
        CountryD.GetComponent<ToolTipSpawner>().toolTipText = genericObjects.countries[3].country;
        CountryE.GetComponent<ToolTipSpawner>().toolTipText = genericObjects.countries[4].country;
        CountryF.GetComponent<ToolTipSpawner>().toolTipText = genericObjects.countries[5].country;
    }

    void UpdatePositionsFirstExperiment(int year, GenericObjects genericObjects)
    {
        switch ( year )
        {
            case 1975:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1976:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1976),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1976),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1976),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1976),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1976),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1976),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1976),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1976),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1976),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1976),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1976),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1976),
                    0);
                break;
            case 1977:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1977),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1977),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1977),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1977),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1977),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1977),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1977),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1977),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1977),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1977),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1977),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1977),
                    0);
                break;
            case 1978:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1978),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1978),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1978),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1978),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1978),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1978),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1978),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1978),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1978),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1978),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1978),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1978),
                    0);
                break;
            case 1979:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1979),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1979),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1979),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1979),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1979),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1979),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1979),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1979),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1979),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1979),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1979),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1979),
                    0);
                break; ;
            case 1980:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1980),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1980),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1980),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1980),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1980),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1980),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1980),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1980),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1980),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1980),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1980),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1980),
                    0);
                break; 
            case 1981:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1981),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1981),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1981),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1981),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1981),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1981),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1981),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1981),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1981),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1981),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1981),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1981),
                    0);
                break;
            case 1982:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1983:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1984:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1985:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1986:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1987:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1988:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1989:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1990:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1991:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1992:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1975),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1975),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1975),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1975),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1975),
                    0);
                break;
            case 1993:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1975),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1975),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1994),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1994),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1994),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1994),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1994),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1994),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1994),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1994),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1994),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1994),
                    0);
                break;
            case 1994:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1995),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1995),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1995),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1995),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1995),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1995),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1995),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1995),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1995),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1995),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1995),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1995),
                    0);
                break;
            case 1995:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1996),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1996),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1996),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1996),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1996),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1996),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1996),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1996),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1996),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1996),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1996),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1996),
                    0);
                break;
            case 1996:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1997),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1997),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1997),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1997),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1997),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1997),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1997),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1997),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1997),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1997),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1997),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1997),
                    0);
                break;
            case 1997:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1998),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1998),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1998),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1998),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1998),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1998),
                    0);
                break;
            case 1998:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1998),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1998),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1998),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1998),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1998),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1998),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1998),
                    0);
                break;
            case 1999:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_1999),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_1999),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_1999),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_1999),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_1999),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_1999),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_1999),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_1999),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_1999),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_1999),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_1999),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_1999),
                    0);
                break;
            case 2000:
                CountryA.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[0].energy_consumption_2000),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[0].gdp_per_capita_2000),
                    0);
                CountryB.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[1].energy_consumption_2000),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[1].gdp_per_capita_2000),
                    0);
                CountryC.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[2].energy_consumption_2000),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[2].gdp_per_capita_2000),
                    0);
                CountryD.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[3].energy_consumption_2000),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[3].gdp_per_capita_2000),
                    0);
                CountryE.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[4].energy_consumption_2000),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[4].gdp_per_capita_2000),
                    0);
                CountryF.transform.position = new Vector3(
                    InitialPosition.x + Util.ScaleEnergyConsumption(genericObjects.countries[5].energy_consumption_2000),
                    InitialPosition.y + Util.ScaleGDPPercapita(genericObjects.countries[5].gdp_per_capita_2000),
                    0);
                break;
        }
    }


    void InstantiateAllObjets()
    {
        CountryA = Instantiate(ElementsGeneric);
        CountryB = Instantiate(ElementsGeneric);
        CountryC = Instantiate(ElementsGeneric);
        CountryD = Instantiate(ElementsGeneric);
        CountryE = Instantiate(ElementsGeneric);
        CountryF = Instantiate(ElementsGeneric);
    }



}
