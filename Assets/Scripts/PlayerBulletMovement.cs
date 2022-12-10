using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    [SerializeField]
    float bulletSpeed = 1f;
    [SerializeField]
    float destroyTimer = 1f;
    float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * bulletSpeed * Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > destroyTimer)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Soldier") || other.CompareTag("Sniper") || other.CompareTag("Tank"))
        {
            Destroy(gameObject);
        }
    }
}
