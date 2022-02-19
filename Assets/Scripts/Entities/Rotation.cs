using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Rotation 
{
    public float x;
    public float y;
    public float z;

    public static Rotation CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<Rotation>(jsonString);
    }
}
