using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

public class LoadFile:MonoBehaviour
{
    private UtilIO IO;
    private void Start()
    {
        IO = new UtilIO();
        Debug.Log(IO.ReadFile("Data", "data.json", gameObject));
    }

}