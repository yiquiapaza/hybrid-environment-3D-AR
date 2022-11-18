using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System;

namespace ScatterPlot
{
    public static class MaterialSlector
    {
        public const string CATEGORY1 = "OC";
        public const string CATEGORY2 = "AS";
        public const string CATEGORY3 = "EU";
        public const string CATEGORY4 = "AF";
        public const string CATEGORY5 = "NA";
        public const string CATEGORY6 = "01";
        public const string CATEGORY7 = "02";
        public const string CATEGORY8 = "03";
    }

    public class ScatterPlotManagement : MonoBehaviour
    {
        // Start is called before the first frame update
        #region Input Features
        [SerializeField] GameObject _scatterElement;

        [SerializeField] Material _materialCategory1;
        [SerializeField] Material _materialCategory2;
        [SerializeField] Material _materialCategory3;
        [SerializeField] Material _materialCategory4;
        [SerializeField] Material _materialCategory5;
        [SerializeField] Material _materialCategory6;
        [SerializeField] Material _materialCategory7;
        [SerializeField] Material _materialCategory8;

        [SerializeField] TextAsset _data;

        #endregion


        #region Features
        private GameObject _tempObject;
        private JSONArray _tempData;
        #endregion

        void Start()
        {
            _tempData = (JSONArray)JSON.Parse(_data.text);
            for (int i = 1; _tempData.Count > i; i++)
            {
                if (_tempData[i]["status"])
                {
                    _tempObject = Instantiate(_scatterElement);
                    _tempObject.transform.parent = transform;
                    AddTagObject(_tempObject, i);
                }
            }
            UpdatePosition("parameter3", "parameter3", 2);
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void AddTagObject(GameObject tempObject, int i)
        {
            tempObject.name = string.Concat("scatter", i);
        }

        private void UpdatePosition(string x, string y, int value)
        {
            for (int i = 1; _tempData.Count > i; i++)
            {
                _tempObject = GameObject.Find("scatter" + i) as GameObject;
                Debug.Log(_tempObject.transform.localScale);
                Debug.Log(_tempObject.transform.position);
                Debug.Log(_tempObject.transform.localPosition);
                Debug.Log(_tempData[i][x]);
                _tempObject.transform.localPosition = new Vector3(_tempData[i][x][value], _tempData[i][y][value], 0);
            }
        }
    }

}
