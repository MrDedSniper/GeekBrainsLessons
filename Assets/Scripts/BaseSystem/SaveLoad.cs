using System;
using System.Xml;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public Transform CurrentPlayerPosition;
    public int StarsCollected = BaseSystem.GameBehavior.starsStatistic;
    public static int totalDeaths = 0;

    void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Q))
            saveInfo();
		
        if(Input.GetKeyDown(KeyCode.E))
            if (PlayerPrefs.HasKey("PosX"))
                loadInfo();

        if(Input.GetKeyDown(KeyCode.R))
            PlayerPrefs.DeleteAll();
        
        Debug.Log(StarsCollected);
    }

    private void OnGUI()
    {
	    GUI.Label(new Rect(50, 100, 160, 50), "Q - Сохранение");
	    GUI.Label(new Rect(50, 120, 160, 50), "E - Загрузка");
	    GUI.Label(new Rect(50, 140, 160, 50), "R - Очистка");
    }

    public void saveInfo()
    {
	    Transform CurrentPlayerPosition = gameObject.transform;
        
		
        PlayerPrefs.SetFloat("PosX", CurrentPlayerPosition.position.x);  
        PlayerPrefs.SetFloat("PosY", CurrentPlayerPosition.position.y); 
        PlayerPrefs.SetFloat("PosZ", CurrentPlayerPosition.position.z);
        
        PlayerPrefs.SetInt("StarsGet", StarsCollected);
        
        PlayerPrefs.SetInt("Total Deaths", totalDeaths);
    }
	
    public void loadInfo()
    {
	    Transform CurrentPlayerPosition = gameObject.transform;
	
        Vector3 PlayerPosition = new Vector3(PlayerPrefs.GetFloat("PosX"), 
	        PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));

        CurrentPlayerPosition.position = PlayerPosition;
        
        GameObject.Find("GameController").GetComponent<BaseSystem.GameBehavior>().Items += StarsCollected;

        Utilities.playerDeaths = totalDeaths;
    }
}
