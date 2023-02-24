using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using SimpleJSON;
using System;
using TMPro;

namespace BarChart
{
    #region Materials
    public static class MaterialSelector
    {
        public const string CATEGORY1 = "OC";
        public const string CATEGORY2 = "AS";
        public const string CATEGORY3 = "EU";
        public const string CATEGORY4 = "AF";
        public const string CATEGORY5 = "NA";
        public const string CATEGORY6 = "01";
        public const string CATEGORY7 = "02";
        public const string CATEGORY8 = "O3";
    }
    #endregion

    public class BarchartManagement : MonoBehaviour
    {
        #region Features
        [SerializeField] GameObject _barElement;
        [SerializeField] GameObject _message;
        [SerializeField] Material _materialCountry1;
        [SerializeField] Material _materialCountry2;
        [SerializeField] Material _materialCountry3;
        [SerializeField] Material _materialCountry4;
        [SerializeField] Material _materialCountry5;
        [SerializeField] Material _materialCountry6;
        [SerializeField] Material _materialCountry7;
        [SerializeField] Material _materialCountry8;

        [SerializeField] TextAsset _data;

        private GameObject TempObj;
        private Vector3 _relativeScale;
        private Vector3 _relativePosition;
        private readonly string _nameObject = "bar";
        private JSONArray _tempData;
        private string[] data;
        private float _temp = 0;

        #endregion
        // Start is called before the first frame update
        void Start()
        {
            _tempData = (JSONArray)JSON.Parse(_data.text);
            for (int i = 0; _tempData.Count > i; i++) 
            {
                for (int j = 0; _tempData[i]["parameter3"].Count > j; j++)
                {
                    TempObj = Instantiate(_barElement) as GameObject;
                    TempObj.transform.parent = transform;
                    UpdateBarSize(TempObj, _tempData[i]["parameter3"][j]);
                    UpdateBarPosition(TempObj, i, j);
                    SetMaterial(TempObj, _tempData[i]["parameter1"]);
                    AddNameObject(TempObj, i, j);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        void UpdateBarPosition(GameObject gameObject, int indexX, int indexz)
        {
            _relativePosition = gameObject.transform.localPosition;
            _relativeScale = gameObject.transform.localScale;
            if (indexz == 0 && indexX == 0)
            {
                gameObject.transform.localPosition = new Vector3(indexX + 0.25f, _relativeScale.y / 2, -indexz - 0.25f);
            }
            else
            {
                gameObject.transform.localPosition = new Vector3(indexX + 0.25f*(indexX +1) , _relativeScale.y / 2, -indexz - 0.25f * (indexz + 1));
            }
        }

        void UpdateBarSize(GameObject gameObject, float size = 0)
        {
            _relativeScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x / _relativeScale.x , 
                size*3f, 
                gameObject.transform.localScale.z / _relativeScale.z);
        }

        #region Material
        void SetMaterial(GameObject gameObject, string category)
        {
            switch (category)
            {
                case MaterialSelector.CATEGORY1:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry1;
                    break;
                case MaterialSelector.CATEGORY2:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry2;
                    break;
                case MaterialSelector.CATEGORY3:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry3;
                    break;
                case MaterialSelector.CATEGORY4:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry4;
                    break;
                case MaterialSelector.CATEGORY5:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry5;
                    break;
                case MaterialSelector.CATEGORY6:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry6;
                    break;
                case MaterialSelector.CATEGORY7:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry7;
                    break;
                case MaterialSelector.CATEGORY8:
                    gameObject.GetComponent<MeshRenderer>().material = _materialCountry8;
                    break;
            }
        }
        #endregion


        void AddNameObject(GameObject gameObject, int indexX, int indexY)
        {
            gameObject.name = string.Concat(_nameObject, "-", indexX, "-", indexY);
        }
    }
}












