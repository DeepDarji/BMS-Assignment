using UnityEngine;

public class DebugTileInteraction : MonoBehaviour
{
    private TileInfo currentTile;

    private void Update()
    {
        // Perform raycast to detect tile under mouse cursor
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            // Print out the name of the object hit by the raycast
            Debug.Log("Hit Object Name: " + hit.collider.gameObject.name);

            // Check if the hit object has a TileInfo component
            currentTile = hit.collider.GetComponent<TileInfo>();

            if (currentTile != null)
            {
                // Print out tile information
                Debug.Log("Current Tile Position: " + currentTile.gridPosition);
                Debug.Log("Is Occupied: " + currentTile.isOccupied);
            }
        }
    }
}
    