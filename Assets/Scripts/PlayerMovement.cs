using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the player
    private bool isMoving = false; // Flag to track if the player is currently moving
    private Vector3 targetPosition; // Target position the player is moving towards

    private void Update()
    {
        // Check for input to move the player
        if (Input.GetMouseButtonUp(0) && !isMoving)
        {
            // Raycast to determine the position clicked on the grid
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // Get the position clicked and move the player there
                targetPosition = hit.point;
                targetPosition.y = transform.position.y; // Keep the y-coordinate the same
                StartCoroutine(MovePlayer());
            }
        }
    }

    private System.Collections.IEnumerator MovePlayer()
    {
        isMoving = true;
        while (Vector3.Distance(transform.position, targetPosition) > 0.05f)
        {
            // Move the player towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
        isMoving = false;
    }
}
