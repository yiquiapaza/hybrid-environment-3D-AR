using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Country 
{
    public string name;
    public int state;

    public static Country CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<Country>(jsonString);
    }
}
