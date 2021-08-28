using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Message : MonoBehaviour
{
    [SerializeField]
    private GameObject display;
    [SerializeField]
    private TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        display.GetComponent<Renderer>().material.color = Color.red;
        text.text = "Preuba";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
