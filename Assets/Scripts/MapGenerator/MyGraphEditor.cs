using System.Collections;
using System.Collections.Generic;
using Unity.EditorCoroutines.Editor;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(MyGraph))]
//public class MyGraphEditor : Editor
//{
//    private MyGraph graph;
//    private SerializedProperty nodePrefabProp;
//    private SerializedProperty linePrefabProp;
//    private SerializedProperty amountProp;


//    private void OnEnable()
//    {
//        graph = serializedObject.targetObject as MyGraph;
//        nodePrefabProp = serializedObject.FindProperty("nodePrefab");
//        linePrefabProp = serializedObject.FindProperty("linePrefab");
//        amountProp = serializedObject.FindProperty("amount");
//    }

//    public override void OnInspectorGUI()
//    {
//        serializedObject.Update();

//        EditorGUILayout.ObjectField(nodePrefabProp);
//        EditorGUILayout.ObjectField(linePrefabProp);
//        EditorGUILayout.PropertyField(amountProp);

//        if (GUILayout.Button("Generate"))
//        {
//            EditorCoroutineUtility.StartCoroutine(graph.Generate(), this);
//        }
//        if (GUILayout.Button("Clear"))
//        {
//            graph.Clear();
//        }

//        serializedObject.ApplyModifiedProperties();
//    }
//}
