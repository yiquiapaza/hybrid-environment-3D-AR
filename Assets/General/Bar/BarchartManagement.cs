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
        #region Features
        [SerializeField] GameObject _barElement;
        [SerializeField] int _countries;
        [SerializeField] int _years;
        [SerializeField] Material _materialCountry1;
        [SerializeField] Material _materialCountry2;
        [SerializeField] Material _materialCountry3;
        [SerializeField] Material _materialCountry4;
        [SerializeField] Material _materialCountry5;
        [SerializeField] Material _materialCountry6;
        [SerializeField] Material _materialCountry7;
        [SerializeField] Material _materialCountry8;

        private GameObject TempObj;
        private Vector3 _relativeScale;
        private Vector3 _relativePostion;


        #endregion
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
                    UpdateBarSizeMessage(TempObj);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        void UpdateBarPosition(GameObject gameObject, int index, int indexY)
        {
            Vector3 gameParentPosition = gameObject.transform.localPosition;
            Debug.Log(gameParentPosition);
            _relativePostion = gameObject.transform.localPosition;
            gameObject = gameObject.transform.GetChild(0).gameObject;
            Debug.Log(gameObject.transform.position);
            gameObject.transform.localPosition = Vector3.zero;
            gameObject.transform.localPosition = new Vector3(
                0.2f + gameObject.transform.localScale.x / transform.localScale.x + (gameObject.transform.localPosition.x + gameObject.transform.localScale.x * index * 0.6f) / gameObject.transform.localScale.x,
                ( gameParentPosition.y / 2 + gameParentPosition.y),
                -0.2f - gameObject.transform.localScale.x / transform.localScale.z - (gameObject.transform.localPosition.z + gameObject.transform.localScale.z * indexY * 0.6f / gameObject.transform.localScale.z));
        }

        void UpdateBarSize(GameObject gameObject, float size = 0)
        {
            _relativeScale = gameObject.transform.localScale;
            gameObject = gameObject.transform.GetChild(0).gameObject;
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x / _relativeScale.x , 
                Random.Range(0f, gameObject.transform.localScale.y / _relativeScale.y), 
                gameObject.transform.localScale.z / _relativeScale.z);
            Debug.Log(gameObject.transform.localScale);
        }

        #region Material
        void SetMaterial(GameObject gameObject, int index)
        {
            gameObject = gameObject.transform.GetChild(0).gameObject;
            switch (index)
            {
                case (int) MaterialSelector.ObjectA:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry1;
                    break;
                case (int) MaterialSelector.ObjectB:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry2;
                    break;
                case (int)MaterialSelector.ObjectC:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry3;
                    break;
                case (int)MaterialSelector.ObjectD:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry4;
                    break;
                case (int)MaterialSelector.ObjectE:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry5;
                    break;
                case (int)MaterialSelector.ObjectF:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry6;
                    break;
                case (int)MaterialSelector.ObjectG:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry7;
                    break;
                case (int)MaterialSelector.ObjectH:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry8;
                    break;
            }
        }
        #endregion

        void UpdateBarSizeMessage(GameObject gameObject)
        {
            gameObject = gameObject.transform.GetChild(1).gameObject;
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
