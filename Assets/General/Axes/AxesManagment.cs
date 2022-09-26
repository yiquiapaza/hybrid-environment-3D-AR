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
    private bool _swappedX = false;

    [SerializeField]
    private bool _flipY;
    [SerializeField]
    private string _labelY;
    [SerializeField]
    private bool _activeY;
    [SerializeField]
    private bool _swappedY = false;

    [SerializeField]
    private bool _flipZ;
    [SerializeField]
    private string _labelZ;
    [SerializeField]
    private bool _activeZ;
    [SerializeField]
    private bool _swappedZ = false;

    private GameObject AxesX;
    private GameObject AxesY;
    private GameObject AxesZ;

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
        AxesX.GetComponent<GenericAxisPrefab>()._swapped = _swappedX;
        AxesX.SetActive(_activeX);
        if(_flipX)
            AxesX.transform.eulerAngles = new Vector3(AxesX.transform.rotation.x, 180f, AxesX.transform.rotation.z);

        AxesY = gameObject.transform.GetChild(1).gameObject;
        AxesY.GetComponent<GenericAxisPrefab>()._nameAxisLabel = _labelY;
        AxesY.GetComponent<GenericAxisPrefab>()._swapped = _swappedY;
        AxesY.SetActive(_activeY);
        if (_flipY)
            AxesY.transform.eulerAngles = new Vector3(180f, AxesY.transform.rotation.y, AxesY.transform.rotation.z);
        
        AxesZ = gameObject.transform.GetChild(2).gameObject;
        AxesZ.GetComponent<GenericAxisPrefab>()._nameAxisLabel = _labelZ;
        AxesZ.GetComponent<GenericAxisPrefab>()._swapped = _swappedZ;
        AxesZ.SetActive(_activeZ);
        if (_flipZ)
            AxesZ.transform.eulerAngles = new Vector3(AxesZ.transform.rotation.z, AxesY.transform.rotation.y, 180f);
    }
}
