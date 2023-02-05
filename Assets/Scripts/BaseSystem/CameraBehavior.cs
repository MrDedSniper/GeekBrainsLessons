using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BaseSystem
{
    public class CameraBehavior : MonoBehaviour
    {
        private static Animator _animator;
        
        /*public Vector3 camOffset = new Vector3(0f, 0f, 0f);
        private Transform target;*/

        private void Start()
        {
          //  target = GameObject.Find("Player").transform;
            _animator = GetComponent <Animator>();
        }

       /* private void LateUpdate()
        {
            transform.position = target.TransformPoint(camOffset);
            transform.LookAt(target);
        }*/

        public static void CameraShake()
        {
            _animator.SetTrigger("GetItem");
        }
    }
}