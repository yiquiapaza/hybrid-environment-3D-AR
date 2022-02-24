using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ScatterPlot3D : MonoBehaviour
{
    [Tooltip("Object Template, with this you can manipulate position, traslation and size")]
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
        TemplateObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        TemplateObject.AddComponent<Animation>();
        gameObject.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        GetData();
        InitialInstantiateObjects();
        //StartCoroutine(WaitOneSecond());
    }

    // Update is called once per frame
    void Update()
    {   

    }

    public IEnumerator ObjectsUpdate()
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
                Debug.Log(client.downloadHandler.text);
            }
        }
    }
    public IEnumerator WaitOneSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            yield return StartCoroutine(ObjectsUpdate());
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

        InitialMaterialObjects();
        CreateAnimation(CountryA, Constants.COUNTRY_A_POPULATION, Constants.COUNTRY_A_GDP_PER_CAPITA, Constants.COUNTRY_A_ENERGY_CONSUMPTION);
        CreateAnimation(CountryB, Constants.COUNTRY_B_POPULATION, Constants.COUNTRY_B_GDP_PER_CAPITA, Constants.COUNTRY_B_ENERGY_CONSUMPTION);
        CreateAnimation(CountryC, Constants.COUNTRY_C_POPULATION, Constants.COUNTRY_C_GDP_PER_CAPITA, Constants.COUNTRY_C_ENERGY_CONSUMPTION);
        CreateAnimation(CountryD, Constants.COUNTRY_D_POPULATION, Constants.COUNTRY_D_GDP_PER_CAPITA, Constants.COUNTRY_D_ENERGY_CONSUMPTION);
        CreateAnimation(CountryE, Constants.COUNTRY_E_POPULATION, Constants.COUNTRY_E_GDP_PER_CAPITA, Constants.COUNTRY_E_ENERGY_CONSUMPTION);
        CreateAnimation(CountryF, Constants.COUNTRY_F_POPULATION, Constants.COUNTRY_F_GDP_PER_CAPITA, Constants.COUNTRY_F_ENERGY_CONSUMPTION);
        CreateAnimation(CountryG, Constants.COUNTRY_G_POPULATION, Constants.COUNTRY_G_GDP_PER_CAPITA, Constants.COUNTRY_G_ENERGY_CONSUMPTION);
        CreateAnimation(CountryH, Constants.COUNTRY_H_POPULATION, Constants.COUNTRY_H_GDP_PER_CAPITA, Constants.COUNTRY_H_ENERGY_CONSUMPTION);
        CreateAnimation(CountryI, Constants.COUNTRY_I_POPULATION, Constants.COUNTRY_I_GDP_PER_CAPITA, Constants.COUNTRY_I_ENERGY_CONSUMPTION);
        CreateAnimation(CountryJ, Constants.COUNTRY_J_POPULATION, Constants.COUNTRY_J_GDP_PER_CAPITA, Constants.COUNTRY_J_ENERGY_CONSUMPTION);
        CreateAnimation(CountryK, Constants.COUNTRY_K_POPULATION, Constants.COUNTRY_K_GDP_PER_CAPITA, Constants.COUNTRY_K_ENERGY_CONSUMPTION);
        CreateAnimation(CountryN, Constants.COUNTRY_N_POPULATION, Constants.COUNTRY_N_GDP_PER_CAPITA, Constants.COUNTRY_N_ENERGY_CONSUMPTION);

        CreateAnimation(CountryM, Constants.COUNTRY_M_POPULATION, Constants.COUNTRY_M_GDP_PER_CAPITA, Constants.COUNTRY_M_ENERGY_CONSUMPTION);
        CreateAnimation(CountryO, Constants.COUNTRY_O_POPULATION, Constants.COUNTRY_O_GDP_PER_CAPITA, Constants.COUNTRY_O_ENERGY_CONSUMPTION);
        CreateAnimation(CountryP, Constants.COUNTRY_P_POPULATION, Constants.COUNTRY_P_GDP_PER_CAPITA, Constants.COUNTRY_P_ENERGY_CONSUMPTION);

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
        
    }

    void SelectCountry(Country country)
    {
        InitialMaterialObjects();
        Debug.Log(country.status);
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
    }

    void GetData()
    {   
        StartCoroutine(GetDataServer());
    }

    void CreateAnimation(GameObject gameObject, float[] scaleData, float[] positionXData, float[] positionYData)
    {
        Animation animation = gameObject.GetComponent<Animation>();
        Keyframe[] positionX, positionY, scale;
        positionX = new Keyframe[26];
        positionY = new Keyframe[26];
        scale = new Keyframe[26];
        float time = 0.0f;
        for (int i = 0; i < scaleData.Length; i++)
        {
            scale[i] = new Keyframe(time, Util.ScalePopulation(scaleData[i]));
            positionX[i] = new Keyframe(time, gameObject.transform.localPosition.x + Util.ScaleGDPPercapita(positionXData[i]));
            positionY[i] = new Keyframe(time, gameObject.transform.localPosition.y + Util.ScaleEnergyConsumption(positionYData[i]));
            time += 0.30f;
        }
        AnimationCurve scaleCurve = new AnimationCurve(scale);
        AnimationCurve positionxCuerve = new AnimationCurve(positionX);
        AnimationCurve positionyCuerve = new AnimationCurve(positionY);
        AnimationClip animationClip;
        animationClip = new AnimationClip();
        animationClip.legacy = true;
        animationClip.SetCurve("", typeof(Transform), "localPosition.x", positionxCuerve);
        animationClip.SetCurve("", typeof(Transform), "localPosition.y", positionyCuerve);
        animationClip.SetCurve("", typeof(Transform), "localScale.x", scaleCurve);
        animationClip.SetCurve("", typeof(Transform), "localScale.y", scaleCurve);
        animationClip.SetCurve("", typeof(Transform), "localScale.z", scaleCurve);
        animation.AddClip(animationClip, "Animation" + gameObject.name);
        animation.wrapMode = WrapMode.Loop;
        animation.Play("Animation"+gameObject.name);
    }


}
