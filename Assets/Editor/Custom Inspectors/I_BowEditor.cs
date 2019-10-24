using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(I_Bow))]
public class I_BowEditor : Editor
{
    // Reference to the instance we're accessing
    I_Bow bow;
    readonly float max = 12;

    private void OnEnable()
    {
        bow = (I_Bow)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        // Changing one stat affects the other
        bow.damage = max - bow.range;
        bow.range = max - bow.damage;

    }
}
