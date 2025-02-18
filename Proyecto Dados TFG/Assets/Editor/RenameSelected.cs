using UnityEditor;
using UnityEngine;

public class RenameSelected : EditorWindow
{
    private string _gameObjectPrefix = "Object";
    private int _startIndex = 0;

    private static readonly Vector2Int size = new Vector2Int(250, 100);

    [MenuItem("Tools/Rename Selected Objects")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<RenameSelected>("Rename Selected Objects").minSize = size;
    }

    private void OnGUI()
    {
        GUILayout.Label("Rename Selected Objects", EditorStyles.boldLabel);
        _gameObjectPrefix = EditorGUILayout.TextField("Prefix", _gameObjectPrefix);
        _startIndex = EditorGUILayout.IntField("Start Index", _startIndex);

        if (GUILayout.Button("Rename Objects"))
        {
            RenameObjects();
        }
    }

    private void RenameObjects()
    {
        GameObject[] selectedObjects = Selection.gameObjects;
        for (int i = 0; i < selectedObjects.Length; i++)
        {
            selectedObjects[i].name = $"{_gameObjectPrefix}{_startIndex + i}";
        }
    }
}