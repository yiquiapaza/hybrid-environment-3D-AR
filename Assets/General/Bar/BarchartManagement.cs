using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using SimpleJSON;


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

        #endregion
        // Start is called before the first frame update
        void Start()
        {
            _tempData = (JSONArray)JSON.Parse(_data.text);
            for (int i = 0; _tempData.Count > i; i++) // Country
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
            ObjectInfo();
        }

        void UpdateBarPosition(GameObject gameObject, int index, int indexz)
        {
            _relativePosition = gameObject.transform.localPosition;
            _relativeScale = gameObject.transform.localScale;
            var tempChild = gameObject.transform.GetChild(0).gameObject;
            gameObject.transform.localPosition = new Vector3( 
                ( transform.position.x * _relativeScale.x ) + _relativePosition.x + 0.08f * index * (_relativeScale.x),
                (tempChild.transform.localScale.y / _relativeScale.y) + (tempChild.transform.localScale.y / 2 ) * _relativeScale.y , 
                ( -transform.position.z * _relativeScale.z ) - (_relativePosition.z + 0.08f * indexz * (_relativeScale.z)));
        }

        void UpdateBarSize(GameObject gameObject, float size = 0)
        {
            _relativeScale = gameObject.transform.localScale;
            gameObject = gameObject.transform.GetChild(0).gameObject;
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x / _relativeScale.x , 
                size, 
                gameObject.transform.localScale.z / _relativeScale.z);
        }

        #region Material
        void SetMaterial(GameObject gameObject, string category)
        {
            gameObject = gameObject.transform.GetChild(0).gameObject;
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

        void ObjectInfo ()
        {
            if (CoreServices.InputSystem.GazeProvider.GazeTarget)
            {
                var tempPosition = CoreServices.InputSystem.GazeProvider.GazeTarget.transform.position;
                _message.transform.SetPositionAndRotation(new Vector3(tempPosition.x, tempPosition.y + 0.08f, tempPosition.z), Quaternion.LookRotation(Camera.main.transform.forward));
            }
            else
            {
                _message.transform.position = new Vector3(0, 0, -10);
            }
        }
    
        void AddNameObject(GameObject gameObject, int indexX, int indexY)
        {
            gameObject = gameObject.transform.GetChild(0).gameObject;
            gameObject.name = string.Concat(_nameObject, indexX, indexY);
        }
    }
}












