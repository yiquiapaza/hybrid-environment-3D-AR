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

    private Animator AnimatorA;


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
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
