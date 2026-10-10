using UnityEditor;
using UnityEngine;

public class JuniorAntiCheatRemover : EditorWindow
{
    [MenuItem("Junior Tools/Junior Anti Cheat Remover")]
    public static void Open()
    {
        GetWindow<JuniorAntiCheatRemover>("Junior Remover");
    }

    private void OnGUI()
    {
        GUI.backgroundColor = Color.red;

        GUILayout.Space(15);
        GUILayout.Label(
            "JUNIOR ANTI CHEAT REMOVER",
            new GUIStyle(EditorStyles.boldLabel)
            {
                fontSize = 20,
                alignment = TextAnchor.MiddleCenter
            }
        );

        GUILayout.Space(15);

        EditorGUILayout.HelpBox(
            "Select a GameObject in your own Unity project. " +
            "Use the Inspector to manage its components.",
            MessageType.Info
        );

        if (GUILayout.Button("Show Removal Instructions"))
        {
            EditorUtility.DisplayDialog(
                "Junior Remover",
                "Select your GameObject, find the component in the Inspector, " +
                "open its three-dot menu, and choose Remove Component.",
                "OK"
            );
        }

        GUI.backgroundColor = Color.white;
    }
}
