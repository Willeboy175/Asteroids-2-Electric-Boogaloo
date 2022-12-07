using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField]
    float enemySpeed = 1f;
    [SerializeField]
    Rigidbody2D enemy;
    [SerializeField]
    Transform player;
    [SerializeField]
    float playerDistance = 1f;
    [SerializeField]
    float playerDistanceForceMultiplier = 1f;
    float distance;
    float angle = 0f;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(enemy.position, player.position);
    }

    private void FixedUpdate()
    {
        enemy.AddForce(transform.right * enemySpeed * Time.fixedDeltaTime);

        if (distance < playerDistance)
        {
            enemy.AddForce(transform.right * enemySpeed * playerDistanceForceMultiplier * -1 * Time.fixedDeltaTime);
        }

        direction = player.position - transform.position;
        angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
