
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody rb;

    private float movementX;

    private float movementY;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate()
    {      
             transform.LookAt(player.transform);
             transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
