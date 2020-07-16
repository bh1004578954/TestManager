using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
[CustomEditor(typeof(ShowCircle))]
public class ShowCircleEditor :Editor
{
    [System.Obsolete]
    private void OnSceneGUI()
    {
        ShowCircle sC = target as ShowCircle;
        Handles.color = sC.color;
        Handles.DrawSolidDisc(sC.transform.position, Vector3.up, sC.radius);
        
        sC.radius = Handles.ScaleValueHandle(sC.radius, sC.transform.position, Quaternion.identity, 1, Handles.ConeCap, 1);
    }
}
