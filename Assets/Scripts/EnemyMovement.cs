
using TMPro;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f;

    public Material deadPlayer;

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

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            Renderer renderer = collision.gameObject.GetComponent<Renderer>();
            if (renderer != null) {
                renderer.material = deadPlayer;
            }
        }
    }
}
