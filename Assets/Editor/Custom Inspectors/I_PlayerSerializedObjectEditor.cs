using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(I_Player))]
public class I_PlayerSerializedObjectEditor : Editor
{
    // Optional
    SerializedProperty currentHealth;
    SerializedProperty maxHealth;
    SerializedProperty rigidBody;
    SerializedProperty speed;
    SerializedProperty weapon;
    SerializedProperty jumpHeight;

    // Similar to the Start method
    private void OnEnable()
    {
        currentHealth = serializedObject.FindProperty("currentHealth");
        maxHealth = serializedObject.FindProperty("maxHealth");
        rigidBody = serializedObject.FindProperty("rigidBody");
        speed = serializedObject.FindProperty("speed");
        weapon = serializedObject.FindProperty("weapon");

        // Still can't get properties
        jumpHeight = serializedObject.FindProperty("JumpHeight"); // Null
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update(); // Checks for any changes

        //base.OnInspectorGUI(); // Default inspector

        // You could declare and use variables...
        // Same as default inspector 
        //EditorGUILayout.PropertyField(currentHealth);
        //EditorGUILayout.PropertyField(maxHealth);
        //EditorGUILayout.PropertyField(rigidBody);
        //EditorGUILayout.PropertyField(speed);
        //EditorGUILayout.PropertyField(weapon);
        //EditorGUILayout.PropertyField(jumpHeight); // Error

        // Or just go straight to FindProperty
        // EditorGUILayout.PropertyField(serializedObject.FindProperty("currentHealth"));
        // etc.

        // Health
        EditorGUILayout.BeginHorizontal();
        GUIContent healthLabel = new GUIContent("Health", "Current Health / Max Health");
        EditorGUILayout.LabelField(healthLabel, GUILayout.Width(100));
        EditorGUILayout.PropertyField(currentHealth, GUIContent.none); // Current Health
        EditorGUILayout.LabelField("/", GUILayout.Width(10));
        EditorGUILayout.PropertyField(maxHealth, GUIContent.none); // Max Health
        EditorGUILayout.EndHorizontal();

        // Speed
        EditorGUILayout.BeginHorizontal();
        GUIContent speedLabel = new GUIContent("Speed", "Player speed; Min: 1, Max 10");
        EditorGUILayout.LabelField(speedLabel, GUILayout.Width(100));
        EditorGUILayout.PropertyField(speed, GUIContent.none);
        EditorGUILayout.EndHorizontal();

        // Weapon
        EditorGUILayout.BeginHorizontal();
        GUIContent weaponLabel = new GUIContent("Weapon", "Weapon player is holding");
        EditorGUILayout.LabelField(weaponLabel, GUILayout.Width(100));
        EditorGUILayout.PropertyField(weapon, GUIContent.none);
        EditorGUILayout.EndHorizontal();

        serializedObject.ApplyModifiedProperties(); // Applies changes
    }
}
