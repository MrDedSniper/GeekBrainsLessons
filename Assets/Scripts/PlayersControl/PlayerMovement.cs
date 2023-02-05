using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace PlayersControl
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private Animator _animator;

        public float moveSpeed;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            
            try
            {
                _animator = GetComponent<Animator>();
            }
            catch (Exception e)
            {
                Debug.Log($"No Animator: {e.Message}");
                throw;
            }

            moveSpeed = 15f;
        }

        private void FixedUpdate()
        {
           if (Input.GetKey (KeyCode.W)) _rigidbody.AddForce(0f, 0f, 1f * moveSpeed);
           if (Input.GetKey (KeyCode.S)) _rigidbody.AddForce(0f, 0f, -1f * moveSpeed);
           if (Input.GetKey (KeyCode.D)) _rigidbody.AddForce(1f * moveSpeed, 0f, 0f);
           if (Input.GetKey (KeyCode.A)) _rigidbody.AddForce(-1f * moveSpeed, 0f, 0f);

        }
    }
}