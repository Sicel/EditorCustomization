using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_SignPost : MonoBehaviour
{
    [TextArea(1, 5)]
    public string text = "Enter Text Here";

    public bool showText = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        showText = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        showText = false;
    }

    private void OnGUI()
    {
        if (showText)
        {
            GUILayout.Box(text);
        }
    }
}
