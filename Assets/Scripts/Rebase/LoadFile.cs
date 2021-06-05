using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

public class LoadFile:MonoBehaviour
{
    private void Start()
    {
        
        Debug.Log(UtilIO.ReadFile("Data", "data.json", gameObject));
    }

}