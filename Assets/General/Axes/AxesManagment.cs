using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxesManagment : MonoBehaviour
{

    [SerializeField]
    private bool _flipX = false;
    [SerializeField]
    private string _labeX;
    [SerializeField]
    private bool _activeX = false;
    [SerializeField]
    private bool _swapped = false;

    [SerializeField]
    private bool _flipY;
    [SerializeField]
    private string _labelY;
    [SerializeField]
    private bool _activeY;


    [SerializeField]
    private bool _flipZ;
    [SerializeField]
    private string _labeZ;
    [SerializeField]
    private bool _activeZ;

    private GameObject AxesX;

    // Start is called before the first frame update
    void Start()
    {
        SetFeatures();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetFeatures ()
    {
        AxesX = gameObject.transform.GetChild(0).gameObject;
        AxesX.GetComponent<GenericAxisPrefab>()._nameAxisLabel = _labeX;
        AxesX.GetComponent<GenericAxisPrefab>()._swapped = _swapped;
        AxesX.SetActive(_activeX);
        if(_flipX)
            AxesX.transform.eulerAngles = new Vector3(AxesX.transform.rotation.y, 180f, AxesX.transform.rotation.z);
    }
}
