using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class DataUtility : MonoBehaviour
{
    JSONObject example;

    // Start is called before the first frame update
    void Start()
    {
        example = (JSONObject)JSON.Parse("{id:1, name: 'nuevo'}");
        Debug.Log(example.ToString());
        Debug.Log(example["name"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
