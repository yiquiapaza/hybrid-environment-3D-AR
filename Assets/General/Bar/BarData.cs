using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using SimpleJSON;

namespace BarChart
{
    public class BarData : MonoBehaviour, IMixedRealityFocusHandler
    {
        #region Features
        [SerializeField] TextAsset _data;
        [SerializeField] GameObject _message;

        private string[] data;
        private JSONArray _tempData;
        private GameObject message;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            message = Instantiate(_message);
            message.SetActive(false);
            _tempData = (JSONArray)JSON.Parse(_data.text);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnFocusEnter(FocusEventData eventData)
        {
            if (CoreServices.InputSystem.GazeProvider.GazeTarget != null)
            {
                message.SetActive(true);
                Debug.Log("==" + eventData.ToString());
                GameObject temp = CoreServices.InputSystem.GazeProvider.GazeTarget;
                string[] data = CoreServices.InputSystem.GazeProvider.GazeTarget.name.Split('-');

                if(data.IsNull())
                {
                    Debug.Log(data[0]);
                    Debug.Log(data[1]);
                    Debug.Log(data[2]);
                }
                //var temData = _tempData[Int16.Parse(data[1])]["parameter"];

                //tmpGameObject = _message.transform.GetChild(1).gameObject;
                //tmpGameObject.GetComponent<TextMeshPro>().text = _tempData[Int16.Parse(data[1])]["parameter"] + "\n" + _tempData[Int16.Parse(data[1])]["parameter3"][Int16.Parse(data[2])];
                //Debug.Log(tmpGameObject.name);
                message.transform.SetPositionAndRotation(new Vector3(gameObject.transform.position.x, 2 * gameObject.transform.position.y + 0.2f, gameObject.transform.position.z), Quaternion.LookRotation(Camera.main.transform.forward));

            }
        }

        public void OnFocusExit(FocusEventData eventData)
        {
            message.SetActive(false);
        }
    }

}
