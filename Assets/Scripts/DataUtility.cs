using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class DataUtility : MonoBehaviour
{
    [SerializeField]
    TextAsset Data;

    JSONArray example;

    // Start is called before the first frame update
    void Start()
    {
        example = (JSONArray)JSON.Parse(Data.text);
        Debug.Log(example.ToString());
        Debug.Log(example[0]["country"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
