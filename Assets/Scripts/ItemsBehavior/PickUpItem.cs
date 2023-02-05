using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemsBehavior
{
    public class PickUpItem : MonoBehaviour
    {
        
        delegate void ShockCameraDelegate(); // делегат для потряхивания камеры
        private ShockCameraDelegate _shockCameraDelegate; 

       private void Start()
        {
            _shockCameraDelegate = DelegateCamera;
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                Destroy(transform.gameObject);
                DelegateCamera();
                _shockCameraDelegate = null; // сразу после использования отписываемся
            }
        }
        
        private static void DelegateCamera()
        {
            BaseSystem.CameraBehavior.CameraShake();
        }
    }
}