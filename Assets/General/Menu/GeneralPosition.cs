using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GeneralPosition : MonoBehaviour, IMixedRealityInputHandler
{
    private Vector3 generalPosition;
    private WWWForm sendPosition = null;
    [SerializeField] GameObject temp;

    public void OnInputDown(InputEventData eventData)
    {
        StartCoroutine(SendPositionCorutine());
    }

    public void OnInputUp(InputEventData eventData)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetPosition ()
    {
        generalPosition = temp.transform.position;
    }

    IEnumerator SendPositionCorutine()
    {
        GetPosition();
        sendPosition = new WWWForm();
        sendPosition.AddField("x", generalPosition.x.ToString());
        sendPosition.AddField("y", generalPosition.y.ToString());
        sendPosition.AddField("z", generalPosition.z.ToString());

        using (UnityWebRequest client = UnityWebRequest.Post(Constants.ENDPOINT_POSITION_POST, sendPosition))
        {
            yield return client.SendWebRequest();
            if (client.isHttpError)
                Debug.LogError(client.error);
        }
    }
}
