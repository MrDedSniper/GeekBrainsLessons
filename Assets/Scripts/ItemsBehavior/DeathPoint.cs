using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemsBehavior
{
    public class DeathPoint : PickUpItem
    {

        public bool showLossScreen = false;

        private Delegate _shockCameraDelegate;

        private void Start()
        {
            _shockCameraDelegate = DelegateCamera;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                if (collision.gameObject.GetComponent<PlayersControl.BonusSystem>().isShielded)
                {
                    Destroy(gameObject);
                    collision.gameObject.GetComponent<PlayersControl.BonusSystem>().isShielded = false;
                }
                else
                {
                    showLossScreen = true;
                    DelegateCamera();
                    Time.timeScale = 0f;
                    Utilities.RestartLevel();
                }
            }
        }

        private static void DelegateCamera()
        {
            BaseSystem.CameraBehavior.CameraShake();
        }

        private void OnGUI()
        {
            if (showLossScreen)
            {
                GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You lose...");
            }
            
        }
    }
}


