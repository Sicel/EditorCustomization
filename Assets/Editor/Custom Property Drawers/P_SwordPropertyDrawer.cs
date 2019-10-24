using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(P_Sword))]
public class P_SwordPropertyDrawer : PropertyDrawer
{
    bool showStats = false;
    
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        //base.OnGUI(position, property, label);

        EditorGUI.BeginProperty(position, label, property);

        SerializedProperty durability = property.FindPropertyRelative("durabilty");
        SerializedProperty damage = property.FindPropertyRelative("damage");
        showStats = EditorGUI.Foldout(position, showStats, label);
        if (showStats)
        {
            EditorGUI.indentLevel++;
            EditorGUILayout.PropertyField(durability);
            EditorGUILayout.PropertyField(damage);
            EditorGUI.indentLevel++;
        }

        EditorGUI.EndProperty();
    }
}
