using UnityEngine;
using UnityEditor;

public class ObstacleEditor : EditorWindow
{
    private bool[,] obstacleGrid = new bool[10, 10]; // 10x10 grid to store obstacle information

    [MenuItem("Window/Obstacle Editor")]
    public static void ShowWindow()
    {
        GetWindow<ObstacleEditor>("Obstacle Editor");
    }

    private void OnGUI()
    {
        GUILayout.Label("Generate Obstacles", EditorStyles.boldLabel);

        // Create a 10x10 grid of toggleable buttons to represent each tile
        for (int row = 0; row < 10; row++)
        {
            GUILayout.BeginHorizontal();
            for (int col = 0; col < 10; col++)
            {
                EditorGUI.BeginChangeCheck();
                obstacleGrid[row, col] = GUILayout.Toggle(obstacleGrid[row, col], GUIContent.none, "Button", GUILayout.Width(20), GUILayout.Height(20));
                if (EditorGUI.EndChangeCheck())
                {
                    // Obstacle status changed, handle accordingly
                    Debug.Log($"Obstacle at ({row}, {col}) toggled: {obstacleGrid[row, col]}");
                }
            }
            GUILayout.EndHorizontal();
        }
    }
}
