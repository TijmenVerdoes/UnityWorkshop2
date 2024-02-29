using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeHuman : MonoBehaviour
{
    public Transform targetPosition; // The position to check the distance to
    public float detectionRange = 5f; // Adjust this value to set the detection range
    public Material human;

    private void Update() {
        // Calculate the distance between this GameObject and the target position
        float distanceToTarget = Vector3.Distance(transform.position, targetPosition.position);

        // If the distance is within the detection range
        if (distanceToTarget <= detectionRange) {
            // Perform your desired action here
            Debug.Log("Target position is within range. Do something now.");
            ChangeShaderProperty();
        }
    }

    private void OnDrawGizmosSelected() {
        // Visualize the detection range in the Unity Editor
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }

    private void ChangeShaderProperty() {
        // Check if the targetPosition has a Renderer component
        Renderer renderer = targetPosition.GetComponent<Renderer>();
        if (renderer != null) {;
            renderer.material = human;
        }
    }
}
