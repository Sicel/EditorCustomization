using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(I_EquipmentList))]
public class P_EquipmentListEditor : Editor
{
    SerializedProperty equipmentList;

    private void OnEnable()
    {
        equipmentList = serializedObject.FindProperty("equipmentList");
        serializedObject.Update();
    }

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        for (int i = 0; i < equipmentList.arraySize; i++)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PropertyField(equipmentList.GetArrayElementAtIndex(i));
            if (GUILayout.Button("-", GUILayout.Width(20)))
            {
                equipmentList.DeleteArrayElementAtIndex(i);
            }
            EditorGUILayout.EndHorizontal();
        }

        if (GUILayout.Button("Add Equipment"))
        {
            equipmentList.InsertArrayElementAtIndex(equipmentList.arraySize);
        }
        serializedObject.ApplyModifiedProperties();
    }
}
