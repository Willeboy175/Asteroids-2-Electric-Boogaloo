using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float playerSpeed = 1f;
    [SerializeField]
    Rigidbody2D player;
    float angle = 0f;
    Vector2 movement;
    Vector3 mousePos;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        player.AddForce(playerSpeed * Time.fixedDeltaTime * movement);

        //rb.velocity = movement * playerSpeed * Time.fixedDeltaTime;

        //rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);

        direction = mousePos - transform.position;
        angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
