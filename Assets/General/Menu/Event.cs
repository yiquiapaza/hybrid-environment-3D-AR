using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour, IMixedRealityInputHandler
{
    [SerializeField] GameObject BarChart;
    [SerializeField] GameObject ScatterPlot;

    private bool state;

    public void OnInputDown(InputEventData eventData)
    {
        if (state)
        {
            BarChart.SetActive(true);
            ScatterPlot.SetActive(false);
            gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
            state = false;
        }
        else
        {
            BarChart.SetActive(false);
            ScatterPlot.SetActive(true);
            gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            state = true;
        }
    }

    public void OnInputUp(InputEventData eventData)
    {

    }   


    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
