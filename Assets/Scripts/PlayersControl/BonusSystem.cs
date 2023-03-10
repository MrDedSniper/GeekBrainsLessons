using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayersControl
{
    public class BonusSystem : MonoBehaviour
    {
        private PlayerMovement _speedBonus; // Получаем скорость из скрипта PlayerMovement
        public bool isSpeed; // проверка бонуса скорости
        public bool isShielded; // проверка бонуса щита
        
        private void Awake()
        {
            _speedBonus = GetComponent<PlayerMovement>();
            isSpeed = false;
            isShielded = false;
        }
        
        private void Update()
        {
            if (isSpeed)
            {
                _speedBonus.moveSpeed = 30f;
            }
            else
            {
                _speedBonus.moveSpeed = 15f;
            }
        }
    }
}


