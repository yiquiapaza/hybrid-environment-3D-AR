using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[AddComponentMenu("Scripts/Main")]
public class Main : MonoBehaviour
{

    [SerializeField]
    private TextMeshPro title = null;
    [SerializeField]
    private TextMeshPro description = null;

    // Start is called before the first frame update
    void Start()
    {
        title.text = "test";
        description.text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateTitle()
    { 
    
    }
}
