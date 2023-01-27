using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayersControl
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector3 _direction;

        private float vInput;
        private float hInput;

        private Animator _animator;

        public float moveSpeed = 10f;
        public float strafeSpeed = 8f;
        public float rotateSpeed = 10f;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        void Update()
        {
            var speed = _direction * moveSpeed * Time.deltaTime;

            _direction.x = Input.GetAxis("Horizontal");
            _direction.z = Input.GetAxis("Vertical");

            transform.Translate(speed);
            transform.Rotate(Vector3.up * rotateSpeed * Input.GetAxis("Mouse X"));
        }
    }
}