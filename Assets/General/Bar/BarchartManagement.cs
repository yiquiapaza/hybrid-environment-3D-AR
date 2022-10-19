using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Microsoft.MixedReality.Toolkit;


namespace BarChart
{
    #region Materials
    public enum MaterialSelector
    {
        ObjectA = 1,
        ObjectB = 2,
        ObjectC = 3,
        ObjectD = 4,
        ObjectE = 5,
        ObjectF = 6,
        ObjectG = 7,
        ObjectH = 8
    }
    #endregion

    public class BarchartManagement : MonoBehaviour
    {
        #region Features
        [SerializeField] GameObject _barElement;
        [SerializeField] GameObject _message;
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
        private Vector3 _relativePosition;


        #endregion
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 1; _countries >= i; i++) // Country
            {
                for (int j = 1; _years >= j; j++)
                {
                    TempObj = Instantiate(_barElement) as GameObject;
                    TempObj.transform.parent = transform;
                    UpdateBarSize(TempObj, i);
                    UpdateBarPosition(TempObj, i, j);
                    SetMaterial(TempObj, i);
                }
            }

            StartCoroutine(WaitServer());
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
                Random.Range(0f, gameObject.transform.localScale.y / _relativeScale.y), 
                gameObject.transform.localScale.z / _relativeScale.z);
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

        IEnumerator RequestServer()
        {
            using (UnityWebRequest request = UnityWebRequest.Get(Constants.ENDPOINT_RAWDATA))
            {
                yield return request.SendWebRequest();
                if (request.isHttpError || request.isNetworkError)
                {
                    Debug.Log(request.error);
                }
                else
                {
                    Debug.Log(request.downloadHandler.text);
                }

            }
        }

        IEnumerator WaitServer()
        {
            while (true)
            {
                StartCoroutine(RequestServer());
                Debug.Log("Wait for next Update");
                yield return new WaitForSecondsRealtime(1f);
            }
        }
    }
}












