using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[AddComponentMenu("Scripts/BarChartComponent")]
public class BarChartComponent : MonoBehaviour
{
    private bool activeComponent = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveGameObject()
    {
        gameObject.SetActive(activeComponent);
        activeComponent = !activeComponent;
    }
}
