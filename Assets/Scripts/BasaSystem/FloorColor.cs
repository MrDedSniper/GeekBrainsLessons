using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseSystem
{
    public class FloorColor : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.GetComponent<MeshRenderer>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {

            }
        }
    }
}