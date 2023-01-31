using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemsBehavior
{
    public class ShieldBonus : PickUpItem
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                collision.gameObject.GetComponent<PlayersControl.BonusSystem>().isShielded = true;
                collision.gameObject.GetComponent<PlayersControl.BonusSystem>().isSpeed = true;
            }
        }
    }
}

