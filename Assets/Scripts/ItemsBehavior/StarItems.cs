using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemsBehavior
{
    public class StarItems : PickUpItem
    {
        public string labelText;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                GameObject.Find("GameController").GetComponent<BaseSystem.GameBehavior>().Items += 1;
                labelText = "Звезда собрана!";
                Destroy(gameObject);
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);
        }
    }
}