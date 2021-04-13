using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GenericAxisPrefab : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _axisLabelPrefab = null;
    [SerializeField]
    private Transform _axisRoot = null;
    [SerializeField]
    private bool _swapped = true;
    [SerializeField]
    private string _nameAxisLabel = null;

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
        float posY = _length / 8;
        if (!_swapped)
            posY *= -1;
        label.transform.localPosition = new Vector3(posX, posY, 0.0f);
        label.text = _axislabel;
    }

}
