using UnityEngine;

public class TileInfo : MonoBehaviour
{
    // Variables to store information about the tile
    public Vector2Int gridPosition; // Position of the tile on the grid (row, column)
    public bool isOccupied; // Indicates whether the tile is occupied by an obstacle or unit
    // Add more variables as needed (e.g., terrain type, tile color, etc.)

    private void Start()
    {
        // Initialize tile information
        InitializeTile(new Vector2Int((int)transform.position.x, (int)transform.position.z));
    }

    // Function to initialize the tile with its position
    private void InitializeTile(Vector2Int position)
    {
        gridPosition = position;
        isOccupied = false; // By default, the tile is not occupied
        // Add more initialization logic as needed
    }

    // Function to handle actions when the tile is clicked or interacted with
    public void OnTileClicked()
    {
        // Implement logic to handle tile interaction (e.g., moving a unit to the tile)
    }

    // Additional functions can be added based on the requirements of your game
}
