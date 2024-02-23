using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileHover : MonoBehaviour
{
    public Text tileInfoText; // Reference to the UI text element to display tile information
    public LayerMask tileLayerMask; // Layer mask to filter raycasts for tiles only

    private Camera mainCamera; // Reference to the main camera

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Cast a ray from the mouse cursor
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Check if the ray hits a tile
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, tileLayerMask))
        {
            // Get the tile info component of the hit object
            TileInfo tileInfo = hit.collider.GetComponent<TileInfo>();

            // Check if the tile info component exists
            if (tileInfo != null)
            {
                // Display information about the tile on UI text element
                tileInfoText.text = "Block: " + tileInfo.gridPosition.ToString();
                // Add more information as needed (e.g., terrain type, unit details)
            }
        }
        else
        {
            // If the ray doesn't hit any tile, clear the tile info text
            tileInfoText.text = "";
        }
    }
}