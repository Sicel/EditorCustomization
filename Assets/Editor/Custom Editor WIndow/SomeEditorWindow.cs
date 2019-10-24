using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SomeEditorWindow : EditorWindow
{
    static I_EquipmentList equipmentList;
    List<string> sentences = new List<string>();
    Vector2 scrollPos;
    Vector2 scrollPos2;

    [MenuItem("Window/Some Window")]
    static void ShowWindow()
    {
        SomeEditorWindow window = GetWindow<SomeEditorWindow>();
        window.Show();
        equipmentList = (I_EquipmentList)AssetDatabase.LoadAssetAtPath("Assets/Scripts/Custom Inspector/Equipment List.asset", typeof(I_EquipmentList));
    }

    private void OnGUI()
    {
        if (!equipmentList)
        {
            equipmentList = (I_EquipmentList)AssetDatabase.LoadAssetAtPath("Assets/Scripts/Custom Inspector/Equipment List.asset", typeof(I_EquipmentList));
        }

        GUILayout.Label("Equipment List", EditorStyles.boldLabel);

        scrollPos = GUILayout.BeginScrollView(scrollPos, GUI.skin.window);
        for (int i = 0; i < equipmentList.equipmentList.Count; i++)
        {
            GUILayout.BeginHorizontal();
            equipmentList.equipmentList[i] = (I_Equipment)EditorGUILayout.ObjectField(equipmentList.equipmentList[i], typeof(I_Equipment), false);
            if (GUILayout.Button("Remove"))
            {
                equipmentList.equipmentList.RemoveAt(i);
            }
            GUILayout.EndHorizontal();
        }
        GUILayout.EndScrollView();

        if (GUILayout.Button("Add Equipment"))
        {
            equipmentList.equipmentList.Add(new I_Equipment());
        }

        GUILayout.Label("Sentences List", EditorStyles.boldLabel);

        scrollPos2 = GUILayout.BeginScrollView(scrollPos2, GUI.skin.button);
        for (int i = 0; i < sentences.Count; i++)
        {
            GUILayout.BeginHorizontal();
            sentences[i] = EditorGUILayout.TextField(sentences[i]);
            if (GUILayout.Button("Remove"))
            {
                sentences.RemoveAt(i);
            }
            GUILayout.EndHorizontal();
        }

        GUILayout.EndScrollView();
        if (GUILayout.Button("Add Equipment"))
        {
            sentences.Add("New Sentences");
        }
    }
}
