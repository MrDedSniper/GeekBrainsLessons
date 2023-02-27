using UnityEditor;
using UnityEngine;

public class ExtendedScriptMethod : MonoBehaviour
{
    public int count = 10;
    public int offset = 1;
    public GameObject obj;

    public float Test;
    private Transform _root;

    private void Start()
    {
        CreateObj();
    }

    public void CreateObj()
    {
        _root = new GameObject("Root").transform;
        for (var i = 1; i <= count; i++)
        {
            Instantiate(obj, new Vector3(0, offset * i, 0),
                Quaternion.identity, _root);
        }
    }
    public void AddComponent()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<MeshRenderer>();
        gameObject.AddComponent<BoxCollider>();
    }
    public void RemoveComponent()
    {
        DestroyImmediate(GetComponent<Rigidbody>());
        DestroyImmediate(GetComponent<MeshRenderer>());
        DestroyImmediate(GetComponent<BoxCollider>());
    }
}



