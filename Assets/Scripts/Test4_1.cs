using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
[CustomEditor(typeof(Test4))]
public class Test4_1 :Editor
{
    [System.Obsolete]
    private void OnSceneGUI()
    {
        Test4 test4 = target as Test4;
        Handles.color = test4.color;
        Handles.DrawSolidDisc(test4.transform.position, Vector3.up, test4.radius);
        
        test4.radius = Handles.ScaleValueHandle(test4.radius, test4.transform.position, Quaternion.identity, 1, Handles.ConeCap, 1);
    }
}
