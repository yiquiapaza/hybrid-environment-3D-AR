using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class Countries : MonoBehaviour
{
    [Header("Put the GameObject with name CountryA")]
    [Tooltip("Select GameObject with name Country A")]
    public GameObject countryA = null;

    [Header("Put the GameObject with name CountryB")]
    [Tooltip("Select GameObject with name Country B")]
    public GameObject countryB = null;

    [Header("Put the GameObject with name CountryC")]
    [Tooltip("Select GameObject with name Country C")]
    public GameObject countryC = null;

    [Header("Put the GameObject with name Country D")]
    [Tooltip("Select GameObject with name Country D")]
    public GameObject countryD = null;

    [Header("Put the GameObject with name Country E")]
    [Tooltip("Select GameObject with name Country E")]
    public GameObject countryE = null;

    [Header("Put the GameObject with name Country F")]
    [Tooltip("Select GameObject with name Country F")]
    public GameObject countryF = null;

    [Header("Put the GameObject with name Country G")]
    [Tooltip("Select GameObject with name Country G")]
    public GameObject countryG = null;

    [Header("Put the GameObject with name Country H")]
    [Tooltip("Select GameObject with name Country H")]
    public GameObject countryH = null;

    [Header("Put the GameObject with name Country I")]
    [Tooltip("Select GameObject with name Country I")]
    public GameObject countryI = null;

    [Header("Put the GameObject with name Country J")]
    [Tooltip("Select GameObject with name Country J")]
    public GameObject countryJ = null;

    [Header("Put the GameObject with name Country K")]
    [Tooltip("Select GameObject with name Country K")]
    public GameObject countryK = null;

    [Header("Put the GameObject with name Country L")]
    [Tooltip("Select GameObject with name Country L")]
    public GameObject countryL = null;

    [Header("Put the GameObject with name Country M")]
    [Tooltip("Select GameObject with name Country M")]
    public GameObject countryM = null;

    [Header("Put the GameObject with name Country N")]
    [Tooltip("Select GameObject with name Country N")]
    public GameObject countryN = null;
    // Start is called before the first frame update

    [Header("Put the GameObject with name Country O")]
    [Tooltip("Select GameObject with name Country O")]
    public GameObject countryO = null;

    [Header("Put the GameObject with name Country P")]
    [Tooltip("Select GameObject with name Country P")]
    public GameObject countryP = null;

    [Header("Slider year")]
    [Tooltip("Select GameObject Slider")]
    public GameObject valueSlider;


    private int flag = 1975;

    void Start()
    {
        UpdatePosition(flag);
        UpdateScale(flag);
        Debug.Log(valueSlider.GetComponent<PinchSlider>().SliderValue);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Util.Year(valueSlider.GetComponent<PinchSlider>().SliderValue) != flag) 
        {
            UpdatePosition(Util.Year(valueSlider.GetComponent<PinchSlider>().SliderValue));
            UpdateScale(Util.Year(valueSlider.GetComponent<PinchSlider>().SliderValue));
            flag = Util.Year(valueSlider.GetComponent<PinchSlider>().SliderValue);
        }
    }

    void UpdatePosition(int year) 
    {
        countryA.gameObject.transform.localPosition = CountryA.GetDataFirtsExperiment(year);
        countryB.gameObject.transform.localPosition = CountryB.GetDataFirtsExperiment(year);
        countryC.gameObject.transform.localPosition = CountryC.GetDataFirtsExperiment(year);
        countryD.gameObject.transform.localPosition = CountryD.GetDataFirtsExperiment(year);
        countryE.gameObject.transform.localPosition = CountryE.GetDataFirtsExperiment(year);
        countryF.gameObject.transform.localPosition = CountryF.GetDataFirtsExperiment(year);
    }

    void UpdateScale(int year)
    {
        countryA.gameObject.transform.localScale = CountryA.GetScale(year);
        countryB.gameObject.transform.localScale = CountryB.GetScale(year);
        countryC.gameObject.transform.localScale = CountryC.GetScale(year);
        countryD.gameObject.transform.localScale = CountryD.GetScale(year);
        countryE.gameObject.transform.localScale = CountryE.GetScale(year);
        countryF.gameObject.transform.localScale = CountryF.GetScale(year);
    }

}
