using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Features : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Vector3 InitialScale;

    [SerializeField]
    private GameObject Axis;

    private Vector3 InitialBoxCollider;

    Vector3 TempScale;
    Vector3 TempCollider;

    void Start()
    {
        InitialScale = transform.localScale;
        InitialBoxCollider = GetComponent<BoxCollider>().size;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateBar();
    }

    private void UpdateBar()
    {
        if (!InitialScale.Equals(TempScale))
        {
            UpdateScale();
        }
        if (!InitialBoxCollider.Equals(TempCollider))
        {
            UpdateCollider();
        }
    }

    private void UpdateScale()
    {
        TempScale = InitialScale;
        transform.localScale = InitialScale;
    }

    private void UpdateCollider()
    {
        TempCollider = InitialBoxCollider;
        GetComponent<BoxCollider>().size = InitialScale;
    }

    private void Resize(float amount)
    {
        transform.position
    }
}
