using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab; // Prefab of the obstacle sphere
    public Vector3 tileSize = new Vector3(1f, 1f, 1f); // Size of each tile
    public Vector3 gridOrigin = new Vector3(0f, 0f, 0f); // Origin of the grid
    private bool[,] obstacleGrid = new bool[10, 10]; // 10x10 grid to store obstacle information

    // Method to set obstacle status for a specific tile
    public void SetTileObstacle(int row, int col, bool isObstacle)
    {
        obstacleGrid[row, col] = isObstacle;
        UpdateObstacles();
    }

    // Method to check if a tile has an obstacle
    public bool IsTileObstacle(int row, int col)
    {
        return obstacleGrid[row, col];
    }

    // Method to update obstacle spheres based on obstacleGrid data
    private void UpdateObstacles()
    {
        // Clear existing obstacle spheres
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Generate obstacle spheres for tiles marked as obstacles
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                if (obstacleGrid[row, col])
                {
                    Vector3 obstaclePosition = gridOrigin + new Vector3(col * tileSize.x, 0f, row * tileSize.z);
                    Instantiate(obstaclePrefab, obstaclePosition, Quaternion.identity, transform);
                }
            }
        }
    }
}
