using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class SceneChange
{
    [MenuItem("Scenes/Attributes")]
    public static void Attributes()
    {
        ChangeScene("Attributes");
    }


    [MenuItem("Scenes/Custom Inspector")]
    public static void CustomInspector()
    {
        ChangeScene("Custom Inspector");
    }

    [MenuItem("Scenes/Custom Property Drawer")]
    public static void CustomPropertyDrawer()
    {
        ChangeScene("Custom Property Drawer");
    }

    [MenuItem("Scenes/Custom Editor Window")]
    public static void CustomEditorWindow()
    {
        ChangeScene("Custom Editor Window");
    }
    static void ChangeScene(string name)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene(string.Format("Assets/Scenes/{0}.unity", name));
        }
    }
}
