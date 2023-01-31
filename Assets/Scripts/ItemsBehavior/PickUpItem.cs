using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemsBehavior
{
    public class PickUpItem : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                Destroy(transform.gameObject);
            }
        }
    }
}