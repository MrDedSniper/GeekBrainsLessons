using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayersControl
{
    public class Player2Movement : PlayerMovement
    {
        private Vector3 _direction;
        
        private Animator _animator;
        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        void Update()
        {
            var speed = _direction * moveSpeed * Time.deltaTime;

            _direction.x = Input.GetAxis("Horizontal2");
            _direction.z = Input.GetAxis("Vertical2");

            transform.Translate(speed);
            transform.Rotate(Vector3.up * rotateSpeed * Input.GetAxis("Mouse X"));
        }
    }
}