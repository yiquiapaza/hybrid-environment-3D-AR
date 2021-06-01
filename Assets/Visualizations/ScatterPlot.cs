using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class ScatterPlot : MonoBehaviour
{
    [SerializeField]
    GameObject Spheres = null;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(UtilIO.GenericObjectJson(UtilIO.ReadFile("Data", "data.json", gameObject)).country);
        Debug.Log("+++++++++++++++++++");
        Debug.Log(UtilIO.GenericObjecsJson(UtilIO.ReadFile("Data", "data1.json", gameObject)).countries[1].country);
        for (int i = 0; i < UtilIO.GenericObjecsJson(UtilIO.ReadFile("Data", "data1.json", gameObject)).countries.Count; i++)
        {
            var a = Instantiate(Spheres);
            a.GetComponent<ToolTipSpawner>().toolTipText = "Hello";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
