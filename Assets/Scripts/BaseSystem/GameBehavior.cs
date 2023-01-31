using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using CustomExtensions;
using static UnityEngine.Debug;

namespace BaseSystem
{
    public class GameBehavior : MonoBehaviour
    {
        //private string _state;

        public bool showWinScreen = false;
        
        public string labelText = "Найдите все 5 звёзд!";
        public int maxItems = 5;

      //  public bool showLossScreen = false;

        private int _itemsCollected = 0;

        public int Items
        {
            get { return _itemsCollected; }
            set
            {
                _itemsCollected = value;
                LogFormat("Звёзд : {0}", _itemsCollected);

                if (_itemsCollected >= maxItems)
                {
                    labelText = "Вы нашли все звёзды!";
                    showWinScreen = true;
                    Time.timeScale = 0f;
                }
                else
                {
                    labelText = "Звезда найдена! Осталось " + (maxItems - _itemsCollected);
                }
            }
        }

        private void OnGUI()
        {
            GUI.Box(new Rect(20, 20, 150, 25), "Смертей игрока:" + Utilities.playerDeaths);
            GUI.Box(new Rect(20, 50, 150, 25), "Найдено звёзд: " + _itemsCollected +"/" + maxItems);
            
            //GUI.Box(new Rect(20, 100, 150, 25), "Найдено звёзд: " + _itemsCollected +"/" + maxItems);

            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

            if (showWinScreen)
            {
                GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "ПОБЕДА!");

                Utilities.RestartLevel(0);
            }

           /* if (showLossScreen)
            {
                GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You lose...");

                Utilities.RestartLevel();
            }*/
        }
    }
}