using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BarChart
{
    public enum MaterialSelector
    {
        ObjectA,
        ObjectB,
        ObjectC,
        ObjectD,
        ObjectE,
        ObjectF,
        ObjectG,
        ObjectH
    }

    public class BarchartManagement : MonoBehaviour
    {
        [SerializeField]
        public GameObject _barElement;
        [SerializeField]
        public int _countries;
        [SerializeField]
        public int _years;
        [SerializeField]
        public Material _materialCountry1;
        [SerializeField]
        public Material _materialCountry2;
        [SerializeField]
        public Material _materialCountry3;
        [SerializeField]
        public Material _materialCountry4;
        [SerializeField]
        public Material _materialCountry5;
        [SerializeField]
        public Material _materialCountry6;
        [SerializeField]
        public Material _materialCountry7;
        [SerializeField]
        public Material _materialCountry8;

        private GameObject TempObj;

        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; _countries > i; i++) // Country
            {
                for (int j = 0; _years > j; j++)
                {
                    TempObj = Instantiate(_barElement) as GameObject;
                    TempObj.transform.parent = transform;
                    UpdateBarSize(TempObj, i);
                    UpdateBarPosition(TempObj, i, j);
                    SetMaterial(TempObj, i);
                    //TempObj.transform.localScale = transform.localScale;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        void UpdateBarPosition(GameObject gameObject, int index, int indexY)
        {
            gameObject.transform.localPosition = Vector3.zero;
            gameObject.transform.localPosition = new Vector3(
                (gameObject.transform.localPosition.x + gameObject.transform.localScale.x * index * 0.6f) / gameObject.transform.localScale.x,
                gameObject.transform.localScale.y / 2 + gameObject.transform.localPosition.y,
                -(gameObject.transform.localPosition.z + gameObject.transform.localScale.z * indexY * 0.6f / gameObject.transform.localScale.z));


        }

        void UpdateBarSize(GameObject gameObject, float size = 0)
        {
            gameObject.transform.localScale = new Vector3(transform.localScale.x, Random.Range(0f, transform.localScale.y), transform.localScale.y);
            Debug.Log(gameObject.transform.localScale);
        }

        void SetMaterial(GameObject country, int index)
        {
            switch (index)
            {
                case (int) MaterialSelector.ObjectA:
                    country.GetComponent<MeshRenderer>().material = _materialCountry1;
                    break;
                case (int) MaterialSelector.ObjectB:
                    country.GetComponent<MeshRenderer>().material = _materialCountry2;
                    break;
                case (int)MaterialSelector.ObjectC:
                    country.GetComponent<MeshRenderer>().material = _materialCountry3;
                    break;
                case (int)MaterialSelector.ObjectD:
                    country.GetComponent<MeshRenderer>().material = _materialCountry4;
                    break;
                case (int)MaterialSelector.ObjectE:
                    country.GetComponent<MeshRenderer>().material = _materialCountry5;
                    break;
                case (int)MaterialSelector.ObjectF:
                    country.GetComponent<MeshRenderer>().material = _materialCountry6;
                    break;
                case (int)MaterialSelector.ObjectG:
                    country.GetComponent<MeshRenderer>().material = _materialCountry7;
                    break;
                case (int)MaterialSelector.ObjectH:
                    country.GetComponent<MeshRenderer>().material = _materialCountry8;
                    break;
            }
        }
    }
}
