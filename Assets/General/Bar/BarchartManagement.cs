using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarchartManagement : MonoBehaviour
{
    [SerializeField]
    public GameObject BarElement;
    [SerializeField]
    public int Length;

    private GameObject TempObj;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; Length > i; i++)
        {
            TempObj = Instantiate(BarElement) as GameObject;
            TempObj.transform.parent = transform;
            UpdateBarPosition(TempObj, i);
            UpdateBarSize(TempObj, i);
            TempObj.transform.localScale = transform.localScale;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateBarPosition(GameObject gameObject, int index)
    {
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.transform.localPosition = new Vector3(
            (gameObject.transform.localPosition.x + gameObject.transform.localScale.x * index * 0.6f) / gameObject.transform.localScale.x, 0, 0);
    }

    void UpdateBarSize(GameObject gameObject, float size = 0)
    {
        Debug.Log(gameObject.transform.lossyScale);
        gameObject.GetComponent<BoxCollider>().size = 

            new Vector3(gameObject.transform.localScale.x, Random.Range(0, 2) * gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        Debug.Log(Random.Range(0f, 20.0f));
    }

}
