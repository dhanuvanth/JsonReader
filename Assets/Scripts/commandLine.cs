using UnityEngine;

using System;

public class commandLine : MonoBehaviour
{
    private string[] args;
    void Start()
    {
        args = Environment.GetCommandLineArgs();
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(30, 30, 600, 6000));
        foreach (string argument in args)
        {
            GUILayout.Label(argument);
        }
        GUILayout.EndArea();
    }

}