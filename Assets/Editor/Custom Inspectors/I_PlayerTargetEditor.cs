using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(I_Player))]
public class I_PlayerTargetEditor : Editor
{
    // Get a referenc to the instance we're accessing 
    I_Player player;

    private void OnEnable()
    {
        player = (I_Player)target;
    }

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI(); // Default Inspector

        // Recreation of the default inspector
        //player.currentHealth = EditorGUILayout.FloatField("Current Health: ", player.currentHealth);
        //player.maxHealth = EditorGUILayout.FloatField("Max Health: ", player.maxHealth);
        //player.rigidBody = (Rigidbody2D)EditorGUILayout.ObjectField("Rigid Body: ", player.rigidBody, typeof(Rigidbody2D), true);
        //player.speed = EditorGUILayout.IntSlider("Speed: ", player.speed, 1, 10);
        //player.weapon = (I_Sword)EditorGUILayout.ObjectField("Weapon: ", player.weapon, typeof(I_Sword), true);

        // You can even show your property if you wanted to
        //player.JumpHeight = EditorGUILayout.FloatField("Jump Heaight: ", player.JumpHeight);

        // Displaying things the way we want to

        // Displays Health
        // Lets us align our elements horizontally
        EditorGUILayout.BeginHorizontal();
        GUIContent healthLabel = new GUIContent("Health", "Current Health / Max Health");
        EditorGUILayout.LabelField(healthLabel, GUILayout.Width(100));

        // Current Health
        player.currentHealth = EditorGUILayout.FloatField(player.currentHealth); // Current Health
        EditorGUILayout.LabelField("/", GUILayout.Width(10));
        player.maxHealth = EditorGUILayout.FloatField(player.maxHealth); // Max Health
        EditorGUILayout.EndHorizontal();

        // Displays Speed (with slider)
        EditorGUILayout.BeginHorizontal();
        GUIContent speedLabel = new GUIContent("Speed", "Player speed; Min: 1, Max 10");
        EditorGUILayout.LabelField(speedLabel, GUILayout.Width(100));
        player.speed = EditorGUILayout.IntSlider(player.speed, 1, 10);
        EditorGUILayout.EndHorizontal();

        // Displays object field for our weapon
        EditorGUILayout.BeginHorizontal();
        GUIContent weaponLabel = new GUIContent("Weapon", "Weapon player is holding");
        EditorGUILayout.LabelField(weaponLabel, GUILayout.Width(100));
        player.weapon = (I_Sword)EditorGUILayout.ObjectField(player.weapon, typeof(I_Sword), true);
        EditorGUILayout.EndHorizontal();
    }
}
