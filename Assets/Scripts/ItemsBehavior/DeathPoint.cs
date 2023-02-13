using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace ItemsBehavior
{
    public class DeathPoint : PickUpItem
    {
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
                    FindObjectOfType<BaseSystem.GameBehavior>().showLossScreen.SetActive(true);
                    Utilities.PlusDeathCount();
                }
            }
        }
    }
}


