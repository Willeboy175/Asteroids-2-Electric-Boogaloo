using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D bullet;
    [SerializeField]
    Transform spawnPosition;
    [SerializeField]
    float bulletCooldown = 1f;
    float bulletTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        bulletTimer += Time.deltaTime;
        if (bulletTimer > bulletCooldown)
        {
            bulletTimer = 0;
            Instantiate(bullet, spawnPosition.position, spawnPosition.rotation);
        }
    }
}
