using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float adjustSpeed;
    public Rigidbody player;
    private Vector3 movement;

    void FixedUpdate()
    {
        Move();

    }

    void Move()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = 0;
        movement.z = Input.GetAxis("Vertical");
        player.MovePosition(player.position + movement * 1000 * Time.deltaTime);
    }
}