using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class test3 : MonoBehaviour
{
    [MenuItem("Undo/RecordObject")]
    // Start is called before the first frame update
    static void RecordObject()
    {
        Transform transform = Selection.activeTransform;
        Undo.RecordObject(transform, "Pos");
        transform.position = new Vector3(0, 0, 0);
    }
    [MenuItem("Undo/AddComponent")]
    static void AddComponent()
    {
        GameObject go = Selection.activeGameObject;
        Rigidbody rigidbody = Undo.AddComponent<Rigidbody>(go);
    }
    [MenuItem("Undo/DestoryComponent")]
    static void DestoryComponent()
    {
        GameObject go = Selection.activeGameObject;
        Undo.DestroyObjectImmediate(go);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
