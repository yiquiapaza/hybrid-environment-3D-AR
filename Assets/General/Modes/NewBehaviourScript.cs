using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class NewBehaviourScript : MonoBehaviour, IMixedRealitySourceStateHandler
{
    [SerializeField] GameObject hand;
    private GameObject _hand;
    public void OnSourceDetected(SourceStateEventData eventData)
    {
        _hand.GetComponent<MeshRenderer>().material.color = Color.red;   
    }

    public void OnSourceLost(SourceStateEventData eventData)
    {
        _hand.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    // Start is called before the first frame update
    void Start()
    {
        _hand = Instantiate(hand);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
