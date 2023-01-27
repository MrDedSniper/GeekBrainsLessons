using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseSystem
{
    public class CameraBehavior : MonoBehaviour
    {
        //public Vector3 camOffset = new Vector3(0f, 8.67f, -9.29f);
        public Vector3 camOffset = new Vector3(0f, 0f, 0f);
        private Transform target;

        private void Start()
        {
            target = GameObject.Find("Player").transform;
        }

        private void LateUpdate()
        {
            transform.position = target.TransformPoint(camOffset);
            transform.LookAt(target);
        }
    }
}