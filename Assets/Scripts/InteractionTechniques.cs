using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class InteractionTechniques : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Vector3 globalCoordinates = Vector3.zero;

    void Start()
    {
        globalCoordinates.x = gameObject.transform.localPosition.x;
        globalCoordinates.y = gameObject.transform.localPosition.y;
        globalCoordinates.z = gameObject.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //TODO: implmentes these methods
    // Translation: move objects in both environment, send with the same data
    // Grab: grab objects in both enviroment with the same data
    // Rotation: rotation objects in the both environment with the same data.
    
    void GlobalRotation()
    {
        using(UnityWebRequest client = UnityWebRequest.Get("example")
        {

        }
    }
}
