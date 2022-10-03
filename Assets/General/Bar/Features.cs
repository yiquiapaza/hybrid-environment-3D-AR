using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BarChart
{
    public class Features : MonoBehaviour
    {
        // Start is called before the first frame update

        [SerializeField]
        public Vector3 _initialScale;

        private Vector3 InitialBoxCollider;

        Vector3 TempScale;
        Vector3 TempCollider;

        void Start()
        {
            _initialScale = transform.localScale;
            InitialBoxCollider = GetComponent<BoxCollider>().size;
        }

        // Update is called once per frame
        void Update()
        {
            UpdateBar();
        }

        private void UpdateBar()
        {
            if (!_initialScale.Equals(TempScale))
            {
                UpdateScale();
            }
            if (!InitialBoxCollider.Equals(TempCollider))
            {
                UpdateCollider();
            }
        }

        private void UpdateScale()
        {
            TempScale = _initialScale;
            transform.localScale = _initialScale;
        }

        private void UpdateCollider()
        {
            TempCollider = InitialBoxCollider;
            GetComponent<BoxCollider>().size = _initialScale;
        }

        private void Resize(float amount)
        {
        }
    }

}
