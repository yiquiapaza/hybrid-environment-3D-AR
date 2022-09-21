﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GenericAxisPrefab : MonoBehaviour
{
    [SerializeField]
    public TextMeshPro _axisLabelPrefab = null;
    [SerializeField]
    public Transform _axisRoot = null;
    [SerializeField]
    public bool _swapped = true;
    [SerializeField]
    public string _nameAxisLabel = null;

    private float _length = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        CreateAxisLabel(_nameAxisLabel);
    }

    private void CreateAxisLabel (string _axislabel)
    {
        var label = Instantiate(_axisLabelPrefab, _axisRoot.transform, false);
        float posX = _length / 2;
        float posY = _length / 16;
        if (!_swapped)
            posY *= -1;
        label.transform.localPosition = new Vector3(posX, posY, 0.0f);
        label.text = _axislabel;
    }

}
