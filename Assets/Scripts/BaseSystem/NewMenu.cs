using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewMenu : MonoBehaviour
{
    [MenuItem("MyButton/Вызов окна %n")]
    private static void NewMenuOption()
    {
        EditorWindow.GetWindow(typeof(MyWindow), true, "Окно для домашнего задания");
    }
    
    [MenuItem("MyButton/Выпадающее меню/Пустое меню")]
    [MenuItem("MyButton/Выпадающее меню/Пустое меню 2")]
    [MenuItem("MyButton/Выпадающее меню/Пустое меню 3")]
    static void MenuOption()
    {
            
    }
}

public class MyWindow : EditorWindow
{
    public static GameObject ObjectInstantiate;
    public string _typeName = "Напишите имя объекта";
    public int _countObject = 1;
    public float _radius = 10;

    private void OnGUI()
    {
        GUILayout.Label("Генерация объекта на сцене", EditorStyles.boldLabel);
        
        _typeName = EditorGUILayout.TextField("Имя объекта", _typeName);

        ObjectInstantiate = EditorGUILayout.ObjectField("Вставить объект", ObjectInstantiate, 
            typeof(GameObject), true) as GameObject;

        _countObject = EditorGUILayout.IntSlider("Количество объектов", _countObject, 1, 10);
        
        _radius = EditorGUILayout.Slider("В каком радиусе", _radius, 5, 30);

        var button = GUILayout.Button("Создать");
        if (button)
        {
            if (ObjectInstantiate)
            {
                GameObject root = new GameObject("Root");
                for (int i = 0; i < _countObject; i++)
                {
                    float angle = i * Mathf.PI * 2 / _countObject;
                    Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle) * _radius);
                    GameObject temp = Instantiate(ObjectInstantiate, pos, Quaternion.identity);
                    temp.name = _typeName + "(" + i + ")";
                    temp.transform.parent = root.transform;
                    var tempRenderer = temp.GetComponent<Renderer>();
                }
            }
        }
    }
}
