using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using CustomExtensions;
using static UnityEngine.Debug;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace BaseSystem
{
    public class GameBehavior : MonoBehaviour
    {
        [SerializeField] public GameObject showLossScreen;
        [SerializeField] public GameObject showWinScreen;
        
        public string labelText = "Найдите все 5 звёзд!";
        public int maxItems = 5;

        private int _itemsCollected = 0;
        public static int starsStatistic = 0;

        public int Items
        {
            get { return _itemsCollected; }
            set
            {
                _itemsCollected = value;
                LogFormat("Звёзд : {0}", _itemsCollected);

                if (_itemsCollected >= maxItems)
                {
                    FindObjectOfType<BaseSystem.GameBehavior>().showWinScreen.SetActive(true);
                }
                else
                {
                    labelText = "Звезда найдена! Осталось " + (maxItems - _itemsCollected);
                }
            }
        }
        
        private void Awake()
        {
            FindObjectOfType<BaseSystem.GameBehavior>().showLossScreen.SetActive(false);
            FindObjectOfType<BaseSystem.GameBehavior>().showWinScreen.SetActive(false);
        }

        private void Update()
        {
            starsStatistic = Items;
        }

        private void FixedUpdate()
        {
            if (Input.GetKey (KeyCode.Escape)) Utilities.RestartLevel();
        }

        private void OnGUI()
        {
            GUI.Box(new Rect(20, 20, 150, 25), "Смертей игрока:" + Utilities.playerDeaths);
            GUI.Box(new Rect(20, 50, 150, 25), "Найдено звёзд: " + _itemsCollected +"/" + maxItems);
            
            //GUI.Box(new Rect(20, 100, 150, 25), "Найдено звёзд: " + _itemsCollected +"/" + maxItems);

            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);
        }

    }
}