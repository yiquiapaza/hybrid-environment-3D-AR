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
        UpdatePopulation(1975);

        CountryA.GetComponent<ToolTipSpawner>().toolTipText = genericObjects.countries[0].country;

        Debug.Log(CountryA.transform.position);
        Debug.Log(CountryB.transform.position);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdaPosition(GameObject country, GenericObjects genericObjects, int index)
    {

    }

    void UpdatePopulation(int year)
    {
        switch ( year )
        {
            case 1975:
                CountryA.transform.position = new Vector3(InitialPosition.x, InitialPosition.y, InitialPosition.z);
                CountryB.transform.position = new Vector3(InitialPosition.x + 0.05f, InitialPosition.y, InitialPosition.z);
                break;
        }
    }

    void InstantiateAllObjets()
    {
        CountryA = Instantiate(ElementsGeneric);
        CountryB = Instantiate(ElementsGeneric);
    }



}
