using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Scripts/MenuMainVisualization")]
public class MenuMainVisualization : MonoBehaviour
{
    private float angle = 90f;
    private Vector3 scale;

    public void Start()
    {
        scale = transform.localScale;
    }

    public void Rotate()
    {
        transform.Rotate(0, angle, 0);
    }

    public void Low()
    {
        transform.localScale = new Vector3(scale.x * 0.5f, scale.y * 0.5f, scale.z * 0.5f);
    }

    public void Medium()
    {
        transform.localScale = new Vector3(scale.x , scale.y, scale.z );
    }

    public void High()
    {
        transform.localScale = new Vector3(scale.x * 1.5f, scale.y * 1.5f, scale.z * 1.5f);
    }
}
