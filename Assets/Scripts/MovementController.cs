using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public float speed;

    private float movementX;

    private float movementY;

    private void Update() {
        if (Input.GetMouseButton(0)) // Left mouse button
           {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                // Move the player towards the clicked point
                Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
        }
    }
}
