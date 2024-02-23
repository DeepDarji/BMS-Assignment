using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 3f; // Movement speed of the enemy
    public Transform playerTransform; // Reference to the player's transform
    private bool isMoving = false; // Flag to track if the enemy is currently moving
    private Vector3 targetPosition; // Target position the enemy is moving towards

    private void Start()
    {
        // Find the player's transform if not set
        if (playerTransform == null)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    private void Update()
    {
        // Check if the enemy is not already moving and the player's transform is set
        if (!isMoving && playerTransform != null)
        {
            // Calculate the target position to move towards the player
            targetPosition = playerTransform.position;
            StartCoroutine(MoveEnemy());
        }
    }

    private System.Collections.IEnumerator MoveEnemy()
    {
        isMoving = true;
        while (Vector3.Distance(transform.position, targetPosition) > 0.05f)
        {
            // Move the enemy towards the player's position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
        isMoving = false;
    }
}
