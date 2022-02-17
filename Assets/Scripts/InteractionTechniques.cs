using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class InteractionTechniques : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 globalCoordinates = Vector3.zero;
    private Vector3 globlaTmp = Vector3.zero;

    private WWWForm rotationPost;

    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    void Start()
    {        

        globalCoordinates.x = gameObject.transform.rotation.x;
        globalCoordinates.y = gameObject.transform.rotation.y;
        globalCoordinates.z = gameObject.transform.rotation.z;

        StartCoroutine(ExampleCoroutine());
        ExampleVisualStudio2022();
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
        Debug.Log(gameObject.transform.rotation);
        new WaitForSeconds(1);

    }

    IEnumerator SendRotation()
    {        
        rotationPost = new WWWForm();

        rotationPost.AddField("x", gameObject.transform.rotation.x.ToString());
        rotationPost.AddField("y", gameObject.transform.rotation.y.ToString());
        rotationPost.AddField("z", gameObject.transform.rotation.z.ToString());
        using (UnityWebRequest client = UnityWebRequest.Post("http://192.168.0.104:3000/rotation", rotationPost)) 
        {
            yield return client.SendWebRequest();

            if (client.isHttpError || client.isHttpError)
            {
                Debug.Log(client.error);
            }
            else
            {
                globlaTmp.y = gameObject.transform.rotation.y;
                Debug.Log("Form upload complete!");
            }
        }
    }
    IEnumerator ExampleCoroutine()
    {
        while (true) 
        {
            yield return new WaitForSeconds(1F);
            StartCoroutine(SendRotation());
            ExampleToCallFunction();
        }
    }

    void ExampleToCallFunction() 
    {
        Debug.Log("Call A function");
    }

    void ExampleVisualStudio2022 ()
    {
        Debug.Log("Test");
    }
}
